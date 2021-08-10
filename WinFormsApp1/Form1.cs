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

        void timercall()
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 100;
            timer1.Enabled = false;
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 100;
            timer2.Enabled = false;
            timer3.Tick += new EventHandler(timer3_Tick);
            timer3.Interval = 100;
            timer3.Enabled = false;
            timer4.Tick += new EventHandler(timer4_Tick);
            timer4.Interval = 100;
            timer4.Enabled = false;
        }

        Timer timer1 = new Timer();
        Timer timer2 = new Timer();
        Timer timer3 = new Timer();
        Timer timer4 = new Timer();
        int x1;
        int y1;

        private void Form1_Load(object sender, EventArgs e)
        {
            timercall();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Form1_KeyUp);
        }
        private void timer1_Tick(object sender, EventArgs e)//「W」キーを押した時の動作
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            Point pt = new Point(x , y - 5);
            pictureBox1.Location = pt;
        }
        private void timer2_Tick(object sender, EventArgs e)//「A」キーを押した時の動作
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            Point pt = new Point(x - 5 , y + 0);
            pictureBox1.Location = pt;
        }
        private void timer3_Tick(object sender, EventArgs e)//「S」キーを押した時の動作
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            Point pt = new Point(x , y + 5);
            pictureBox1.Location = pt;
        }
        private void timer4_Tick(object sender, EventArgs e)//「D」キーを押した時の動作
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            Point pt = new Point(x + 5, y);
            pictureBox1.Location = pt;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                timer1.Enabled = true;

            if (e.KeyCode == Keys.A)
                timer2.Enabled = true;

            if (e.KeyCode == Keys.S)
                timer3.Enabled = true;

            if (e.KeyCode == Keys.D)
                timer4.Enabled = true;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                timer1.Enabled = false;

            if (e.KeyCode == Keys.A)
                timer2.Enabled = false;

            if (e.KeyCode == Keys.S)
                timer3.Enabled = false;

            if (e.KeyCode == Keys.D)
                timer4.Enabled = false;
        }
    }
}
