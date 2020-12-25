using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Firebase.Storage;
namespace RIOFLIX123
{
    public partial class movietemplate : UserControl
    {
        string url;
        public movietemplate()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog on = new OpenFileDialog();
            on.Title = "Photo";
            on.Filter = "Image (*.jpg) | *.jpg";
            if (on.ShowDialog() == DialogResult.OK)
            {
                Image ir = new Bitmap(on.FileName);
                pictureBox1.Image = ir.GetThumbnailImage(128, 130, null, new IntPtr());
            }
        }

        private async void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog im = new OpenFileDialog();
            im.Title = "Select";
            im.Filter = "(mp3,wav,mp4,mov,wmv,mpg)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpg|all files|*.*";
            if (im.ShowDialog() == DialogResult.OK)
            {


                try
                {
                    var stream = File.Open(im.FileName, FileMode.Open);
                    var task = new FirebaseStorage("fir-fast-36fe8.appspot.com")
                            .Child("data")
                            .Child("project")
                            .Child(im.FileName)
                            .PutAsync(stream);

                    bunifuProgressBar1.Show();
                    task.Progress.ProgressChanged += (s, rk) => bunifuProgressBar1.Value = rk.Percentage;




                    var downloadUrl = await task;
                    url = downloadUrl;
                    bunifuProgressBar1.Hide();
                }
                catch ( Exception es) {
                    var msg = es;
                    MessageBox.Show("Internet error");

                       }

            }
        }

        private void movietemplate_Load(object sender, EventArgs e)
        {
            bunifuProgressBar1.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            moviedata md = new moviedata();
            string[] genre = genretext.Text.Split(',');
            string[] director = creatortext.Text.Split(',');
            string[] actor = startext.Text.Split(',');
            string[] keyword = keywordtext.Text.Split(',');
            string img;
            Bitmap image = new Bitmap(pictureBox1.Image);
            img = md.photoconvert(image);
            md.setdata(nametext.Text, director, genre, actor, keyword, descriptext.Text, url, img);
            md.adddata(md, "1");
        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
