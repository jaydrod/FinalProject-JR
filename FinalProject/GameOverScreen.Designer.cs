namespace FinalProject
{
    partial class GameOverScreen
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
            this.playAgain = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playAgain
            // 
            this.playAgain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playAgain.Location = new System.Drawing.Point(370, 33);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(75, 64);
            this.playAgain.TabIndex = 0;
            this.playAgain.Text = "View score and play again";
            this.playAgain.UseVisualStyleBackColor = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitButton.Location = new System.Drawing.Point(370, 213);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit ";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.FinalProjectGameOverScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playAgain);
            this.DoubleBuffered = true;
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(448, 381);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Button exitButton;
    }
}
