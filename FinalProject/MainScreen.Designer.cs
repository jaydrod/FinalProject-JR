namespace FinalProject
{
    partial class MainScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayGame = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalProject.Properties.Resources.FinalProjectMenuScreen;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 373);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PlayGame
            // 
            this.PlayGame.BackColor = System.Drawing.Color.DimGray;
            this.PlayGame.ForeColor = System.Drawing.Color.DarkRed;
            this.PlayGame.Location = new System.Drawing.Point(37, 300);
            this.PlayGame.Name = "PlayGame";
            this.PlayGame.Size = new System.Drawing.Size(135, 37);
            this.PlayGame.TabIndex = 1;
            this.PlayGame.Text = "Play";
            this.PlayGame.UseVisualStyleBackColor = false;
            this.PlayGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Gray;
            this.exitbutton.ForeColor = System.Drawing.Color.DarkRed;
            this.exitbutton.Location = new System.Drawing.Point(255, 300);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(114, 37);
            this.exitbutton.TabIndex = 2;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.PlayGame);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(486, 373);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PlayGame;
        private System.Windows.Forms.Button exitbutton;
    }
}
