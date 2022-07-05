using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace login.gruppe5.tetris
{
    public partial class Tetris : Form
    {
        Ablauf KlasseAblauf = new Ablauf();
        private int _hoehe;
        private int _breite;
        private int _punktzahl;
        private int _level;
        private int _XPositionBlock = 4;
        private int _YPositionBlock = 0;
        public bool IstamBoden;
        public bool GeheLinks = false;
        public bool GeheRechts = false;
        Random _rndFarben = new Random();

        public Panel Bloecke = new Panel();

        private Color aktuelleFarbe = Color.Red;

        private Color[] colorArray = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Pink };

        public Panel[,] _welt;
        private bool[,] _istBlockNebenan;

        public Tetris()
        {
            InitializeComponent();
            _welt = new Panel[8, 13];
        }

        public void BloeckeErstellen()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Panel block = new Panel()
                    {
                        Width = pnlSpielfeld.Width / 8,
                        Height = pnlSpielfeld.Height / 13,
                        BackColor = Color.Black,
                    };
                    block.Location = new Point(i * block.Width, j * block.Height);
                    _welt[i, j] = block;
                    pnlSpielfeld.Controls.Add(block);
                }
            }
        }

        public void BloeckeFallen()
        {
            _welt[_XPositionBlock, _YPositionBlock].BackColor = aktuelleFarbe;
            if (_YPositionBlock < 12 && _welt[_XPositionBlock, _YPositionBlock + 1].BackColor == Color.Black)
            {
                _welt[_XPositionBlock, _YPositionBlock + 1].BackColor = _welt[_XPositionBlock, _YPositionBlock].BackColor;
                _welt[_XPositionBlock, _YPositionBlock].BackColor = Color.Black;
                _YPositionBlock++;
                //KontrolliereBlockreihe();
            }
            else
            {
                _YPositionBlock = 0;
                _XPositionBlock = 4;

                aktuelleFarbe = (radioButton1.Checked)
                    ? colorArray[_rndFarben.Next(0, 5)]
                    : colorArray[_rndFarben.Next(0, 6)];
            }
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            BloeckeFallen();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSpiel.Interval = 200;
            BloeckeErstellen();

            if (btnStart.Text == "Starten")
            {
                tmrSpiel.Start();
                btnStart.Text = "Pausieren";
            }
            else if (btnStart.Text == "Pausieren")
            {
                tmrSpiel.Stop();
                btnStart.Text = "Starten";
            }
        }

        private void btnHighscore_Click(object sender, EventArgs e)
        {
            this.Hide();
            Highscore highscore = new Highscore();
            highscore.Show();
        }

        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Tetris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                _welt[_XPositionBlock - 1, _YPositionBlock].BackColor = _welt[_XPositionBlock, _YPositionBlock].BackColor;
                _welt[_XPositionBlock, _YPositionBlock].BackColor = Color.Black;

                if (_XPositionBlock > 1)
                {
                    _XPositionBlock -= 1;
                }
            }

            if (e.KeyCode == Keys.D)
            {
                _welt[_XPositionBlock + 1, _YPositionBlock].BackColor = _welt[_XPositionBlock, _YPositionBlock].BackColor;
                _welt[_XPositionBlock, _YPositionBlock].BackColor = Color.Black;

                if (_XPositionBlock < 8)
                {
                    _XPositionBlock += 1;
                }
            }
        }

        private void Tetris_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.A)
            {
                _welt[_XPositionBlock, _YPositionBlock].BackColor = _welt[_XPositionBlock, _YPositionBlock].BackColor;
            }

            if (e.KeyCode == Keys.D)
            {
                _welt[_XPositionBlock, _YPositionBlock].BackColor = _welt[_XPositionBlock, _YPositionBlock].BackColor;
            }
        }

        private void KontrolliereBlockreihe(int x, int y)
        {
            /*if (x == 0 || y == 0 || x == 8 || y == 13)
            {

            }
            else
            {
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (_welt[i, j].BackColor == _welt[i - 1, j].BackColor && _welt[i, j].BackColor == _welt[i + 1, j].BackColor)
                        {
                            _level++;
                            tmrSpiel.Interval -= 5;
                            Bloecke.BackColor = aktuelleFarbe;
                        }

                        if (_welt[i, j].BackColor == _welt[i, j - 1].BackColor && _welt[i, j].BackColor == _welt[i, j + 1].BackColor)
                        {
                            _level++;
                            tmrSpiel.Interval -= 5;
                            Bloecke.BackColor = aktuelleFarbe;
                        }
                    }
                }
            }*/
        }
    }
}
