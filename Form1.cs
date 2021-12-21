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

        Random Random;

        PictureBox[] FeebleEnemy;
        int SizeOfFeeble;
        int SpeedOfFeeble;

        private Label LabelOfScore;
        int Score;
        public Form1()
        {
            InitializeComponent();
            LabelOfScore = new Label();
            LabelOfScore.Size = new Size(100, 60);
            LabelOfScore.Location = new Point(1030, 30);
            LabelOfScore.Font = new System.Drawing.Font("Showcard Gothic", 18); //починить
            LabelOfScore.Text = "Score: 0";
            this.Controls.Add(LabelOfScore);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SpaceShipSpeed = 10;

            Random = new Random();

            Missile = new PictureBox[2];
            SpeedOfMissile = 20;

            FeebleEnemy = new PictureBox[5];
            SizeOfFeeble = 80;
            SpeedOfFeeble = 3;
            Image ImageOfFeeble = Image.FromFile("C:\\ship2.png");

            for(int i = 0; i < FeebleEnemy.Length; i++) //Задаем параметры слабым ребятам
            {
                FeebleEnemy[i] = new PictureBox();
                FeebleEnemy[i].Size = new Size(SizeOfFeeble, SizeOfFeeble);
                FeebleEnemy[i].SizeMode = PictureBoxSizeMode.Zoom;
                FeebleEnemy[i].BackColor = Color.Transparent;
                FeebleEnemy[i].Image = ImageOfFeeble;
                FeebleEnemy[i].Location = new Point((i + 1) * Random.Next(90, 160) + 1080, Random.Next(40, 150)); //починить.

                this.Controls.Add(FeebleEnemy[i]);
            }

            for(int i = 0; i < Missile.Length; i++) //выстрелы mainShipa
            {
                Missile[i] = new PictureBox();
                Missile[i].BorderStyle = BorderStyle.None;
                Missile[i].Size = new Size(5, 20);
                Missile[i].BackColor = Color.Red;

                this.Controls.Add(Missile[i]);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timerLeft_Tick(object sender, EventArgs e) //КНОПАЧКА НАЖАТА ВЛЕВА
        {
            if(MainSpaceShip.Left > 5)
            {
                MainSpaceShip.Left -= SpaceShipSpeed; //КНОПАЧКА НАЖАТА ВПРАВА
            }
        }

        private void timerRight_Tick(object sender, EventArgs e) 
        {
            if (MainSpaceShip.Left < 1100)
            {
                MainSpaceShip.Left += SpaceShipSpeed;
            }
        }

        private void timerUp_Tick(object sender, EventArgs e) //КНОПАЧКА НАЖАТА ВНИЗ
        {
            MainSpaceShip.Top -= SpaceShipSpeed;
        }

        private void timerDown_Tick(object sender, EventArgs e) //КНОПАЧКА НАЖАТА ВВЕРХ
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
                for (int i = 0; i < Missile.Length; i++)
                {
                    HitEnemy();
                    Missile[i].Location = new Point(MainSpaceShip.Location.X + 10, MainSpaceShip.Location.Y + 100); // Для стрельбы из левого
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                timerRight.Start();
                for (int i = 0; i < Missile.Length; i++)
                {
                    HitEnemy();
                    Missile[i].Location = new Point(MainSpaceShip.Location.X + 150, MainSpaceShip.Location.Y - 10); // Для стрельбы из правого
                }
            }

            if (e.KeyCode == Keys.Up) //вверх
            {
                timerUp.Start();
            }

            if (e.KeyCode == Keys.Down) //вниз
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

        private void TimerForMissile_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < Missile.Length; i++)
            {
                Missile[i].Top -= SpeedOfMissile;
            }
        }

        private void TimerForFeeble_Tick(object sender, EventArgs e)
        {
            MoveFeeble(FeebleEnemy, SpeedOfFeeble);
        }

        private void MoveFeeble(PictureBox[] FeebleEnemy, int SpeedOfFeeble)
        {
            for(int i = 0; i < FeebleEnemy.Length; i++)
            {
                FeebleEnemy[i].Left -= SpeedOfFeeble + (int)(Math.Sin(FeebleEnemy[i].Left * Math.PI / 180) + 
                    (int)Math.Cos(FeebleEnemy[i].Left * Math.PI / 180));

                HitEnemy();

                if(FeebleEnemy[i].Top < this.Top)
                {
                    int SizeOfFeeble = Random.Next(70, 80);
                    FeebleEnemy[i].Size = new Size(SizeOfFeeble, SizeOfFeeble);
                    FeebleEnemy[i].Location = new Point(500, 100); //починить.
                }
            }
        }

        private void HitEnemy()//поменять название и доделать
        {
            for(int i = 0; i < FeebleEnemy.Length; i++)
            {
                if (Missile[0].Bounds.IntersectsWith(FeebleEnemy[i].Bounds))
                {
                    FeebleEnemy[i].Location = new Point((i + 1) * Random.Next(90, 160) + 1280, Random.Next(90, 140));
                    Missile[0].Location = new Point(2000, MainSpaceShip.Location.Y + 50);

                    LabelOfScore.Text = "Score: " + ++Score;
                }

                if (MainSpaceShip.Bounds.IntersectsWith(FeebleEnemy[i].Bounds))
                {
                    MainSpaceShip.Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
