using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoflanKurs
{
    public partial class Form1 : Form
    {
        int SpaceShipSpeed;
        PictureBox[] Missile;
        int SpeedOfMissile;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SpaceShipSpeed = 10;
            Missile = new PictureBox[2];
            SpeedOfMissile = 40;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timerLeft_Tick(object sender, EventArgs e)
        {
            if(MainSpaceShip.Left > 10)
            {
                MainSpaceShip.Left -= SpaceShipSpeed;
            }
        }

        private void timerRight_Tick(object sender, EventArgs e)
        {
            if (MainSpaceShip.Left < 1150)
            {
                MainSpaceShip.Left += SpaceShipSpeed;
            }
        }

        private void timerUp_Tick(object sender, EventArgs e)
        {
            MainSpaceShip.Top -= SpaceShipSpeed;
        }

        private void timerDown_Tick(object sender, EventArgs e)
        {
            MainSpaceShip.Top += SpaceShipSpeed;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                timerLeft.Start();
            }

            if (e.KeyCode == Keys.Right)
            {
                timerRight.Start();
            }

            if (e.KeyCode == Keys.Up)
            {
                timerUp.Start();
            }

            if (e.KeyCode == Keys.Down)
            {
                timerDown.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            timerLeft.Stop();
            timerRight.Stop();
            timerUp.Stop();
            timerDown.Stop();
        }

        
    }
}
