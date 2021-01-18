
namespace RIOFLIX123
{
    partial class loginformUSER
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
            this.adminsignup1 = new RIOFLIX123.adminsignup();
            this.SuspendLayout();
            // 
            // adminsignup1
            // 
            this.adminsignup1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.adminsignup1.Location = new System.Drawing.Point(94, 3);
            this.adminsignup1.Name = "adminsignup1";
            this.adminsignup1.Size = new System.Drawing.Size(620, 456);
            this.adminsignup1.TabIndex = 0;
            // 
            // loginformUSER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.adminsignup1);
            this.Name = "loginformUSER";
            this.Text = "loginformUSER";
            this.Load += new System.EventHandler(this.loginformUSER_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private adminsignup adminsignup1;
    }
}