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
    public partial class ALLmovies : UserControl
    {
        Panel p2;
        SingleLinkedList l1;
        string username;
        module ml;
        public ALLmovies(module m1,SingleLinkedList l2, Panel p1,string n)
        {
            ml = m1;
            username = n;
            l1 = l2;
            p2 = p1;
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void populatepanel1()
        {
         //   MessageBox.Show("called");
            movieplay[] m2 = new movieplay[l1.getcount()];
            SNode temp = l1.gethead();
            //aggaya hoga
            //
            //MessageBox.Show(temp.next.next.data.Name);
            // MessageBox.Show(l1.getcount().ToString());
            for (int i = 0; i < l1.getcount(); i++)
            {
                //  MessageBox.Show(temp.data.Name);
                m2[i] = new movieplay(ml,p2,username);
                m2[i].Nametext = temp.data.Name;
                m2[i].Icon = temp.data.photoback(temp.data.Imagefile);
                m2[i].ID = temp.data.M_id.ToString();

                temp = temp.next;
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

        private void ALLmovies_Load(object sender, EventArgs e)
        {
            populatepanel1();
        }
    }
}