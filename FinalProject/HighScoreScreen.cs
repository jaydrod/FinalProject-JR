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
    public partial class HighScoreScreen : UserControl
    {
        public HighScoreScreen()
        {
            InitializeComponent();
            outputLABLE.Text = Form1.timer + "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainScreen cs = new MainScreen();
            f.Controls.Add(cs);
        }
    }
}
