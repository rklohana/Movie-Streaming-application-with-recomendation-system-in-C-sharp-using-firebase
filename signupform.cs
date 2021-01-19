using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIOFLIX123
{
    public partial class signupform : Form
    {
        loginformUSER lf;
        public signupform(loginformUSER us)
        {
            lf = us;
            InitializeComponent();
        }

        private void signupform_Load(object sender, EventArgs e)
        {
            usersignup us = new usersignup(lf,this);
            panel1.Controls.Clear();
            panel1.Controls.Add(us);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
