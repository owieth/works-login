namespace Programm_zur_Öffnung_anderer_Programmen
{
    partial class frmProgramm
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
            this.btnSpotify = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnMoodle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpotify
            // 
            this.btnSpotify.Location = new System.Drawing.Point(12, 12);
            this.btnSpotify.Name = "btnSpotify";
            this.btnSpotify.Size = new System.Drawing.Size(156, 98);
            this.btnSpotify.TabIndex = 1;
            this.btnSpotify.Text = "Spotify";
            this.btnSpotify.UseVisualStyleBackColor = true;
            this.btnSpotify.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(174, 12);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(156, 98);
            this.btnWord.TabIndex = 2;
            this.btnWord.Text = "Word 2016";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 116);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(156, 98);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LoginWebseiten";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnMoodle
            // 
            this.btnMoodle.Location = new System.Drawing.Point(174, 116);
            this.btnMoodle.Name = "btnMoodle";
            this.btnMoodle.Size = new System.Drawing.Size(156, 98);
            this.btnMoodle.TabIndex = 4;
            this.btnMoodle.Text = "Moodle";
            this.btnMoodle.UseVisualStyleBackColor = true;
            // 
            // frmProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 434);
            this.Controls.Add(this.btnMoodle);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnSpotify);
            this.Name = "frmProgramm";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSpotify;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnMoodle;
    }
}

