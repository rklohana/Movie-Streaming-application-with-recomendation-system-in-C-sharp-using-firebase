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
    public partial class movieplay : UserControl

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
                name.Text = value;
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

        public movieplay()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void movieplay_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(c2.getConfig());
            if (client == null)
            {

                MessageBox.Show("error Connecting");
            }
        }
    }
}
