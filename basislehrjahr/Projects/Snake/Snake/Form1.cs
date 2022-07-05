using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class frmSpiel : Form
    {
        public frmSpiel()
        {
            InitializeComponent();
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            pbSnake.Location = new Point(pbSnake.Location.X, pbSnake.Location.Y);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSpiel.Start(); 
            
        }

        private void ToddurchWand()
        {
            /*if (pbSnake.Location.X)
            {

            }*/
        }

        private void ToddurchSnake()
        {

        }

        private void Essen()
        {

        }
    }
}
