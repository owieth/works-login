namespace Uebung_Calculator
{
    partial class frmCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculator));
            this.lblValue = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.numericUpDown01 = new System.Windows.Forms.NumericUpDown();
            this.lblUnit01 = new System.Windows.Forms.Label();
            this.lblUnit02 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.labelUnit01 = new System.Windows.Forms.Label();
            this.labelUnit02 = new System.Windows.Forms.Label();
            this.radioButtonCelsius = new System.Windows.Forms.RadioButton();
            this.radioButtonFahrenheit = new System.Windows.Forms.RadioButton();
            this.radioButtonKelvin = new System.Windows.Forms.RadioButton();
            this.radioButtonCelsius2 = new System.Windows.Forms.RadioButton();
            this.radioButtonFahrenheit2 = new System.Windows.Forms.RadioButton();
            this.radioButtonKelvin2 = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown01)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(12, 25);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(44, 17);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "Value";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 78);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(48, 17);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            // 
            // numericUpDown01
            // 
            this.numericUpDown01.Location = new System.Drawing.Point(100, 25);
            this.numericUpDown01.Name = "numericUpDown01";
            this.numericUpDown01.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown01.TabIndex = 2;
            // 
            // lblUnit01
            // 
            this.lblUnit01.AutoSize = true;
            this.lblUnit01.Location = new System.Drawing.Point(249, 30);
            this.lblUnit01.Name = "lblUnit01";
            this.lblUnit01.Size = new System.Drawing.Size(64, 17);
            this.lblUnit01.TabIndex = 3;
            this.lblUnit01.Text = "              ";
            // 
            // lblUnit02
            // 
            this.lblUnit02.AutoSize = true;
            this.lblUnit02.Location = new System.Drawing.Point(249, 78);
            this.lblUnit02.Name = "lblUnit02";
            this.lblUnit02.Size = new System.Drawing.Size(64, 17);
            this.lblUnit02.TabIndex = 4;
            this.lblUnit02.Text = "              ";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(100, 78);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(92, 17);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "                     ";
            // 
            // labelUnit01
            // 
            this.labelUnit01.AutoSize = true;
            this.labelUnit01.Location = new System.Drawing.Point(18, 11);
            this.labelUnit01.Name = "labelUnit01";
            this.labelUnit01.Size = new System.Drawing.Size(45, 17);
            this.labelUnit01.TabIndex = 6;
            this.labelUnit01.Text = "Unit 1";
            // 
            // labelUnit02
            // 
            this.labelUnit02.AutoSize = true;
            this.labelUnit02.Location = new System.Drawing.Point(7, 11);
            this.labelUnit02.Name = "labelUnit02";
            this.labelUnit02.Size = new System.Drawing.Size(45, 17);
            this.labelUnit02.TabIndex = 7;
            this.labelUnit02.Text = "Unit 2";
            // 
            // radioButtonCelsius
            // 
            this.radioButtonCelsius.AutoSize = true;
            this.radioButtonCelsius.Location = new System.Drawing.Point(15, 48);
            this.radioButtonCelsius.Name = "radioButtonCelsius";
            this.radioButtonCelsius.Size = new System.Drawing.Size(74, 21);
            this.radioButtonCelsius.TabIndex = 8;
            this.radioButtonCelsius.TabStop = true;
            this.radioButtonCelsius.Text = "Celsius";
            this.radioButtonCelsius.UseVisualStyleBackColor = true;
            this.radioButtonCelsius.CheckedChanged += new System.EventHandler(this.radioButtonCelsius_CheckedChanged);
            // 
            // radioButtonFahrenheit
            // 
            this.radioButtonFahrenheit.AutoSize = true;
            this.radioButtonFahrenheit.Location = new System.Drawing.Point(15, 75);
            this.radioButtonFahrenheit.Name = "radioButtonFahrenheit";
            this.radioButtonFahrenheit.Size = new System.Drawing.Size(97, 21);
            this.radioButtonFahrenheit.TabIndex = 9;
            this.radioButtonFahrenheit.TabStop = true;
            this.radioButtonFahrenheit.Text = "Fahrenheit";
            this.radioButtonFahrenheit.UseVisualStyleBackColor = true;
            this.radioButtonFahrenheit.CheckedChanged += new System.EventHandler(this.radioButtonFahrenheit_CheckedChanged);
            // 
            // radioButtonKelvin
            // 
            this.radioButtonKelvin.AutoSize = true;
            this.radioButtonKelvin.Location = new System.Drawing.Point(15, 102);
            this.radioButtonKelvin.Name = "radioButtonKelvin";
            this.radioButtonKelvin.Size = new System.Drawing.Size(67, 21);
            this.radioButtonKelvin.TabIndex = 10;
            this.radioButtonKelvin.TabStop = true;
            this.radioButtonKelvin.Text = "Kelvin";
            this.radioButtonKelvin.UseVisualStyleBackColor = true;
            this.radioButtonKelvin.CheckedChanged += new System.EventHandler(this.radioButtonKelvin_CheckedChanged);
            // 
            // radioButtonCelsius2
            // 
            this.radioButtonCelsius2.AutoSize = true;
            this.radioButtonCelsius2.Location = new System.Drawing.Point(10, 48);
            this.radioButtonCelsius2.Name = "radioButtonCelsius2";
            this.radioButtonCelsius2.Size = new System.Drawing.Size(74, 21);
            this.radioButtonCelsius2.TabIndex = 11;
            this.radioButtonCelsius2.TabStop = true;
            this.radioButtonCelsius2.Text = "Celsius";
            this.radioButtonCelsius2.UseVisualStyleBackColor = true;
            this.radioButtonCelsius2.CheckedChanged += new System.EventHandler(this.radioButtonCelsius2_CheckedChanged);
            // 
            // radioButtonFahrenheit2
            // 
            this.radioButtonFahrenheit2.AutoSize = true;
            this.radioButtonFahrenheit2.Location = new System.Drawing.Point(10, 75);
            this.radioButtonFahrenheit2.Name = "radioButtonFahrenheit2";
            this.radioButtonFahrenheit2.Size = new System.Drawing.Size(97, 21);
            this.radioButtonFahrenheit2.TabIndex = 12;
            this.radioButtonFahrenheit2.TabStop = true;
            this.radioButtonFahrenheit2.Text = "Fahrenheit";
            this.radioButtonFahrenheit2.UseVisualStyleBackColor = true;
            this.radioButtonFahrenheit2.CheckedChanged += new System.EventHandler(this.radioButtonFahrenheit2_CheckedChanged);
            // 
            // radioButtonKelvin2
            // 
            this.radioButtonKelvin2.AutoSize = true;
            this.radioButtonKelvin2.Location = new System.Drawing.Point(10, 102);
            this.radioButtonKelvin2.Name = "radioButtonKelvin2";
            this.radioButtonKelvin2.Size = new System.Drawing.Size(67, 21);
            this.radioButtonKelvin2.TabIndex = 13;
            this.radioButtonKelvin2.TabStop = true;
            this.radioButtonKelvin2.Text = "Kelvin";
            this.radioButtonKelvin2.UseVisualStyleBackColor = true;
            this.radioButtonKelvin2.CheckedChanged += new System.EventHandler(this.radioButtonKelvin2_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(103, 293);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 23);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelUnit01);
            this.groupBox1.Controls.Add(this.radioButtonCelsius);
            this.groupBox1.Controls.Add(this.radioButtonFahrenheit);
            this.groupBox1.Controls.Add(this.radioButtonKelvin);
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 142);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelUnit02);
            this.groupBox2.Controls.Add(this.radioButtonCelsius2);
            this.groupBox2.Controls.Add(this.radioButtonFahrenheit2);
            this.groupBox2.Controls.Add(this.radioButtonKelvin2);
            this.groupBox2.Location = new System.Drawing.Point(139, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 142);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 329);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblUnit02);
            this.Controls.Add(this.lblUnit01);
            this.Controls.Add(this.numericUpDown01);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblValue);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculator";
            this.Text = "Temperature Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown01)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.NumericUpDown numericUpDown01;
        private System.Windows.Forms.Label lblUnit01;
        private System.Windows.Forms.Label lblUnit02;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label labelUnit01;
        private System.Windows.Forms.Label labelUnit02;
        private System.Windows.Forms.RadioButton radioButtonCelsius;
        private System.Windows.Forms.RadioButton radioButtonFahrenheit;
        private System.Windows.Forms.RadioButton radioButtonKelvin;
        private System.Windows.Forms.RadioButton radioButtonCelsius2;
        private System.Windows.Forms.RadioButton radioButtonFahrenheit2;
        private System.Windows.Forms.RadioButton radioButtonKelvin2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

