namespace login.gruppe5.tetris
{
    partial class Highscore
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
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnEintragen = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSchliessenHighscore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(13, 13);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(357, 22);
            this.txtScore.TabIndex = 0;
            // 
            // btnEintragen
            // 
            this.btnEintragen.Location = new System.Drawing.Point(138, 41);
            this.btnEintragen.Name = "btnEintragen";
            this.btnEintragen.Size = new System.Drawing.Size(88, 25);
            this.btnEintragen.TabIndex = 1;
            this.btnEintragen.Text = "Eintragen";
            this.btnEintragen.UseVisualStyleBackColor = true;
            this.btnEintragen.Click += new System.EventHandler(this.btnEintragen_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(357, 155);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btnSchliessenHighscore
            // 
            this.btnSchliessenHighscore.Location = new System.Drawing.Point(270, 268);
            this.btnSchliessenHighscore.Name = "btnSchliessenHighscore";
            this.btnSchliessenHighscore.Size = new System.Drawing.Size(100, 23);
            this.btnSchliessenHighscore.TabIndex = 3;
            this.btnSchliessenHighscore.Text = "Schliessen";
            this.btnSchliessenHighscore.UseVisualStyleBackColor = true;
            this.btnSchliessenHighscore.Click += new System.EventHandler(this.btnSchliessenHighscore_Click);
            // 
            // Highscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 303);
            this.Controls.Add(this.btnSchliessenHighscore);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnEintragen);
            this.Controls.Add(this.txtScore);
            this.Name = "Highscore";
            this.Text = "Highscore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnEintragen;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSchliessenHighscore;
    }
}