using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGF.SettingCommon.Model
{
    public class Setting
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public int SortOrder { get; set; }
        public bool Visible { get; set; }
        public HGF.SettingCommon.Enums.DisplayLayout Layout { get; set; }
        public Setting DefaultSetting { get; set; }
        public List<Setting> Settings { get; set; }
        public Options Options { get; set; }
    }
}
