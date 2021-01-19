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
   public class moviedata
    {
        protected int m_id;
        public int M_id
        {
            get
            {
                return m_id;
            }
            set
            {
                m_id = value;
            }
        }
        public    string getname()
        {
            return name;
        }

        private string name;
        public string Name { get
            {
                return name;
            }
            set {
                name = value;
                }
        }
        private string description;
        public string Description
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
        private string director;
        public string Director
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
        private string genre;
        public string Genre
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
        private string keyword;
        public string Keyword
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
        private string actor;
        public string Actor
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
        public string Imagefile
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
        public string Videofile
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
        
        private int rate;
        public int Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
            }
        }
        private int viewrate;
        public int Viewrate
        {
            get
            {
                return viewrate;
            }
            set
            {
                viewrate = value;
            }
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
        public moviedata()
        {
         
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {

                MessageBox.Show("Not Connected");
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

        //counter1 obj= new counter1();


        public async void adddata()
        {
            try
            {
                using (StreamWriter outputFile = new StreamWriter(Path.Combine("movienames.txt"),true))
                {
                        outputFile.WriteLine(name);
                }
                MessageBox.Show("add data: " +  M_id.ToString());
                SetResponse response = await client.SetAsync("Movie DATA/" + M_id.ToString(), this);
                moviedata result = response.ResultAs<moviedata>();
               // MessageBox.Show(name);
            // MessageBox.Show("Data inserted");
            }
            catch(Exception eeee)
            {
                MessageBox.Show(eeee.ToString());
            }
        }

        public async void deletedata(string a)
        {
            FirebaseResponse r = await client.DeleteAsync("Movie DATA/" + a);
            //   MessageBox.Show("Data deleted");

        }
        public async void updatedata(string a)
        {
           // MessageBox.Show("CALLed");
            FirebaseResponse r = await client.UpdateAsync("Movie DATA/" + a, this);
            moviedata obj = r.ResultAs<moviedata>();
            //  MessageBox.Show("Data updated");

        }
        public void setdata(int id,string n, string d, string g, string c, string k,string des,string v,string i)
        {
            
            m_id = id;
            name = n;
            director =  d ;
            genre = g;
            actor = c;
            keyword = k;
            description = des;
            videofile = v;
            imagefile = i;
            rate = 0;
            
            viewrate = 0;
            
        }
        public async void retrivevalues(string id1)
        {
            try
            {
                FirebaseResponse r = await client.GetAsync("Movie DATA/"+id1);
               moviedata  obj = r.ResultAs<moviedata>();
             //   MessageBox.Show("Name: " + obj.Name);
                if (obj.Name != null)
                {

                    m_id = Convert.ToInt32( id1);
                    this.setdata(obj.M_id,obj.Name, obj.Director, obj.Genre, obj.Actor, obj.Keyword, obj.Description, obj.Videofile, obj.Imagefile);
                }
                
                  
                
                }
            catch
            {
                MessageBox.Show("Internet Error");
            }
        }
    }
}
