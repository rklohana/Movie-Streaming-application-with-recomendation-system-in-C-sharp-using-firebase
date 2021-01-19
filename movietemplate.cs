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


        protected IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "y4RjXMGpXFsmuG4T0pMLmWIBtcQ6V84ke4uJ3hCT",
            BasePath = "https://rioflix-default-rtdb.firebaseio.com/"
        };
        private  void movietemplate_Load(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Hide();
            bunifuThinButton21.Hide();
            bunifuThinButton22.Hide();
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {

                MessageBox.Show("Not Connected");
            }


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

                    trans1.ShowSync(bunifuCircleProgressbar1);
                    task.Progress.ProgressChanged += (s, rk) => bunifuCircleProgressbar1.Value = rk.Percentage;




                    var downloadUrl = await task;
                    url = downloadUrl;
                    bunifuCircleProgressbar1.Hide();
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

        private async void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            moviedata md = new moviedata();
            FirebaseResponse response = await client.GetAsync("Counter DATA/");
            counter1 obj = response.ResultAs<counter1>();

            int n = obj.Mov_id;
            //    counter1 obj = new counter1();
            //obj.retrivevalues();

            // MessageBox.Show("setdata " + m_id.ToString());
            obj.increase();
            obj.adddata(obj);
            string img;
            Bitmap image = new Bitmap(pictureBox1.Image);
            img = md.photoconvert(image);
            md.setdata(n,nametext.Text, creatortext.Text, genretext.Text, startext.Text, keywordtext.Text, descriptext.Text, url, img);
            
            md.adddata();
           
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nametext_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void startext_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void creatortext_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void descriptext_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void keywordtext_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
