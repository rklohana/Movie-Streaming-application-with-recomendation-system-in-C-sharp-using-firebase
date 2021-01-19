namespace RIOFLIX123
{
    partial class mediaplayer1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mediaplayer1));
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.pausebutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.playbutton = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vlcControl1.Location = new System.Drawing.Point(0, 0);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(580, 508);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 0;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = null;
            this.vlcControl1.Click += new System.EventHandler(this.vlcControl1_Click);
            this.vlcControl1.MouseEnter += new System.EventHandler(this.vlcControl1_MouseEnter);
            this.vlcControl1.MouseLeave += new System.EventHandler(this.vlcControl1_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.bunifuSlider1);
            this.panel4.Controls.Add(this.pausebutton);
            this.panel4.Controls.Add(this.playbutton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 467);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(580, 41);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 0;
            this.bunifuSlider1.IndicatorColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuSlider1.Location = new System.Drawing.Point(461, 5);
            this.bunifuSlider1.MaximumValue = 100;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(116, 30);
            this.bunifuSlider1.TabIndex = 2;
            this.bunifuSlider1.Value = 100;
            this.bunifuSlider1.ValueChanged += new System.EventHandler(this.bunifuSlider1_ValueChanged);
            // 
            // pausebutton
            // 
            this.pausebutton.BackColor = System.Drawing.Color.Transparent;
            this.pausebutton.Image = ((System.Drawing.Image)(resources.GetObject("pausebutton.Image")));
            this.pausebutton.ImageActive = null;
            this.pausebutton.Location = new System.Drawing.Point(369, 5);
            this.pausebutton.Name = "pausebutton";
            this.pausebutton.Size = new System.Drawing.Size(25, 24);
            this.pausebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pausebutton.TabIndex = 1;
            this.pausebutton.TabStop = false;
            this.pausebutton.Zoom = 10;
            this.pausebutton.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // playbutton
            // 
            this.playbutton.BackColor = System.Drawing.Color.Transparent;
            this.playbutton.Image = ((System.Drawing.Image)(resources.GetObject("playbutton.Image")));
            this.playbutton.ImageActive = null;
            this.playbutton.Location = new System.Drawing.Point(369, 3);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(25, 24);
            this.playbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playbutton.TabIndex = 0;
            this.playbutton.TabStop = false;
            this.playbutton.Zoom = 5;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // mediaplayer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.vlcControl1);
            this.Name = "mediaplayer1";
            this.Size = new System.Drawing.Size(580, 508);
            this.Load += new System.EventHandler(this.mediaplayer1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton pausebutton;
        private Bunifu.Framework.UI.BunifuImageButton playbutton;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
