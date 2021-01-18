using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.IO;
using System.Windows.Forms;
namespace RIOFLIX123
{
   public class playlist
    {
        private static string listname;
        public string ListName
        {
            get
            {
                return listname;
            }
            set
            {
                listname = value;
            }
        }


        private static string histname;
        public string HistName
        {
            get
            {
                return histname;
            }
            set
            {
                histname = value;
            }
        }

        public void setdata(string p,string h)
        {
            histname = h;
            listname = p;
        }
        public IFirebaseClient client;


        protected IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "y4RjXMGpXFsmuG4T0pMLmWIBtcQ6V84ke4uJ3hCT",
            BasePath = "https://rioflix-default-rtdb.firebaseio.com/"
        };

        public IFirebaseConfig getConfig()
        {
            return config;
        }
        public playlist()
        {
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {

                MessageBox.Show("Not Connected");

            }
        }

        public async void adddatalist(playlist md,string movname,string username)
        {
            try
            {
                
                md.ListName += "," + movname;
                SetResponse response = await client.SetAsync("Playlist/"+username, md);
                playlist result = response.ResultAs<playlist>();
                // MessageBox.Show(name);
                //   MessageBox.Show("Data inserted");
            }
            catch (Exception eeee)
            {
                var ex = eeee;
                MessageBox.Show("Error");
            }
        }
        public async void retrivevalues(string username)
        {
            try
            {
                FirebaseResponse r = await client.GetAsync("Playlist/"+username);
                playlist obj = r.ResultAs<playlist>();
                this.setdata(obj.ListName, obj.HistName);
            }
            catch
            {
                MessageBox.Show("Internet Error");
            }
        }



        public async void adddatahist(playlist md, string movname,string username)
        {
            try
            {
                
                md.HistName += "," + movname;
                SetResponse response = await client.SetAsync("Playlist/"+username, md);
                playlist result = response.ResultAs<playlist>();
                // MessageBox.Show(name);
                //   MessageBox.Show("Data inserted");
            }
            catch (Exception eeee)
            {
                var ex = eeee;
                MessageBox.Show("Error");
            }
        }


    }
}
