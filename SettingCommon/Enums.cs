using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGF.SettingCommon
{
    public class Enums
    {
        /// <summary>
        /// 显示布局
        /// </summary>
        public enum DisplayLayout
        {
            /// <summary>
            /// 流式布局
            /// </SUMMARY>
            Flow = 0,
            /// <SUMMARY>
            /// 网格布局
            /// </SUMMARY>
            Grid = 1,
        }
        /// <summary>
        /// 配置项的控件类型
        /// </summary>
        public enum OptionControlType
        {
            /// <summary>
            /// 选择框
            /// </SUMMARY>
            CheckBox = 0,
            /// <SUMMARY>
            /// 文本框
            /// </SUMMARY>
            TextBox = 1,
            /// <SUMMARY>
            /// 文本框
            /// </SUMMARY>
            ComboBox = 2
        }
        /// <summary>
        /// 配置节点类型
        /// </summary>
        public enum ConfigXmlElementType
        {
            /// <summary>
            /// 根节点
            /// </SUMMARY>
            settings = 0,
            /// <SUMMARY>
            /// 配置节点
            /// </SUMMARY>
            setting = 1,
            /// <SUMMARY>
            /// 配置选项组
            /// </SUMMARY>
            options = 2,
            /// <SUMMARY>
            /// 配置选项
            /// </SUMMARY>
            option = 3
        }
    }
}
