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
        public usersignup()
        {
            InitializeComponent();
        }

        private void signupbutt_Click(object sender, EventArgs e)
        {

            if (passtext.Text == conpasstext.Text)
            {
                c2.add_data(nametext.Text, mobiletext.Text, addresstext.Text, emailtext.Text, passtext.Text);
                c2.adddata(c2);
                //   MessageBox.Show("Account  created");


                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Passwords donot match");
            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void conpasstext_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
