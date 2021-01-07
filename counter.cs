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

  public  class counter1
    {
        private int mov_id;
        public int Mov_id {
            get
            {
                return mov_id;
            }
            set
            {
                mov_id = value;
            }
        
        
        }



        public async void retrivevalues()
        {
            FirebaseResponse response = await client.GetAsync("Counter DATA/");
            counter1 c1 = response.ResultAs<counter1>();
            mov_id = c1.getmovid();



                }
        public int getmovid()
        {
            MessageBox.Show(mov_id.ToString());
            return mov_id;
        }

        public  void increase()
        {
            mov_id++;
           
            
        }

        public IFirebaseClient client;


        protected IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "y4RjXMGpXFsmuG4T0pMLmWIBtcQ6V84ke4uJ3hCT",
            BasePath = "https://rioflix-default-rtdb.firebaseio.com/"
        };
       public counter1()
        {
            client = new FireSharp.FirebaseClient(config);
            if (client == null)
            {

                MessageBox.Show("Not Connected");
            }
           
        }
        public async void adddata(counter1 md)
        {
            try
            {
               
                SetResponse response = await client.SetAsync("Counter DATA/", md);
                counter1 result = response.ResultAs<counter1>();
                // MessageBox.Show(name);
                
            }
            catch (Exception eeee)
            {
                MessageBox.Show(eeee.ToString());
            }
        }

    }
}
