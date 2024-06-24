using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsageDeskband
{
    public partial class DeskBandUI : UserControl
    {
        private PerformanceCounter cpuCounter;
        public DeskBandUI()
        {
            InitializeComponent();

            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float cpuUsage = cpuCounter.NextValue();

            label1.Text = $"{(int)cpuUsage} %";
        }
    }
}
