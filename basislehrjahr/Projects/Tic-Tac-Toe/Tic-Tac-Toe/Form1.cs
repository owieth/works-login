using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class frmSpiel : Form
    {
        public static int _scoreplayer01;
        public static int _scoreplayer02;
        
        public frmSpiel()
        {
            InitializeComponent();
        }

        private void SelectAllButtons(object sender, EventArgs e) //Mit dieser Methode werden alle Buttons angesprochen.
        {
            Button SelectAllButtonsClicked = (Button) sender;

            if (radioButton01.Checked == true)
            {
                SelectAllButtonsClicked.Text = "X";
                WhoWins();
                radioButton02.Checked = true;   
                FullGame();
            }
            else if (radioButton02.Checked == true)
            {
                SelectAllButtonsClicked.Text = "O";
                WhoWins();
                radioButton01.Checked = true;
                FullGame();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGame();
        }

        private void ClearGame() //Spielfeld wird zurückgesetzt.
        {
            btn01.Text = "";
            btn02.Text = "";
            btn03.Text = "";
            btn04.Text = "";
            btn05.Text = "";
            btn06.Text = "";
            btn07.Text = "";
            btn08.Text = "";
            btn09.Text = "";
        }

        private void FullGame() //Falls alle Felder besetzt sind, werden diese gelöscht.
        {
            if ((btn01.Text == "X" || btn01.Text == "O") && (btn02.Text == "X" || btn02.Text == "O") && (btn03.Text == "X" || btn03.Text == "O") &&
                (btn04.Text == "X" || btn04.Text == "O") && (btn05.Text == "X" || btn05.Text == "O") && (btn06.Text == "X" || btn06.Text == "O") &&
                (btn07.Text == "X" || btn07.Text == "O") && (btn08.Text == "X" || btn08.Text == "O") && (btn09.Text == "X" || btn09.Text == "O"))
            {
                MessageBox.Show("Unentschieden");
                ClearGame();
            }
        }

        private void WhoWins() //In dieser Methode wird geprüft ob drei gleiche Zeichen nebeneinander sind.
        {
            //Spieler 01
            //Alle horizontal
            if (btn01.Text == "X" && btn02.Text == "X" && btn03.Text == "X")
            {
                _scoreplayer01++;
                txtPunktzahl01.Text = Convert.ToString(_scoreplayer01);
                MessageBox.Show("Player 01 hat gewonnen");
                ClearGame();
            }

            if (btn04.Text == "X" && btn05.Text == "X" && btn06.Text == "X")
            {
                _scoreplayer01++;
                txtPunktzahl01.Text = Convert.ToString(_scoreplayer01);
                MessageBox.Show("Player 01 hat gewonnen");
                ClearGame();
            }

            if (btn07.Text == "X" && btn08.Text == "X" && btn09.Text == "X")
            {
                _scoreplayer01++;
                txtPunktzahl01.Text = Convert.ToString(_scoreplayer01);
                MessageBox.Show("Player 01 hat gewonnen");
                ClearGame();
            }

            //Alle senkrecht
            if (btn01.Text == "X" && btn04.Text == "X" && btn07.Text == "X")
            {
                _scoreplayer01++;
                txtPunktzahl01.Text = Convert.ToString(_scoreplayer01);
                MessageBox.Show("Player 01 hat gewonnen");
                ClearGame();
            }

            if (btn02.Text == "X" && btn05.Text == "X" && btn08.Text == "X")
            {
                _scoreplayer01++;
                txtPunktzahl01.Text = Convert.ToString(_scoreplayer01);
                MessageBox.Show("Player 01 hat gewonnen");
                ClearGame();
            }

            if (btn03.Text == "X" && btn06.Text == "X" && btn09.Text == "X")
            {
                _scoreplayer01++;
                txtPunktzahl01.Text = Convert.ToString(_scoreplayer01);
                MessageBox.Show("Player 01 hat gewonnen");
                ClearGame();
            }

            //Zwei diagonal
            if (btn01.Text == "X" && btn05.Text == "X" && btn09.Text == "X")
            {
                _scoreplayer01++;
                txtPunktzahl01.Text = Convert.ToString(_scoreplayer01);
                MessageBox.Show("Player 01 hat gewonnen");
                ClearGame();
            }

            if (btn03.Text == "X" && btn05.Text == "X" && btn07.Text == "X")
            {
                _scoreplayer01++;
                txtPunktzahl01.Text = Convert.ToString(_scoreplayer01);
                MessageBox.Show("Player 01 hat gewonnen");
            }
            //Spieler 02
            //Alle horizontal
            if (btn01.Text == "O" && btn02.Text == "O" && btn03.Text == "O")
            {
                _scoreplayer02++;
                txtPunktzahl02.Text = Convert.ToString(_scoreplayer02);
                MessageBox.Show("Player 02 hat gewonnen");
                ClearGame();
            }

            if (btn04.Text == "O" && btn05.Text == "O" && btn06.Text == "O")
            {
                _scoreplayer02++;
                txtPunktzahl02.Text = Convert.ToString(_scoreplayer02);
                MessageBox.Show("Player 02 hat gewonnen");
                ClearGame();
            }

            if (btn07.Text == "O" && btn08.Text == "O" && btn09.Text == "O")
            {
                _scoreplayer02++;
                txtPunktzahl02.Text = Convert.ToString(_scoreplayer02);
                MessageBox.Show("Player 02 hat gewonnen");
                ClearGame();
            }
            
            //Alle senkrecht
            if (btn01.Text == "O" && btn04.Text == "O" && btn07.Text == "O")
            {
                _scoreplayer02++;
                txtPunktzahl02.Text = Convert.ToString(_scoreplayer02);
                MessageBox.Show("Player 02 hat gewonnen");
                ClearGame();
            }

            if (btn02.Text == "O" && btn05.Text == "O" && btn08.Text == "O")
            {
                _scoreplayer02++;
                txtPunktzahl02.Text = Convert.ToString(_scoreplayer02);
                MessageBox.Show("Player 02 hat gewonnen");
                ClearGame();
            }

            if (btn03.Text == "O" && btn06.Text == "O" && btn09.Text == "O")
            {
                _scoreplayer02++;
                txtPunktzahl02.Text = Convert.ToString(_scoreplayer02);
                MessageBox.Show("Player 02 hat gewonnen");
                ClearGame();
            }

            //Zwei diagonal
            if (btn01.Text == "O" && btn05.Text == "O" && btn09.Text == "O")
            {
                _scoreplayer02++;
                txtPunktzahl02.Text = Convert.ToString(_scoreplayer02);
                MessageBox.Show("Player 02 hat gewonnen");
                ClearGame();
            }

            if (btn03.Text == "O" && btn05.Text == "O" && btn07.Text == "O")
            {
                _scoreplayer02++;
                txtPunktzahl02.Text = Convert.ToString(_scoreplayer02);
                MessageBox.Show("Player 02 hat gewonnen");
                ClearGame();
            }
        }

        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPunktzahl01.Clear();
            txtPunktzahl02.Clear();
        }
    }
}
