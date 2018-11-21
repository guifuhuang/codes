using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HGF.Common.Helpers
{
    public class PwdHelper
    {
        /// <summary>
        /// 密码加密
        /// </summary>
        /// <param name="sPwd"></param>
        /// <returns></returns>
        public static string EncryptPwd(string sPwd)
        {
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] palindata = Encoding.Default.GetBytes(sPwd);
            byte[] encryptdata = md5.ComputeHash(palindata);
            return Convert.ToBase64String(encryptdata);
        }
        /// <summary>
        /// 验证密码是否安全
        /// </summary>
        /// <param name="sPwd"></param>
        /// <returns></returns>
        public static bool CheckPwdIsMatchOrNot(string sPwd)
        {
            if (!Regex.IsMatch(sPwd, Consts.STRING_REGEXP_PASSWORD))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
