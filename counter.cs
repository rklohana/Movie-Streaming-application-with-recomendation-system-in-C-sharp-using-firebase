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
       // private int mov_id;
        public int Mov_id {
            get; set;
        }



        public async void retrivevalues()
        {
            FirebaseResponse response = await client.GetAsync("Counter DATA/");
            counter1 c1 = response.ResultAs<counter1>();
            Mov_id = c1.Mov_id;
         //   MessageBox.Show("Class"+Mov_id.ToString());
            return;

                }
        

        public  void increase()
        {
            Mov_id++;
           
            
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
             //    MessageBox.Show(Mov_id.ToString());
                
            }
            catch (Exception eeee)
            {
                MessageBox.Show(eeee.ToString());
            }
        }

    }
}
