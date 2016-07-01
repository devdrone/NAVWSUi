namespace Editor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RequestTab = new System.Windows.Forms.TabPage();
            this.RequestBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.ResponseTab = new System.Windows.Forms.TabPage();
            this.ResponseBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.RequestTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestBox)).BeginInit();
            this.ResponseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResponseBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(200, 480);
            this.treeView1.TabIndex = 2;
            this.treeView1.NodeMouseDoubleClick+=treeView1_NodeMouseDoubleClick;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(133, 471);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(882, 10);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RequestTab);
            this.tabControl1.Controls.Add(this.ResponseTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(133, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 447);
            this.tabControl1.TabIndex = 4;
            // 
            // RequestTab
            // 
            this.RequestTab.BackColor = System.Drawing.Color.Gainsboro;
            this.RequestTab.Controls.Add(this.RequestBox);
            this.RequestTab.Location = new System.Drawing.Point(4, 22);
            this.RequestTab.Name = "RequestTab";
            this.RequestTab.Padding = new System.Windows.Forms.Padding(3);
            this.RequestTab.Size = new System.Drawing.Size(874, 421);
            this.RequestTab.TabIndex = 0;
            this.RequestTab.Text = "Request";
            this.RequestTab.UseVisualStyleBackColor = true;
            // 
            // RequestBox
            // 
            this.RequestBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.RequestBox.AutoIndentCharsPatterns = "";
            this.RequestBox.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.RequestBox.BackBrush = null;
            this.RequestBox.CharHeight = 14;
            this.RequestBox.CharWidth = 8;
            this.RequestBox.CommentPrefix = null;
            this.RequestBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RequestBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.RequestBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RequestBox.IsReplaceMode = false;
            this.RequestBox.Language = FastColoredTextBoxNS.Language.XML;
            this.RequestBox.LeftBracket = '<';
            this.RequestBox.LeftBracket2 = '(';
            this.RequestBox.Location = new System.Drawing.Point(3, 3);
            this.RequestBox.Name = "RequestBox";
            this.RequestBox.Paddings = new System.Windows.Forms.Padding(0);
            this.RequestBox.RightBracket = '>';
            this.RequestBox.RightBracket2 = ')';
            this.RequestBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.RequestBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("RequestBox.ServiceColors")));
            this.RequestBox.Size = new System.Drawing.Size(868, 415);
            this.RequestBox.TabIndex = 0;
            this.RequestBox.WordWrap = true;
            this.RequestBox.Zoom = 100;
            // 
            // ResponseTab
            // 
            this.ResponseTab.Controls.Add(this.ResponseBox);
            this.ResponseTab.Location = new System.Drawing.Point(4, 22);
            this.ResponseTab.Name = "ResponseTab";
            this.ResponseTab.Padding = new System.Windows.Forms.Padding(3);
            this.ResponseTab.Size = new System.Drawing.Size(874, 421);
            this.ResponseTab.TabIndex = 1;
            this.ResponseTab.Text = "Response";
            this.ResponseTab.UseVisualStyleBackColor = true;
            // 
            // ResponseBox
            // 
            this.ResponseBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.ResponseBox.AutoIndentCharsPatterns = "";
            this.ResponseBox.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.ResponseBox.BackBrush = null;
            this.ResponseBox.CharHeight = 14;
            this.ResponseBox.CharWidth = 8;
            this.ResponseBox.CommentPrefix = null;
            this.ResponseBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ResponseBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ResponseBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResponseBox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.ResponseBox.IsReplaceMode = false;
            this.ResponseBox.Language = FastColoredTextBoxNS.Language.XML;
            this.ResponseBox.LeftBracket = '<';
            this.ResponseBox.LeftBracket2 = '(';
            this.ResponseBox.Location = new System.Drawing.Point(3, 3);
            this.ResponseBox.Name = "ResponseBox";
            this.ResponseBox.Paddings = new System.Windows.Forms.Padding(0);
            this.ResponseBox.RightBracket = '>';
            this.ResponseBox.RightBracket2 = ')';
            this.ResponseBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ResponseBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("ResponseBox.ServiceColors")));
            this.ResponseBox.Size = new System.Drawing.Size(868, 415);
            this.ResponseBox.TabIndex = 0;
            this.ResponseBox.WordWrap = true;
            this.ResponseBox.Zoom = 100;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(554, 24);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(115, 19);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click+=SubmitButton_Click;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 481);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.RequestTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RequestBox)).EndInit();
            this.ResponseTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResponseBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormNew.Deactivate+=FormNew_Deactivate;
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RequestTab;
        private FastColoredTextBoxNS.FastColoredTextBox RequestBox;
        private System.Windows.Forms.TabPage ResponseTab;
        private FastColoredTextBoxNS.FastColoredTextBox ResponseBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}

