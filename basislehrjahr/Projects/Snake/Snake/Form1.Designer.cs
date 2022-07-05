namespace Snake
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
            this.lblPunkte = new System.Windows.Forms.Label();
            this.txtPunkte = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbSnake = new System.Windows.Forms.PictureBox();
            this.pbEssen = new System.Windows.Forms.PictureBox();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.pnlSpielfeld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEssen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSpielfeld
            // 
            this.pnlSpielfeld.BackColor = System.Drawing.Color.LightGreen;
            this.pnlSpielfeld.Controls.Add(this.pbEssen);
            this.pnlSpielfeld.Controls.Add(this.pbSnake);
            this.pnlSpielfeld.Location = new System.Drawing.Point(12, 12);
            this.pnlSpielfeld.Name = "pnlSpielfeld";
            this.pnlSpielfeld.Size = new System.Drawing.Size(420, 315);
            this.pnlSpielfeld.TabIndex = 0;
            // 
            // lblPunkte
            // 
            this.lblPunkte.AutoSize = true;
            this.lblPunkte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunkte.Location = new System.Drawing.Point(12, 340);
            this.lblPunkte.Name = "lblPunkte";
            this.lblPunkte.Size = new System.Drawing.Size(72, 20);
            this.lblPunkte.TabIndex = 1;
            this.lblPunkte.Text = "Punkte:";
            // 
            // txtPunkte
            // 
            this.txtPunkte.Location = new System.Drawing.Point(91, 337);
            this.txtPunkte.Name = "txtPunkte";
            this.txtPunkte.Size = new System.Drawing.Size(100, 22);
            this.txtPunkte.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(208, 337);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbSnake
            // 
            this.pbSnake.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbSnake.Location = new System.Drawing.Point(15, 263);
            this.pbSnake.Name = "pbSnake";
            this.pbSnake.Size = new System.Drawing.Size(10, 35);
            this.pbSnake.TabIndex = 0;
            this.pbSnake.TabStop = false;
            // 
            // pbEssen
            // 
            this.pbEssen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbEssen.Location = new System.Drawing.Point(196, 115);
            this.pbEssen.Name = "pbEssen";
            this.pbEssen.Size = new System.Drawing.Size(10, 10);
            this.pbEssen.TabIndex = 1;
            this.pbEssen.TabStop = false;
            // 
            // tmrSpiel
            // 
            this.tmrSpiel.Tick += new System.EventHandler(this.tmrSpiel_Tick);
            // 
            // frmSpiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 383);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPunkte);
            this.Controls.Add(this.lblPunkte);
            this.Controls.Add(this.pnlSpielfeld);
            this.MaximizeBox = false;
            this.Name = "frmSpiel";
            this.Text = "Snake";
            this.pnlSpielfeld.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSnake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEssen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSpielfeld;
        private System.Windows.Forms.Label lblPunkte;
        private System.Windows.Forms.TextBox txtPunkte;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbSnake;
        private System.Windows.Forms.PictureBox pbEssen;
        private System.Windows.Forms.Timer tmrSpiel;
    }
}

