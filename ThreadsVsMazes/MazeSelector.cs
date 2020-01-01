using System;
using System.Configuration;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ThreadsVsMazes
{
    public partial class MazeSelector : Form
    {
        private readonly int _mazeHeight = 350;
        private readonly Random _random = new Random();
        private readonly int _threadAmount;
        private readonly MazeForm[] _mazes;
        private readonly Button[] _Btns;

        public MazeSelector(int squareAmount, int threadAmount)
        {
            _threadAmount = threadAmount;
            _Btns = new Button[_threadAmount];
            _mazes = new MazeForm[_threadAmount];
            InitializeComponent();
            LoadMazes();
            var startPos = new Position(_random.Next(0, squareAmount), _random.Next(0, squareAmount));
            var finishPos = new Position(_random.Next(0, squareAmount), _random.Next(0, squareAmount));
            _mazeHeight /= squareAmount;
            var mazeWidth = _mazeHeight *= squareAmount;
            for(var t = 0; t < _threadAmount; t++)
                _mazes[t] = new MazeForm(new Maze(squareAmount), mazeWidth, _mazeHeight, startPos, finishPos);
        }

        private void LoadMazes()
        {
            for (var i = 1; i <= _threadAmount; i++)
            {
                var btn = new Button()
                {
                    Name = "Thread-" + i,
                    Text = "Thread-" + i,
                    Cursor = Cursors.Hand,
                    Location = new Point(0, 100 * i - 100),
                    Size = new Size(ButtonContainer.Width - 32, 50),
                    BackColor = Color.FromArgb(156, 204, 101),
                    BackgroundImageLayout = ImageLayout.None,
                    FlatAppearance =
                    {
                        BorderSize = 0
                    },
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    ForeColor = Color.FromArgb(238, 238, 238)
                };
                btn.Click += SelectThread;
                ButtonContainer.Controls.Add(btn);
                _Btns[i - 1] = btn;
            }

        }

        private void SelectThread(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            _mazes[btn.Name[btn.Name.Length - 1] - 49].Show();
        }

        private void CloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void StartSolving(object sender, EventArgs e)
        {
            for (var i = 0; i < _threadAmount; i++)
            {
                var i1 = i;
                var thread = new Thread(() =>
                {
                    _Btns[i1].Text = _mazes[i1].Solve().ToString();
                })
                {
                    Name = "MazeThread-" + i
                };
                thread.Start();
                
            }
        }
    }
}