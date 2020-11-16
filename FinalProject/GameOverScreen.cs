using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            HighScoreScreen cs = new HighScoreScreen();

            Form f = this.FindForm();

            f.Controls.Remove(this);


            f.Controls.Add(cs);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
