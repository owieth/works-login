namespace FlappyBird
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
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.pbPipe1 = new System.Windows.Forms.PictureBox();
            this.pbPipe2 = new System.Windows.Forms.PictureBox();
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.lblAussage = new System.Windows.Forms.Label();
            this.lblPunktzahl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGround
            // 
            this.pbGround.BackColor = System.Drawing.Color.Transparent;
            this.pbGround.Image = global::FlappyBird.Properties.Resources.ground;
            this.pbGround.Location = new System.Drawing.Point(-2, 550);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(499, 50);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 0;
            this.pbGround.TabStop = false;
            // 
            // pbPipe1
            // 
            this.pbPipe1.BackColor = System.Drawing.Color.Transparent;
            this.pbPipe1.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pbPipe1.Location = new System.Drawing.Point(368, 320);
            this.pbPipe1.Name = "pbPipe1";
            this.pbPipe1.Size = new System.Drawing.Size(100, 233);
            this.pbPipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe1.TabIndex = 1;
            this.pbPipe1.TabStop = false;
            // 
            // pbPipe2
            // 
            this.pbPipe2.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pbPipe2.Location = new System.Drawing.Point(216, -1);
            this.pbPipe2.Name = "pbPipe2";
            this.pbPipe2.Size = new System.Drawing.Size(100, 165);
            this.pbPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe2.TabIndex = 2;
            this.pbPipe2.TabStop = false;
            // 
            // pbBird
            // 
            this.pbBird.Image = global::FlappyBird.Properties.Resources.bird;
            this.pbBird.Location = new System.Drawing.Point(67, 184);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(89, 67);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBird.TabIndex = 3;
            this.pbBird.TabStop = false;
            // 
            // lblAussage
            // 
            this.lblAussage.AutoSize = true;
            this.lblAussage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAussage.Location = new System.Drawing.Point(12, 424);
            this.lblAussage.Name = "lblAussage";
            this.lblAussage.Size = new System.Drawing.Size(237, 72);
            this.lblAussage.TabIndex = 4;
            this.lblAussage.Text = "Game Over!\r\n\r\nDeine Punktzahl beträgt:";
            this.lblAussage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPunktzahl
            // 
            this.lblPunktzahl.AutoSize = true;
            this.lblPunktzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunktzahl.Location = new System.Drawing.Point(255, 471);
            this.lblPunktzahl.Name = "lblPunktzahl";
            this.lblPunktzahl.Size = new System.Drawing.Size(38, 25);
            this.lblPunktzahl.TabIndex = 5;
            this.lblPunktzahl.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(67, 320);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 75);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Spiel starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmSpiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 601);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblPunktzahl);
            this.Controls.Add(this.lblAussage);
            this.Controls.Add(this.pbBird);
            this.Controls.Add(this.pbPipe2);
            this.Controls.Add(this.pbPipe1);
            this.Controls.Add(this.pbGround);
            this.Name = "frmSpiel";
            this.Text = "FlappyBird";
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.PictureBox pbPipe1;
        private System.Windows.Forms.PictureBox pbPipe2;
        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.Label lblAussage;
        private System.Windows.Forms.Label lblPunktzahl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
    }
}

