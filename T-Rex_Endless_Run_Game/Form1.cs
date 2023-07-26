using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Rex_Endless_Run_Game
{
    public partial class Form1 : Form
    {
        bool jumping = false; 

        int jumpspeed = 15; 

        int force = 15; 

        int score = 0; 

        int obstacleSpeed = 10;

        int position;

        bool isgameover = false;
        
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            resetgame();

            
        }

        private void Trex_Click(object sender, EventArgs e)
        {

        }

        private void gameevent(object sender, EventArgs e)
        {

            Trex.Top += jumpspeed;

            txtscore.Text = "Score: " + score;

            if (jumping == true && force < 0)

            {
                jumping = false;
            }
            
            if (jumping == true)

            {
                jumpspeed = -15;
                force -= 1;
            }
            else

            {
               
                jumpspeed = 15;
            }

            if (Trex.Top >= 100 && !jumping)
            {
                
                force = 15;
                Trex.Top = floor.Top - Trex.Height;
                jumpspeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                
                if (x is PictureBox && (string)x.Tag == "obstacle1")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left + x.Width < -120)

                    {
                        x.Left = this.ClientSize.Width + rnd.Next(400, 800) + (x.Width *10);
                        score++;
                    }
                  
                    if (Trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gametimer.Stop();
                        
                        Trex.Image = Properties.Resources.dead;

                        isgameover = true;

                        show.Visible = true;

                        show.Text = "Game Over !";
                    }
                }

                if (x is PictureBox && (string)x.Tag == "obstacle2")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left + x.Width < -120)

                    {
                        x.Left = this.ClientSize.Width + rnd.Next(200, 600) + (x.Width * 10);
                        score++;
                    }

                    if (Trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gametimer.Stop();

                        Trex.Image = Properties.Resources.dead;

                        txtscore.Text += "  Press R to restart";

                        isgameover = true;
                    }
                }
            }


        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space && !jumping)

            {
                jumping = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {

            if (jumping)

            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isgameover == true )

            {
                resetgame();
            }

        }

        public void resetgame()
        {

            force = 12; 
          
            jumpspeed = 0;

            jumping = false;

            score = 0;

            obstacleSpeed = 10;

            txtscore.Text = "Score: " + score;

            Trex.Image = Properties.Resources.running;

            Trex.Top = floor.Top - Trex.Height;

            foreach (Control x in this.Controls)
            {
                
                if (x is PictureBox && (string)x.Tag == "obstacle1")

                {
                    position = this.ClientSize.Width + rnd.Next(600, 1000) + (x.Width *10);

                    x.Left = position;
                }

                if (x is PictureBox && (string)x.Tag == "obstacle2")

                {
                    position = this.ClientSize.Width + rnd.Next(600, 1000) + (x.Width * 10);

                    x.Left = position;
                }
            }

            gametimer.Start();

            show.Visible = false;

        }

        private void txtscore_Click(object sender, EventArgs e)
        {

        }

        private void obstacle1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void floor_Click(object sender, EventArgs e)
        {

        }
    }
}
