using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Firebase.Storage;
using System.IO;
namespace RIOFLIX123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  void Form1_Load(object sender, EventArgs e)
        {
            movietemplate mt = new movietemplate();
            mt.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void colorSlider1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void usersignup1_Load(object sender, EventArgs e)
        {

        }

        private void usersignup1_Load_1(object sender, EventArgs e)
        {
            
        }

        private async void button1_Click_1(object sender, EventArgs e)
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
                    int value;
                    task.Progress.ProgressChanged += (s, rk) =>  value= rk.Percentage;
                    var downloadUrl = await task;
                    //axWindowsMediaPlayer1.URL = downloadUrl;
                    stream = null;
                    GC.Collect();
                }
                catch (Exception ex)
                {
                    var msg = ex;
                    MessageBox.Show("some error");
                }


            }

        }
    }
}
