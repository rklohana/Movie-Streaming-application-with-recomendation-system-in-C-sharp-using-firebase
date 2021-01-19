using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace RIOFLIX123
{
    public partial class recent : UserControl
      {
        SingleLinkedList l1;
        Panel p2;
        playlist plist;
        string username;
        module m;
        public recent(module m1,Panel p1,SingleLinkedList l2,playlist pl,string n)
        {
            m = m1;
            username = n;
            plist = pl;
            l1 = l2;
            p2 = p1;
            InitializeComponent();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public IFirebaseClient client;


        protected IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "y4RjXMGpXFsmuG4T0pMLmWIBtcQ6V84ke4uJ3hCT",
            BasePath = "https://rioflix-default-rtdb.firebaseio.com/"
        };
        counter1 c1 = new counter1();
        
        private  void recent_Load(object sender, EventArgs e)
        {
            
           
            populatepanel1();
        }
        void populatepanel1()
        {
            try
            {
              //  MessageBox.Show("called");
                movieplay[] m2 = new movieplay[plist.HistName.Length];

                SNode temp;
                //MessageBox.Show(temp.next.next.data.Name);
                // MessageBox.Show(l1.getcount().ToString());
                int i = 0;
                var history = plist.HistName.Split(',');
                Stack st = new Stack();
                for (int k = 1; k < history.Length; k++)
                {
                    st.Push(history[k]);
                }
                Node stemp = st.rethead();
                while (stemp != null)
                {
                    temp = l1.gethead();
                    for (int j = 0; j < l1.getcount(); j++)
                    {
                        try
                        {
                            if (stemp.data == temp.data.Name)
                            {
                                //  MessageBox.Show(temp.data.Name);
                                m2[i] = new movieplay(m,p2, username);
                                m2[i].Nametext = temp.data.Name;
                                m2[i].Icon = temp.data.photoback(temp.data.Imagefile);
                                m2[i].ID = temp.data.M_id.ToString();


                                if (flowLayoutPanel1.Controls.Count < 0)
                                {
                                    flowLayoutPanel1.Controls.Clear();
                                }
                                else
                                {
                                    m2[i].Show();
                                    flowLayoutPanel1.Controls.Add(m2[i]);
                                }
                            }
                        }
                        catch (Exception eeeeeeeeeee)
                        {
                            MessageBox.Show("Some error");
                        }
                        temp = temp.next;


                    }
                    stemp = stemp.next;
                    i++;
                }
            }
            catch(Exception eeee)
            {

            }
           
        }
    }
}
