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
    public partial class ClassicGameForm : Form
    {
        Game game;
        List<Label> snake;
        List<Label> food;

        public ClassicGameForm(Speed speed)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            game = new Game(speed);
            snake = new List<Label>();
            food = new List<Label>();
            game.OnTick += UpDate;
        }

        private void UpDate()
        {
            food.Clear();
            snake.Clear();
            Controls.Clear();
            for (int i = 0; i < game.Snake.Count; i++)
            {
                snake.Add(new Label { Location = game.Snake[i], BackColor = Color.WhiteSmoke, Size = new Size(10, 10) });
                Controls.Add(snake[i]);
            }
            for (int i = 0; i < game.Food.Count; i++)
            {
                food.Add(new Label { Location = game.Food[i], BackColor = Color.WhiteSmoke, Size = new Size(10, 10) });
                Controls.Add(food[i]);
            }
            Controls.Add(pictureBox1);
            Controls.Add(lblScore);
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
