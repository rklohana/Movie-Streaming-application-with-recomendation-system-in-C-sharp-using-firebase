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
            this.movietemplate1 = new RIOFLIX123.movietemplate();
            this.usersignup1 = new RIOFLIX123.usersignup();
            this.SuspendLayout();
            // 
            // movietemplate1
            // 
            this.movietemplate1.Location = new System.Drawing.Point(85, 12);
            this.movietemplate1.Name = "movietemplate1";
            this.movietemplate1.Size = new System.Drawing.Size(676, 334);
            this.movietemplate1.TabIndex = 0;
            // 
            // usersignup1
            // 
            this.usersignup1.Location = new System.Drawing.Point(74, -18);
            this.usersignup1.Name = "usersignup1";
            this.usersignup1.Size = new System.Drawing.Size(620, 456);
            this.usersignup1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usersignup1);
            this.Controls.Add(this.movietemplate1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private movietemplate movietemplate1;
        private usersignup usersignup1;
    }
}

