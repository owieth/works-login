using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLifeWindowsForms // Olivier Winkler & Mara Ayissi 28.03.18 - 29.03.18
{
    public partial class Form1 : Form
    {
        private const int Rows = 40;
        private const int Columns = 40;
        private const int CellSize = 10;
        private const int CellSpace = 2;
        public bool[,] _fillWorld;
        public bool[,] _nextGeneration;
        public CheckBox[,] CheckBoxes;

        public Form1()
        {
            InitializeComponent();
            _fillWorld = new bool[Rows, Columns];
            _nextGeneration = new bool[Rows, Columns];
            CheckBoxes = new CheckBox[Rows, Columns];
            FülleGrid();
        }

        private void FülleGrid()
        {
            pnlSpielfeld.Size = new Size(Rows * 17, Columns * 17);
            var randomGenerator = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    int Temp = randomGenerator.Next(0, 3);

                    if (Temp == 1)
                    {
                        _fillWorld[i, j] = true;
                    }
                    else
                    {
                        _fillWorld[i, j] = false;
                    }

                    var checkBox = new CheckBox()
                    {
                        Width = 17,
                        Height = 17,
                        Checked = _fillWorld[i, j]
                    };

                    checkBox.Location = new Point(i * 17, j * 17);
                    CheckBoxes[i, j] = checkBox;
                    pnlSpielfeld.Controls.Add(checkBox);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (btnStart.Text == "Start" | btnStart.Text == "Weiterlaufen")
            {
                tmrTimer.Start();
                btnStart.Text = "Anhalten";
            }
            else
            {
                tmrTimer.Stop();
                btnStart.Text = "Weiterfahren";
            }
        }


        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            tmrTimer.Enabled = true;
            tmrTimer.Stop();
            NextGeneration();
            tmrTimer.Start();
        }



        private int CountNeighbours(int x, int y)
        {
            var numbersOfNeighbours = 0;

            if (x == 0 || y == 0 || x == Rows - 1 || y == Columns - 1)
            {
                numbersOfNeighbours = 0;
            }
            else
            {

                if (_fillWorld[x - 1, y - 1] == true) numbersOfNeighbours++;

                // oben mitte
                if (_fillWorld[x - 1, y] == true) numbersOfNeighbours++;

                // oben rechts
                if (_fillWorld[x - 1, y + 1] == true) numbersOfNeighbours++;

                // mitte links
                if (_fillWorld[x, y - 1] == true) numbersOfNeighbours++;

                // mitte rechts
                if (_fillWorld[x, y + 1] == true) numbersOfNeighbours++;

                // unten links
                if (_fillWorld[x + 1, y - 1] == true) numbersOfNeighbours++;

                // unten mitte
                if (_fillWorld[x + 1, y] == true) numbersOfNeighbours++;

                // unten rechts
                if (_fillWorld[x + 1, y + 1] == true) numbersOfNeighbours++;
            }

            return numbersOfNeighbours;
        }

        private void NextGeneration()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    var anzahlNachbaren = CountNeighbours(i, j);
                    if (_fillWorld[i, j])
                    {
                        // Zelle stirbt wenn sie weniger als 2 oder mehr als 3 Nachbaren hat (vereinsamung oder überbevölkerung)
                        _nextGeneration[i, j] = !(anzahlNachbaren < 2 || anzahlNachbaren > 3);
                    }
                    else
                    {
                        // tote Zelle wird bei 3 Nachbaren geboren
                        _nextGeneration[i, j] = anzahlNachbaren == 3;
                    }

                }
            }

            _fillWorld = _nextGeneration;
            ShowNextGeneration();
        }

        private void ShowNextGeneration()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    CheckBoxes[i, j].Checked = (_fillWorld[i, j]) ? true : false;
                }
            }
        }
    }
}