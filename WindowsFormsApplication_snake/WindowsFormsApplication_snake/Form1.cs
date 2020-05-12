using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class SnakeForm : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private Circle Food = new Circle();

        public SnakeForm()
        {
            InitializeComponent();
            new Settings();
            GameTimer.Interval = 1000 / Settings.Speed;
            GameTimer.Tick += UpdateScreen;
            GameTimer.Start();

            StartGame();
        }

       

        private void StartGame()
        {
            GameOver.Visible = false;
            ScoreSaver.Enabled = false;
            restart.Enabled = false;
            new Settings();
            Snake.Clear();

            Circle head = new Circle { X = 15, Y = 20 };
            Snake.Add(head);

            TrackLabel.Text = Settings.Score.ToString();
            GenerateFood();
        }

        private void GenerateFood()
        {
            int MaxPosX = pictureBox1.Size.Width / Settings.Width; //Odredujemo max visinu i sirinu 
            int MaxPosY = pictureBox1.Size.Height / Settings.Height;

            Random random = new Random();

            Food = new Circle { X = random.Next(0, MaxPosX), Y = random.Next(0, MaxPosY) };
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (Settings.GameOver == true)
            {
                ScoreSaver.Enabled=true;
                restart.Enabled = true;
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.Direction != Directions.Left)
                    Settings.Direction = Directions.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.Direction != Directions.Right)
                    Settings.Direction = Directions.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.Direction != Directions.Down)
                    Settings.Direction = Directions.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.Direction != Directions.Up)
                    Settings.Direction = Directions.Down;

                MovePlayer();
                
            }
        pictureBox1.Invalidate(); //refresh za igru, da se stvori iluzija kretanja sa brisanjem i dodavanjem kruga
        }

        




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SnakeForm_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Settings.GameOver == true)
            {
                this.Close();
                new SaveScoreForm().Show();
            }
        }
        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Micanje glave
                if (i == 0)
                {
                    switch (Settings.Direction)
                    {
                        case Directions.Right:
                            Snake[i].X++;
                            break;
                        case Directions.Left:
                            Snake[i].X--;
                            break;
                        case Directions.Up:
                            Snake[i].Y--;
                            break;
                        case Directions.Down:
                            Snake[i].Y++;
                            break;
                    }

                        //velicina prozora, da dode do kolizije ako se glava nade na poziciji jednakoj max visini ili sirini
                    int maxPosX = pictureBox1.Size.Width / Settings.Width;
                    int maxPosY = pictureBox1.Size.Height / Settings.Height;

                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxPosX || Snake[i].Y >= maxPosY)
                    {
                        Die();
                    }

                        //ako se sudari sama sa svojim tijelom
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }
                        //ako dode do hrane
                    if (Snake[0].X == Food.X && Snake[0].Y == Food.Y)
                    {
                        Eat();
                    }
                
                }

                    
                else
                {
                    //kretanje tijela
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
               
            }
            
        }
        //Stvara hranu,povecava zmiju pozivom funkcija generate food i snake.add
        private void Eat()
        {
            Circle Food = new Circle
            {

                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(Food);

            Settings.Score += Settings.Points;
            TrackLabel.Text = Settings.Score.ToString();

            GenerateFood();
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                for (int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.Red; //Glava
                    else
                        snakeColour = Brushes.Green; //Trup

                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height)); //Zmija

                    canvas.FillEllipse(Brushes.Orange,
                        new Rectangle(Food.X * Settings.Width,
                             Food.Y * Settings.Height, Settings.Width, Settings.Height)); //Hrana
                }
            }
            else 
            {
                string gameOver = "Your score is "+Settings.Score;
                GameOver.Text = gameOver;
                GameOver.Visible = true; //ispis score
            }
        }

        private void GameOver_Click(object sender, EventArgs e)
        {

        }

        private void GameOverLab_Click(object sender, EventArgs e)
        {

        }

        //registracija keyDown/up sa tipkovnice na form
        private void SnakeForm_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void SnakeForm_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StartGame();
        }

        

    }
}

