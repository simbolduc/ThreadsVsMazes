using System;
using System.Windows.Forms;

namespace ThreadsVsMazes {
    public partial class MainMenu : Form
    {

        private int _threadAmount = 1;
        private int _mazeWidth = 25;

        public MainMenu() {
            InitializeComponent();
        }

        private void CloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ThreadDown(object sender, EventArgs e)
        {
            if (_threadAmount <= 1) return;
            _threadAmount--;
            ThreadNumber.Text = _threadAmount.ToString();
        }

        private void ThreadUp(object sender, EventArgs e)
        {
            if (_threadAmount >= 50) return;
            _threadAmount++;
            ThreadNumber.Text = _threadAmount.ToString();
        }

        private void MazeWidthDown(object sender, EventArgs e)
        {
            if (_mazeWidth <= 10) return;
            _mazeWidth--;
            MazeWidthNumber.Text = _mazeWidth.ToString();
        }

        private void MazeWidthUp(object sender, EventArgs e)
        {
            if (_mazeWidth >= 100) return;
            _mazeWidth++;
            MazeWidthNumber.Text = _mazeWidth.ToString();
        }

        private void StartClick(object sender, EventArgs e)
        {
            new MazeSelector(_mazeWidth, _threadAmount).Show();
        }
    }
}