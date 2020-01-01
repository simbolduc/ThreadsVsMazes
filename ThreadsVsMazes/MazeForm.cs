using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;

namespace ThreadsVsMazes
{
    public partial class MazeForm : Form
    {

        private readonly Maze _maze;
        private readonly int _mazeWidth;
        private readonly int _mazeHeight;
        private readonly int _mazeSquareAmount;
        private readonly Position _startPos;
        private readonly Position _finishPos;
        private int _squareWidth;
        private TableLayoutPanel _grid;
        private readonly Random _random = new Random();

        public MazeForm(Maze maze, int width, int height, Position start, Position finish)
        {
            InitializeComponent();
            _startPos = start;
            _finishPos = finish;
            _maze = maze;
            _mazeWidth = width;
            _mazeHeight = height;
            _mazeSquareAmount = (int) Math.Sqrt(_maze.GetMaze().Length);
        }

        private void CloseClick(object sender, EventArgs e)
        {
            Hide();
        }

        private void LoadGrid(object sender, EventArgs e)
        {
            var grid = new TableLayoutPanel 
            {
                Location = new Point(15, 50),
                Name = "Maze",
                Size = new Size(_mazeWidth, _mazeHeight),
                TabIndex = 0,
                BackColor = Color.LightBlue,
                ColumnCount = _mazeSquareAmount,
                RowCount = _mazeSquareAmount
            };
            _squareWidth = grid.Size.Width / _mazeSquareAmount;
            for (var row = 0; row < _mazeSquareAmount; row++)
            {
                grid.RowStyles.Add(new RowStyle(SizeType.Absolute, _squareWidth));
                for (var col = 0; col < _mazeSquareAmount; col++)
                    grid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, _squareWidth));
            }
            grid.CellPaint += PaintGridIndex;
            Controls.Add(grid);
            _grid = grid;
        }

        private void PaintGridIndex(object sender, TableLayoutCellPaintEventArgs e)
        {
            var rectangle = e.CellBounds;
            
            // START POSITION
            if (e.Column == _startPos.X && e.Row == _startPos.Y)
                e.Graphics.FillRectangle(Brushes.SeaGreen, rectangle.X + 1, rectangle.Y + 1, rectangle.Width - 1, rectangle.Width - 1);
            
            // FINISH POSITION
            if (e.Column == _finishPos.X && e.Row == _finishPos.Y)
                e.Graphics.FillRectangle(Brushes.Brown, rectangle.X + 1, rectangle.Y + 1, rectangle.Width - 1, rectangle.Width - 1);
            
            // TOP LINE
            if (_maze.GetMaze()[e.Column, e.Row].Neighbours[0] == 0)
                e.Graphics.DrawLine(new Pen(Brushes.Black), 
                    new Point(rectangle.X, rectangle.Y),
                    new Point(rectangle.X + rectangle.Width, rectangle.Y));
            // RIGHT LINE
            if (_maze.GetMaze()[e.Column, e.Row].Neighbours[1] == 0)
                e.Graphics.DrawLine(new Pen(Brushes.Black), 
                    new Point(rectangle.X + rectangle.Width, rectangle.Y),
                    new Point(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Width));
            // BOTTOM LINE
            if (_maze.GetMaze()[e.Column, e.Row].Neighbours[2] == 0)
                e.Graphics.DrawLine(new Pen(Brushes.Black), 
                    new Point(rectangle.X, rectangle.Y + rectangle.Width),
                    new Point(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Width));
            // LEFT LINE
            if (_maze.GetMaze()[e.Column, e.Row].Neighbours[3] == 0)
                e.Graphics.DrawLine(new Pen(Brushes.Black), 
                    new Point(rectangle.X, rectangle.Y),
                    new Point(rectangle.X, rectangle.Y + rectangle.Width));
        }

        public TimeSpan Solve()
        {
            var stopwatch = Stopwatch.StartNew();
            var current = _startPos;
             int x, y;
             var history = new Stack<Position>();
             history.Push(current);
             while (current.X != _finishPos.X || current.Y != _finishPos.Y)
             {
                 var rnd = _random.Next(0, 4);
                 switch (rnd)
                 {
                     // GO UP
                     case 0:
                         x = current.X;
                         y = current.Y - 1;
                         if (x >= 0 && x < _mazeSquareAmount && y >= 0 && y < _mazeSquareAmount)
                         {
                             current = new Position(x, y, rnd);
                             history.Push(current);
                         }
                         break;
                     // GO RIGHT
                     case 1:
                         x = current.X + 1;
                         y = current.Y;
                         if (x >= 0 && x < _mazeSquareAmount && y >= 0 && y < _mazeSquareAmount)
                         {
                             current = new Position(x, y, rnd);
                             history.Push(current);
                         }
                         break;
                     // GO DOWN
                     case 2:
                         x = current.X;
                         y = current.Y + 1;
                         if (x >= 0 && x < _mazeSquareAmount && y >= 0 && y < _mazeSquareAmount)
                         {
                             current = new Position(x, y, rnd);
                             history.Push(current);
                         }
                         break;
                     // GO LEFT
                     case 3:
                         x = current.X - 1;
                         y = current.Y;
                         if (x >= 0 && x < _mazeSquareAmount && y >= 0 && y < _mazeSquareAmount)
                         {
                             current = new Position(x, y, rnd);
                             history.Push(current);
                         }
                         break;
                     // WRONG DIRECTION, NOT SUPPOSED TO HAPPEN
                     default:
                         Console.WriteLine("Invalid random number generated");
                         break;
                 }
             }
             stopwatch.Stop();
             Console.WriteLine("Thread : {0}, done (time taken : {1})", Thread.CurrentThread.Name, stopwatch.Elapsed);
             return stopwatch.Elapsed;
        }
        
    }

}