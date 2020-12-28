using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Firebase.Storage;
using System.IO;
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
            this.userlogin1 = new RIOFLIX123.userlogin();
            this.SuspendLayout();
            // 
            // userlogin1
            // 
            this.userlogin1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userlogin1.Location = new System.Drawing.Point(61, 25);
            this.userlogin1.Name = "userlogin1";
            this.userlogin1.Size = new System.Drawing.Size(475, 350);
            this.userlogin1.TabIndex = 0;
            this.userlogin1.Load += new System.EventHandler(this.userlogin1_Load);
            // 
            // loginformUSER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userlogin1);
            this.Name = "loginformUSER";
            this.Text = "loginformUSER";
            this.Load += new System.EventHandler(this.loginformUSER_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private userlogin userlogin1;
    }
}