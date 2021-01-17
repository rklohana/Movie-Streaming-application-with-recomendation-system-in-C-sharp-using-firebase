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
        public mediaplayer1()
        {
            InitializeComponent();
        }

        private void mediaplayer1_Load(object sender, EventArgs e)
        {
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
            this.Hide();
            vlcControl1.Pause();
            playbutton.Show();
        }

        private void playbutton_Click(object sender, EventArgs e)
        {

            this.Hide();
            vlcControl1.Pause();
            pausebutton.Show();
        }
    }
}
