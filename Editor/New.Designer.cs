namespace Editor
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProjName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Domain";
            // 
            // domain
            // 
            this.domain.Location = new System.Drawing.Point(105, 196);
            this.domain.Name = "domain";
            this.domain.Size = new System.Drawing.Size(183, 20);
            this.domain.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Select Company*";
            // 
            // company
            // 
            this.company.FormattingEnabled = true;
            this.company.Location = new System.Drawing.Point(105, 221);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(183, 21);
            this.company.TabIndex = 46;
            this.company.DropDown += new System.EventHandler(this.company_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "SOAP Port*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Instance Name*";
            // 
            // soapPort
            // 
            this.soapPort.Location = new System.Drawing.Point(105, 170);
            this.soapPort.Name = "soapPort";
            this.soapPort.Size = new System.Drawing.Size(183, 20);
            this.soapPort.TabIndex = 43;
            this.soapPort.Text = "7047";
            // 
            // instanceName
            // 
            this.instanceName.Location = new System.Drawing.Point(105, 144);
            this.instanceName.Name = "instanceName";
            this.instanceName.Size = new System.Drawing.Size(183, 20);
            this.instanceName.TabIndex = 42;
            this.instanceName.Text = "dynamicsnav70";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Password*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "User Name*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Server Name*";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(105, 118);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(183, 20);
            this.password.TabIndex = 38;
            this.password.Text = "devdrone";
            this.password.UseSystemPasswordChar = true;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(105, 92);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(183, 20);
            this.userName.TabIndex = 37;
            this.userName.Text = "devdrone";
            // 
            // serverName
            // 
            this.serverName.Location = new System.Drawing.Point(105, 66);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(183, 20);
            this.serverName.TabIndex = 36;
            this.serverName.Text = "localhost";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(105, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(198, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 52;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Project Name*";
            // 
            // ProjName
            // 
            this.ProjName.Location = new System.Drawing.Point(105, 14);
            this.ProjName.Name = "ProjName";
            this.ProjName.Size = new System.Drawing.Size(183, 20);
            this.ProjName.TabIndex = 54;
            this.ProjName.Text = "devdrone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Project Location*";
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(105, 40);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(183, 20);
            this.location.TabIndex = 56;
            this.location.Text = "C:\\Users\\devdrone\\Documents\\Graphics";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 20);
            this.button3.TabIndex = 57;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // New
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(301, 284);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ProjName);
            this.Controls.Add(this.label1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProjName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Button button3;
    }
}