namespace FinalProject
{
    partial class PauseScreen
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
            this.continueButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.Maroon;
            this.continueButton.ForeColor = System.Drawing.Color.DarkGray;
            this.continueButton.Location = new System.Drawing.Point(58, 276);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 23);
            this.continueButton.TabIndex = 0;
            this.continueButton.Text = "Continue?";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Maroon;
            this.exitButton.ForeColor = System.Drawing.Color.DarkGray;
            this.exitButton.Location = new System.Drawing.Point(254, 276);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // PauseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.FinalProjectPauseScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.continueButton);
            this.Name = "PauseScreen";
            this.Size = new System.Drawing.Size(378, 318);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button exitButton;
    }
}
