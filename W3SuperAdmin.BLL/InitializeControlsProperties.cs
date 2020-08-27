using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3SuperAdmin.BLL
{
    public class InitializeControlsProperties
    {
        public static void TrackBars(IEnumerable<TrackBar> controls)
        {
            foreach (var trackBar in controls)
            {
                trackBar.Maximum = 100;
                trackBar.Minimum = 0;
                trackBar.LargeChange = 1;
                trackBar.SmallChange = 1;
            }
        }
    }
}
