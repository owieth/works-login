using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uebung_Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void radioButtonCelsius_CheckedChanged(object sender, EventArgs e)
        {
            lblUnit01.Text = "°C";
        }

        private void radioButtonFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            lblUnit01.Text = "°F";
        }

        private void radioButtonKelvin_CheckedChanged(object sender, EventArgs e)
        {
            lblUnit01.Text = "K";
        }

        private void radioButtonCelsius2_CheckedChanged(object sender, EventArgs e)
        {
            lblUnit02.Text = "°C";
        }

        private void radioButtonFahrenheit2_CheckedChanged(object sender, EventArgs e)
        {
            lblUnit02.Text = "°F";
        }

        private void radioButtonKelvin2_CheckedChanged(object sender, EventArgs e)
        {
            lblUnit02.Text = "K";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (radioButtonCelsius.Checked && radioButtonCelsius2.Checked)
            {
                lblOutput.Text = Convert.ToString(numericUpDown01.Value);
            }
            else if (radioButtonCelsius.Checked && radioButtonFahrenheit2.Checked)
            {
                double _volume01;
                _volume01 = Convert.ToDouble(numericUpDown01.Value);
                double _result;
                _result = _volume01 * 1.8 + 32;

                lblOutput.Text = Convert.ToString(_result);
            }
            else if (radioButtonCelsius.Checked && radioButtonKelvin2.Checked)
            {
                double _volume02;
                _volume02 = Convert.ToDouble(numericUpDown01.Value);
                double _result;
                _result = _volume02 + 273.15;

                lblOutput.Text = Convert.ToString(_result);
            }
            else if (radioButtonFahrenheit.Checked && radioButtonCelsius2.Checked)
            {
                double _volume03;
                _volume03 = Convert.ToDouble(numericUpDown01.Value);
                double _result;
                _result = _volume03 - 32 / 1.8;

                lblOutput.Text = Convert.ToString(_result);
            }
            else if (radioButtonFahrenheit.Checked && radioButtonFahrenheit2.Checked)
            {
                lblOutput.Text = Convert.ToString(numericUpDown01.Value);
            }
            else if (radioButtonFahrenheit.Checked && radioButtonKelvin2.Checked)
            {
                double _volume04;
                _volume04 = Convert.ToDouble(numericUpDown01.Value);
                double _result;
                _result = _volume04 + 459.67 / 1.8;

                lblOutput.Text = Convert.ToString(_result);
            }
            else if (radioButtonKelvin.Checked && radioButtonCelsius2.Checked)
            {
                double _volume05;
                _volume05 = Convert.ToDouble(numericUpDown01.Value);
                double _result;
                _result = _volume05 - 273.15;

                lblOutput.Text = Convert.ToString(_result);
            }
            else if (radioButtonKelvin.Checked && radioButtonFahrenheit2.Checked)
            {
                double _volume06;
                _volume06 = Convert.ToDouble(numericUpDown01.Value);
                double _result;
                _result = _volume06 * 1.8 - 459.67;

                lblOutput.Text = Convert.ToString(_result);
            }
            else if (radioButtonKelvin.Checked && radioButtonKelvin2.Checked)
            {
                lblOutput.Text = Convert.ToString(numericUpDown01.Value);
            }
        }
    }
}
