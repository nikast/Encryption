namespace LZ_arhive
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Archive = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            this.OpenFIle = new System.Windows.Forms.Button();
            this.NameBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UnZip = new System.Windows.Forms.Button();
            this.PathLabelUnzip = new System.Windows.Forms.Label();
            this.OpenUnzipButton = new System.Windows.Forms.Button();
            this.NameBoxUnzip = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DBar = new System.Windows.Forms.ProgressBar();
            this.EBar = new System.Windows.Forms.ProgressBar();
            this.KeyE = new System.Windows.Forms.NumericUpDown();
            this.Key = new System.Windows.Forms.Label();
            this.KeyD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.Archive.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyD)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(485, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(52, 20);
            this.AboutMenu.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 270);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(485, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.Archive);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(485, 246);
            this.MainPanel.TabIndex = 2;
            // 
            // Archive
            // 
            this.Archive.Controls.Add(this.tabPage1);
            this.Archive.Controls.Add(this.tabPage2);
            this.Archive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Archive.Location = new System.Drawing.Point(0, 0);
            this.Archive.Name = "Archive";
            this.Archive.SelectedIndex = 0;
            this.Archive.Size = new System.Drawing.Size(483, 244);
            this.Archive.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.Key);
            this.tabPage1.Controls.Add(this.KeyE);
            this.tabPage1.Controls.Add(this.EBar);
            this.tabPage1.Controls.Add(this.BottomPanel);
            this.tabPage1.Controls.Add(this.PathLabel);
            this.tabPage1.Controls.Add(this.OpenFIle);
            this.tabPage1.Controls.Add(this.NameBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(475, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encryption";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomPanel.Controls.Add(this.StartButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(3, 143);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(467, 70);
            this.BottomPanel.TabIndex = 5;
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Location = new System.Drawing.Point(24, 24);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Encryption";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(26, 17);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(35, 13);
            this.PathLabel.TabIndex = 3;
            this.PathLabel.Text = "Path: ";
            // 
            // OpenFIle
            // 
            this.OpenFIle.Location = new System.Drawing.Point(29, 71);
            this.OpenFIle.Name = "OpenFIle";
            this.OpenFIle.Size = new System.Drawing.Size(74, 23);
            this.OpenFIle.TabIndex = 2;
            this.OpenFIle.Text = "Open file";
            this.OpenFIle.UseVisualStyleBackColor = true;
            this.OpenFIle.Click += new System.EventHandler(this.OpenFileButton);
            // 
            // NameBox1
            // 
            this.NameBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameBox1.Location = new System.Drawing.Point(29, 45);
            this.NameBox1.Name = "NameBox1";
            this.NameBox1.Size = new System.Drawing.Size(238, 20);
            this.NameBox1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.KeyD);
            this.tabPage2.Controls.Add(this.DBar);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.PathLabelUnzip);
            this.tabPage2.Controls.Add(this.OpenUnzipButton);
            this.tabPage2.Controls.Add(this.NameBoxUnzip);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(475, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decryption";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.UnZip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 70);
            this.panel1.TabIndex = 7;
            // 
            // UnZip
            // 
            this.UnZip.Enabled = false;
            this.UnZip.Location = new System.Drawing.Point(24, 24);
            this.UnZip.Name = "UnZip";
            this.UnZip.Size = new System.Drawing.Size(75, 23);
            this.UnZip.TabIndex = 0;
            this.UnZip.Text = "Decryption";
            this.UnZip.UseVisualStyleBackColor = true;
            this.UnZip.Click += new System.EventHandler(this.UnZip_Click);
            // 
            // PathLabelUnzip
            // 
            this.PathLabelUnzip.AutoSize = true;
            this.PathLabelUnzip.Location = new System.Drawing.Point(26, 17);
            this.PathLabelUnzip.Name = "PathLabelUnzip";
            this.PathLabelUnzip.Size = new System.Drawing.Size(35, 13);
            this.PathLabelUnzip.TabIndex = 6;
            this.PathLabelUnzip.Text = "Path: ";
            // 
            // OpenUnzipButton
            // 
            this.OpenUnzipButton.Location = new System.Drawing.Point(29, 71);
            this.OpenUnzipButton.Name = "OpenUnzipButton";
            this.OpenUnzipButton.Size = new System.Drawing.Size(74, 23);
            this.OpenUnzipButton.TabIndex = 5;
            this.OpenUnzipButton.Text = "Open file";
            this.OpenUnzipButton.UseVisualStyleBackColor = true;
            this.OpenUnzipButton.Click += new System.EventHandler(this.OpenUnzipButton_Click);
            // 
            // NameBoxUnzip
            // 
            this.NameBoxUnzip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameBoxUnzip.Location = new System.Drawing.Point(29, 45);
            this.NameBoxUnzip.Name = "NameBoxUnzip";
            this.NameBoxUnzip.Size = new System.Drawing.Size(238, 20);
            this.NameBoxUnzip.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DBar
            // 
            this.DBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DBar.Location = new System.Drawing.Point(3, 125);
            this.DBar.Name = "DBar";
            this.DBar.Size = new System.Drawing.Size(467, 18);
            this.DBar.TabIndex = 8;
            // 
            // EBar
            // 
            this.EBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EBar.Location = new System.Drawing.Point(3, 125);
            this.EBar.Name = "EBar";
            this.EBar.Size = new System.Drawing.Size(467, 18);
            this.EBar.TabIndex = 9;
            // 
            // KeyE
            // 
            this.KeyE.Location = new System.Drawing.Point(289, 46);
            this.KeyE.Name = "KeyE";
            this.KeyE.Size = new System.Drawing.Size(77, 20);
            this.KeyE.TabIndex = 11;
            this.KeyE.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Key
            // 
            this.Key.AutoSize = true;
            this.Key.Location = new System.Drawing.Point(289, 17);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(25, 13);
            this.Key.TabIndex = 12;
            this.Key.Text = "Key";
            // 
            // KeyD
            // 
            this.KeyD.Location = new System.Drawing.Point(289, 46);
            this.KeyD.Name = "KeyD";
            this.KeyD.Size = new System.Drawing.Size(77, 20);
            this.KeyD.TabIndex = 9;
            this.KeyD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Key";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 292);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Encryption/Decryption";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.Archive.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeyE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TabControl Archive;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button OpenFIle;
        private System.Windows.Forms.TextBox NameBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UnZip;
        private System.Windows.Forms.Label PathLabelUnzip;
        private System.Windows.Forms.Button OpenUnzipButton;
        private System.Windows.Forms.TextBox NameBoxUnzip;
        private System.Windows.Forms.ProgressBar DBar;
        private System.Windows.Forms.ProgressBar EBar;
        private System.Windows.Forms.Label Key;
        private System.Windows.Forms.NumericUpDown KeyE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown KeyD;
    }
}

