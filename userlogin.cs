using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class userlogin : UserControl
    {
        Userdata c2 = new Userdata();
        IFirebaseClient client;
        public userlogin()
        {
            InitializeComponent();
        }

        private async void signin_Click(object sender, EventArgs e)
        {
            FirebaseResponse r = await client.GetAsync("Userdata DATA/" + mobiletext.Text);
            Userdata obj = r.ResultAs<Userdata>();
           
                if (obj.getname() != null)
                {
                    if (obj.getpass() == passwordtext.Text)
                    {
                    
                    }
                }
            
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void userlogin_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(c2.getConfig());
            if (client == null)
            {

                MessageBox.Show("error Connecting");
            }
        }
    }
}
