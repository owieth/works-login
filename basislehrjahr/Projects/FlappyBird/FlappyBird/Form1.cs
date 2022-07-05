using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class frmSpiel : Form
    {
        private bool _springen;
        private int _anziehung = 5;
        private int _spielgeschwindigkeit = 5;
        private int _punkzahl;
        Random Pipe = new Random();
        private bool PipeIsUp;
        private bool PipeIsDown;

        public frmSpiel()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            pbBird.Top = 200;
            pbBird.Left = 70;

            pbPipe1.Top = 315;
            pbPipe1.Left = 350;

            pbPipe2.Top = 2;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _punkzahl++;

            lblPunktzahl.Text = "" + _punkzahl;

            if (pbPipe1.Left > 250)
            {
                pbPipe1.Left = -250;
            }

            if (pbPipe2.Left > 250)
            {
                pbPipe2.Left = -250;
            }

            if (PipeIsUp)
            {

            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Hide();
            timer1.Start();
        }

        private void gameOver()
        {
            timer1.Stop();
            lblAussage.Show();

        }

        private void Pipes()
        {
            int _zufall = Pipe.Next(1, 4);

            switch (_zufall)
            {
                case 1:
                    pbPipe1.Image = Properties.Resources.pipe;
                    break;

                case 2:
                    pbPipe1.BackColor = Color.Transparent;
                    break;

                case 3:
                    pbPipe2.Image = Properties.Resources.pipedown;
                    break;

                case 4:
                    pbPipe2.BackColor = Color.Transparent;
                    break;

                default:
                    break;
            }
        }
    }
}
