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
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen cs = new GameScreen();
            f.Controls.Add(cs);
            cs.Focus(); 
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
