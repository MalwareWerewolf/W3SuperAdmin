using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace W3SuperAdmin.BLL
{
    public partial class SettingsFormBLL
    {
        private const string strHigh = "High";
        private const string strMedium = "Medium";
        private const string strLow = "Low";

        private const string strON = "ON";
        private const string strOFF = "OFF";

        private const string strWindowWidth = "windowwidth";
        private const string strWindowHeight = "windowheight";

        private const string strWindowed = "Windowed";
        private const string strWindowedFullscreen = "Windowed Fullscreen";
        private const string strFullscreen = "Fullscreen";

        private const string baseComboBoxNameThreeOptions = "comboBoxThreeOptions";
        private const string baseComboBoxNameBoolOptions = "comboBoxBoolOptions";
        private const string comboBoxScreenResolutionName = "comboBoxScreenResolution";
        private const string comboBoxWindowModeName = "comboBoxWindowMode";
        private const string baseComboBoxBitOptionsName = "comboBoxBitOptions";

        private const string baseTrackBarName = "trackBar";

        private const string baseTextBoxName = "textBox";

        private string ConvertComboBoxIntValueToString(int value)
        {
            if (value == 1)
            {
                return strMedium;
            }
            else if (value == 2)
            {
                return strHigh;
            }

            return strLow;
        }

        private string ConvertComboBoxIntValueToWindowMode(int value)
        {
            if (value == 1)
            {
                return "Windowed Fullscreen";
            }
            else if (value == 2)
            {
                return "Fullscreen";
            }

            return "Windowed";
        }

        private string ConvertComboBoxBoolValueToString(int value)
        {
            if (value == 0)
            {
                return "OFF";
            }
            else
            {
                return "ON";
            }
        }

        private int ConvertComboBoxValueToInt(string value)
        {
            if (value.Contains("bit"))
            {
                value = value.Replace("bit", string.Empty);
                return Int16.Parse(value);
            }
            else if (value.Equals(strHigh) || value.Equals(strFullscreen))
            {
                return 2;
            }
            else if (value.Equals(strMedium) || value.Equals(strON) || value.Equals(strWindowedFullscreen))
            {
                return 1;
            }
            else if (value.Equals(strLow) || value.Equals(strOFF) || value.Equals(strWindowed))
            {
                return 0;
            }

            return -1;
        }

        private int GetTrackBarValueOnLoadForm(string trackBarName, GroupBox groupBox, Key keyVideo = null)
        {
            object keyValue = null;

            if (groupBox.Controls[trackBarName] is TrackBar trackBar)
            {
                if (keyVideo != null)
                {
                    keyValue = keyVideo.Values.FirstOrDefault(k => k.Key == trackBar.Name.Replace(baseTrackBarName, string.Empty).Replace("_", string.Empty).ToLower()).Value;

                    if (keyValue != null)
                    {
                        return trackBar.Value = (int)keyValue;
                    }
                }

                return trackBar.Value;
            }

            return -1;
        }

        private void SetTrackBarText(Control control, GroupBox groupBox, Key key)
        {
            int trackBarValue;

            trackBarValue = GetTrackBarValueOnLoadForm(control.Name.Replace("Label", string.Empty), groupBox, key);

            if (trackBarValue != -1)
            {
                control.Text = string.Concat(control.Name.Replace(SettingsFormBLL.baseTrackBarLabelName, string.Empty).Replace("_", " "), " ", trackBarValue, "%");
            }
        }

        private void SetRegistryValueWithTrackBar(Control control, GroupBox groupBox, string[] subKeyNames, RegistryKey key)
        {
            int trackBarValue;
            string subKeyName;
            object subKeyValue = null;

            trackBarValue = GetTrackBarValueOnLoadForm(control.Name, groupBox);
            subKeyName = subKeyNames.FirstOrDefault(s => s == control.Name.Replace(baseTrackBarName, string.Empty).Replace("_", string.Empty).ToLower());

            if (trackBarValue != -1 && subKeyName != null && subKeyValue != key.GetValue(subKeyName))
            {
                key.SetValue(subKeyName, trackBarValue);
            }
        }

        private void SetComboBoxBoolOptionsLabelText(Control control, Key key) {
            object keyValue = null;

            if (control.Name.Contains("Replay"))
            {
                keyValue = key.Values.FirstOrDefault(k => k.Key == control.Name.Replace(baseComboBoxNameBoolOptions, string.Empty).Replace("_", string.Empty)).Value;
            }
            else {
                keyValue = key.Values.FirstOrDefault(k => k.Key == control.Name.Replace(baseComboBoxNameBoolOptions, string.Empty).ToLower()).Value;
            }

            if (keyValue != null)
            {
                control.Text = ConvertComboBoxBoolValueToString((int)keyValue);
            }
        }
    }
}
