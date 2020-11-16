namespace FinalProject
{
    partial class HighScoreScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.outputLABLE = new System.Windows.Forms.Label();
            this.playAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DimGray;
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(343, 304);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 32);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outputLABLE
            // 
            this.outputLABLE.AutoSize = true;
            this.outputLABLE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.outputLABLE.ForeColor = System.Drawing.Color.DarkRed;
            this.outputLABLE.Location = new System.Drawing.Point(18, 257);
            this.outputLABLE.Name = "outputLABLE";
            this.outputLABLE.Size = new System.Drawing.Size(0, 13);
            this.outputLABLE.TabIndex = 1;
            // 
            // playAgain
            // 
            this.playAgain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playAgain.ForeColor = System.Drawing.Color.Red;
            this.playAgain.Location = new System.Drawing.Point(4, 312);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(75, 23);
            this.playAgain.TabIndex = 2;
            this.playAgain.Text = "Play Again";
            this.playAgain.UseVisualStyleBackColor = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // HighScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.FinalProjectHighScoreScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.outputLABLE);
            this.Controls.Add(this.exitButton);
            this.Name = "HighScoreScreen";
            this.Size = new System.Drawing.Size(454, 339);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label outputLABLE;
        private System.Windows.Forms.Button playAgain;
    }
}
