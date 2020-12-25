using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;


namespace RIOFLIX123
{
    class moviedata
    {
        public static int m_id = 0;
        public int getm_id()
        {
            return m_id;
        }

        private string name;
        private string Name { get
            {
                return name;
            }
            set {
                name = value;
                }
        }
        private string description;
        private string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        private string[] director;
        private string[] Director
        {
            get
            {
                return director;
            }
            set
            {
                director = value;
            }
        }
        private string[] genre;
        private string[] Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }
        private string[] keyword;
        private string[] Keyword
        {
            get
            {
                return keyword;
            }
            set
            {
                keyword = value;
            }
        }
        private string[] actor;
        private string[] Actor
        {
            get
            {
                return actor;
            }
            set
            {
                actor = value;
            }
        }

        private string imagefile;
        private string Imagefile
        {
            get
            {
                return imagefile;
            }
            set
            {
                imagefile = value;
            }
        }

        private string videofile;
        private string Videofile
        {
            get
            {
                return videofile;
            }
            set
            {
                videofile = value;
            }
        }
        public IFirebaseClient client;


        protected IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "VIB4QyeoIjd43kf2yFcU7l9ynqtKSJPF3fplsdUp",
            BasePath = "https://fir-fast-36fe8.firebaseio.com/"
        };
        public IFirebaseConfig getConfig()
        {
            return config;
        }
        public moviedata()
        {
            m_id++;
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {

                MessageBox.Show("not Connected");
            }
        }
        public string photoconvert(Bitmap i)
        {
            string image1;
            MemoryStream m = new MemoryStream();
            i.Save(m, ImageFormat.Jpeg);
            byte[] a = m.GetBuffer();
            image1 = Convert.ToBase64String(a);
            return image1;
        }
        public Image photoback(string i)
        {
            byte[] b = Convert.FromBase64String(i);
            MemoryStream m = new MemoryStream();
            m.Write(b, 0, Convert.ToInt32(b.Length));
            Bitmap bm = new Bitmap(m, false);
            m.Dispose();
            return bm;
        }
        public async void adddata(moviedata a, string b)
        {
            SetResponse response = await client.SetAsync("Moviedata DATA/" + b, a);
            moviedata result = response.ResultAs<moviedata>();
            /////   MessageBox.Show("Data inserted");
        }

        public async void deletedata(string a)
        {
            FirebaseResponse r = await client.DeleteAsync("Moviedata DATA/" + a);
            //   MessageBox.Show("Data deleted");

        }
        public async void updatedata(string a, moviedata b)
        {
            FirebaseResponse r = await client.UpdateAsync("Moviedata DATA/" + a, b);
            moviedata obj = r.ResultAs<moviedata>();
            //  MessageBox.Show("Data updated");

        }
        public void setdata(string n, string[] d, string[] g, string[] c, string[] k,string des,string v,string i)
        {
            name = n;
            director =  d ;
            genre = g;
            actor = c;
            keyword = k;
            description = des;
            videofile = v;
            imagefile = i;
        }
    }
}
