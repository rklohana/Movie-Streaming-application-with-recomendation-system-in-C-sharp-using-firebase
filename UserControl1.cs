using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace RIOFLIX123
{
    public partial class movieshowall : UserControl
    {
        IFirebaseClient client;
        Stack st1 = new Stack();
        Queue q1 = new Queue();
        Queue nm = new Queue();
        public movieshowall()
        {
            InitializeComponent();
        }
        
        private void UserControl1_Load(object sender, EventArgs e)
        {

            playlist pp = new playlist();
            pp.retrivevalues();
            var movienames = pp.MovName.Split(',');
            for(int i = 0; i < movienames.Length; i++)
            {
                nm.Enqueue(movienames[i]);
            }
                moviedata t1 = new moviedata();
            client = new FireSharp.FirebaseClient(t1.getConfig());
            if (client == null)
            {
                MessageBox.Show("not Connected");
            }
            string[] lastwatched;
            string[] mylist;
            playlist pl = new playlist();
            pl.retrivevalues();
             lastwatched = pl.HistName.Split(',');
            mylist = pl.ListName.Split(',');
          
            for(int i = 0; i < lastwatched.Length; i++)
            {
                st1.Push(lastwatched[i]);
            }
            for (int i = 0; i < mylist.Length; i++)
            {
                q1.Enqueue(mylist[i]);
            }
            similartotext.Text += ' ' + st1.Peek() + " :";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void movieplay1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        async void populatelist()
        {
            movieplay[] mn = new movieplay[q1.getsize()];
            int i = 0;
            while (!q1.isempty())
            {



                FirebaseResponse r = await client.GetAsync("Movie DATA/" + q1.Dequeue());
                moviedata obj = r.ResultAs<moviedata>();
                mn[i].Name = obj.Name;
                var im = mn[i].showphoto(obj.Imagefile);
                mn[i].Icon = im;
                if (mylistpanel.Controls.Count < 0)
                {
                    mylistpanel.Controls.Clear();
                }
                else
                {
                    displaytrans.ShowSync(mn[i]);
                    mylistpanel.Controls.Add(mn[i]);
                }
            }

        }
    }
}
