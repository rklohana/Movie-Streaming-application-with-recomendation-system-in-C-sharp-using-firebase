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
    public partial class UserControl1 : UserControl
    {

        string[] lastwatched;

        public UserControl1()
        {
            InitializeComponent();
        }
        
        private void UserControl1_Load(object sender, EventArgs e)
        {
            playlist pl = new playlist();
            pl.retrivevalues();
             lastwatched = pl.HistName.Split(',');
            similartotext.Text += ' ' + lastwatched[0] + " :";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void movieplay1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
