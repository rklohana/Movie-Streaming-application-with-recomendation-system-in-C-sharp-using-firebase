namespace RIOFLIX123
{
    partial class mainpagedisplay
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainpagedisplay));
            this.similartotext = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.similartopanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.mylistpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.allmoviespanel = new System.Windows.Forms.FlowLayoutPanel();
            this.displaytrans = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.SuspendLayout();
            // 
            // similartotext
            // 
            this.similartotext.AutoSize = true;
            this.similartotext.BackColor = System.Drawing.Color.Transparent;
            this.displaytrans.SetDecoration(this.similartotext, BunifuAnimatorNS.DecorationType.None);
            this.similartotext.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.similartotext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.similartotext.Location = new System.Drawing.Point(3, 267);
            this.similartotext.Name = "similartotext";
            this.similartotext.Size = new System.Drawing.Size(77, 18);
            this.similartotext.TabIndex = 11;
            this.similartotext.Text = "Similar To";
            // 
            // similartopanel
            // 
            this.similartopanel.AutoScroll = true;
            this.displaytrans.SetDecoration(this.similartopanel, BunifuAnimatorNS.DecorationType.None);
            this.similartopanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.similartopanel.Location = new System.Drawing.Point(6, 288);
            this.similartopanel.Name = "similartopanel";
            this.similartopanel.Size = new System.Drawing.Size(400, 101);
            this.similartopanel.TabIndex = 10;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.displaytrans.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 142);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(62, 18);
            this.bunifuCustomLabel2.TabIndex = 9;
            this.bunifuCustomLabel2.Text = "My List:";
            // 
            // mylistpanel
            // 
            this.mylistpanel.AutoScroll = true;
            this.displaytrans.SetDecoration(this.mylistpanel, BunifuAnimatorNS.DecorationType.None);
            this.mylistpanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mylistpanel.Location = new System.Drawing.Point(6, 163);
            this.mylistpanel.Name = "mylistpanel";
            this.mylistpanel.Size = new System.Drawing.Size(400, 101);
            this.mylistpanel.TabIndex = 8;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.displaytrans.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 17);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(94, 18);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "ALL Movies:";
            // 
            // allmoviespanel
            // 
            this.allmoviespanel.AutoScroll = true;
            this.displaytrans.SetDecoration(this.allmoviespanel, BunifuAnimatorNS.DecorationType.None);
            this.allmoviespanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.allmoviespanel.Location = new System.Drawing.Point(6, 38);
            this.allmoviespanel.Name = "allmoviespanel";
            this.allmoviespanel.Size = new System.Drawing.Size(400, 101);
            this.allmoviespanel.TabIndex = 6;
            // 
            // displaytrans
            // 
            this.displaytrans.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.displaytrans.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.displaytrans.DefaultAnimation = animation2;
            this.displaytrans.Interval = 20;
            // 
            // mainpagedisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.similartotext);
            this.Controls.Add(this.similartopanel);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.mylistpanel);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.allmoviespanel);
            this.displaytrans.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "mainpagedisplay";
            this.Size = new System.Drawing.Size(411, 405);
            this.Load += new System.EventHandler(this.mainpagedisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel similartotext;
        private System.Windows.Forms.FlowLayoutPanel similartopanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.FlowLayoutPanel mylistpanel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.FlowLayoutPanel allmoviespanel;
        private BunifuAnimatorNS.BunifuTransition displaytrans;
    }
}
