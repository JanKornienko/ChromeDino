using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChromeDino
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        public float points;
        public int intPoints;
        public int speed = 5;
        public int jumpPoint = 0;
        public int moveDir = 11;
        bool over = true;

        private void StartGame()
        {
            over = false;
            points = 0;
            gameOverText.Visible = false;
            restartBtn.Visible = false;
            moveT.Start();
            fastLevelT.Start();
        }

        private void EndGame()
        {
            ListScore list = new ListScore(intPoints);
            over = false;
            this.cactus.Location = new System.Drawing.Point(889, 185);
            gameOverText.Visible = true;
            restartBtn.Visible = true;
            moveT.Stop();
            fastLevelT.Stop();
            list.ShowDialog();
            speed = 5;   
        }

        private void Cactus()
        {
            cactus.Left -= speed;
            if (cactus.Location.X <= -59)
            {
                string[] cactusPictures = { "cactus1.png", "cactus2.png" };
                Random rn = new Random();
                int choice = rn.Next(0, 2);

                this.Controls.Remove(cactus);
                cactus = new PictureBox
                {
                    Name = "cactus",
                    BackColor = Color.Transparent,
                    Size = new Size(59, 98),
                    Location = new Point(889, 185),
                    Image = Image.FromFile(cactusPictures[choice]),
                };
                this.Controls.Add(cactus);
            }
        }

        private void Movement()
        {
            ground.Left -= speed;
            if (ground.Location.X <= -1500)
            {
                this.Controls.Remove(ground);
                ground = new PictureBox
                {
                    Name = "ground",
                    BackColor = Color.Transparent,
                    Size = new Size(2402, 26),
                    Location = new Point(-9, 275),
                    Image = Image.FromFile("ground.png"),
                };
                this.Controls.Add(ground);
            }
        }

        private void Colision()
        {
            if (dino.Bounds.IntersectsWith(cactus.Bounds))
            {
                EndGame();
            }
        }

        private void ScoreCount()
        {
            points += 0.1f * speed / 3;
            intPoints = Convert.ToInt32(points);
            scoreText.Text = intPoints.ToString();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (over == true) StartGame();
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up) JumpT.Start();
        }

        private void restart_Click(object sender, EventArgs e) { StartGame(); }

        private void fastLevel_Tick(object sender, EventArgs e) { speed++; }

        private void moveT_Tick(object sender, EventArgs e)
        {
            Movement();
            ScoreCount();
            Cactus();
            Colision();
        }

        private void JumpT_Tick(object sender, EventArgs e)
        {
            dino.Location = new Point(dino.Location.X, dino.Location.Y - moveDir);
            jumpPoint++;
            if (jumpPoint == 20) moveDir = 0;
            if (jumpPoint == 30){ moveDir = -11; }
            if (jumpPoint == 50)
            {
                moveDir = 11;
                jumpPoint = 0;
                JumpT.Stop();
            }
        }
    }
}
