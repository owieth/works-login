using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Programm_zur_Öffnung_anderer_Programmen
{
    public partial class frmProgramm : Form
    {
        public frmProgramm()
        {
            InitializeComponent();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\olivier.winkler\AppData\Roaming\Spotify\Spotify.exe");
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Microsoft Office\Office16\WINWORD.exe"); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\olivier.winkler\Desktop\LoginWebsiten.exe");
        }
    }
}
