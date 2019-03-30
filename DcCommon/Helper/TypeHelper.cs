using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DcCommon.Helper
{
    public static class TypeHelper
    {
        /// <summary>
        /// 获得Xelemnt属性值
        /// </summary>
        /// <param name="element"></param>
        /// <param name="attr"></param>
        /// <returns></returns>
        public static string GetAttribute(this System.Xml.Linq.XElement element,string attr)
        {
            string sValue = string.Empty;
            if (element.Attribute(attr) != null)
            {
                sValue = element.Attribute(attr).Value;
            }
            return sValue;
        }

        #region DataTable

        #region 根据条件查询符合条件的DataRow
        /// <summary>
        /// 根据条件查询符合条件的DataRow
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="dicWhere"></param>
        /// <returns></returns>
        public static System.Data.DataRow[] FindRows(this System.Data.DataTable dt, Dictionary<string, string> dicWhere)
        {
            string sAnd = "and";
            StringBuilder sbWhere = new StringBuilder();
            foreach (var kv in dicWhere)
            {
                if (string.IsNullOrWhiteSpace(kv.Value))
                {
                    sbWhere.Append(Consts.CHAR_SPACE_HALF).Append("(").Append(kv.Key).Append("='' or ").Append(kv.Key).Append(" is null ) ").Append(sAnd);
                }
                else
                {
                    sbWhere.Append(Consts.CHAR_SPACE_HALF).Append(kv.Key).Append("='").Append(kv.Value).Append("' ").Append(sAnd);
                }
            }
            int n = sbWhere.ToString().LastIndexOf(sAnd);
            sbWhere.Remove(n, sAnd.Length);
            System.Data.DataRow[] drFound = dt.Select(sbWhere.ToSafeString());
            return drFound;
        }
        #endregion

        #endregion

        #region DcType
        public static string GetTypeNameCh(this QTMValueTypeDesc type)
        {
            string sTypeName = string.Empty;
            switch (type)
            {
                case QTMValueTypeDesc.WTg:// 重量
                sTypeName = "重量";
                break;
                case QTMValueTypeDesc.SIZEmmL:// 圆周
                sTypeName = "圆周";
                break;
                case QTMValueTypeDesc.OVALmm:// 椭圆度
                sTypeName = "椭圆度";
                break;
                case QTMValueTypeDesc.VENT:// 总通风
                sTypeName = "总通风";
                break;
                case QTMValueTypeDesc.TIP:// 嘴通风
                sTypeName = "嘴通风";
                break;
                case QTMValueTypeDesc.ENV:// 纸通风
                sTypeName = "纸通风";
                break;
                case QTMValueTypeDesc.PDOkPa:// 开吸阻(kPa)
                sTypeName = "开吸阻(kPa)";
                break;
                case QTMValueTypeDesc.PDOmm:// 开吸阻(mm)
                sTypeName = "开吸阻(mm)";
                break;
                case QTMValueTypeDesc.PDCmm:// 闭吸阻(mm)
                sTypeName = "闭吸阻(mm)";
                break;
                case QTMValueTypeDesc.PDmm:// 压降单支
                sTypeName = "压降单支";
                break;
                case QTMValueTypeDesc.HARD:// 硬度
                sTypeName = "硬度";
                break;
            }
            return sTypeName;
        }
        public static string GetTypeNameEn(this QTMValueTypeDesc type)
        {
            string sTypeName = type.ToString();
            switch (type)
            {
                case QTMValueTypeDesc.VENT:// 总通风
                    sTypeName="VENT%";
                break;
                case QTMValueTypeDesc.TIP:// 嘴通风
                    sTypeName="TIP%";
                break;
                case QTMValueTypeDesc.ENV:// 纸通风
                    sTypeName="ENV%";
                break;
                case QTMValueTypeDesc.HARD:// 硬度
                    sTypeName=".%HARD";
                break;
            }
            //switch (type)
            //{
            //    QTMValueTypeDesc.WTg:// 重量
            //    sTypeName = QTMValueTypeDesc.WTg.to;
            //    break;
            //    QTMValueTypeDesc.SIZEmmL:// 圆周
            //    break;
            //    QTMValueTypeDesc.OVALmm:// 椭圆度
            //    break;
            //    QTMValueTypeDesc.VENT%:// 总通风
            //    break;
            //    QTMValueTypeDesc.TIP%:// 嘴通风
            //    break;
            //    QTMValueTypeDesc.ENV%:// 纸通风
            //    break;
            //    QTMValueTypeDesc.PDOkPa:// 开吸阻(kPa)
            //    break;
            //    QTMValueTypeDesc.PDOmm:// 开吸阻(mm)
            //    break;
            //    QTMValueTypeDesc.PDCmm:// 闭吸阻(mm)
            //    break;
            //    QTMValueTypeDesc.PDmm:// 压降单支
            //    break;
            //    QTMValueTypeDesc.%HARD:// 硬度
            //    break;
            //}
            return sTypeName;
        }
        /// <summary>
        /// 取得枚举的英文名称
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetCdTypeNameEn(this DcType type)
        {
            return Enum.GetName(typeof(DcType), type);
        }
        /// <summary>
        /// 取得枚举的中文名称
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetDcTypeNameCh(this DcType type)
        {
            string sTypeName = string.Empty;
            switch (type)
            {
                // 摩擦系数仪
                case DcType.A00: sTypeName = "摩擦系数仪"; break;
                // 雾度仪
                case DcType.A01: sTypeName = "雾度仪"; break;
                // 拉力机
                case DcType.A02: sTypeName = "拉力机"; break;
                // 白度仪
                case DcType.A03: sTypeName = "白度仪"; break;
                // 光泽度仪
                case DcType.A04: sTypeName = "光泽度仪"; break;
                // QTM综合测试台
                case DcType.A05: sTypeName = "QTM综合测试台"; break;
                // 单丝线密度仪
                case DcType.A06: sTypeName = "单丝线密度仪"; break;
                // 动态接触角测试仪
                case DcType.A07: sTypeName = "动态接触角测试仪"; break;
                // 数码显微成像测量系统
                case DcType.A08: sTypeName = "数码显微成像测量系统"; break;
                // 条码仪
                case DcType.A09: sTypeName = "条码仪"; break;
                // 激光粒度分析仪
                case DcType.A10: sTypeName = "激光粒度分析仪"; break;
                // 透气度测定仪
                case DcType.A11: sTypeName = "透气度仪"; break;
                // 色差仪
                case DcType.A12: sTypeName = "色差仪"; break;
                // 压痕测试仪
                case DcType.A13: sTypeName = "压痕测试仪"; break;
                // 便携式分光密度仪
                case DcType.A14: sTypeName = "便携式分光密度仪"; break;
                // 直线吸烟机
                case DcType.A15: sTypeName = "直线吸烟机"; break;
                // 转盘吸烟机
                case DcType.A16: sTypeName = "转盘吸烟机"; break;
                // Antaris傅里叶变换近红外光谱仪
                case DcType.A17: sTypeName = "Antaris光谱仪"; break;
                // 数字投影仪
                case DcType.A18: sTypeName = "数字投影仪"; break;
                // 密度折光联用仪
                case DcType.A19: sTypeName = "密度折光联用仪"; break;
                // 烟支含末率测量仪
                case DcType.A20: sTypeName = "烟支含末率测量仪"; break;
                // 长度仪
                case DcType.A21: sTypeName = "长度仪"; break;
                // 纸张强度测试仪
                case DcType.A22: sTypeName = "纸张强度测试仪"; break;
                // 纸张粗糙度测试仪
                case DcType.A23: sTypeName = "纸张粗糙度测试仪"; break;
                // 扩散系数测定仪
                case DcType.A24: sTypeName = "扩散系数测定仪"; break;
                // 胶囊颗粒强度检测仪
                case DcType.A25: sTypeName = "胶囊颗粒强度检测仪"; break;
                // 烟用胶囊滤棒综合检测仪
                case DcType.A26: sTypeName = "烟用胶囊滤棒综合检测仪"; break;
            }
            return sTypeName;
        }
        public static string GetTypeNameCh(this IOResultType type)
        {
            string sTypeName = string.Empty;
            switch (type)
            {
                // 等待
                case IOResultType.Waiting: sTypeName = "等待"; break;
                // 成功
                case IOResultType.Success: sTypeName = "成功"; break;
                // 失败
                case IOResultType.Failure: sTypeName = "失败"; break;
                default: sTypeName = "无"; break;
            }
            return sTypeName;
        }
        public static string GetTypeNameCh(this DIVType type)
        {
            string sTypeName = string.Empty;
            switch (type)
            {
                // 班别
                case DIVType.Class: sTypeName = "班别"; break;
                // 班次
                case DIVType.ClassNo: sTypeName = "班次"; break;
                // 标样
                case DIVType.Std: sTypeName = "标样"; break;
                // 检测环节
                case DIVType.DetectionLink: sTypeName = "检测环节"; break;
                // 片烟区域
                case DIVType.TobaccoStripsPlace: sTypeName = "片烟区域"; break;
                // 七害项
                case DIVType.Harmful: sTypeName = "七害项"; break;
                default: sTypeName = "无"; break;
            }
            return sTypeName;
        }
        public static string GetTypeNameCh(this ComparisonType type)
        {
            string sTypeName = string.Empty;
            switch (type)
            {
                case ComparisonType.UnEqualTo:
                    sTypeName = "不等于";
                    break;
                case ComparisonType.EqualTo:
                    sTypeName = "等于";
                    break;
                case ComparisonType.LessThan:
                    sTypeName = "小于";
                    break;
                case ComparisonType.GreaterThan:
                    sTypeName = "大于";
                    break;
                case ComparisonType.LessThanOrEqualTo:
                    sTypeName = "小于等于";
                    break;
                case ComparisonType.GreaterThanOrEqualTo:
                    sTypeName = "大于等于";
                    break;
            }
            return sTypeName;
        }
        public static string GetTypeNameCh(this MataLabParamCategory type)
        {
            string sTypeName = string.Empty;
            switch (type)
            {
                case MataLabParamCategory.Position:
                    sTypeName = "部位";
                    break;
                case MataLabParamCategory.Chemistry:
                    sTypeName = "化学值";
                    break;
                case MataLabParamCategory.Background:
                    sTypeName = "背景";
                    break;
                case MataLabParamCategory.Feel:
                    sTypeName = "感官";
                    break;
                case MataLabParamCategory.Odor:
                    sTypeName = "香型";
                    break;
                case MataLabParamCategory.OutPoint:
                    sTypeName = "外点";
                    break;
            }
            return sTypeName;
        }
        public static string GetTypeNameCh(this InspectionTaskStatusType type)
        {
            string sTypeName = string.Empty;
            switch (type)
            {
                case InspectionTaskStatusType.RollBack:
                    sTypeName = "取回";
                    break;
                case InspectionTaskStatusType.Normal:
                    sTypeName = "未检";
                    break;
                case InspectionTaskStatusType.Finished:
                    sTypeName = "已检";
                    break;
                case InspectionTaskStatusType.Uploaded:
                    sTypeName = "已回传";
                    break;
            }
            return sTypeName;
        }
        #endregion

        /// <summary>
        /// 整数验证
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsInteger(this string s)
        {
            string pattern = @"^\d*$";
            return System.Text.RegularExpressions.Regex.IsMatch(s, pattern);
        }

        #region IsNullOrEmptyString
        /// <summary>
        /// Identify whether the string is null or empty
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNullOrEmptyString(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
        #endregion

        #region Convert
        /// <summary>
        /// Safely convert to string 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToSafeString(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            return value;
        }

        /// <summary>
        /// Safely convert to string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToSafeString(this object value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            return value.ToString();
        }

        /// <summary>
        /// Safely substring
        /// </summary>
        /// <param name="content"></param>
        /// <param name="startIndex"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string ToSafeSubstring(this string content, int startIndex, int length)
        {
            string substringContent = content.ToSafeString();

            if (substringContent.Length >= startIndex + length)
            {
                return substringContent.Substring(startIndex, length);
            }
            else if (substringContent.Length > startIndex)
            {
                return substringContent.Substring(startIndex);
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Safely substring
        /// </summary>
        /// <param name="content"></param>
        /// <param name="startIndex"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string ToSafeSubstring(this object content, int startIndex, int length)
        {
            return content.ToSafeString().ToSafeSubstring(startIndex, length);
        }

        /// <summary>
        /// Safely convert to decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal ToSafeDecimal(this decimal? value)
        {
            return value.HasValue ? value.Value : 0.0m;
        }
        /*
        /// <summary>
        /// Safely convert to decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal ToSafeDecimal(this OracleDecimal? value)
        {
            return value.ToSafeOracleDecimal().ToSafeDecimal();
        }

        /// <summary>
        /// Safely convert to decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal ToSafeDecimal(this OracleDecimal value)
        {
            return value.Value;
        }
        */
        /// <summary>
        /// Safely convert to decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal ToSafeDecimal(this string value)
        {
            decimal rtn = 0.0m;
            if (value == null)
            {
                return rtn;
            }
            if (value.Replace("*",string.Empty).IsNullOrEmptyString())
            {
                return rtn;
            }


            try
            {
                rtn = decimal.Parse(value);
            }
            catch
            {
                rtn = 0.0m;
            }

            return rtn;
        }
        /// <summary>
        /// 判断是否是Decimal型字符串
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsDecimalString(this string value)
        {
            if (value == null)
            {
                return false;
            }
            if (value.Replace("*", string.Empty).IsNullOrEmptyString())
            {
                return false;
            }


            try
            {
                decimal rtn = decimal.Parse(value);
            }
            catch
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// Safely convert to decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal ToSafeDecimal(this object value)
        {
            decimal rtn = 0.0m;

            if (value == null)
            {
                return rtn;
            }

            string stringValue = value.ToSafeString().Replace(",", ".").Replace("*", string.Empty);

            try
            {
                if (stringValue.Contains("E") || stringValue.Contains("e"))
                {
                    rtn = Convert.ToDecimal(Decimal.Parse(stringValue.ToString(), System.Globalization.NumberStyles.Float));
                }
                else
                {
                    rtn = decimal.Parse(stringValue);
                }
            }
            catch
            {
                rtn = 0.0m;
            }

            return rtn;
        }

        /*
        /// <summary>
        /// Safely convert to Oracle decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static OracleDecimal ToSafeOracleDecimal(this decimal? value)
        {
            return value.ToSafeDecimal().ToSafeOracleDecimal();
        }

        /// <summary>
        /// Safely convert to Oracle decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static OracleDecimal ToSafeOracleDecimal(this decimal value)
        {
            return value;
        }

        /// <summary>
        /// Safely convert to Oracle decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static OracleDecimal ToSafeOracleDecimal(this OracleDecimal? value)
        {
            return value.HasValue ? value.Value : 0.0m;
        }

        /// <summary>
        /// Safely convert to Oracle decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static OracleDecimal ToSafeOracleDecimal(this string value)
        {
            OracleDecimal rtn = 0.0m;

            if (value.IsNullOrEmptyString())
            {
                return rtn;
            }

            value = value.AdjustNumberSignPostion();

            try
            {
                rtn = OracleDecimal.Parse(value);
            }
            catch
            {
                rtn = 0.0m;
            }

            return rtn;
        }

        /// <summary>
        /// Safely convert to Oracle decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static OracleDecimal? ToSafeOracleDecimalNullable(this string value)
        {
            OracleDecimal? rtn = null;

            if (value.IsNullOrEmptyString())
            {
                return rtn;
            }

            value.AdjustNumberSignPostion();

            try
            {
                rtn = OracleDecimal.Parse(value);
            }
            catch
            {
                rtn = null;
            }

            return rtn;
        }
        /// <summary>
        /// Safely convert to Oracle decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static OracleDecimal ToSafeOracleDecimal(this object value)
        {
            OracleDecimal rtn = 0.0m;

            if (value == null)
            {
                return rtn;
            }

            string stringValue = value.ToSafeString();
            stringValue = stringValue.AdjustNumberSignPostion();

            try
            {
                rtn = OracleDecimal.Parse(stringValue);
            }
            catch
            {
                rtn = 0.0m;
            }

            return rtn;
        }
        */
        /// <summary>
        /// Safely convert to int
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToSafeInt(this int? value)
        {
            return value.HasValue ? value.Value : 0;
        }

        /// <summary>
        /// Safely convert to int
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToSafeInt(this string value)
        {
            int rtn = 0;

            if (value.IsNullOrEmptyString())
            {
                return rtn;
            }

            try
            {
                rtn = int.Parse(value);
            }
            catch
            {
                rtn = 0;
            }

            return rtn;
        }

        /// <summary>
        /// Safely convert to int
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ToSafeInt(this object value)
        {
            int rtn = 0;

            if (value == null)
            {
                return rtn;
            }

            string stringValue = value.ToSafeString();

            try
            {
                rtn = int.Parse(stringValue);
            }
            catch
            {
                rtn = 0;
            }

            return rtn;
        }

        /// <summary>
        /// Safely convert to long
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long ToSafeLong(this long? value)
        {
            return value.HasValue ? value.Value : 0;
        }

        /// <summary>
        /// Safely convert to long
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long ToSafeLong(this string value)
        {
            long rtn = 0;

            if (value.IsNullOrEmptyString())
            {
                return rtn;
            }


            try
            {
                rtn = long.Parse(value);
            }
            catch
            {
                rtn = 0;
            }

            return rtn;
        }

        /// <summary>
        /// Safely convert to long
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long ToSafeLong(this object value)
        {
            long rtn = 0;

            if (value == null)
            {
                return rtn;
            }

            string stringValue = value.ToSafeString();

            try
            {
                rtn = long.Parse(stringValue);
            }
            catch
            {
                rtn = 0;
            }

            return rtn;
        }

        /// <summary>
        /// Safely convert to datetime
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime ToSafeDateTime(this string value)
        {
            DateTime rtn = DateTime.MinValue;

            if (value.IsNullOrEmptyString())
            {
                return rtn;
            }

            try
            {
                rtn = DateTime.Parse(value);
            }
            catch
            {
                rtn = DateTime.MinValue;
            }

            return rtn;
        }

        /// <summary>
        /// Safely convert to datetime
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime ToSafeDateTime(this DateTime? value)
        {
            return value.HasValue ? value.Value : DateTime.MinValue;
        }

        /// <summary>
        /// Convert to int display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToIntString(this decimal value)
        {
            return value.ToString("0");
        }

        /// <summary>
        /// Convert to int display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToIntString(this int value)
        {
            return value.ToString("0");
        }

        /// <summary>
        /// Convert to long display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToLongString(this decimal value)
        {
            return value.ToString("0");
        }

        /// <summary>
        /// Convert to long display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToLongString(this long value)
        {
            return value.ToString("0");
        }

        /// <summary>
        /// Convert to decimal display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToDecimalString(this decimal value)
        {
            return value.ToDecimalString(2);
        }
        /*
        /// <summary>
        /// Convert to decimal display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToDecimalString(this OracleDecimal value)
        {
            return value.ToDecimalString(2);
        }
        */
        /// <summary>
        /// Convert to decimal display string
        /// </summary>
        /// <param name="value"></param>
        /// <param name="decimalCount">The decimal count of the string</param>
        /// <returns></returns>
        public static string ToDecimalString(this decimal value, int decimalCount)
        {
            return value.ToString("0." + new string('0', decimalCount));
        }
        /*
        /// <summary>
        /// Convert to decimal display string
        /// </summary>
        /// <param name="value"></param>
        /// <param name="decimalCount">The decimal count of the string</param>
        /// <returns></returns>
        public static string ToDecimalString(this OracleDecimal value, int decimalCount, bool isAmount = false)
        {
            string rtn = value.ToString();

            if (rtn.IndexOf(".") == -1)
            {
                rtn += ".";
            }

            rtn += new string('0', decimalCount);

            rtn = rtn.Substring(0, rtn.IndexOf(".") + decimalCount + 1);

            if (isAmount)
            {
                var beforeSign = "-";
                if (rtn.IndexOf(beforeSign) == -1)
                {
                    beforeSign = string.Empty;
                }

                var substr = string.Empty;
                var strInteger = rtn.Substring(0, rtn.IndexOf("."));
                if (!string.IsNullOrEmpty(beforeSign))
                {
                    strInteger = strInteger.Replace(beforeSign, string.Empty);
                }

                var strDecimal = rtn.Substring(rtn.IndexOf("."));

                while (strInteger.Length > 3)
                {
                    substr = "," + strInteger.Substring(strInteger.Length - 3) + substr;
                    strInteger = strInteger.Substring(0, strInteger.Length - 3);
                }
                substr = strInteger + substr;

                rtn = beforeSign + substr + strDecimal;
            }

            return rtn;
        }
        */
        /// <summary>
        /// Convert to datetime display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DateTimeToddMMyyyy(this DateTime? value)
        {
            return value.ToSafeDateTime().DateTimeToddMMyyyy();
        }

        /// <summary>
        /// Convert to datetime display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DateTimeToddMMyyyy(this DateTime value)
        {
            if (value == DateTime.MinValue)
            {
                return string.Empty;
            }

            return value.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Convert to datetime display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DateTimeToddMMyyyyhhmmss(this DateTime? value)
        {
            return value.ToSafeDateTime().DateTimeToddMMyyyyhhmmss();
        }

        /// <summary>
        /// Convert to datetime display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DateTimeToddMMyyyyhhmmss(this DateTime value)
        {
            if (value == DateTime.MinValue)
            {
                return string.Empty;
            }

            return value.ToString("dd/MM/yyyy hh:mm:ss");
        }

        /// <summary>
        /// Convert to datetime display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DateTimeToyyyyMMdd(this DateTime? value)
        {
            return value.ToSafeDateTime().DateTimeToyyyyMMdd();
        }

        /// <summary>
        /// Convert to datetime display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DateTimeToyyyyMMdd(this DateTime value)
        {
            if (value == DateTime.MinValue)
            {
                return string.Empty;
            }

            return value.ToString("yyyyMMdd");
        }

        /// <summary>
        /// Convert to datetime display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DateTimeToyyyy_MM_dd(this DateTime? value)
        {
            return value.ToSafeDateTime().DateTimeToyyyy_MM_dd();
        }

        /// <summary>
        /// Convert to datetime display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DateTimeToyyyy_MM_dd(this DateTime value)
        {
            if (value == DateTime.MinValue)
            {
                return string.Empty;
            }

            return value.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// Convert to datetime display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DateTimeToyyyyMMddHHmmss(this DateTime? value)
        {
            return value.ToSafeDateTime().DateTimeToyyyyMMddHHmmss();
        }

        /// <summary>
        /// Convert to datetime display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DateTimeToyyyyMMddHHmmss(this DateTime value)
        {
            if (value == DateTime.MinValue)
            {
                return string.Empty;
            }

            return value.ToString("yyyyMMddHHmmss");
        }

        /// <summary>
        /// Convert to datetime display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DateTimeToyyyy_MM_dd_HH_mm_ss(this DateTime? value)
        {
            return value.ToSafeDateTime().DateTimeToyyyy_MM_dd_HH_mm_ss();
        }

        /// <summary>
        /// Convert to datetime display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DateTimeToyyyy_MM_dd_HH_mm_ss(this DateTime value)
        {
            if (value == DateTime.MinValue)
            {
                return string.Empty;
            }

            return value.ToString("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// Safely convert to datetime
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime yyyyMMddToDateTime(this string value)
        {
            try
            {
                return DateTime.ParseExact(value, "yyyyMMdd", null);
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        /// <summary>
        /// Safely convert to datetime
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime yyyyMMddHHmmssToDateTime(this string value)
        {
            try
            {
                return DateTime.ParseExact(value, "yyyyMMddHHmmss", null);
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        /// <summary>
        /// Safely convert to datetime
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime dd_MM_yyyyToDateTime(this string value)
        {
            try
            {
                return DateTime.ParseExact(value, "dd/MM/yyyy", null);
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        /// <summary>
        /// Safely convert to boolean
        /// </summary>
        /// <param name="value">value</param>
        /// <returns></returns>
        public static bool ToSafeBool(this string value)
        {
            if (value.IsNullOrEmptyString())
            {
                return false;
            }

            try
            {
                return bool.Parse(value);
            }
            catch
            {
                return false;
            }
        }

        public static object SafeConvert(this object value, Type convertToType)
        {
            object rtn = null;

            if (value == null || value == DBNull.Value)
            {
                return null;
            }

            if (convertToType == typeof(string))
            {
                rtn = Convert.ToString(value);
            }
            else if (convertToType == typeof(int) || convertToType == typeof(Nullable<int>))
            {
                rtn = Convert.ToInt32(value);
            }
            else if (convertToType == typeof(long) || convertToType == typeof(Nullable<long>))
            {
                rtn = Convert.ToInt64(value);
            }
            else if (convertToType == typeof(double) || convertToType == typeof(Nullable<double>))
            {
                rtn = Convert.ToDouble(value);
            }
            else if (convertToType == typeof(float) || convertToType == typeof(Nullable<float>))
            {
                rtn = Convert.ToSingle(value);
            }
            else if (convertToType == typeof(decimal) || convertToType == typeof(Nullable<decimal>))
            {
                rtn = Convert.ToDecimal(value);
            }
            //else if (convertToType == typeof(OracleDecimal) || convertToType == typeof(Nullable<OracleDecimal>))
            //{
            //    if (value is OracleDecimal && ((OracleDecimal)value).IsNull)
            //    {
            //        return null;
            //    }

            //    rtn = OracleDecimal.Parse(Convert.ToString(value));
            //}
            else if (convertToType == typeof(DateTime) || convertToType == typeof(Nullable<DateTime>))
            {
                rtn = Convert.ToDateTime(value);
            }

            return rtn;
        }
        public static double ToSafeDouble(this string value)
        {
            double rtn = 0;
            //if (value.Contains("E") || value.Contains("e"))
            //{
            //    rtn = Convert.ToDouble(Double.Parse(value.ToString(), System.Globalization.NumberStyles.Float));
            //}
            rtn = Convert.ToDouble(Double.Parse(value.ToString(), System.Globalization.NumberStyles.Float));
            return rtn;
        }
        #endregion

        #region FormatString
        /// <summary>
        /// Format string
        /// </summary>
        /// <param name="value"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string FormatString(this string value, List<string> args)
        {
            return value.FormatString(args.ToArray());
        }

        /// <summary>
        /// Format string
        /// </summary>
        /// <param name="value"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string FormatString(this string value, params object[] args)
        {
            List<object> argList = new List<object>();
            if (args != null && args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i] is List<string>)
                    {
                        argList.AddRange(args[i] as List<string>);
                    }
                    else
                    {
                        argList.Add(args[i]);
                    }
                }

                return string.Format(value, argList.ToArray());
            }
            else
            {
                return value;
            }
        }
        #endregion

        #region Stream Convert
        /// <summary>
        /// Stream convert to string
        /// </summary>
        /// <param name="value">Stream</param>
        /// <returns>String</returns>
        public static string StreamToString(this Stream value)
        {
            return StreamToBytes(value).BytesToString();
        }

        /// <summary>
        /// Stream convert to byte
        /// </summary>
        /// <param name="value">Stream</param>
        /// <returns>Byte</returns>
        public static byte[] StreamToBytes(this Stream value)
        {
            List<byte> rtn = new List<byte>();
            byte[] buffer = new byte[100];
            int offset = 0;
            int totalCount = 0;
            while (true)
            {
                int bytesRead = value.Read(buffer, 0, 100);
                if (bytesRead == 0)
                {
                    break;
                }
                offset += bytesRead;
                totalCount += bytesRead;
                rtn.AddRange(buffer.Take(bytesRead));
            }

            return rtn.ToArray();
        }

        /// <summary>
        /// String convert to byte (UTF8)
        /// </summary>
        /// <param name="value">String</param>
        /// <returns>Byte</returns>
        public static byte[] StringToBytes(this string value)
        {
            byte[] rtn = Encoding.UTF8.GetBytes(value);

            return rtn;
        }

        /// <summary>
        /// Byte convert to string
        /// </summary>
        /// <param name="value">Byte</param>
        /// <returns>String</returns>
        public static string BytesToString(this byte[] value)
        {
            return BytesToString(value, Encoding.UTF8);
        }

        /// <summary>
        /// Byte convert to string
        /// </summary>
        /// <param name="value">Byte</param>
        /// <param name="encoding">Encoding</param>
        /// <returns>String</returns>
        public static string BytesToString(this byte[] value, Encoding encoding)
        {
            string rtn = encoding.GetString(value);

            return rtn;
        }
        #endregion

        #region Trim Words
        /// <summary>
        /// Trim the extra words
        /// </summary>
        /// <param name="content"></param>
        /// <param name="maxWords"></param>
        /// <returns></returns>
        public static string TrimWords(this string content, int maxWords)
        {
            string trimContent = content.ToSafeString();

            if (trimContent.Length > maxWords + 3)
            {
                return trimContent.Substring(0, maxWords - 3) + "...";
            }

            return trimContent;
        }

        /// <summary>
        /// Trim the extra words
        /// </summary>
        /// <param name="content"></param>
        /// <param name="maxWords"></param>
        /// <returns></returns>
        public static string TrimWords(this object content, int maxWords)
        {
            return content.ToSafeString().TrimWords(maxWords);
        }
        #endregion


        #region Convert type
        /// <summary>
        /// Convert the type from object
        /// </summary>
        /// <typeparam name="NewType">The type need convert to</typeparam>
        /// <param name="obj">The object want to convert</param>
        /// <returns>New type of object</returns>
        public static NewType ConvertType<NewType>(this object obj) where NewType : new()
        {
            if (!(obj is NewType))
            {
                throw new System.Exception("Special type can not be converted successfully");
            }

            return (NewType)obj;
        }
        #endregion Convert type

        /// <summary>
        /// 拷贝对象的相同属性值
        /// </summary>
        /// <param name="objB"></param>
        /// <param name="objA"></param>
        public static void CopySamePropertysFrom(this object objB, object objA)
        {
            List<System.Reflection.PropertyInfo> lstProA = objA.GetType().GetProperties().ToList();
            List<System.Reflection.PropertyInfo> lstProB = objB.GetType().GetProperties().ToList();
            foreach (System.Reflection.PropertyInfo proA in lstProA)
            {
                if (objB.GetType().GetProperty(proA.Name)!=null)
                {
                    System.Reflection.PropertyInfo proB = objB.GetType().GetProperty(proA.Name);
                    if (proB.CanWrite)
                    {
                        proB.SetValue(objB, proA.GetValue(objA, null), null);
                    }
                }
            }
        }

        /// <summary>
        /// Convert to datetime display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DateTimeToyyyy_MM_dd_HH_mm_ss_fff(this DateTime? value)
        {
            return value.ToSafeDateTime().DateTimeToyyyy_MM_dd_HH_mm_ss_fff();
        }

        /// <summary>
        /// Convert to datetime display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DateTimeToyyyy_MM_dd_HH_mm_ss_fff(this DateTime value)
        {
            if (value == DateTime.MinValue)
            {
                return string.Empty;
            }
            string sDtMsg = value.DateTimeToyyyyMMddHHmmssfff();

            return string.Format("{0}-{1}-{2} {3}:{4}:{5}.{6}"
            , sDtMsg.Substring(0, 4) // 年
            , sDtMsg.Substring(4, 2) // 月
            , sDtMsg.Substring(6, 2) // 日
            , sDtMsg.Substring(8, 2) // 时
            , sDtMsg.Substring(10, 2) // 分
            , sDtMsg.Substring(12, 2) // 秒
            , sDtMsg.Substring(14));
        }

        /// <summary>
        /// Convert to datetime display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DateTimeToyyyyMMddHHmmssfff(this DateTime? value)
        {
            return value.ToSafeDateTime().DateTimeToyyyyMMddHHmmssfff();
        }

        /// <summary>
        /// Convert to datetime display string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DateTimeToyyyyMMddHHmmssfff(this DateTime value)
        {
            if (value == DateTime.MinValue)
            {
                return string.Empty;
            }
            StringBuilder sbTime = new StringBuilder(value.DateTimeToyyyyMMddHHmmss());
            if (value.TimeOfDay.ToString().Length < 9)
            {
                sbTime.Append("000");
            }
            else
            {
                sbTime.Append(value.TimeOfDay.ToString().Remove(0, 9));
            }
            return sbTime.ToString();
        }
        /// <summary>
        /// 将yyyyMMddHHmmssfff格式化成yyyy-MM-dd HH:mm:ss.ffff格式
        /// </summary>
        /// <param name="sDateTimeString">yyyyMMddHHmmssfff字符串</param>
        /// <returns>yyyy-MM-dd HH:mm:ss.ffff格式字符串</returns>
        public static string FormatDateTimeStingToOracleTimeStampString(this string sDateTimeString)
        {
            string sOracleTimeStampString = string.Empty;
            // 时间戳
            if (!string.IsNullOrWhiteSpace(sDateTimeString))
            {
                DateTime dtNow = System.DateTime.Now;
                if (DateTime.TryParse(sDateTimeString, out dtNow))
                {
                    DateTime dtMsg = DateTime.Parse(sDateTimeString);
                    sOracleTimeStampString = TypeHelper.DateTimeToyyyy_MM_dd_HH_mm_ss_fff(dtMsg);
                }
                else
                {
                    if (sDateTimeString.Length > 14)
                    {
                        sOracleTimeStampString = string.Format("{0}-{1}-{2} {3}:{4}:{5}.{6}"
                            , sDateTimeString.Substring(0, 4) // 年
                            , sDateTimeString.Substring(4, 2) // 月
                            , sDateTimeString.Substring(6, 2) // 日
                            , sDateTimeString.Substring(8, 2) // 时
                            , sDateTimeString.Substring(10, 2) // 分
                            , sDateTimeString.Substring(12, 2) // 秒
                            , sDateTimeString.Substring(14));
                        if (!DateTime.TryParse(sDateTimeString, out dtNow))
                        {
                            DateTime dtNowTime = System.DateTime.Now;
                            sOracleTimeStampString = TypeHelper.DateTimeToyyyy_MM_dd_HH_mm_ss_fff(dtNowTime);
                        }
                    }
                    else
                    {
                        DateTime dtNowTime = System.DateTime.Now;
                        sOracleTimeStampString = TypeHelper.DateTimeToyyyy_MM_dd_HH_mm_ss_fff(dtNowTime);
                    }
                }
            }
            else
            {
                DateTime dtNowTime = System.DateTime.Now;
                sOracleTimeStampString = TypeHelper.DateTimeToyyyy_MM_dd_HH_mm_ss_fff(dtNowTime);
            }
            return sOracleTimeStampString;
        }
        /// <summary>
        /// 按字节截取字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="startIndex"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string CutStringByte(string str, int startIndex, int len)
        {
            if (str == null || str.Trim() == "")
            {
                return "";
            }
            if (Encoding.Default.GetByteCount(str) < startIndex + 1)
            {
                return string.Empty;
            }
            int i = 0;//字节数
            int j = 0;//实际截取长度
            int iCount = 0;// 实际的起始位置
            foreach (char newChar in str)
            {
                if ((int)newChar > 127)
                {
                    //汉字
                    i += 2;
                }
                else
                {
                    i++;
                }
                iCount++;
                if (i > startIndex + len)
                {
                    int iStart = startIndex - i + iCount;
                    if (iStart <= 0 || startIndex == 0)
                    {
                        iStart = 0;
                    }
                    str = str.Substring(iStart, j);
                    break;
                }
                if (i > startIndex)
                {
                    j++;
                }
            }
            return str;
        }
        public static string CutStringByte(string str, int startIndex)
        {
            if (str == null || str.Trim() == "")
            {
                return "";
            }
            if (Encoding.Default.GetByteCount(str) < startIndex + 1)
            {
                return string.Empty;
            }
            int i = 0;//字节数
            //int j = 0;//实际截取长度
            int iCount = 0;// 实际的起始位置
            foreach (char newChar in str)
            {
                if ((int)newChar > 127)
                {
                    //汉字
                    i += 2;
                }
                else
                {
                    i++;
                }
                iCount++;
                if (i > startIndex)
                {
                    int iStart = startIndex - i + iCount;
                    if (iStart <= 0 || startIndex == 0)
                    {
                        iStart = 0;
                    }
                    str = str.Substring(iStart);
                    break;
                }
                //if (i > startIndex)
                //{
                //    j++;
                //}
            }
            return str;
        }

        /// <summary>
        /// 计算字符串中子串出现的次数
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="substring">子串</param>
        /// <returns>出现的次数</returns>
        public static int SubstringCount(this string str, string substring)
        {
            if (str.Contains(substring))
            {
                string strReplaced = str.Replace(substring, "");
                return (str.Length - strReplaced.Length) / substring.Length;
            }

            return 0;
        }
    }
}
