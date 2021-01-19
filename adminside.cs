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

namespace RIOFLIX123
{
    public partial class adminside : Form

    {
        public SingleLinkedList l1;
        public playlist p2;
        module m2;
        recent r1;
        maylikepanel mp;
        ALLmovies al;
        playlistpanel pp;
        Admin un;

        public IFirebaseClient client;


        protected IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "y4RjXMGpXFsmuG4T0pMLmWIBtcQ6V84ke4uJ3hCT",
            BasePath = "https://rioflix-default-rtdb.firebaseio.com/"
        };
        public adminside(SingleLinkedList l2, playlist pl, Admin ud, module m1)
        {
            un = ud;
            m2 = m1;
            l1 = l2;
            p2 = pl;
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FirebaseResponse r = await client.GetAsync("Playlist/" + un.Name);
            playlist obj = r.ResultAs<playlist>();
            r1 = new recent(m2,recentpanel, l1, obj, un.Name);
            recentpanel.Controls.Clear();
            recentpanel.Controls.Add(r1);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            recentpanel.Controls.Clear();
            recentpanel.Controls.Add(al);
        }

        private async void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            FirebaseResponse r = await client.GetAsync("Playlist/" + un.Name);
            playlist obj = r.ResultAs<playlist>();
            pp = new playlistpanel(m2, recentpanel, l1, obj, un.Name);
            recentpanel.Controls.Clear();
            recentpanel.Controls.Add(pp);

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            recentpanel.Controls.Clear();
            recentpanel.Controls.Add(mp);
        }

        private void recentpanel_Paint(object sender, PaintEventArgs e)
        {

        }
        searchpanel sp;
        private void adminside_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {

                MessageBox.Show("Not Connected");

            }
            pictureBox1.Image = un.photoback(un.Imagefile);
            // moviedisppanel.Hide();

            mp = new maylikepanel(m2, recentpanel, l1, p2, un.Name);
            al = new ALLmovies(m2,l1, recentpanel, un.Name);
            sp = new searchpanel(m2, recentpanel, un.Name);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            movietemplate mt = new movietemplate();
            recentpanel.Controls.Clear();
            recentpanel.Controls.Add(mt);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            recentpanel.Controls.Clear();
            recentpanel.Controls.Add(sp);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            loginformUSER lf = new loginformUSER();
            lf.Show();
            this.Close();
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            adminsignup asp = new adminsignup();
            recentpanel.Controls.Clear();
            recentpanel.Controls.Add(asp);
        }
    }
}
