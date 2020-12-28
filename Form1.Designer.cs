namespace RIOFLIX123
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainpagedisplay1 = new RIOFLIX123.mainpagedisplay();
            this.SuspendLayout();
            // 
            // mainpagedisplay1
            // 
            this.mainpagedisplay1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainpagedisplay1.Location = new System.Drawing.Point(59, 1);
            this.mainpagedisplay1.Name = "mainpagedisplay1";
            this.mainpagedisplay1.Size = new System.Drawing.Size(411, 405);
            this.mainpagedisplay1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.mainpagedisplay1);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private mainpagedisplay mainpagedisplay1;
    }
}

