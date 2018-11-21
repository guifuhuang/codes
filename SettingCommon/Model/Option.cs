using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGF.SettingCommon.Model
{
    public class Option
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public int SortOrder { get; set; }
        public bool Visible { get; set; }
        public HGF.SettingCommon.Enums.OptionControlType ControlType { get; set; }
        public string ValueProperty { get; set; }
        public object Value { get; set; }
    }
}
