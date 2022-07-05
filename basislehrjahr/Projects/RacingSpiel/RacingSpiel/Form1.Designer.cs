namespace RacingSpiel
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblDistance2 = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.pnlStrasse = new System.Windows.Forms.Panel();
            this.pbRoadTrack1 = new System.Windows.Forms.PictureBox();
            this.pbRoadTrack2 = new System.Windows.Forms.PictureBox();
            this.pbCar1 = new System.Windows.Forms.PictureBox();
            this.pbCar2 = new System.Windows.Forms.PictureBox();
            this.pbExplosion = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbTrophy = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlStrasse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadTrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExplosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrophy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(123, 498);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 60);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(98, 458);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(111, 25);
            this.lblDistance.TabIndex = 1;
            this.lblDistance.Text = "Distance:";
            // 
            // lblDistance2
            // 
            this.lblDistance2.AutoSize = true;
            this.lblDistance2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance2.Location = new System.Drawing.Point(215, 458);
            this.lblDistance2.Name = "lblDistance2";
            this.lblDistance2.Size = new System.Drawing.Size(38, 25);
            this.lblDistance2.TabIndex = 2;
            this.lblDistance2.Text = "00";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(5, 569);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(388, 75);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "Avoid other cars and get points\r\n\r\nUse Left and Right Key to Move the car\r\n";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStrasse
            // 
            this.pnlStrasse.BackColor = System.Drawing.Color.Black;
            this.pnlStrasse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStrasse.Controls.Add(this.pbTrophy);
            this.pnlStrasse.Controls.Add(this.pbPlayer);
            this.pnlStrasse.Controls.Add(this.pbExplosion);
            this.pnlStrasse.Controls.Add(this.pbCar2);
            this.pnlStrasse.Controls.Add(this.pbCar1);
            this.pnlStrasse.Controls.Add(this.pbRoadTrack2);
            this.pnlStrasse.Controls.Add(this.pbRoadTrack1);
            this.pnlStrasse.Location = new System.Drawing.Point(7, 12);
            this.pnlStrasse.Name = "pnlStrasse";
            this.pnlStrasse.Size = new System.Drawing.Size(380, 424);
            this.pnlStrasse.TabIndex = 4;
            // 
            // pbRoadTrack1
            // 
            this.pbRoadTrack1.Image = global::RacingSpiel.Properties.Resources.roadTrack;
            this.pbRoadTrack1.Location = new System.Drawing.Point(-2, -2);
            this.pbRoadTrack1.Name = "pbRoadTrack1";
            this.pbRoadTrack1.Size = new System.Drawing.Size(385, 632);
            this.pbRoadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRoadTrack1.TabIndex = 0;
            this.pbRoadTrack1.TabStop = false;
            // 
            // pbRoadTrack2
            // 
            this.pbRoadTrack2.Image = global::RacingSpiel.Properties.Resources.roadTrack;
            this.pbRoadTrack2.Location = new System.Drawing.Point(-7, -2);
            this.pbRoadTrack2.Name = "pbRoadTrack2";
            this.pbRoadTrack2.Size = new System.Drawing.Size(385, 632);
            this.pbRoadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRoadTrack2.TabIndex = 1;
            this.pbRoadTrack2.TabStop = false;
            // 
            // pbCar1
            // 
            this.pbCar1.BackColor = System.Drawing.Color.Transparent;
            this.pbCar1.Image = global::RacingSpiel.Properties.Resources.carGrey;
            this.pbCar1.Location = new System.Drawing.Point(68, 28);
            this.pbCar1.Name = "pbCar1";
            this.pbCar1.Size = new System.Drawing.Size(50, 101);
            this.pbCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar1.TabIndex = 2;
            this.pbCar1.TabStop = false;
            // 
            // pbCar2
            // 
            this.pbCar2.BackColor = System.Drawing.Color.Transparent;
            this.pbCar2.Image = global::RacingSpiel.Properties.Resources.carGreen;
            this.pbCar2.Location = new System.Drawing.Point(274, 79);
            this.pbCar2.Name = "pbCar2";
            this.pbCar2.Size = new System.Drawing.Size(50, 101);
            this.pbCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar2.TabIndex = 3;
            this.pbCar2.TabStop = false;
            // 
            // pbExplosion
            // 
            this.pbExplosion.BackColor = System.Drawing.Color.Transparent;
            this.pbExplosion.Image = global::RacingSpiel.Properties.Resources.explosion;
            this.pbExplosion.Location = new System.Drawing.Point(154, 219);
            this.pbExplosion.Name = "pbExplosion";
            this.pbExplosion.Size = new System.Drawing.Size(64, 64);
            this.pbExplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExplosion.TabIndex = 4;
            this.pbExplosion.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.Image = global::RacingSpiel.Properties.Resources.carYellow;
            this.pbPlayer.Location = new System.Drawing.Point(168, 302);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(50, 101);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 5;
            this.pbPlayer.TabStop = false;
            // 
            // pbTrophy
            // 
            this.pbTrophy.BackColor = System.Drawing.Color.Transparent;
            this.pbTrophy.Image = global::RacingSpiel.Properties.Resources.bronze;
            this.pbTrophy.Location = new System.Drawing.Point(62, 135);
            this.pbTrophy.Name = "pbTrophy";
            this.pbTrophy.Size = new System.Drawing.Size(250, 100);
            this.pbTrophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrophy.TabIndex = 6;
            this.pbTrophy.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSpiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 656);
            this.Controls.Add(this.pnlStrasse);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblDistance2);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSpiel";
            this.Text = "Car Racing Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.moveCar);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stopCar);
            this.pnlStrasse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadTrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExplosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrophy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblDistance2;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Panel pnlStrasse;
        private System.Windows.Forms.PictureBox pbRoadTrack2;
        private System.Windows.Forms.PictureBox pbRoadTrack1;
        private System.Windows.Forms.PictureBox pbCar1;
        private System.Windows.Forms.PictureBox pbCar2;
        private System.Windows.Forms.PictureBox pbExplosion;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbTrophy;
        private System.Windows.Forms.Timer timer1;
    }
}

