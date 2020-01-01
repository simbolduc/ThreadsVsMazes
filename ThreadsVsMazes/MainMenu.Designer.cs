using System.Drawing;

namespace ThreadsVsMazes
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Header = new System.Windows.Forms.Panel();
            this.HeaderTitle = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SettingLabel = new System.Windows.Forms.Label();
            this.SettingsBar = new System.Windows.Forms.Panel();
            this.ThreadLabel = new System.Windows.Forms.Label();
            this.MazeWidthLabel = new System.Windows.Forms.Label();
            this.ThreadDownBtn = new System.Windows.Forms.PictureBox();
            this.ThreadUpBtn = new System.Windows.Forms.PictureBox();
            this.MazeWidthDownBtn = new System.Windows.Forms.PictureBox();
            this.MazeWidthUpBtn = new System.Windows.Forms.PictureBox();
            this.ThreadNumber = new System.Windows.Forms.Label();
            this.MazeWidthNumber = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ThreadDownBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.ThreadUpBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.MazeWidthDownBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.MazeWidthUpBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (124)))), ((int) (((byte) (179)))),
                ((int) (((byte) (66)))));
            this.Header.Controls.Add(this.HeaderTitle);
            this.Header.Controls.Add(this.CloseBtn);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(933, 40);
            this.Header.TabIndex = 0;
            // 
            // HeaderTitle
            // 
            this.HeaderTitle.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.HeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (238)))),
                ((int) (((byte) (238)))), ((int) (((byte) (238)))));
            this.HeaderTitle.Location = new System.Drawing.Point(6, 7);
            this.HeaderTitle.Name = "HeaderTitle";
            this.HeaderTitle.Size = new System.Drawing.Size(267, 28);
            this.HeaderTitle.TabIndex = 1;
            this.HeaderTitle.Text = "ThreadsVsMazes";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = ((System.Drawing.Image) (resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(887, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(34, 33);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseClick);
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Bottom)));
            this.StartBtn.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (156)))), ((int) (((byte) (204)))),
                ((int) (((byte) (101)))));
            this.StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.FlatAppearance.BorderSize = 0;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.StartBtn.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (238)))), ((int) (((byte) (238)))),
                ((int) (((byte) (238)))));
            this.StartBtn.Location = new System.Drawing.Point(330, 344);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(280, 57);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.TabStop = false;
            this.StartBtn.Text = "Create";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartClick);
            // 
            // SettingLabel
            // 
            this.SettingLabel.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.SettingLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (238)))),
                ((int) (((byte) (238)))), ((int) (((byte) (238)))));
            this.SettingLabel.Location = new System.Drawing.Point(330, 190);
            this.SettingLabel.Name = "SettingLabel";
            this.SettingLabel.Size = new System.Drawing.Size(233, 32);
            this.SettingLabel.TabIndex = 2;
            this.SettingLabel.Text = "Settings";
            // 
            // SettingsBar
            // 
            this.SettingsBar.BackColor = System.Drawing.Color.White;
            this.SettingsBar.Location = new System.Drawing.Point(330, 225);
            this.SettingsBar.Name = "SettingsBar";
            this.SettingsBar.Size = new System.Drawing.Size(279, 1);
            this.SettingsBar.TabIndex = 3;
            // 
            // ThreadLabel
            // 
            this.ThreadLabel.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ThreadLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (238)))),
                ((int) (((byte) (238)))), ((int) (((byte) (238)))));
            this.ThreadLabel.Location = new System.Drawing.Point(344, 250);
            this.ThreadLabel.Name = "ThreadLabel";
            this.ThreadLabel.Size = new System.Drawing.Size(150, 24);
            this.ThreadLabel.TabIndex = 4;
            this.ThreadLabel.Text = "Threads : ";
            // 
            // MazeWidthLabel
            // 
            this.MazeWidthLabel.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.MazeWidthLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (238)))),
                ((int) (((byte) (238)))), ((int) (((byte) (238)))));
            this.MazeWidthLabel.Location = new System.Drawing.Point(344, 298);
            this.MazeWidthLabel.Name = "MazeWidthLabel";
            this.MazeWidthLabel.Size = new System.Drawing.Size(150, 25);
            this.MazeWidthLabel.TabIndex = 5;
            this.MazeWidthLabel.Text = "Maze Width : ";
            // 
            // ThreadDownBtn
            // 
            this.ThreadDownBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThreadDownBtn.Image = ((System.Drawing.Image) (resources.GetObject("ThreadDownBtn.Image")));
            this.ThreadDownBtn.Location = new System.Drawing.Point(547, 250);
            this.ThreadDownBtn.Name = "ThreadDownBtn";
            this.ThreadDownBtn.Size = new System.Drawing.Size(31, 37);
            this.ThreadDownBtn.TabIndex = 6;
            this.ThreadDownBtn.TabStop = false;
            this.ThreadDownBtn.Click += new System.EventHandler(this.ThreadDown);
            // 
            // ThreadUpBtn
            // 
            this.ThreadUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThreadUpBtn.Image = ((System.Drawing.Image) (resources.GetObject("ThreadUpBtn.Image")));
            this.ThreadUpBtn.Location = new System.Drawing.Point(579, 250);
            this.ThreadUpBtn.Name = "ThreadUpBtn";
            this.ThreadUpBtn.Size = new System.Drawing.Size(31, 37);
            this.ThreadUpBtn.TabIndex = 7;
            this.ThreadUpBtn.TabStop = false;
            this.ThreadUpBtn.Click += new System.EventHandler(this.ThreadUp);
            // 
            // MazeWidthDownBtn
            // 
            this.MazeWidthDownBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MazeWidthDownBtn.Image = ((System.Drawing.Image) (resources.GetObject("MazeWidthDownBtn.Image")));
            this.MazeWidthDownBtn.Location = new System.Drawing.Point(547, 293);
            this.MazeWidthDownBtn.Name = "MazeWidthDownBtn";
            this.MazeWidthDownBtn.Size = new System.Drawing.Size(31, 45);
            this.MazeWidthDownBtn.TabIndex = 8;
            this.MazeWidthDownBtn.TabStop = false;
            this.MazeWidthDownBtn.Click += new System.EventHandler(this.MazeWidthDown);
            // 
            // MazeWidthUpBtn
            // 
            this.MazeWidthUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MazeWidthUpBtn.Image = ((System.Drawing.Image) (resources.GetObject("MazeWidthUpBtn.Image")));
            this.MazeWidthUpBtn.Location = new System.Drawing.Point(577, 293);
            this.MazeWidthUpBtn.Name = "MazeWidthUpBtn";
            this.MazeWidthUpBtn.Size = new System.Drawing.Size(31, 45);
            this.MazeWidthUpBtn.TabIndex = 9;
            this.MazeWidthUpBtn.TabStop = false;
            this.MazeWidthUpBtn.Click += new System.EventHandler(this.MazeWidthUp);
            // 
            // ThreadNumber
            // 
            this.ThreadNumber.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ThreadNumber.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (238)))),
                ((int) (((byte) (238)))), ((int) (((byte) (238)))));
            this.ThreadNumber.Location = new System.Drawing.Point(491, 250);
            this.ThreadNumber.Name = "ThreadNumber";
            this.ThreadNumber.Size = new System.Drawing.Size(49, 24);
            this.ThreadNumber.TabIndex = 10;
            this.ThreadNumber.Text = "1";
            // 
            // MazeWidthNumber
            // 
            this.MazeWidthNumber.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.MazeWidthNumber.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (238)))),
                ((int) (((byte) (238)))), ((int) (((byte) (238)))));
            this.MazeWidthNumber.Location = new System.Drawing.Point(491, 298);
            this.MazeWidthNumber.Name = "MazeWidthNumber";
            this.MazeWidthNumber.Size = new System.Drawing.Size(49, 24);
            this.MazeWidthNumber.TabIndex = 11;
            this.MazeWidthNumber.Text = "25";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (66)))), ((int) (((byte) (66)))),
                ((int) (((byte) (66)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.MazeWidthNumber);
            this.Controls.Add(this.ThreadNumber);
            this.Controls.Add(this.MazeWidthUpBtn);
            this.Controls.Add(this.MazeWidthDownBtn);
            this.Controls.Add(this.ThreadUpBtn);
            this.Controls.Add(this.ThreadDownBtn);
            this.Controls.Add(this.MazeWidthLabel);
            this.Controls.Add(this.ThreadLabel);
            this.Controls.Add(this.SettingsBar);
            this.Controls.Add(this.SettingLabel);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ThreadDownBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.ThreadUpBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.MazeWidthDownBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.MazeWidthUpBtn)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Label HeaderTitle;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Panel SettingsBar;
        private System.Windows.Forms.Label ThreadLabel;
        private System.Windows.Forms.Label MazeWidthLabel;
        private System.Windows.Forms.Label SettingLabel;
        private System.Windows.Forms.PictureBox MazeWidthDownBtn;
        private System.Windows.Forms.PictureBox ThreadUpBtn;
        private System.Windows.Forms.PictureBox ThreadDownBtn;
        private System.Windows.Forms.PictureBox MazeWidthUpBtn;
        private System.Windows.Forms.Label MazeWidthNumber;
        private System.Windows.Forms.Label ThreadNumber;
    }
}