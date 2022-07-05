using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uebung_Serie2_Aufgabe_02
{
    public partial class frmBMI : Form
    {
        public static double Groesse;
        public static double GewichtZahl;
        public static double Ausgabe;

        public frmBMI()
        {
            InitializeComponent();
        }

        private void ZahlenEinfügen()
        {
            GewichtZahl = Convert.ToDouble(txtGewicht.Text);
            Groesse = Convert.ToDouble(txtGroesse.Text);
        }

        private void btnBerechnung_Click(object sender, EventArgs e)
        {
            ZahlenEinfügen();
            Ausgabe = GewichtZahl / (Groesse * Groesse);
            txtWert.Text = Convert.ToString(Ausgabe);
            Kategorien();
            
        }

        private void Kategorien()
        {
            if (Ausgabe <= 16.00)
            {
                txtKategorie.Text = "Starkes Untergewicht";
                txtKategorie.ForeColor = Color.White;
                txtKategorie.BackColor = Color.Blue;
            }
            else if (Ausgabe > 16.00 && Ausgabe <= 16.99)
            {
                txtKategorie.Text = "Mässiges Untergewicht";
                txtKategorie.ForeColor = Color.White;
                txtKategorie.BackColor = Color.BlueViolet;
            }
            else if (Ausgabe > 17.00 && Ausgabe <= 18.49)
            {
                txtKategorie.Text = "Leichtes Untergewicht";
                txtKategorie.ForeColor = Color.White;
                txtKategorie.BackColor = Color.Aqua;
            }
            else if (Ausgabe > 18.50 && Ausgabe <= 24.99)
            {
                txtKategorie.Text = "Normalgewicht";
                txtKategorie.ForeColor = Color.White;
                txtKategorie.BackColor = Color.Green;
            }
            else if (Ausgabe > 25.00 && Ausgabe <= 29.99)
            {
                txtKategorie.Text = "Präadipositas";
                txtKategorie.ForeColor = Color.White;
                txtKategorie.BackColor = Color.Yellow;
            }
            else if (Ausgabe > 30.00 && Ausgabe <= 34.99)
            {
                txtKategorie.Text = "Adipositas Grad I";
                txtKategorie.ForeColor = Color.White;
                txtKategorie.BackColor = Color.Orange;
            }
            else if (Ausgabe > 35.00 && Ausgabe <= 39.99)
            {
                txtKategorie.Text = "Adipositas Grad II";
                txtKategorie.ForeColor = Color.White;
                txtKategorie.BackColor = Color.Red;
            }
            else if (Ausgabe >= 40.00)
            {
                txtKategorie.Text = "Adipositas Grad III";
                txtKategorie.ForeColor = Color.White;
                txtKategorie.BackColor = Color.DarkRed;
            }
        }
    }
}
