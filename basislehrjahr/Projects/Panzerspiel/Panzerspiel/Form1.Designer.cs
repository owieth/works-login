namespace Panzerspiel
{
    partial class frmSpiel
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
            this.components = new System.ComponentModel.Container();
            this.pnlSpielfeld = new System.Windows.Forms.Panel();
            this.btnHindernis2 = new System.Windows.Forms.Button();
            this.btnHindernis1 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.btnPanzer2 = new System.Windows.Forms.Button();
            this.btnPanzer1 = new System.Windows.Forms.Button();
            this.pbBase2 = new System.Windows.Forms.PictureBox();
            this.pbBase1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlSpielfeld.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBase2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBase1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSpielfeld
            // 
            this.pnlSpielfeld.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlSpielfeld.Controls.Add(this.button1);
            this.pnlSpielfeld.Controls.Add(this.btnPanzer2);
            this.pnlSpielfeld.Controls.Add(this.btnPanzer1);
            this.pnlSpielfeld.Controls.Add(this.pbBase2);
            this.pnlSpielfeld.Controls.Add(this.pbBase1);
            this.pnlSpielfeld.Controls.Add(this.btnHindernis2);
            this.pnlSpielfeld.Controls.Add(this.btnHindernis1);
            this.pnlSpielfeld.Location = new System.Drawing.Point(12, 68);
            this.pnlSpielfeld.Name = "pnlSpielfeld";
            this.pnlSpielfeld.Size = new System.Drawing.Size(740, 449);
            this.pnlSpielfeld.TabIndex = 0;
            // 
            // btnHindernis2
            // 
            this.btnHindernis2.Location = new System.Drawing.Point(341, 118);
            this.btnHindernis2.Name = "btnHindernis2";
            this.btnHindernis2.Size = new System.Drawing.Size(40, 208);
            this.btnHindernis2.TabIndex = 5;
            this.btnHindernis2.UseVisualStyleBackColor = true;
            // 
            // btnHindernis1
            // 
            this.btnHindernis1.Location = new System.Drawing.Point(107, 241);
            this.btnHindernis1.Name = "btnHindernis1";
            this.btnHindernis1.Size = new System.Drawing.Size(40, 208);
            this.btnHindernis1.TabIndex = 4;
            this.btnHindernis1.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Spieler 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(122, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Spieler 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(131, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spieler:";
            // 
            // btnPanzer2
            // 
            this.btnPanzer2.BackgroundImage = global::Panzerspiel.Properties.Resources.tank2;
            this.btnPanzer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPanzer2.Location = new System.Drawing.Point(664, 16);
            this.btnPanzer2.Name = "btnPanzer2";
            this.btnPanzer2.Size = new System.Drawing.Size(60, 60);
            this.btnPanzer2.TabIndex = 10;
            this.btnPanzer2.UseVisualStyleBackColor = true;
            // 
            // btnPanzer1
            // 
            this.btnPanzer1.BackgroundImage = global::Panzerspiel.Properties.Resources.tank;
            this.btnPanzer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPanzer1.Location = new System.Drawing.Point(23, 369);
            this.btnPanzer1.Name = "btnPanzer1";
            this.btnPanzer1.Size = new System.Drawing.Size(60, 60);
            this.btnPanzer1.TabIndex = 9;
            this.btnPanzer1.UseVisualStyleBackColor = true;
            // 
            // pbBase2
            // 
            this.pbBase2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pbBase2.Location = new System.Drawing.Point(640, 0);
            this.pbBase2.Name = "pbBase2";
            this.pbBase2.Size = new System.Drawing.Size(100, 50);
            this.pbBase2.TabIndex = 8;
            this.pbBase2.TabStop = false;
            // 
            // pbBase1
            // 
            this.pbBase1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pbBase1.Location = new System.Drawing.Point(4, 396);
            this.pbBase1.Name = "pbBase1";
            this.pbBase1.Size = new System.Drawing.Size(100, 50);
            this.pbBase1.TabIndex = 7;
            this.pbBase1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 208);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmSpiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 529);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlSpielfeld);
            this.Name = "frmSpiel";
            this.Text = "Panzer-Battleground";
            this.pnlSpielfeld.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBase2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBase1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSpielfeld;
        private System.Windows.Forms.Button btnHindernis2;
        private System.Windows.Forms.Button btnHindernis1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbBase2;
        private System.Windows.Forms.PictureBox pbBase1;
        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.Button btnPanzer1;
        private System.Windows.Forms.Button btnPanzer2;
        private System.Windows.Forms.Button button1;
    }
}

