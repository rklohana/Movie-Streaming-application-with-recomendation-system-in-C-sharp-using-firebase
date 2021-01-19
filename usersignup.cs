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
    public partial class usersignup : UserControl
    { Userdata c2 = new Userdata();
        loginformUSER lf1;
        signupform sf;
        public usersignup(loginformUSER lf,signupform ss)
        {
            sf = ss;
            lf1 = lf;
            InitializeComponent();
        }

        private void signupbutt_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (passtext.Text == conpasstext.Text)
                {
                    Bitmap image = new Bitmap(pictureBox1.Image);
                    string photo=c2.photoconvert(image);
                    c2.add_data(nametext.Text, mobiletext.Text, addresstext.Text, emailtext.Text, passtext.Text,photo);
                    c2.adddata(c2);
                    //   MessageBox.Show("Account  created");
                    
                    lf1.Show();
                    this.Hide();
                    sf.Close();

                   // this.Hide();
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

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void conpasstext_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void mobiletext_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

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

        private void usersignup_Load(object sender, EventArgs e)
        {
            imagelabel.Hide();
            passlabel.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            sf.Close();
        }
    }
}
