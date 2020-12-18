﻿using FireSharp.Config;
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
    class information
    {
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
        protected string name;
        public string Name
        {

            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        protected string mobile;
        public string Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                mobile = value;
            }
        }
        protected string address;
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        protected string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        protected string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
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
        public information()
        {




        }
        public string getname()
        {
            return name;
        }

        public string getmobile()
        {
            return mobile;
        }
        public string getaddress()
        {
            return address;
        }
        public string getemail()
        {
            return email;
        }
        public string getpass()
        {
            return password;
        }




    }
    class Admin : information
    {
        public static int id = 0;
        protected string image;

        public string Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }

        }
        public string getimage()
        {
            return image;
        }
        public void setdata(string n, string im, string m, string a, string e, string p)
        {
            name = n;
            image = im;
            mobile = m;
            address = a;
            email = e;
            password = p;

        }
        public Admin()
        {
            id++;
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {

                MessageBox.Show("not Connected");
            }
        }
        public async void adddata(Admin a, string b)
        {
            SetResponse response = await client.SetAsync("Admin DATA/" + b, a);
            Admin result = response.ResultAs<Admin>();
            /////   MessageBox.Show("Data inserted");
        }

        public async void deletedata(string a)
        {
            FirebaseResponse r = await client.DeleteAsync("Admin DATA/" + a);
            //   MessageBox.Show("Data deleted");

        }
        public async void updatedata(string a, Admin b)
        {
            FirebaseResponse r = await client.UpdateAsync("Admin DATA/" + a, b);
            Admin obj = r.ResultAs<Admin>();
            //  MessageBox.Show("Data updated");

        }

        public int getid()
        {
            return id;
        }
    }

    class Userdata : information
    {
        public Userdata()
        {

            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {

                MessageBox.Show("error Connecting");
            }
        }
        public void add_data(string n, string m, string a, string e, string p)
        {
            name = n;
            mobile = m;
            address = a;
            email = e;
            password = p;

        }
        public async void adddata(Userdata c)
        {

            SetResponse response = await client.SetAsync("Userdata DATA/" + c.getmobile(), c);
            Userdata result = response.ResultAs<Userdata>();
            //   MessageBox.Show(c.getemail());
        }
        public async Task<Userdata> retrievedata(string a)
        {
            FirebaseResponse r = await client.GetAsync("Userdata DATA/" + a);
            Userdata obj = r.ResultAs<Userdata>();
            return obj;
        }
        public async void deletedata(string a)
        {
            FirebaseResponse r = await client.DeleteAsync("Userdata DATA/" + a);
            //  MessageBox.Show("Data deleted");

        }
        public async void updatedata(string a, Userdata b)
        {

            FirebaseResponse r = await client.UpdateAsync("Userdata DATA/" + a, b);
            Userdata obj = r.ResultAs<Userdata>();
            //  MessageBox.Show("Data updated");

        }

    }




}