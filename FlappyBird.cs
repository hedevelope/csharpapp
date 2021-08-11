using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationAndLogin
{
    public partial class FlappyBird : Form
    {
        public FlappyBird()
        {
            InitializeComponent();
        }

        int pipespeed = 0;
        int gravity = 15;
        int score = 0;
        private void FlappyBird_Load(object sender, EventArgs e)
        {

        }

        private void gameTimer(object sender, EventArgs e)
        {
            pictureBox1.Top += gravity;
            pictureBox2.Left -= pipespeed;
            pictureBox3.Left -= pipespeed;
            label1.Text = "SKOR" + score;

            if(pictureBox2.Left < -150)

            {
                pictureBox2.Left = 800;
                score++;
            }
            if(pictureBox3.Left < -180)
            {
                pictureBox3.Left = 950;
                score++;
            } 
            if(pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds) || 
               pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds) ||
               pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds) || pictureBox1.Top < -25)
            {
                EndGame();
            }
        }
        public void EndGame()
        {
            timer1.Stop();
            label1.Text = "GAME OVER";
        }

        private void game_Down(object sender, KeyEventArgs e)
        {
            
        }

        private void game_Up(object sender, KeyEventArgs e)
        {

        }
    }
}
