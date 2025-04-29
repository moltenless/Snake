using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public enum Direction
    {
        Up, Down, Left, Right
    }
    public enum Speed
    {
        Low = 60, Medium = 30, Fast = 15
    }
    public enum Mode
    {
        Classic, Modern
    }
    internal delegate void MyHandler();

    class Game
    {
        public event MyHandler OnTick;
        public List<Point> Snake;
        public List<Point> Food;
        public Point[] Walls;
        public Direction Direction = Direction.Right;
        public const int Size = 80 * LABEL_SIZE;
        public const int LABEL_SIZE = 10;
        public bool KeyEnabled = true;
        public int Score = 0;

        Timer timer;
        static Random rnd = new Random();

        public Game(Speed speed)
        {
            Walls = new Point[0];
            StartGame();
            timer = new Timer { Enabled = true, Interval = (int)speed };
            timer.Tick += UpDate;
        }

        public Game(Speed speed, Point[] walls)
        {
            Walls = walls;
            StartGame();
            timer = new Timer { Enabled = true, Interval = (int)speed };
            timer.Tick += UpDate;
        }
        private void UpDate(object sender, EventArgs e)
        {
            //get ne wpoint of head of the snake
            Point head = Snake[0];
            if (Direction == Direction.Right) head.X += LABEL_SIZE;
            else if (Direction == Direction.Left) head.X -= LABEL_SIZE;
            else if (Direction == Direction.Up) head.Y -= LABEL_SIZE;
            else head.Y += LABEL_SIZE;

            // if snake go out to the border
            if (head.X < 0) head.X = Size - LABEL_SIZE;
            else if (head.X > Size - LABEL_SIZE) head.X = 0;
            else if (head.Y < 0) head.Y = Size - LABEL_SIZE;
            else if (head.Y > Size - LABEL_SIZE) head.Y = 0;

            //get new point of every part of snake
            for (int j = Snake.Count - 1; j > 0; j--)
            {
                Snake[j] = Snake[j - 1];
                //if Snake eat itself :(
                if (head == Snake[j]) { StartGame(); return; }
            }
            for (int i = 0; i < Walls.Length; i++)
                if (head == Walls[i]) { StartGame(); return; }

            Snake[0] = head;
            //if snake eat food :)
            for (int i = 0; i < Food.Count; i++)
                if (head == Food[i]) { Eat(i); break; }
            OnTick();
        }

        private void Eat(int eatedFoodIndex)
        {
            Food.Remove(Food[eatedFoodIndex]);
            GenerateFood(1);
            int last = Snake.Count - 1;
            Point newTail = Snake[0];
            //Get point of new tail 
            if (Snake.Count == 1)
                if (Direction == Direction.Right) newTail.X -= LABEL_SIZE;
                else if (Direction == Direction.Left) newTail.X += LABEL_SIZE;
                else if (Direction == Direction.Up) newTail.Y += LABEL_SIZE;
                else newTail.Y -= LABEL_SIZE;
            else if (Snake[last].X > Snake[last - 1].X) newTail.X -= LABEL_SIZE;
            else if (Snake[last].X < Snake[last - 1].X) newTail.X += LABEL_SIZE;
            else if (Snake[last].Y > Snake[last - 1].Y) newTail.Y += LABEL_SIZE;
            else newTail.Y -= LABEL_SIZE;
            Snake.Add(newTail);
            Score++;
        }

        private void StartGame()
        {
            Score = 0;
            Direction = Direction.Right;
            Food = new List<Point>();
            Snake = new List<Point>();
            Snake.Add(new Point(Size / 2, Size / 2));
            Snake.Add(new Point(Size / 2, Size / 2));
            Snake.Add(new Point(Size / 2, Size / 2));
            GenerateFood(6);
        }

        private void GenerateFood(int countFood)
        {
            for (int i = 0; i < countFood; i++)
            {
            genFod:
                Point newFood = new Point(rnd.Next(Size / LABEL_SIZE) * LABEL_SIZE, rnd.Next(Size / LABEL_SIZE) * LABEL_SIZE);
                if (newFood.X > 100 && newFood.X < 700 && newFood.Y > 100 && newFood.Y < 700)
                    Food.Add(newFood);
                else goto genFod;
            }
        }
    }
}
