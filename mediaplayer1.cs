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
    public partial class mediaplayer1 : UserControl
    {
        moviedata m2;
        Panel p2;
        string name;
        string url;
        Image im;
        public mediaplayer1(string n,Panel p1,string u,Image ic)
        {
            im = ic;
            url = u;
            name = n;
            p2 = p1;
            
            InitializeComponent();
        }

        private void mediaplayer1_Load(object sender, EventArgs e)
        {
           // bunifuProgressBar1.Hide();
            pictureBox1.Image = im;
            label1.Text = name;
            vlcControl1.Play(new Uri(url));
            vlcControl1.Audio.Volume = bunifuSlider1.Value;
            vlcControl1.Time = 0;
            vlcControl1.Update();
        }

        private void vlcControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            vlcControl1.Audio.Volume = bunifuSlider1.Value;
        }

        private void bunifuSlider2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            pausebutton.Hide();
            vlcControl1.Pause();
            playbutton.Show();
        }

        private void playbutton_Click(object sender, EventArgs e)
        {

            playbutton.Hide();
            vlcControl1.Pause();
            pausebutton.Show();
        }

        private void vlcControl1_MouseEnter(object sender, EventArgs e)
        {
            //bunifuProgressBar1.Show();
            //bunifuProgressBar1.Value = Convert.ToInt32(vlcControl1.Time);
        }

        private void vlcControl1_MouseLeave(object sender, EventArgs e)
        {
          //  bunifuProgressBar1.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
