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
                description.Text = value;
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


        #endregion
        public moviedisplay()
        {
            InitializeComponent();
        }

        private void moviedisplay_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(c2.getConfig());
            if (client == null)
            {

                MessageBox.Show("error Connecting");
            }
        }
    }
}
