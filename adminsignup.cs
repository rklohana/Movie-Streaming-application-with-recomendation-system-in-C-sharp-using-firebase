using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIOFLIX123
{
    public partial class adminsignup : UserControl
    {
        Admin c2 = new Admin();
        public adminsignup()
        {
            InitializeComponent();
        }

        private void nametext_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void signupbutt_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (passtext.Text == conpasstext.Text)
                {
                    Bitmap image = new Bitmap(pictureBox1.Image);
                    string photo = c2.photoconvert(image);
                    c2.setdata(nametext.Text,photo, mobiletext.Text, addresstext.Text, emailtext.Text, passtext.Text);
                    c2.adddata(c2,nametext.Text);
                    //   MessageBox.Show("Account  created");



                    //this.Hide();
                }
                else
                {
                    // MessageBox.Show("Passwords donot match");
                    // loginformUSER l = new loginformUSER();
                    //l.Show();
                    passlabel.Show();
                }
            }
            else
            {
                imagelabel.Show();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OpenFileDialog on = new OpenFileDialog();
            on.Title = "Photo";
            on.Filter = "Image (jpg,jpeg,png) | *.jpg;*.jpeg;*.png|all files|*.*";
            if (on.ShowDialog() == DialogResult.OK)
            {
                Image ir = new Bitmap(on.FileName);
                pictureBox1.Image = ir.GetThumbnailImage(128, 130, null, new IntPtr());

            }
        }

        private void adminsignup_Load(object sender, EventArgs e)
        {
            imagelabel.Hide();
            passlabel.Hide();
        }

        private void passlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
