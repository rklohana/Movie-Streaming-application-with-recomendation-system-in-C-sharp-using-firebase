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
        
        IFirebaseClient client;
        public userlogin()
        {   
            InitializeComponent();
        }
       public Userdata ud;
        public Admin ad;
      public  playlist pl;
        private async void signin_Click(object sender, EventArgs e)
        {
            if (bunifuDropdown1.selectedIndex == 1)
            {   
                FirebaseResponse r = await client.GetAsync("Userdata DATA/" + mobiletext.Text);
                 ud = r.ResultAs<Userdata>();
                if (ud.Password == passwordtext.Text)
                {

                    FirebaseResponse r1 = await client.GetAsync("Playlist/" + ud.Name);
                     pl = r1.ResultAs<playlist>();
                    retrievedata();
                    listcheck lc = new listcheck(l1,pl,ad,ud);
                }
                else
                {
                    invalidlabel.Show();
                }
            }
            else if (bunifuDropdown1.selectedIndex == 2)
            {
                FirebaseResponse r = await client.GetAsync("Admin DATA/" + mobiletext.Text);
               ad = r.ResultAs<Admin>();
                if (ad.Password == passwordtext.Text)
                
                {
                    FirebaseResponse r1 = await client.GetAsync("Playlist/" + ad.Name);
                   pl = r1.ResultAs<playlist>();
                    retrievedata();
                }
                else
                {
                    invalidlabel.Show();
                }
            }
            else
            {
                label4.Show();
                return;
            }
        }
        counter1 c1;
      public  SingleLinkedList l1= new SingleLinkedList();
        public async void retrievedata()
        {
            FirebaseResponse response = await client.GetAsync("Counter DATA/");
            c1 = response.ResultAs<counter1>();
            MessageBox.Show(c1.Mov_id.ToString());
            int n = c1.Mov_id;
            for (int i = 0; i < n; i++)
            {

                FirebaseResponse response1 = await client.GetAsync("Movie DATA/" + i.ToString());
                moviedata m1 = response1.ResultAs<moviedata>();
                //  MessageBox.Show(m1.Name+" "+i.ToString() );
                l1.InsertLast(m1);

            }
        }
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
        Userdata c2 = new Userdata();
        private void userlogin_Load(object sender, EventArgs e)
        {
            invalidlabel.Hide();
            label4.Hide();
            client = new FireSharp.FirebaseClient(c2.getConfig());
            if (client == null)
            {

                MessageBox.Show("error Connecting");
            }
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            if (bunifuDropdown1.selectedIndex == 1)
            {
                mobiletext.Text = "Name: ";
            }
            else
            {
                mobiletext.Text = "Phone: ";
            }
        }
    }
}
