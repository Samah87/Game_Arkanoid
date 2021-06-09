using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Arkanoid
{
    public partial class Form1 : Form
    {

        int Punkte = 0;
        int BallX;
        int BallY;
        int PlayerSpeed;
        bool goLeft, goRight, isGameover;

        PictureBox[] blockArray;

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            SetupGame();
        }

        private void SetupGame()
        {
            isGameover = false;
            Punkte = 0;
            BallX = 5;
            BallY = 5;
            PlayerSpeed = 12;

            TxtPunkte.Text = "Punkte: " + Punkte;
            Ball.Left = 410;
            Ball.Top = 330;

            Player.Left = 375;
            Player.Top = 514;

            blockArray = new PictureBox[40];

            int a = 0;
            int top = 90;
            int links = 140;

            for(int t = 0; t < blockArray.Length; t++)
            {
                blockArray[t] = new PictureBox
                {
                    Width = 54,
                    Height = 22,
                    //BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255)),
                    BackColor = Color.Transparent,
                    BackgroundImage = Properties.Resources.akanoid_block,
                    Tag = "blocks"
                };

                if(a == 10)
                {
                    top += 24;
                    links = 140;
                    a = 0;
                }

                if(a < 10)
                {
                    a++;
                    blockArray[t].Left = links;
                    blockArray[t].Top = top;
                    this.Controls.Add(blockArray[t]);
                    links += 60;
                }

            }

            GameTimer.Start();

        }


        private void GameTimer_Tick(object sender, EventArgs e)
        {
            TxtPunkte.Text = "Punkte: " + Punkte;
            if(goLeft == true && Player.Left > 0)
            {
                Player.Left -= PlayerSpeed;
            }

            if(goRight == true && Player.Left < this.ClientSize.Width - Player.Width)
            {
                Player.Left += PlayerSpeed;
            }

            Ball.Left += BallX;
            Ball.Top += BallY;

            if(Ball.Left <0 || Ball.Left > this.ClientSize.Width - Ball.Width)
            {
                BallX = -BallX;
            }

            if(Ball.Top < 0)
            {
                BallY = -BallY;
            }

            if (Ball.Bounds.IntersectsWith(Player.Bounds))
            {
                Ball.Top = 503;

                //BallY = -BallY;

                BallY = rnd.Next(5, 12) * -1;

                if(BallX < 0)
                {
                    BallX = rnd.Next(5, 12) * -1;
                }
                else
                {
                    BallX = rnd.Next(5, 12);
                }
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "blocks")
                {
                    if (Ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        Punkte++;
                        BallY = -BallY;

                        this.Controls.Remove(x);
                    }
                }
            }

            if(Punkte == blockArray.Length)
            {
                GameOver("G");
            }


            if(Ball.Top > this.ClientSize.Height - Ball.Height)
            {
                GameOver("V");
            }
        }


        private void GameOver(string Zeichen)
        {
            GameTimer.Stop();
            isGameover = true;
            HightBox.Visible = true;
            HightPunkte.Text = "Punkte: " + Punkte;
            HightPunkte.Visible = true;
            HightPunkte.BringToFront();

            if(Zeichen == "G")
            {
                TxtGewonnen.Text = "Gewonnen";
                TxtGewonnen.Visible = true;
            }
            else
            {
                TxtGewonnen.Text = "Verloren";
                TxtGewonnen.Visible = true;
            }
        }


        private void IsKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
        }

        private void IsKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if(e.KeyCode == Keys.Enter && isGameover == true)
            {
                ResetBlock();
                SetupGame();
            }
        }

        private void ResetBlock()
        {
            foreach(PictureBox x in blockArray)
            {
                this.Controls.Remove(x);
            }

            HightBox.Visible = false;
            HightPunkte.Visible = false;
            TxtGewonnen.Visible = false;
        }
    }
}
