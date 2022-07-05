using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpAndRun
{
    public partial class frmSpiel : Form
    {
        bool GeheLinks = false;
        bool GeheRechts = false;
        bool Springen = false;

        int SprungSpeed = 10;
        int Anziehung = 8;
        int Punktzahl = 0;

        public frmSpiel()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                GeheLinks = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                GeheRechts = true;
            }
            if (e.KeyCode == Keys.Space && !Springen)
            {
                Springen = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                GeheLinks = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                GeheRechts = false;
            }
            if (e.KeyCode == Keys.Space && !Springen)
            {
                Springen = false;
            }
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            player.Top += SprungSpeed; //Erzeugt Anziehungskraft

            if (Springen && Anziehung < 0)
            {
                Springen = false;
            }
            
            if (GeheLinks)
            {
                player.Left -= 5;
            }

            if (GeheRechts)
            {
                player.Left += 5;
            }

            if (Springen)
            {
                SprungSpeed = -12;
                Anziehung = -1;
            }
            else
            {
                SprungSpeed = 12;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !Springen)
                    {
                        Anziehung = 8;
                        player.Top = x.Top - player.Height;
                    }
                }
            }
        }
    }
}
