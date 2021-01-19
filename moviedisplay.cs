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
using FireSharp.Response;
using FireSharp.Interfaces;


namespace RIOFLIX123
{
    public partial class moviedisplay : UserControl
    {
        moviedata c2 = new moviedata();
        IFirebaseClient client;
        #region properties
        private string nametext;
        [Category("Customs props")]
        public string Nametext
        {
            get
            {
                return nametext;
            }
            set
            {
                nametext = value;
                moviename.Text = value;
            }
        }
        private string descriptiontext;
        [Category("Customs props")]
        public string Descriptiontext
        {
            get
            {
                return descriptiontext;
            }
            set
            {
                descriptiontext = value;
                
            }
        }
        private string genretext;
        [Category("Customs props")]
        public string Genretext
        {
            get
            {
                return genretext;
            }
            set
            {
                genretext = value;
                genre.Text = value;
            }
        }
        private string startext;
        [Category("Customs props")]
        public string Startext
        {
            get
            {
                return startext;
            }
            set
            {
                startext = value;
                cast.Text = value;
            }
        }
        private string directortext;
        [Category("Customs props")]
        public string Directortext
        {
            get
            {
                return directortext;
            }
            set
            {
                directortext = value;
                directors.Text = value;
            }
        }

        private Image icon;
        [Category("Customs props")]
        public Image Icon
        {
            get { return icon; }
            set
            {
                icon = value;
                bunifuImageButton2.Image = value;
            }
        }


        private int rate1;
        [Category("Customs props")]
        public int ratetext
        {
            get
            {
                return rate1;
            }
            set
            {
                rate1 = value;
                bunifuSlider1.Value = value;
            }
        }



        private string id;
        [Category("Customs props")]
        public string ID
        {
            get { return id; }
            set
            {
                id = value;

            }
        }


        private string videofile;
        [Category("Customs props")]
        public string Videofile
        {
            get { return videofile; }
            set
            {
                videofile = value;

            }
        }
        
        #endregion
        Panel p2;
        string username1;
        module m2;
        SingleLinkedList l1;
        public moviedisplay(module m1,Panel p1,string username)
        {
            m2 = m1;
            username1 = username;
            p2 = p1;
            l1 = m1.returnlist();
            InitializeComponent();
        }
        moviedata obj;
        private async void moviedisplay_Load(object sender, EventArgs e)
        {
            donepic.Hide();
            client = new FireSharp.FirebaseClient(c2.getConfig());
            if (client == null)
            {

                MessageBox.Show("error Connecting");

            }
            try
            {
                FirebaseResponse r = await client.GetAsync("Movie DATA/" + id);
                 obj = r.ResultAs<moviedata>();
            }
            catch
            {
                MessageBox.Show("Internet Error");
            }
            populatepanel1();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            obj.Rate += bunifuSlider1.Value;
            obj.Viewrate++;
            int r = obj.Rate / obj.Viewrate;
            obj.Rate = r;
            obj.Viewrate = 1;
            obj.updatedata(id);
            
        }

        private void mylistbutton_Click(object sender, EventArgs e)
        {
            playlist pl = new playlist();
            pl.adddatalist(pl, nametext,username1);
            mylistbutton.Hide();
            donepic.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void populatepanel1()
        {

            try
            {
               
                var like = m2.getreccomend(nametext);
              //  MessageBox.Show("called");
                movieplay[] ml = new movieplay[like.Count];




                SNode temp;
                //MessageBox.Show(temp.next.next.data.Name);
                // MessageBox.Show(l1.getcount().ToString());
                int i = 0;
                foreach (var pls in like)
                {
                    temp = l1.gethead();
                    for (int j = 0; j < l1.getcount(); j++)
                    {
                        try
                        {
                            if (pls == temp.data.Name)
                            {
                                //  MessageBox.Show(temp.data.Name);
                                ml[i] = new movieplay(m2,p2, username1);
                                ml[i].Nametext = temp.data.Name;
                                ml[i].Icon = temp.data.photoback(temp.data.Imagefile);
                                ml[i].ID = temp.data.M_id.ToString();


                                if (flowLayoutPanel1.Controls.Count < 0)
                                {
                                    flowLayoutPanel1.Controls.Clear();
                                }
                                else
                                {
                                    ml[i].Show();
                                    flowLayoutPanel1.Controls.Add(ml[i]);
                                }

                            }
                        }
                        catch (Exception eee)
                        {

                        }
                        temp = temp.next;
                    }
                    i++;
                }
            }
            catch (Exception eee)
            {

            }

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_DoubleClick(object sender, EventArgs e)
        {
            playlist pl = new playlist();
            pl.retrivevalues(username1);
            pl.adddatahist(pl, nametext, username1);
            var url = videofile;
            mediaplayer1 mp = new mediaplayer1(nametext, p2,url,icon);
            p2.Controls.Clear();
            p2.Controls.Add(mp);
            p2.Show();
            p2.BringToFront();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
