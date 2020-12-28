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
    partial class userlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userlogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mobiletext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordtext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.signin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(72, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "RIOFLIX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(79, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Number";
            // 
            // mobiletext
            // 
            this.mobiletext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mobiletext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mobiletext.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobiletext.ForeColor = System.Drawing.Color.White;
            this.mobiletext.HintForeColor = System.Drawing.Color.Empty;
            this.mobiletext.HintText = "";
            this.mobiletext.isPassword = false;
            this.mobiletext.LineFocusedColor = System.Drawing.Color.Lavender;
            this.mobiletext.LineIdleColor = System.Drawing.Color.DarkRed;
            this.mobiletext.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.mobiletext.LineThickness = 4;
            this.mobiletext.Location = new System.Drawing.Point(82, 108);
            this.mobiletext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mobiletext.Name = "mobiletext";
            this.mobiletext.Size = new System.Drawing.Size(292, 39);
            this.mobiletext.TabIndex = 2;
            this.mobiletext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(79, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // passwordtext
            // 
            this.passwordtext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtext.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtext.ForeColor = System.Drawing.Color.White;
            this.passwordtext.HintForeColor = System.Drawing.Color.Empty;
            this.passwordtext.HintText = "";
            this.passwordtext.isPassword = false;
            this.passwordtext.LineFocusedColor = System.Drawing.Color.Lavender;
            this.passwordtext.LineIdleColor = System.Drawing.Color.DarkRed;
            this.passwordtext.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passwordtext.LineThickness = 4;
            this.passwordtext.Location = new System.Drawing.Point(82, 196);
            this.passwordtext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(292, 39);
            this.passwordtext.TabIndex = 4;
            this.passwordtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // signin
            // 
            this.signin.ActiveBorderThickness = 1;
            this.signin.ActiveCornerRadius = 20;
            this.signin.ActiveFillColor = System.Drawing.Color.Maroon;
            this.signin.ActiveForecolor = System.Drawing.Color.White;
            this.signin.ActiveLineColor = System.Drawing.Color.Maroon;
            this.signin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signin.BackgroundImage")));
            this.signin.ButtonText = "Sign In";
            this.signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.signin.IdleBorderThickness = 1;
            this.signin.IdleCornerRadius = 20;
            this.signin.IdleFillColor = System.Drawing.Color.Maroon;
            this.signin.IdleForecolor = System.Drawing.SystemColors.AppWorkspace;
            this.signin.IdleLineColor = System.Drawing.Color.Maroon;
            this.signin.Location = new System.Drawing.Point(82, 267);
            this.signin.Margin = new System.Windows.Forms.Padding(5);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(292, 41);
            this.signin.TabIndex = 5;
            this.signin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(160, 324);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(133, 13);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "New to RIOFLIX? Sign up.";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // userlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mobiletext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "userlogin";
            this.Size = new System.Drawing.Size(475, 350);
            this.Load += new System.EventHandler(this.userlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mobiletext;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordtext;
        private Bunifu.Framework.UI.BunifuThinButton2 signin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
