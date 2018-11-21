using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGF.SettingCommon.Model
{
    public class Options
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public int SortOrder { get; set; }
        public bool Visible { get; set; }
        public HGF.SettingCommon.Enums.DisplayLayout Layout { get; set; }
        public List<Option> OptionList { get; set; }
    }
}
