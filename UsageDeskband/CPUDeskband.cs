using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpShell.Attributes;
using SharpShell.SharpDeskBand;

namespace UsageDeskband
{
    [ComVisible(true)]
    [DisplayName("CPU Usage")]
    public class CPUDeskband : SharpDeskBand
    {
        protected override UserControl CreateDeskBand()
        {
            return new DeskBandUI();
        }

        protected override BandOptions GetBandOptions()
        {
            return new BandOptions()
            {
                HasVariableHeight = false,
                IsSunken = false,
                ShowTitle = true,
                Title = "CPU Usage",
                UseBackgroundColour = false,
                AlwaysShowGripper = true
            };
        }
    }
}
