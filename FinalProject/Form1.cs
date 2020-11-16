using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public static int timer = 0;
        public static Image MonsterImage;

        public Form1()
        {
            InitializeComponent();
        }

        // Create an instance of the MainScreen 

        private void Form1_Load_1(object sender, EventArgs e)
        {
            MainScreen cs = new MainScreen();
            this.Controls.Add(cs);
        }
    }
}
