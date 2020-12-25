
namespace RIOFLIX123
{
    partial class movietemplate
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movietemplate));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nametext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.descriptext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.creatortext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.startext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.genretext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.keywordtext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.addimage = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.trans1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.trans1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.trans1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(139, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.trans1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(139, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.trans1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(139, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Creators";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.trans1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(139, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Starring";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.trans1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(139, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Genre";
            // 
            // nametext
            // 
            this.nametext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans1.SetDecoration(this.nametext, BunifuAnimatorNS.DecorationType.None);
            this.nametext.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nametext.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.nametext.HintForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.nametext.HintText = "";
            this.nametext.isPassword = false;
            this.nametext.LineFocusedColor = System.Drawing.Color.LightSlateGray;
            this.nametext.LineIdleColor = System.Drawing.Color.Maroon;
            this.nametext.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.nametext.LineThickness = 3;
            this.nametext.Location = new System.Drawing.Point(240, 10);
            this.nametext.Margin = new System.Windows.Forms.Padding(4);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(307, 34);
            this.nametext.TabIndex = 6;
            this.nametext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // descriptext
            // 
            this.descriptext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans1.SetDecoration(this.descriptext, BunifuAnimatorNS.DecorationType.None);
            this.descriptext.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.descriptext.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.descriptext.HintForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.descriptext.HintText = "";
            this.descriptext.isPassword = false;
            this.descriptext.LineFocusedColor = System.Drawing.Color.LightSlateGray;
            this.descriptext.LineIdleColor = System.Drawing.Color.Maroon;
            this.descriptext.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.descriptext.LineThickness = 3;
            this.descriptext.Location = new System.Drawing.Point(240, 51);
            this.descriptext.Margin = new System.Windows.Forms.Padding(4);
            this.descriptext.Name = "descriptext";
            this.descriptext.Size = new System.Drawing.Size(307, 33);
            this.descriptext.TabIndex = 7;
            this.descriptext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // creatortext
            // 
            this.creatortext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans1.SetDecoration(this.creatortext, BunifuAnimatorNS.DecorationType.None);
            this.creatortext.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.creatortext.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.creatortext.HintForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.creatortext.HintText = "";
            this.creatortext.isPassword = false;
            this.creatortext.LineFocusedColor = System.Drawing.Color.LightSlateGray;
            this.creatortext.LineIdleColor = System.Drawing.Color.Maroon;
            this.creatortext.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.creatortext.LineThickness = 3;
            this.creatortext.Location = new System.Drawing.Point(240, 92);
            this.creatortext.Margin = new System.Windows.Forms.Padding(4);
            this.creatortext.Name = "creatortext";
            this.creatortext.Size = new System.Drawing.Size(307, 33);
            this.creatortext.TabIndex = 8;
            this.creatortext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // startext
            // 
            this.startext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans1.SetDecoration(this.startext, BunifuAnimatorNS.DecorationType.None);
            this.startext.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.startext.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.startext.HintForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.startext.HintText = "";
            this.startext.isPassword = false;
            this.startext.LineFocusedColor = System.Drawing.Color.LightSlateGray;
            this.startext.LineIdleColor = System.Drawing.Color.Maroon;
            this.startext.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.startext.LineThickness = 3;
            this.startext.Location = new System.Drawing.Point(240, 133);
            this.startext.Margin = new System.Windows.Forms.Padding(4);
            this.startext.Name = "startext";
            this.startext.Size = new System.Drawing.Size(307, 33);
            this.startext.TabIndex = 9;
            this.startext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // genretext
            // 
            this.genretext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans1.SetDecoration(this.genretext, BunifuAnimatorNS.DecorationType.None);
            this.genretext.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.genretext.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.genretext.HintForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.genretext.HintText = "";
            this.genretext.isPassword = false;
            this.genretext.LineFocusedColor = System.Drawing.Color.LightSlateGray;
            this.genretext.LineIdleColor = System.Drawing.Color.Maroon;
            this.genretext.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.genretext.LineThickness = 3;
            this.genretext.Location = new System.Drawing.Point(240, 174);
            this.genretext.Margin = new System.Windows.Forms.Padding(4);
            this.genretext.Name = "genretext";
            this.genretext.Size = new System.Drawing.Size(307, 33);
            this.genretext.TabIndex = 10;
            this.genretext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.genretext.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox5_OnValueChanged);
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.trans1.SetDecoration(this.bunifuProgressBar1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuProgressBar1.Location = new System.Drawing.Point(240, 300);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(106, 10);
            this.bunifuProgressBar1.TabIndex = 14;
            this.bunifuProgressBar1.UseWaitCursor = true;
            this.bunifuProgressBar1.Value = 0;
            // 
            // keywordtext
            // 
            this.keywordtext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.keywordtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trans1.SetDecoration(this.keywordtext, BunifuAnimatorNS.DecorationType.None);
            this.keywordtext.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.keywordtext.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.keywordtext.HintForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.keywordtext.HintText = "";
            this.keywordtext.isPassword = false;
            this.keywordtext.LineFocusedColor = System.Drawing.Color.LightSlateGray;
            this.keywordtext.LineIdleColor = System.Drawing.Color.Maroon;
            this.keywordtext.LineMouseHoverColor = System.Drawing.Color.LightSlateGray;
            this.keywordtext.LineThickness = 3;
            this.keywordtext.Location = new System.Drawing.Point(240, 215);
            this.keywordtext.Margin = new System.Windows.Forms.Padding(4);
            this.keywordtext.Name = "keywordtext";
            this.keywordtext.Size = new System.Drawing.Size(307, 33);
            this.keywordtext.TabIndex = 16;
            this.keywordtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.trans1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(139, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Keywords";
            // 
            // addimage
            // 
            this.addimage.ActiveBorderThickness = 1;
            this.addimage.ActiveCornerRadius = 20;
            this.addimage.ActiveFillColor = System.Drawing.Color.Maroon;
            this.addimage.ActiveForecolor = System.Drawing.Color.Transparent;
            this.addimage.ActiveLineColor = System.Drawing.Color.Maroon;
            this.addimage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addimage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addimage.BackgroundImage")));
            this.addimage.ButtonText = "Add Image";
            this.addimage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans1.SetDecoration(this.addimage, BunifuAnimatorNS.DecorationType.None);
            this.addimage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addimage.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.addimage.IdleBorderThickness = 1;
            this.addimage.IdleCornerRadius = 20;
            this.addimage.IdleFillColor = System.Drawing.Color.Maroon;
            this.addimage.IdleForecolor = System.Drawing.SystemColors.AppWorkspace;
            this.addimage.IdleLineColor = System.Drawing.Color.Maroon;
            this.addimage.Location = new System.Drawing.Point(5, 143);
            this.addimage.Margin = new System.Windows.Forms.Padding(5);
            this.addimage.Name = "addimage";
            this.addimage.Size = new System.Drawing.Size(106, 35);
            this.addimage.TabIndex = 17;
            this.addimage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addimage.Click += new System.EventHandler(this.addimage_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Add Video";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans1.SetDecoration(this.bunifuThinButton21, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.Location = new System.Drawing.Point(240, 257);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(106, 35);
            this.bunifuThinButton21.TabIndex = 18;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuThinButton22.ButtonText = "Done";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trans1.SetDecoration(this.bunifuThinButton22, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.Location = new System.Drawing.Point(441, 257);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(106, 35);
            this.bunifuThinButton22.TabIndex = 19;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // trans1
            // 
            this.trans1.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.trans1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.trans1.DefaultAnimation = animation1;
            // 
            // movietemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.addimage);
            this.Controls.Add(this.keywordtext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.genretext);
            this.Controls.Add(this.startext);
            this.Controls.Add(this.creatortext);
            this.Controls.Add(this.descriptext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.trans1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "movietemplate";
            this.Size = new System.Drawing.Size(676, 334);
            this.Load += new System.EventHandler(this.movietemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nametext;
        private Bunifu.Framework.UI.BunifuMaterialTextbox descriptext;
        private Bunifu.Framework.UI.BunifuMaterialTextbox creatortext;
        private Bunifu.Framework.UI.BunifuMaterialTextbox startext;
        private Bunifu.Framework.UI.BunifuMaterialTextbox genretext;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox keywordtext;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 addimage;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private BunifuAnimatorNS.BunifuTransition trans1;
    }
}
