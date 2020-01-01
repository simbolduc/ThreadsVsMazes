using System;
using System.Collections.Generic;
using System.Linq;

namespace ThreadsVsMazes
{
    public class Maze
    {
        
        private int _visit;
        private readonly int _mazeSquareAmount;
        private readonly Position[,] _maze;
        private readonly Random _random = new Random();
        private readonly Stack<Position> _history;

        public Maze(int amount)
        {
            _mazeSquareAmount = amount;
            _history = new Stack<Position>();
            _maze = new Position[_mazeSquareAmount, _mazeSquareAmount];
            CreateMaze();
        }

        public Position[,] GetMaze()
        {
            return _maze;
        }
        
        private int CountNeighbours(int x, int y)
        {
            var count = 0;
            if (y + 1 < _mazeSquareAmount)
            {
                if (_maze[x, y + 1] != null)
                    count++;
            }
            else count++;
            if (x + 1 < _mazeSquareAmount)
            {
                if (_maze[x + 1, y] != null)
                    count++;
            }
            else count++;
            if (y - 1 >= 0)
            {
                if (_maze[x, y - 1] != null)
                    count++;
            }
            else count++;
            if (x - 1 >= 0)
            {
                if (_maze[x - 1, y] != null)
                    count++;
            }
            else count++;

            return count;
        }
        
        private void CreateMaze()
        {
            _visit = 1;
           
            var start = new Position(0, 0);
            _history.Push(start);
            _maze[0, 0] = start;

            while (_visit != _mazeSquareAmount * _mazeSquareAmount)
            {
                
                if (CountNeighbours(_history.First().X, _history.First().Y) == 4)
                    _history.Pop();
                
                var rnd = _random.Next(0, 4);
                
                Position next;
                int x;
                int y;
                switch (rnd)
                {
                    // GO UP
                    case 0:
                        x = _history.First().X;
                        y = _history.First().Y - 1;
                        if (x >= 0 && x < _mazeSquareAmount && y >= 0 && y < _mazeSquareAmount && _maze[x, y] == null)
                        {
                            if (_maze[x, y] == null)
                                _history.First().Neighbours[rnd] = 1;
                            next = new Position(x, y, rnd);
                            _history.Push(next);
                            _maze[x, y] = next;
                            _visit++;
                        }
                        break;
                    // GO RIGHT
                    case 1:
                        x = _history.First().X + 1;
                        y = _history.First().Y;
                        if (x >= 0 && x < _mazeSquareAmount && y >= 0 && y < _mazeSquareAmount && _maze[x, y] == null)
                        {
                            if (_maze[x, y] == null)
                                _history.First().Neighbours[rnd] = 1;
                            next = new Position(x, y, rnd);
                            _history.Push(next);
                            _maze[x, y] = next;
                            _visit++;
                        }

                        break;
                    // GO DOWN
                    case 2:
                        x = _history.First().X;
                        y = _history.First().Y + 1;
                        if (x >= 0 && x < _mazeSquareAmount && y >= 0 && y < _mazeSquareAmount && _maze[x, y] == null)
                        {
                            if (_maze[x, y] == null)
                                _history.First().Neighbours[rnd] = 1;
                            next = new Position(x, y, rnd);
                            _history.Push(next);
                            _maze[x, y] = next;
                            _visit++;
                        }
                        break;
                    // GO LEFT
                    case 3:
                        x = _history.First().X - 1;
                        y = _history.First().Y;
                        if (x >= 0 && x < _mazeSquareAmount && y >= 0 && y < _mazeSquareAmount && _maze[x, y] == null)
                        {
                            if (_maze[x, y] == null)
                                _history.First().Neighbours[rnd] = 1;
                            next = new Position(x, y, rnd);
                            _history.Push(next);
                            _maze[x, y] = next;
                            _visit++;
                        }

                        break;
                    // WRONG DIRECTION, NOT SUPPOSED TO HAPPEN
                    default:
                        Console.WriteLine("Invalid random number generated");
                        break;
                }
            }
            
        }

    }
}