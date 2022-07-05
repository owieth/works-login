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


namespace login.gruppe5.tetris
{
    public partial class Highscore : Form
    {
        public Highscore()
        {
            InitializeComponent();
            richTextBox1.Text = Convert.ToString(richTextBox1.Text);
            //File.ReadAllText("‪D:\\Highscore.txt", richTextBox1.Text);
        }

        private void btnSchliessenHighscore_Click(object sender, EventArgs e)
        {
            Tetris tetris = new Tetris();
            tetris.Show();
            this.Hide();
        }

        private void btnEintragen_Click(object sender, EventArgs e)
        {
            
            File.WriteAllText("D:\\Highscore.txt", txtScore.Text);
            
        }
    }
}
