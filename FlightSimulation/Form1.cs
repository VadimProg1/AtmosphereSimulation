using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSimulation
{
    public partial class Form1 : Form
    {
        decimal t, x0, y0, v0, cosA, sinA;
        const decimal dt = 0.1M, g = 9.81M;
        bool isPaused = false;
        double seconds = 0;
        int minutes = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled && !isPaused)
            {
                isPaused = true;
                timer1.Stop();
                button_pause.Text = "Unpause";
            }
            else if (isPaused)
            {
                isPaused = false;
                timer1.Start();
                button_pause.Text = "Pause";
            }
        }

        private void button_launch_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled && !isPaused)
            {
                seconds = 0;
                minutes = 0;
                chart1.Series[0].Points.Clear();
                t = 0;
                x0 = 0;
                y0 = numeric_height.Value;
                v0 = numeric_speed.Value;
                double a = (double)numeric_angle.Value * Math.PI / 180;
                cosA = (decimal)Math.Cos(a);
                sinA = (decimal)Math.Sin(a);
                chart1.Series[0].Points.AddXY(x0, y0);
                timer1.Start();
            }
            
        }

        private void UpdateTime()
        {
            if(seconds >= 60)
            {
                seconds = 0;
                minutes++;
                label_minutes.Text = minutes.ToString();
            }
            else
            {
                int secToInt = Convert.ToInt32(seconds);
                label_seconds.Text = secToInt.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;
            decimal x = x0 + v0 * cosA * t;
            decimal y = y0 + v0 * sinA * t - g * t * t / 2;
            if(y <= 0)
            {
                timer1.Stop();
            }
            else
            {
                seconds += 0.1;            
            }
            chart1.Series[0].Points.AddXY(x, y);
            UpdateTime();

        }
    }
}
