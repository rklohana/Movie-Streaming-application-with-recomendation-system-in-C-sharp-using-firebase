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

        private async void Form1_Load(object sender, EventArgs e)
        {
            
            var stream = File.Open(@"C:\Users\rk\Pictures\Screenshots\isbah.png", FileMode.Open);

            
            var task = new FirebaseStorage("fir-fast-36fe8.appspot.com")
                .Child("data")
                .Child("project")
                .Child("file.png")
                .PutAsync(stream);
           
            
            task.Progress.ProgressChanged += (s, rk) => MessageBox.Show($"Progress: {rk.Percentage} %");

            
            var downloadUrl = await task;

            MessageBox.Show("hello");
            MessageBox.Show(downloadUrl);





        }
    }
}
