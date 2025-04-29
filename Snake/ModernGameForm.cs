using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class ModernGameForm : Form
    {
        Game game;
        List<Label> snake;
        List<Label> food;
        Label[] wall;

        public ModernGameForm(Speed speed)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            Point[] walls = new Point[]
            {
                //left top figure
                new Point(100, 0), new Point(100, 10), new Point(100, 20), new Point(100, 30),new Point(100, 40),new Point(100, 50),new Point(100, 60),new Point(100, 70),new Point(100, 80),new Point(100, 90),
                new Point(90, 90),new Point(80, 90),new Point(70, 90),new Point(60, 90),new Point(50, 90),new Point(40, 90),new Point(30, 90),new Point(20, 90),new Point(10, 90),new Point(0, 90),
                //left bottom figure
                new Point(100,790),new Point(100,780),new Point(100,770),new Point(100,760),new Point(100,750),new Point(100,740),new Point(100,730),new Point(100,720),new Point(100,710),new Point(100,700),
                new Point(90,700), new Point(80,700),new Point(70,700),new Point(60,700),new Point(50,700),new Point(40,700),new Point(30,700),new Point(20,700),new Point(10,700),new Point(0,700),
                //right top figure
                new Point(700,0),new Point(700,10),new Point(700,20),new Point(700,30),new Point(700,40),new Point(700,50),new Point(700,60),new Point(700,70),new Point(700,80),new Point(700,90),
                new Point(700, 100),new Point(710, 100),new Point(720, 100),new Point(730, 100),new Point(740, 100),new Point(750, 100),new Point(760, 100),new Point(770, 100),new Point(780, 100),new Point(790, 100),
                //right bottom figure
                new Point(700,700),new Point(700,710),new Point(700,720),new Point(700,730),new Point(700,740),new Point(700,750),new Point(700,760),new Point(700,770),new Point(700,780),new Point(700,790),
                new Point(710,700),new Point(720,700),new Point(730,700),new Point(740,700),new Point(750,700),new Point(760,700),new Point(770,700),new Point(780,700),new Point(790,700),
                //first line 
                new Point(200,300),new Point(210,300),new Point(220,300),new Point(230,300),new Point(240,300),new Point(250,300),new Point(260,300),new Point(270,300),new Point(280,300),new Point(290,300),new Point(300,300),
                new Point(310,300),new Point(320,300),new Point(330,300),new Point(340,300),new Point(350,300),new Point(360,300),new Point(370,300),new Point(380,300),new Point(390,300),new Point(400,300),
                new Point(410,300),new Point(420,300),new Point(430,300),new Point(440,300),new Point(450,300),new Point(460,300),new Point(470,300),new Point(480,300),new Point(490,300),new Point(500,300),
                new Point(510,300),new Point(520,300),new Point(530,300),new Point(540,300),new Point(550,300),new Point(560,300),new Point(570,300),new Point(580,300),new Point(590,300),new Point(600,300),
                //second line
                new Point(200,500),new Point(210,500),new Point(220,500),new Point(230,500),new Point(240,500),new Point(250,500),new Point(260,500),new Point(270,500),new Point(280,500),new Point(290,500),new Point(300,500),
                new Point(310,500),new Point(320,500),new Point(330,500),new Point(340,500),new Point(350,500),new Point(360,500),new Point(370,500),new Point(380,500),new Point(390,500),new Point(400,500),
                new Point(410,500),new Point(420,500),new Point(430,500),new Point(440,500),new Point(450,500),new Point(460,500),new Point(470,500),new Point(480,500),new Point(490,500),new Point(500,500),
                new Point(510,500),new Point(520,500),new Point(530,500),new Point(540,500),new Point(550,500),new Point(560,500),new Point(570,500),new Point(580,500),new Point(590,500),new Point(600,500),
            };
            wall = new Label[walls.Length];
            for (int i = 0; i < wall.Length; i++)
            {
                wall[i] = new Label { Location = walls[i], Size = new Size(10, 10), Image = Properties.Resources.wall };
                Controls.Add(wall[i]);
            }
            game = new Game(speed, walls);
            snake = new List<Label>();
            food = new List<Label>();
            game.OnTick += UpDate;
        }

        private void UpDate()
        {
            for (int i = 0; i < snake.Count; i++)
                Controls.Remove(snake[i]);
            for (int i = 0; i < food.Count; i++)
                Controls.Remove(food[i]);
            food.Clear();
            snake.Clear();

            for (int i = 0; i < game.Snake.Count; i++)
            {
                Label lbl = new Label { Location = game.Snake[i], Size = new Size(10, 10), Image = Properties.Resources.tail };
                if (i == 0) lbl.Image = Properties.Resources.head;
                snake.Add(lbl);
                Controls.Add(snake[i]);
            }
            for (int i = 0; i < game.Food.Count; i++)
            {
                food.Add(new Label { Location = game.Food[i], Size = new Size(10, 10), Image = Properties.Resources.food2 });
                Controls.Add(food[i]);
            }
            lblScore.Text = game.Score.ToString();
        }

        private void KeysDown(object sender, KeyEventArgs e)
        {
            var d = e.KeyCode;
            if (game.KeyEnabled)
            {
                if (d == Keys.Right && game.Direction != Direction.Left) game.Direction = Direction.Right;
                else if (d == Keys.Left && game.Direction != Direction.Right) game.Direction = Direction.Left;
                else if (d == Keys.Up && game.Direction != Direction.Down) game.Direction = Direction.Up;
                else if (d == Keys.Down && game.Direction != Direction.Up) game.Direction = Direction.Down;
                game.KeyEnabled = !game.KeyEnabled;
            }
        }

        private void KeysUp(object sender, KeyEventArgs e)
        {
            game.KeyEnabled = !game.KeyEnabled;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
