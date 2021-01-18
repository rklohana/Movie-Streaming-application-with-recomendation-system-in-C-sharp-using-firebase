using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIOFLIX123
{
    public partial class playlistpanel : UserControl
    {
        module m;
        playlist plist;
        public playlistpanel(module m1, Panel p1, SingleLinkedList l2, playlist pl)
        {
            plist = pl;
            l1 = l2;
            p2 = p1;
            m = m1;
            InitializeComponent();
        }
        SingleLinkedList l1;
        Panel p2;
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void populatepanel1()
        {
            string[] history = plist.ListName.Split(',');
            
            MessageBox.Show("called");
            movieplay[] m2 = new movieplay[history.Length];




            SNode temp;
            //MessageBox.Show(temp.next.next.data.Name);
            // MessageBox.Show(l1.getcount().ToString());
            int i = 0;
            foreach (var pls in history)
            {
                temp = l1.gethead();
                for (int j = 0; j < l1.getcount(); j++)
                {
                    if (pls == temp.data.Name)
                    {
                        //  MessageBox.Show(temp.data.Name);
                        m2[i] = new movieplay(p2);
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
                    temp = temp.next;
                }
                i++;
            }
        }
    }
}
