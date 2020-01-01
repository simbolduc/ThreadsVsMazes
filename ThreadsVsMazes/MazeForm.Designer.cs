using System.ComponentModel;
using System.Drawing;

namespace ThreadsVsMazes
{
    partial class MazeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
                new System.ComponentModel.ComponentResourceManager(typeof(MazeForm));
            this.HeaderTitle = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.CloseBtn)).BeginInit();
            this.SuspendLayout();
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
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (124)))), ((int) (((byte) (179)))),
                ((int) (((byte) (66)))));
            this.Header.Controls.Add(this.HeaderTitle);
            this.Header.Controls.Add(this.CloseBtn);
            this.Header.Location = new System.Drawing.Point(1, 1);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(933, 40);
            this.Header.TabIndex = 1;
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
            // Maze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (66)))), ((int) (((byte) (66)))),
                ((int) (((byte) (66)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Maze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maze";
            this.Load += new System.EventHandler(this.LoadGrid);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.CloseBtn)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label HeaderTitle;
    }
}