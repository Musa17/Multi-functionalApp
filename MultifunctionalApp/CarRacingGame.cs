using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultifunctionalApp
{
    public partial class CarRacingGame : Form
    {
        int gameSpeed = 0;
        int x;
        int collectedCoins = 0;

        Random r = new Random();

        bool isGameOver = false;

        public CarRacingGame()
        {
            InitializeComponent();
            gameOverPanel.Visible = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            moveLine(gameSpeed);
            moveEnemy(gameSpeed);
            moveCoin(gameSpeed);
            coinCollection();
            gameOver();
        }

        void moveEnemy(int speed)
        {
            if (enemy1.Top > 500)
            {
                x = r.Next(0, 170);

                enemy1.Location = new Point(x, 0);
            }

            else
            {
                enemy1.Top += speed;
            }


            if (enemy2.Top > 500)
            {
                x = r.Next(180, 200);

                enemy2.Location = new Point(x, 0);
            }

            else
            {
                enemy2.Top += speed;
            }


            if (enemy3.Top > 500)
            {
                x = r.Next(200, 350);

                enemy3.Location = new Point(x, 0);
            }

            else
            {
                enemy3.Top += speed;
            }
        }

        void moveCoin(int speed)
        {
            if (coin1.Top > 500)
            {
                x = r.Next(50, 130);

                coin1.Location = new Point(x, 0);
            }

            else
            {
                coin1.Top += speed;
            }


            if (coin2.Top > 500)
            {
                x = r.Next(150, 230);

                coin2.Location = new Point(x, 0);
            }

            else
            {
                coin2.Top += speed;
            }


            if (coin3.Top > 500)
            {
                x = r.Next(250, 300);

                coin3.Location = new Point(x, 0);
            }

            else
            {
                coin3.Top += speed;
            }


            if (coin4.Top > 500)
            {
                x = r.Next(310, 360);

                coin4.Location = new Point(x, 0);
            }

            else
            {
                coin4.Top += speed;
            }
        }

        void gameOver()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer.Enabled = false;
                gameOverPanel.Visible = true;
                isGameOver = true;
            }

            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer.Enabled = false;
                gameOverPanel.Visible = true;
                isGameOver = true;
            }

            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer.Enabled = false;
                gameOverPanel.Visible = true;
                isGameOver = true;
            }
        }

        void moveLine(int speed)
        {
            if (pictureBox1.Top > 500)
            {
                pictureBox1.Top = 0;
            }

            else
            {
                pictureBox1.Top += speed;
            }


            if (pictureBox2.Top > 500)
            {
                pictureBox2.Top = 0;
            }

            else
            {
                pictureBox2.Top += speed;
            }


            if (pictureBox3.Top > 500)
            {
                pictureBox3.Top = 0;
            }

            else
            {
                pictureBox3.Top += speed;
            }


            if (pictureBox4.Top > 500)
            {
                pictureBox4.Top = 0;
            }

            else
            {
                pictureBox4.Top += speed;
            }
        }

        private void CarRacingGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isGameOver)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (car.Left > 30)
                    {
                        car.Left += -8;
                    }
                }

                if (e.KeyCode == Keys.Right)
                {
                    if (car.Right < 360)
                    {
                        car.Left += 8;
                    }
                }

                if (e.KeyCode == Keys.Up)
                {
                    if (gameSpeed < 21)
                    {
                        gameSpeed++;
                    }
                }

                if (e.KeyCode == Keys.Down)
                {
                    if (gameSpeed > 0)
                    {
                        gameSpeed--;
                    }
                }
            }
        }

        void coinCollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedCoins++;
                resultLabel.Text = "Coins: " + collectedCoins.ToString();

                x = r.Next(50, 130);
                coin1.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedCoins++;
                resultLabel.Text = "Coins: " + collectedCoins.ToString();

                x = r.Next(150, 230);
                coin2.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedCoins++;
                resultLabel.Text = "Coins: " + collectedCoins.ToString();

                x = r.Next(250, 300);
                coin3.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedCoins++;
                resultLabel.Text = "Coins: " + collectedCoins.ToString();

                x = r.Next(310, 360);
                coin4.Location = new Point(x, 0);
            }
        }
    }
}
