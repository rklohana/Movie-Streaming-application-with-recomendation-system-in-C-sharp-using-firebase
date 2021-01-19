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
    public partial class searchpanel : UserControl
    {
        module ml;
        Panel p2;
        string username;


        public void addpanel()
        {
            try
            {
                movieplay mpp = new movieplay(ml, p2, username);
                mpp.Nametext = m.Name;
                mpp.Icon = m.photoback(m.Imagefile);
                mpp.ID = m.M_id.ToString();
                flowLayoutPanel1.Controls.Add(mpp);
            }
            catch(Exception eeee)
            {

            }
        }
        public searchpanel(module mo, Panel p, string n)
        {
            p2 = p;
            ml = mo;
            username = n;
            InitializeComponent();
        }
        moviedata m;
        SingleLinkedList l1;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            l1 = ml.returnlist();
            AVL btree = ml.returnbtree();
            m = btree.find(bunifuMaterialTextbox1.Text);
            searchlist();
            addpanel();
            populatepanel1();

        }
        List<moviedata> list1 = new List<moviedata>();
        void searchlist()
        {
            SNode temp = l1.gethead();
            while (temp != null)
            {
                if (temp.data.Name.Contains(bunifuMaterialTextbox1.Text))
                {
                    list1.Add(temp.data);
                }
                temp = temp.next;
            }
        }
        void populatepanel1()
        {
            try
            {

              //  MessageBox.Show("called");
                movieplay[] m2 = new movieplay[list1.Count];

                SNode temp;
                //MessageBox.Show(temp.next.next.data.Name);
                // MessageBox.Show(l1.getcount().ToString());
                int i = 0;
                //var history = plist.HistName.Split(',');


                foreach (var pls in list1)
                {

                    try
                    {

                        //  MessageBox.Show(temp.data.Name);
                        m2[i] = new movieplay(ml, p2, username);
                        m2[i].Nametext = pls.Name;
                        m2[i].Icon = pls.photoback(pls.Imagefile);
                        m2[i].ID = pls.M_id.ToString();


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
                    catch (Exception eeeeeeeeeee)
                    {
                        MessageBox.Show("Some error");
                    }

                    i++;
                }
            }
            catch (Exception eeee)
            {

            }

        }
    }
}
