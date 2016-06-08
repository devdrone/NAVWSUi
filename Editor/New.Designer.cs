﻿namespace Editor
{
    partial class New
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
            this.label8 = new System.Windows.Forms.Label();
            this.domain = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.soapPort = new System.Windows.Forms.TextBox();
            this.instanceName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.serverName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Domain";
            // 
            // domain
            // 
            this.domain.Location = new System.Drawing.Point(105, 142);
            this.domain.Name = "domain";
            this.domain.Size = new System.Drawing.Size(183, 20);
            this.domain.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Select Company*";
            // 
            // company
            // 
            this.company.FormattingEnabled = true;
            this.company.Location = new System.Drawing.Point(105, 167);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(183, 21);
            this.company.TabIndex = 46;
            this.company.DropDown += new System.EventHandler(this.company_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "SOAP Port*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Instance Name*";
            // 
            // soapPort
            // 
            this.soapPort.Location = new System.Drawing.Point(105, 116);
            this.soapPort.Name = "soapPort";
            this.soapPort.Size = new System.Drawing.Size(183, 20);
            this.soapPort.TabIndex = 43;
            // 
            // instanceName
            // 
            this.instanceName.Location = new System.Drawing.Point(105, 90);
            this.instanceName.Name = "instanceName";
            this.instanceName.Size = new System.Drawing.Size(183, 20);
            this.instanceName.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Password*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "User Name*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Server Name*";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(105, 64);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(183, 20);
            this.password.TabIndex = 38;
            this.password.UseSystemPasswordChar = true;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(105, 38);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(183, 20);
            this.userName.TabIndex = 37;
            // 
            // serverName
            // 
            this.serverName.Location = new System.Drawing.Point(105, 12);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(183, 20);
            this.serverName.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 52;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 242);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.domain);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.company);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.soapPort);
            this.Controls.Add(this.instanceName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.serverName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "New";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox domain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox company;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soapPort;
        private System.Windows.Forms.TextBox instanceName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}