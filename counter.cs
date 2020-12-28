using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Windows.Forms;

namespace RIOFLIX123
{
    class counter1
    {
        protected static string adminid;
        public string Id
        {
            get
            {
                return adminid;
            }
            set
            {
                adminid = value;
            }
        }
        protected static string usid;
        public string UsId
        {
            get
            {
                return usid;
            }
            set
            {
                usid = value;
            }
        }
        protected static string movid;
        public string Movid
        {
            get
            {
                return movid;
            }
            set
            {
                movid = value;
            }
        }
        protected static string listid;
        public string Listid
        {
            get
            {
                return listid;
            }
            set
            {
                listid = value;
            }
        }
        public static counter1 operator ++(counter1 c)
        {
            count123++;
            return c;

        }
        public static int count123 { get; set; }
        protected static string acid;
        public string Acid
        {
            get
            {
                return acid;
            }
            set
            {
                acid = value;
            }
        }

        protected IFirebaseClient client;


        protected IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "y4RjXMGpXFsmuG4T0pMLmWIBtcQ6V84ke4uJ3hCT",
            BasePath = "https://rioflix-default-rtdb.firebaseio.com/"
        };
    
        public void movieincrease(counter1 c)
        {
            int mwid = Convert.ToInt32(c.Movid);
            mwid++;
            c.Movid = mwid.ToString();

            adddata(c);
        }

        public void listincrease(counter1 c)
        {
            int lid = Convert.ToInt32(c.Listid);
            lid++;
            c.Listid = lid.ToString();

            adddata(c);
        }
        public void adminincrease(counter1 c)
        {
            int aid = Convert.ToInt32(c.Id);
            aid++;
            c.Id = aid.ToString();

            adddata(c);
        }

        public void userincrease(counter1 c)
        {
            int epid = Convert.ToInt32(c.UsId);
            epid++;
            c.UsId = epid.ToString();

            adddata(c);
        }
        public IFirebaseConfig getconfig()
        {
            return config;
        }
        public counter1()
        {


            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {

                MessageBox.Show(" Connection error");
            }

        }
        public async void adddata(counter1 a)
        {
            //   counter a = new counter();
            SetResponse response = await client.SetAsync("Counter DATA/", a); ;
            counter1 result = response.ResultAs<counter1>();
            //   MessageBox.Show(id);
        }
        public async void retrivevalues()
        {
            try
            {
                FirebaseResponse r = await client.GetAsync("Counter DATA/");
                counter1 obj = r.ResultAs<counter1>();
                MessageBox.Show("retrieved successfully");
                MessageBox.Show(movid);
            }
            catch
            {
                MessageBox.Show("Internet Error");
            }
        }
        public async void deletedata(string a)
        {
            FirebaseResponse r = await client.DeleteAsync("Counter DATA/" + a);
            MessageBox.Show("Data deleted");

        }
        public async void updatedata(string a, counter1 b)
        {
            FirebaseResponse r = await client.UpdateAsync("Counter DATA/" + a, b);
            counter1 obj = r.ResultAs<counter1>();
            MessageBox.Show("Data updated");

        }
        public string getadid()
        {
            return adminid;
        }
        public string getusid()
        {
            return usid;
        }
        public string getmovid()
        {
            return movid;
        }
        public string getlistid()
        {
            return listid;
        }
        
    }
}
