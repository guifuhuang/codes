using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HGF.Common
{
    public class Consts
    {
        // 密码复杂验证
        public const string STRING_REGEXP_PASSWORD = @"(?=.*\d)(?=.*[a-zA-Z])(?=.*[^a-zA-Z0-9]).{8,30}";
        //JS:(?=.*[0-9])(?=.*[a-zA-Z])(?=.*[^a-zA-Z0-9]).{8,30}

        #region 符号

        public const char CHAR_SPACE_FULL = '　';
        public const char CHAR_SPACE_HALF = ' ';
        public const char CHAR_TAB = '	';
        public const char CHAR_COMMA = ',';
        public const char CHAR_SEMICOLON = ';';

        #endregion
    }
}
