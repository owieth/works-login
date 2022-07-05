using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingSpiel //Erstellt am 27.04.2k18 mithilfe von Mooict.com
{
    public partial class frmSpiel : Form
    {
        private int _carSpeed = 5; //Globale Variablen 
        private int _roadSpeed = 5;
        private bool IsCarLeft;
        private bool IsCarRight;
        private int _trafficSpeed = 5;
        private int _score = 0;
        Random rnd = new Random();

        public frmSpiel()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset() //Methode für Zurücksetzung von Spiel
        {
            pbTrophy.Hide();
            btnStart.Enabled = false;
            pbExplosion.Hide();
            _trafficSpeed = 5;
            _roadSpeed = 5;
            _score = 0;

            pbPlayer.Left = 161;
            pbPlayer.Top = 286;

            IsCarLeft = false;
            IsCarRight = false;

            pbCar1.Left = 66;
            pbCar1.Top = -120;

            pbCar2.Left = 294;
            pbCar2.Top = -185;

            pbRoadTrack2.Left = -3;
            pbRoadTrack2.Top = -222;
            pbRoadTrack1.Left = -2;
            pbRoadTrack1.Top = -683;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _score++;

            lblDistance2.Text = "" + _score;

            pbRoadTrack1.Top += _roadSpeed;
            pbRoadTrack2.Top += _roadSpeed;

            if (pbRoadTrack1.Top > 630)
            {
                pbRoadTrack1.Top = -630;
            }

            if (pbRoadTrack2.Top > 630)
            {
                pbRoadTrack2.Top = -630;
            }

            if (IsCarLeft)
            {
                pbPlayer.Left -= _carSpeed;
            }

            if (IsCarRight)
            {
                pbPlayer.Left += _carSpeed;
            }

            if (pbPlayer.Left < 1)
            {
                IsCarLeft = false;
            }
            else if (pbPlayer.Left + pbPlayer.Width > 380)
            {
                IsCarRight = false;
            }

            pbCar1.Top += _trafficSpeed;
            pbCar2.Top += _trafficSpeed;

            if (pbCar1.Top > pnlStrasse.Height)
            {
                changepbCar1();
                pbCar1.Left = rnd.Next(2, 160);
                pbCar1.Top = rnd.Next(100, 200) * -1;
            }

            if (pbCar2.Top > pnlStrasse.Height)
            {
                changepbCar2();
                pbCar2.Left = rnd.Next(185, 327);
                pbCar2.Top = rnd.Next(100, 200);
            }

            if (pbPlayer.Bounds.IntersectsWith(pbCar1.Bounds))
            {
                gameOver();
            }

            if (_score > 100 && _score < 500)
            {
                _trafficSpeed = 6;
                _roadSpeed = 7;
            }

            else if (_score > 500 && _score < 1000)
            {
                _trafficSpeed = 7;
                _roadSpeed = 8;
            }

            else if (_score > 1200)
            {
                _trafficSpeed = 9;
                _roadSpeed = 10;
            }
        }

        private void moveCar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && pbPlayer.Left > 0)
            {
                IsCarLeft = true;
            }

            if (e.KeyCode == Keys.Right && pbPlayer.Left + pbPlayer.Width < pnlStrasse.Width)
            {
                IsCarRight = true;
            }
        }

        private void stopCar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                IsCarLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                IsCarRight = false;
            }
        }

        private void changepbCar1()
        {
            int images = rnd.Next(1, 8); //Variable für Randomanzeige von Bilder der neuen Autos.

            switch (images)
            {
                case 1:
                    pbCar1.Image = Properties.Resources.carGreen;
                    break;

                case 2:
                    pbCar2.Image = Properties.Resources.carGrey;
                    break;

                case 3:
                    pbCar1.Image = Properties.Resources.carOrange;
                    break;

                case 4:
                    pbCar1.Image = Properties.Resources.carPink;
                    break;

                case 5:
                    pbCar1.Image = Properties.Resources.CarRed;
                    break;

                case 6:
                    pbCar1.Image = Properties.Resources.TruckBlue;
                    break;

                case 7:
                    pbCar1.Image = Properties.Resources.TruckWhite;
                    break;

                case 8:
                    pbCar1.Image = Properties.Resources.ambulance;
                    break;
                default:
                    break;
            }
        }

        private void changepbCar2()
        {
            int images = rnd.Next(1, 8); //Variable für Randomanzeige von Bilder der neuen Autos.

            switch (images)
            {
                case 1:
                    pbCar1.Image = Properties.Resources.carGreen;
                    break;

                case 2:
                    pbCar2.Image = Properties.Resources.carGrey;
                    break;

                case 3:
                    pbCar1.Image = Properties.Resources.carOrange;
                    break;

                case 4:
                    pbCar1.Image = Properties.Resources.carPink;
                    break;

                case 5:
                    pbCar1.Image = Properties.Resources.CarRed;
                    break;

                case 6:
                    pbCar1.Image = Properties.Resources.TruckBlue;
                    break;

                case 7:
                    pbCar1.Image = Properties.Resources.TruckWhite;
                    break;

                case 8:
                    pbCar1.Image = Properties.Resources.ambulance;
                    break;
                default:
                    break;
            }
        }

        private void gameOver()
        {
            pbTrophy.Show();
            timer1.Stop();
            btnStart.Enabled = true;

            pbExplosion.Show();
            pbPlayer.Controls.Add(pbExplosion);
            pbExplosion.Location = new Point(-8, 5);
            pbExplosion.BackColor = Color.Transparent;
            pbExplosion.BringToFront();

            if (_score < 1000)
            {
                pbTrophy.Image = Properties.Resources.bronze;
            }

            if (_score > 2000)
            {
                pbTrophy.Image = Properties.Resources.silver;
            }

            if (_score > 3500)
            {
                pbTrophy.Image = Properties.Resources.gold;
            }

            playSound();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void playSound()
        {
            System.Media.SoundPlayer PlayerSound = new SoundPlayer(@"hit.wav");
            PlayerSound.Play();
        }
    }
}
