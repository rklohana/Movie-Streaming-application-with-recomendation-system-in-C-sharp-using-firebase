using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace RIOFLIX123
{
    public partial class mainpagedisplay : UserControl
    {
        IFirebaseClient client;
        Stack st1 = new Stack();
        Queue q1 = new Queue();
        Queue nm = new Queue();
        public mainpagedisplay()
        {
            InitializeComponent();
        }

        private void mainpagedisplay_Load(object sender, EventArgs e)
        {
            try
            {
                var str1 = ",Toy Story,jumanji,sabrina";
                playlist pp = new playlist();
                pp.retrivevalues();
                var movienames = str1.Split(',');
                for (int i = 0; i < movienames.Length; i++)
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

                for (int i = 0; i < lastwatched.Length; i++)
                {
                    st1.Push(lastwatched[i]);
                }
                for (int i = 0; i < mylist.Length; i++)
                {
                    q1.Enqueue(mylist[i]);
                }
                similartotext.Text += ' ' + st1.Peek() + " :";
                populatelist();
            }
            catch { 
            }
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
