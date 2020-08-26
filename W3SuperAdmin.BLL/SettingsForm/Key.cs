using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3SuperAdmin.BLL
{
    public class Key : SettingsFormBLL
    {
        public string KeyName { get; set; }
        public List<KeyValuePair<string, object>> Values { get; set; }

        public Key()
        {
            Values = new List<KeyValuePair<string, object>>();
        }
    }
}
