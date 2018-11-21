using HGF.SettingCommon.Model;
using HGF.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HGF.SettingCommon.Utils
{
    public class SettingsHelper
    {
        public static Settings LoadSettingsConfig(string configFile)
        {
            Settings returnSettings = new Settings();
            // 配置信息
            Dictionary<string, object> dicSettings = new Dictionary<string, object>();
            // 加载配置文件
            XDocument doc = XDocument.Load(configFile);
            XElement xSettingsRoot = doc.Element(SettingCommon.Enums.ConfigXmlElementType.settings.ToString());
            if (xSettingsRoot != null)
            {
                returnSettings.Name = xSettingsRoot.Attribute("name").Value;
                returnSettings.Text = xSettingsRoot.Attribute("text").Value;
                returnSettings.SortOrder = xSettingsRoot.Attribute("sortOrder").Value.ToSafeInt();
                returnSettings.Visible = xSettingsRoot.Attribute("visible").Value.ToSafeBool();

                var xSettings = doc.Descendants(SettingCommon.Enums.ConfigXmlElementType.setting.ToString());
                if (xSettings != null && xSettings.Count() != 0)
                {
                    foreach (var xSetting in xSettings)
                    {
                        xSetting.Elements("");
                    }
                }
            }
            return returnSettings;
        }
    }
}
