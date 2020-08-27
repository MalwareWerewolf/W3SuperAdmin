using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3SuperAdmin.BLL
{
    public partial class SettingsFormBLL
    {
        private string _keyPath;
        private string message;
        private string title;

        public static string baseTrackBarLabelName = "trackBarLabel";

        public SettingsFormBLL() { }

        public SettingsFormBLL(string keyPath)
        {
            _keyPath = keyPath;
        }

        public void UpdateRegistryKeys(string keyVideoName, string keySoundName, string keyGameplayName, string keyMiscName, string keyStringName, GroupBox videoGroupBox, GroupBox soundGoupBox, 
            GroupBox gameplayGroupBox, TextBox textBoxCampaignProfile, TextBox textBoxUserLocal)
        {
            object subKeyValue = null;
            string[] subKeyNames;
            string subKeyName = "";

            try
            {
                using (var registryKeyMisc = Registry.CurrentUser.OpenSubKey(string.Concat(_keyPath, @"\", keyMiscName), true))
                {
                    subKeyNames = registryKeyMisc.GetValueNames();
                    subKeyName = subKeyNames.FirstOrDefault(s => s == textBoxCampaignProfile.Name.Replace(baseTextBoxName, string.Empty).ToLower());

                    if (subKeyName != null)
                    {
                        subKeyValue = textBoxCampaignProfile.Text;

                        if (subKeyValue != null && (string)subKeyValue != string.Empty && !subKeyValue.Equals(registryKeyMisc.GetValue(subKeyName)))
                        {
                            registryKeyMisc.SetValue(subKeyName, subKeyValue);
                        }
                    }
                }

                using (var registryKeyString = Registry.CurrentUser.OpenSubKey(string.Concat(_keyPath, @"\", keyStringName), true))
                {
                    subKeyNames = registryKeyString.GetValueNames();
                    subKeyName = subKeyNames.FirstOrDefault(s => s == textBoxUserLocal.Name.Replace(baseTextBoxName, string.Empty).ToLower());

                    if (subKeyName != null)
                    {
                        subKeyValue = textBoxUserLocal.Text;

                        if (subKeyValue != null && (string)subKeyValue != string.Empty && !subKeyValue.Equals(registryKeyString.GetValue(subKeyName)))
                        {
                            registryKeyString.SetValue(subKeyName, subKeyValue);
                        }
                    }
                }

                using (var registryKeyVideo = Registry.CurrentUser.OpenSubKey(string.Concat(_keyPath, @"\", keyVideoName), true))
                {
                    if (registryKeyVideo == null) return;

                    subKeyNames = registryKeyVideo.GetValueNames();
                    int height = 0;
                    int width = 0;

                    foreach (Control control in videoGroupBox.Controls)
                    {
                        if (control.Name.Contains(baseComboBoxNameThreeOptions))
                        {
                            subKeyName = subKeyNames.FirstOrDefault(s => s == control.Name.Replace(baseComboBoxNameThreeOptions, string.Empty).ToLower());
                        }
                        else if (control.Name.Contains(baseComboBoxNameBoolOptions))
                        {
                            subKeyName = subKeyNames.FirstOrDefault(s => s == control.Name.Replace(baseComboBoxNameBoolOptions, string.Empty).ToLower());
                        }
                        else if (control.Name.Contains(baseComboBoxBitOptionsName))
                        {
                            subKeyName = subKeyNames.FirstOrDefault(s => s == control.Name.Replace(baseComboBoxBitOptionsName, string.Empty).ToLower());
                        }
                        else if (control.Name.Contains(comboBoxScreenResolutionName))
                        {
                            width = Int16.Parse(control.Text.Substring(0, control.Text.IndexOf("x")));
                            height = Int16.Parse(control.Text.Substring(control.Text.IndexOf("x") + 1));

                            if (height > 0 && width > 0)
                            {
                                registryKeyVideo.SetValue(strWindowHeight, height);
                                registryKeyVideo.SetValue(strWindowWidth, width);

                                continue;
                            }
                        }
                        else if (control.Name.Contains(comboBoxWindowModeName))
                        {
                            subKeyName = subKeyNames.FirstOrDefault(s => s == control.Name.Replace("comboBox", string.Empty).ToLower());
                        }
                        else if (control.Name.Contains(baseTrackBarName) && !control.Name.Contains("Label"))
                        {
                            SetRegistryValueWithTrackBar(control, videoGroupBox, subKeyNames, registryKeyVideo);
                            continue;
                        }

                        if (subKeyName != null)
                        {
                            subKeyValue = ConvertComboBoxValueToInt(control.Text);

                            if (subKeyValue != null && (int)subKeyValue != -1 && subKeyValue != registryKeyVideo.GetValue(subKeyName))
                            {
                                registryKeyVideo.SetValue(subKeyName, subKeyValue);
                            }
                        }
                    }
                }

                using (var registryKeySound = Registry.CurrentUser.OpenSubKey(string.Concat(_keyPath, @"\", keySoundName), true))
                {
                    subKeyNames = registryKeySound.GetValueNames();

                    foreach (Control control in soundGoupBox.Controls)
                    {
                        if (control.Name.Contains(baseTrackBarName) && !control.Name.Contains("Label"))
                        {
                            SetRegistryValueWithTrackBar(control, soundGoupBox, subKeyNames, registryKeySound);
                            continue;
                        }
                        else if (control.Name.Contains(baseComboBoxNameBoolOptions))
                        {
                            subKeyName = subKeyNames.FirstOrDefault(s => s == control.Name.Replace(baseComboBoxNameBoolOptions, string.Empty).ToLower());
                        }

                        if (subKeyName != null)
                        {
                            subKeyValue = ConvertComboBoxValueToInt(control.Text);

                            if (subKeyValue != null && (int)subKeyValue != -1 && subKeyValue != registryKeySound.GetValue(subKeyName))
                            {
                                registryKeySound.SetValue(subKeyName, subKeyValue);
                            }
                        }
                    }
                }

                using (var registryKeyGameplay = Registry.CurrentUser.OpenSubKey(string.Concat(_keyPath, @"\", keyGameplayName), true))
                {
                    subKeyNames = registryKeyGameplay.GetValueNames();

                    foreach (Control control in gameplayGroupBox.Controls)
                    {
                        if (control.Name.Contains(baseTrackBarName) && !control.Name.Contains("Label"))
                        {
                            SetRegistryValueWithTrackBar(control, gameplayGroupBox, subKeyNames, registryKeyGameplay);
                        }
                        else if (control.Name.Contains(baseComboBoxNameBoolOptions))
                        {
                            if (control.Name.Contains("Replay"))
                            {
                                subKeyName = subKeyNames.FirstOrDefault(s => s == control.Name.Replace(baseComboBoxNameBoolOptions, string.Empty).Replace("_", string.Empty));
                            }
                            else {
                                subKeyName = subKeyNames.FirstOrDefault(s => s == control.Name.Replace(baseComboBoxNameBoolOptions, string.Empty).ToLower());
                            }
                        }

                        if (subKeyName != null)
                        {
                            subKeyValue = ConvertComboBoxValueToInt(control.Text);

                            if (subKeyValue != null && (int)subKeyValue != -1 && subKeyValue != registryKeyGameplay.GetValue(subKeyName))
                            {
                                registryKeyGameplay.SetValue(subKeyName, subKeyValue);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                message = "Something went wrong, try again the operation.";
                title = "Error";

                MessageBox.Show(message, title, MessageBoxButtons.OK);
                return;
            }

            message = "Work complete! You can close this window.";
            title = "Upgrade done";

            MessageBox.Show(message, title, MessageBoxButtons.OK);
        }

        public void LoadForm(string keyVideoName, string keySoundName, string keyGameplayName, string keyMiscName, string keyStringName, GroupBox videoGroupBox, GroupBox soundGoupBox, 
            GroupBox gameplayGroupBox, TextBox textBoxCampaignProfile, TextBox textBoxUserLocal)
        {
            Key keyVideo = GetKeyValue(keyVideoName);
            Key keySound = GetKeyValue(keySoundName);
            Key keyGameplay = GetKeyValue(keyGameplayName);
            Key keyMisc = GetKeyValue(keyMiscName);
            Key keyString = GetKeyValue(keyStringName);

            object keyValue = null;

            keyValue = keyMisc.Values.FirstOrDefault(k => k.Key == textBoxCampaignProfile.Name.Replace(baseTextBoxName, string.Empty).ToLower()).Value;

            if (keyValue != null) {
                textBoxCampaignProfile.Text = (string)keyValue;
            }

            keyValue = keyString.Values.FirstOrDefault(k => k.Key == textBoxUserLocal.Name.Replace(baseTextBoxName, string.Empty).ToLower()).Value;

            if (keyValue != null)
            {
                textBoxUserLocal.Text = (string)keyValue;
            }

            //load Video GroupBox
            foreach (Control control in videoGroupBox.Controls)
            {
                if (control.Name.Contains(baseTrackBarLabelName))
                {
                    SetTrackBarText(control, videoGroupBox, keyVideo);
                }
                else if (control.Name.Contains(baseComboBoxNameThreeOptions))
                {
                    keyValue = keyVideo.Values.FirstOrDefault(k => k.Key == control.Name.Replace(baseComboBoxNameThreeOptions, string.Empty).ToLower()).Value;
                    var trackBar = control as TrackBar;

                    if (keyValue != null)
                    {
                        control.Text = ConvertComboBoxIntValueToString((int)keyValue);
                    }
                }
                else if (control.Name.Contains(baseComboBoxNameBoolOptions))
                {
                    SetComboBoxBoolOptionsLabelText(control, keyVideo);
                }
                else if (control.Name.Contains(baseComboBoxBitOptionsName))
                {
                    keyValue = keyVideo.Values.FirstOrDefault(k => k.Key == control.Name.Replace(baseComboBoxBitOptionsName, string.Empty).ToLower()).Value;

                    if (keyValue != null)
                    {
                        control.Text = string.Concat((int)keyValue, "bit");
                    }
                }
                else if (control.Name.Contains(comboBoxScreenResolutionName))
                {
                    object widthValue = keyVideo.Values.FirstOrDefault(k => k.Key == "windowwidth").Value;
                    object heightValue = keyVideo.Values.FirstOrDefault(k => k.Key == "windowheight").Value;

                    if (widthValue != null && heightValue != null)
                    {
                        control.Text = string.Format("{0}x{1}", widthValue, heightValue);
                    }
                }
                else if (control.Name.Contains(comboBoxWindowModeName))
                {
                    keyValue = keyVideo.Values.FirstOrDefault(k => k.Key == control.Name.Replace("comboBox", string.Empty).ToLower()).Value;

                    if (keyValue != null)
                    {
                        control.Text = ConvertComboBoxIntValueToWindowMode((int)keyValue);
                    }
                }
            }

            //load Sound GroupBox
            foreach (Control control in soundGoupBox.Controls)
            {
                if (control.Name.Contains(baseTrackBarLabelName))
                {
                    SetTrackBarText(control, soundGoupBox, keySound);
                }
                else if (control.Name.Contains(baseTrackBarLabelName))
                {
                    SetTrackBarText(control, soundGoupBox, keySound);
                }
                else if (control.Name.Contains(baseComboBoxNameBoolOptions))
                {
                    SetComboBoxBoolOptionsLabelText(control, keySound);
                }
            }

            //load Gameplay GroupBox
            foreach (Control control in gameplayGroupBox.Controls)
            {
                if (control.Name.Contains(baseTrackBarLabelName))
                {
                    SetTrackBarText(control, gameplayGroupBox, keyGameplay);
                }
                else if (control.Name.Contains(baseComboBoxNameBoolOptions))
                {
                    SetComboBoxBoolOptionsLabelText(control, keyGameplay);
                }
            }
        }

        private Key GetKeyValue(string keyName)
        {
            var result = new Key() { KeyName = keyName };
            using (var key = Registry.CurrentUser.OpenSubKey(string.Concat(_keyPath, @"\", keyName)))
            {
                if (key == null) return null;

                foreach (var valueName in key.GetValueNames())
                {
                    var val = key.GetValue(valueName);
                    var pair = new KeyValuePair<string, object>(valueName, val);
                    result.Values.Add(pair);
                }
            }

            return result;
        }
    }
}