using System.ComponentModel;
using System.Windows.Forms;

namespace ThreadsVsMazes
{
    partial class MazeSelector
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(MazeSelector));
            this.Header = new System.Windows.Forms.Panel();
            this.HeaderTitle = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.ButtonContainer = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.StartSolvingBtn = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.CloseBtn)).BeginInit();
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
            this.CloseBtn.Location = new System.Drawing.Point(892, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(38, 35);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseClick);
            // 
            // ButtonContainer
            // 
            this.ButtonContainer.AutoScroll = true;
            this.ButtonContainer.Location = new System.Drawing.Point(23, 59);
            this.ButtonContainer.Name = "ButtonContainer";
            this.ButtonContainer.Size = new System.Drawing.Size(294, 435);
            this.ButtonContainer.TabIndex = 1;
            // 
            // StartSolvingBtn
            // 
            this.StartSolvingBtn.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (124)))),
                ((int) (((byte) (179)))), ((int) (((byte) (66)))));
            this.StartSolvingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartSolvingBtn.FlatAppearance.BorderSize = 0;
            this.StartSolvingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartSolvingBtn.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.StartSolvingBtn.ForeColor = System.Drawing.Color.White;
            this.StartSolvingBtn.Location = new System.Drawing.Point(323, 59);
            this.StartSolvingBtn.Name = "StartSolvingBtn";
            this.StartSolvingBtn.Size = new System.Drawing.Size(194, 57);
            this.StartSolvingBtn.TabIndex = 2;
            this.StartSolvingBtn.Text = "Start";
            this.StartSolvingBtn.UseVisualStyleBackColor = false;
            this.StartSolvingBtn.Click += new System.EventHandler(this.StartSolving);
            // 
            // MazeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (66)))), ((int) (((byte) (66)))),
                ((int) (((byte) (66)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.StartSolvingBtn);
            this.Controls.Add(this.ButtonContainer);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MazeSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.CloseBtn)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Label HeaderTitle;
        private System.Windows.Forms.Panel ButtonContainer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button StartSolvingBtn;
    }
}