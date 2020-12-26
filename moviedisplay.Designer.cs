namespace RIOFLIX123
{
    partial class moviedisplay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(moviedisplay));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.moviename = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.description = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cast = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.directors = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.genre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.mylistbutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mylistbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(170, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 136);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            // 
            // moviename
            // 
            this.moviename.AutoSize = true;
            this.moviename.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviename.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moviename.Location = new System.Drawing.Point(17, 151);
            this.moviename.Name = "moviename";
            this.moviename.Size = new System.Drawing.Size(127, 23);
            this.moviename.TabIndex = 1;
            this.moviename.Text = "movie name";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.description.Location = new System.Drawing.Point(20, 185);
            this.description.Name = "description";
            this.description.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.description.Size = new System.Drawing.Size(79, 16);
            this.description.TabIndex = 2;
            this.description.Text = "description";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(19, 216);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(63, 16);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Starring:";
            // 
            // cast
            // 
            this.cast.AutoSize = true;
            this.cast.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cast.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cast.Location = new System.Drawing.Point(80, 216);
            this.cast.Name = "cast";
            this.cast.Size = new System.Drawing.Size(130, 16);
            this.cast.TabIndex = 4;
            this.cast.Text = "bunifuCustomLabel2";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(19, 240);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(67, 16);
            this.bunifuCustomLabel3.TabIndex = 5;
            this.bunifuCustomLabel3.Text = "Creators:";
            // 
            // directors
            // 
            this.directors.AutoSize = true;
            this.directors.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.directors.Location = new System.Drawing.Point(80, 240);
            this.directors.Name = "directors";
            this.directors.Size = new System.Drawing.Size(130, 16);
            this.directors.TabIndex = 6;
            this.directors.Text = "bunifuCustomLabel4";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(19, 264);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(56, 16);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Genre: ";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.genre.Location = new System.Drawing.Point(80, 264);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(130, 16);
            this.genre.TabIndex = 8;
            this.genre.Text = "bunifuCustomLabel4";
            // 
            // mylistbutton
            // 
            this.mylistbutton.BackColor = System.Drawing.Color.Transparent;
            this.mylistbutton.Image = ((System.Drawing.Image)(resources.GetObject("mylistbutton.Image")));
            this.mylistbutton.ImageActive = null;
            this.mylistbutton.Location = new System.Drawing.Point(478, 50);
            this.mylistbutton.Name = "mylistbutton";
            this.mylistbutton.Size = new System.Drawing.Size(59, 27);
            this.mylistbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mylistbutton.TabIndex = 10;
            this.mylistbutton.TabStop = false;
            this.mylistbutton.Zoom = 10;
            this.mylistbutton.Click += new System.EventHandler(this.mylistbutton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this.bunifuImageButton1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 24);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 13;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuSlider1.BorderRadius = 20;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.Maroon;
            this.bunifuSlider1.Location = new System.Drawing.Point(368, 14);
            this.bunifuSlider1.MaximumValue = 10;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(169, 30);
            this.bunifuSlider1.TabIndex = 11;
            this.bunifuSlider1.Value = 0;
            this.bunifuSlider1.ValueChanged += new System.EventHandler(this.bunifuSlider1_ValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 306);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(559, 198);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // moviedisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.bunifuSlider1);
            this.Controls.Add(this.mylistbutton);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.directors);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.cast);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.moviename);
            this.Controls.Add(this.pictureBox1);
            this.Name = "moviedisplay";
            this.Size = new System.Drawing.Size(565, 507);
            this.Load += new System.EventHandler(this.moviedisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mylistbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel moviename;
        private Bunifu.Framework.UI.BunifuCustomLabel description;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel cast;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel directors;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel genre;
        private Bunifu.Framework.UI.BunifuImageButton mylistbutton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}
