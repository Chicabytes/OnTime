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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartTime();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void StartTime()
        {
            Timer timer = new Timer();
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
    }
}
