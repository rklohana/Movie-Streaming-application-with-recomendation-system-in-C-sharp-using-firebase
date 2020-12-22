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
            usersignup us = new usersignup();
            us.Show();
            
            


        }

        private async void button1_Click(object sender, EventArgs e)
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
                    

                    task.Progress.ProgressChanged += (s, rk) =>MessageBox.Show( "{rk.Percentage}");



                    var downloadUrl = await task;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("some error");
                }
               
                
            }

        }

        private void colorSlider1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }
    }
}
