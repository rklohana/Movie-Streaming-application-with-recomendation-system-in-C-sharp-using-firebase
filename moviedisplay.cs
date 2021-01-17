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
                pictureBox1.Image = value;
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
        #endregion
        Panel p2;
        
        public moviedisplay()
        {
          
        
            InitializeComponent();
        }
        moviedata obj;
        private async void moviedisplay_Load(object sender, EventArgs e)
        {
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

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           
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
            pl.adddatalist(pl, nametext,"");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            playlist pl = new playlist();
            pl.retrivevalues("");
            pl.adddatahist(pl, nametext,"");
            var url = obj.Videofile;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
