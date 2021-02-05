using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTime
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
            StartTime();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void StartTime()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Enabled = true;
            timer.Interval = 1000; // 1 seconds
            DateTime SystemStartTime = DateTime.Now.AddMilliseconds(-Environment.TickCount);
            var Uptime = DateTime.Now - SystemStartTime;
            timer.Tick += (o, args) =>
            {
                InfoLabel.Text = (DateTime.Now - SystemStartTime).ToString(@"hh\:mm\:ss");
            };
            timer.Start();
        }

        private void Timer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.D1))
            {
                this.BackgroundImage = Properties.Resources.Yellow;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.D2))
            {
                this.BackgroundImage = Properties.Resources.blue;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.D3))
            {
                this.BackgroundImage = Properties.Resources.cyan;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.D4))
            {
                this.BackgroundImage = Properties.Resources.green;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.D5))
            {
                this.BackgroundImage = Properties.Resources.hot_pink;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.D6))
            {
                this.BackgroundImage = Properties.Resources.lavanda;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.D7))
            {
                this.BackgroundImage = Properties.Resources.orange;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.D8))
            {
                this.BackgroundImage = Properties.Resources.red;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.D0))
            {
                this.BackgroundImage = null;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Close();
            }
        }
    }
}
