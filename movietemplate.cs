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

        moviedata md = new moviedata();
        public IFirebaseClient client;
        private  void movietemplate_Load(object sender, EventArgs e)
        {
            bunifuProgressBar1.Hide();
            bunifuThinButton21.Hide();
            bunifuThinButton22.Hide();


        }

       

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void addimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog on = new OpenFileDialog();
            on.Title = "Photo";
            on.Filter = "Image (jpg,jpeg,png) | *.jpg;*.jpeg;*.png|all files|*.*";
            if (on.ShowDialog() == DialogResult.OK)
            {
                Image ir = new Bitmap(on.FileName);
                pictureBox1.Image = ir.GetThumbnailImage(128, 130, null, new IntPtr());
                trans1.ShowSync(bunifuThinButton21);
            }
        }

        private async void bunifuThinButton21_Click(object sender, EventArgs e)
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

                    trans1.ShowSync(bunifuProgressBar1);
                    task.Progress.ProgressChanged += (s, rk) => bunifuProgressBar1.Value = rk.Percentage;




                    var downloadUrl = await task;
                    url = downloadUrl;
                    bunifuProgressBar1.Hide();
                    trans1.ShowSync(bunifuThinButton22);
                   // bunifuThinButton22.Show();
                }
                catch (Exception es)
                {
                    var msg = es;
                    MessageBox.Show("Internet error");

                }

            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            moviedata md = new moviedata();
            
            string img;
            Bitmap image = new Bitmap(pictureBox1.Image);
            img = md.photoconvert(image);
            md.setdata(nametext.Text, creatortext.Text, genretext.Text, startext.Text, keywordtext.Text, descriptext.Text, url, img);
            
            md.adddata(md);

            
        }
    }
}
