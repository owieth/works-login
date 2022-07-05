using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class frmPingPong : Form
    {
        int WertX = 3;
        int WertY = 3;
        int Punktzahl = 0;

        public frmPingPong()
        {
            InitializeComponent();
            vsbScrollbar.Maximum = pnlSpiel.Height - picSchlägerRechts.Height + vsbScrollbar.LargeChange;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSpiel.Start();
        }

        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            int BallX = picBall.Location.X;
            int BallY = picBall.Location.Y;
            Boolean IsInHitboxY = BallY > picSchlägerRechts.Location.Y - picSchlägerRechts.Height && BallY < picSchlägerRechts.Location.Y + picSchlägerRechts.Height;
            /*BallY > picSchlägerRechts.Location.Y && BallY < picSchlägerRechts.Location.Y + picSchlägerRechts.Height;*/
            Boolean IsInHitboxX = BallX < picSchlägerRechts.Location.X - picSchlägerRechts.Width && BallY > picSchlägerRechts.Location.X + picSchlägerRechts.Width;
            /*BallX > picSchlägerRechts.Location.X - picSchlägerRechts.Width;*/

            if (BallY + picBall.Height > pnlSpiel.Height || BallY < 0)
            {
                WertY = -WertY;
            }

            if (BallX + picBall.Width > pnlSpiel.Width || BallX < 0)
            {
                WertX = -WertX;
            }

            picBall.Location = new Point(BallX + WertX, BallY + WertY);

            if (IsInHitboxX)
            {
                WertX = -WertX;

                /*Punktzahl += 10;
                txtPunkte.Text = Convert.ToString(Punktzahl); */
            }
            else if (picBall.Location.X > pnlSpiel.Width && !IsInHitboxX)
            {
                tmrSpiel.Stop();
                MessageBox.Show("(╯°□°）╯︵ ┻━┻");
                this.Close();
            }
        }

        private void vsbSchlägerRechts_Scroll(object sender, ScrollEventArgs e)
        {
            picSchlägerRechts.Location = new Point(picSchlägerRechts.Location.X, vsbScrollbar.Value);
        }

        private void picSchlägerRechts_Click(object sender, EventArgs e)
        {

        }
    }
}
