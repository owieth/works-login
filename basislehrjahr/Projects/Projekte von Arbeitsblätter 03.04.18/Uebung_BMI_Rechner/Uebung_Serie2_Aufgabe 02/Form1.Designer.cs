namespace Uebung_Serie2_Aufgabe_02
{
    partial class frmBMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBMI));
            this.lblText = new System.Windows.Forms.Label();
            this.lblGewicht = new System.Windows.Forms.Label();
            this.lblGroesse = new System.Windows.Forms.Label();
            this.txtGewicht = new System.Windows.Forms.TextBox();
            this.txtGroesse = new System.Windows.Forms.TextBox();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.txtWert = new System.Windows.Forms.RichTextBox();
            this.txtKategorie = new System.Windows.Forms.RichTextBox();
            this.btnBerechnung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(327, 17);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Zur Berechnung  benötigen wir folgende Angaben:";
            // 
            // lblGewicht
            // 
            this.lblGewicht.AutoSize = true;
            this.lblGewicht.Location = new System.Drawing.Point(12, 37);
            this.lblGewicht.Name = "lblGewicht";
            this.lblGewicht.Size = new System.Drawing.Size(82, 17);
            this.lblGewicht.TabIndex = 1;
            this.lblGewicht.Text = "Ihr Gewicht:";
            // 
            // lblGroesse
            // 
            this.lblGroesse.AutoSize = true;
            this.lblGroesse.Location = new System.Drawing.Point(12, 66);
            this.lblGroesse.Name = "lblGroesse";
            this.lblGroesse.Size = new System.Drawing.Size(86, 17);
            this.lblGroesse.TabIndex = 2;
            this.lblGroesse.Text = "Ihre Grösse:";
            // 
            // txtGewicht
            // 
            this.txtGewicht.Location = new System.Drawing.Point(137, 34);
            this.txtGewicht.Name = "txtGewicht";
            this.txtGewicht.Size = new System.Drawing.Size(100, 22);
            this.txtGewicht.TabIndex = 3;
            // 
            // txtGroesse
            // 
            this.txtGroesse.Location = new System.Drawing.Point(137, 66);
            this.txtGroesse.Name = "txtGroesse";
            this.txtGroesse.Size = new System.Drawing.Size(100, 22);
            this.txtGroesse.TabIndex = 4;
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.Location = new System.Drawing.Point(12, 196);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(108, 17);
            this.lblAusgabe.TabIndex = 5;
            this.lblAusgabe.Text = "Ihr BMI beträgt: ";
            // 
            // txtWert
            // 
            this.txtWert.Location = new System.Drawing.Point(137, 193);
            this.txtWert.Name = "txtWert";
            this.txtWert.Size = new System.Drawing.Size(153, 29);
            this.txtWert.TabIndex = 7;
            this.txtWert.Text = "";
            // 
            // txtKategorie
            // 
            this.txtKategorie.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKategorie.Location = new System.Drawing.Point(296, 193);
            this.txtKategorie.Name = "txtKategorie";
            this.txtKategorie.Size = new System.Drawing.Size(164, 29);
            this.txtKategorie.TabIndex = 8;
            this.txtKategorie.Text = "";
            // 
            // btnBerechnung
            // 
            this.btnBerechnung.Location = new System.Drawing.Point(137, 95);
            this.btnBerechnung.Name = "btnBerechnung";
            this.btnBerechnung.Size = new System.Drawing.Size(100, 34);
            this.btnBerechnung.TabIndex = 9;
            this.btnBerechnung.Text = "Berechnung";
            this.btnBerechnung.UseVisualStyleBackColor = true;
            this.btnBerechnung.Click += new System.EventHandler(this.btnBerechnung_Click);
            // 
            // frmBMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 247);
            this.Controls.Add(this.btnBerechnung);
            this.Controls.Add(this.txtKategorie);
            this.Controls.Add(this.txtWert);
            this.Controls.Add(this.lblAusgabe);
            this.Controls.Add(this.txtGroesse);
            this.Controls.Add(this.txtGewicht);
            this.Controls.Add(this.lblGroesse);
            this.Controls.Add(this.lblGewicht);
            this.Controls.Add(this.lblText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBMI";
            this.Text = "BMI-Berechnung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblGewicht;
        private System.Windows.Forms.Label lblGroesse;
        private System.Windows.Forms.TextBox txtGewicht;
        private System.Windows.Forms.TextBox txtGroesse;
        private System.Windows.Forms.Label lblAusgabe;
        private System.Windows.Forms.RichTextBox txtWert;
        private System.Windows.Forms.RichTextBox txtKategorie;
        private System.Windows.Forms.Button btnBerechnung;
    }
}

