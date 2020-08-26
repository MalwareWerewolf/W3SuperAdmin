using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3SuperAdmin.BLL
{
    public class InitializeControlsProperties
    {
        public static void MetroTrackBars(IEnumerable<MetroTrackBar> controls)
        {
            foreach (var trackBar in controls)
            {
                trackBar.Maximum = 100;
                trackBar.LargeChange = 1;
                trackBar.SmallChange = 1;
            }
        }

        public static void SetButtonIcon(Button btn, string imageName)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            // Assign an image to the button.
            btn.Image = Image.FromFile(string.Concat(projectDirectory, @"\Resources\", imageName, ".png"));
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.TextAlign = ContentAlignment.MiddleRight;
            btn.ImageAlign = ContentAlignment.MiddleLeft;
        }
    }
}
