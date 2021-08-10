using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Timer timer = new Timer();
        int x1;
        int y1;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 100;
            timer.Enabled = false;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Form1_KeyUp);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            Point pt = new Point(x+5, y+5);
            pictureBox1.Location = pt;

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            timer.Enabled = true;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            timer.Enabled = false;
        }
    }
}
