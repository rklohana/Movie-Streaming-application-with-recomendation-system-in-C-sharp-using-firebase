using System;
using System.Windows.Forms;

namespace RIOFLIX123
{
    public partial class listcheck : Form
    {
        public SingleLinkedList l1;
        public playlist p2;
        public listcheck(SingleLinkedList l2,playlist pl,Admin ad,Userdata ud)
        {
            l1 = l2;
            p2 = pl;
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void bunifuCustomTextbox1_TextChanged_1(object sender, EventArgs e)
        {
            

        }

        private void flyleafPlayer1_Load(object sender, EventArgs e)
        {
           
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listcheck_Load(object sender, EventArgs e)
        {
           // moviedisppanel.Hide();
            recent r1 = new recent(recentpanel,l1);
            recentpanel.Controls.Clear();
            recentpanel.Controls.Add(r1);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void moviedisppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void recentpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
