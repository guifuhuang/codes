using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Data;
using System.Collections;

namespace HGF.Common.Helpers
{
    public static class JsonHelper
    {
        /// <summary>
        /// 将对象转换成Json格式字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ObjToJson<T>(this T obj)
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
                using (MemoryStream ms = new MemoryStream())
                {
                    serializer.WriteObject(ms, obj);
                    byte[] byteArr = ms.ToArray();
                    return Encoding.UTF8.GetString(byteArr);
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
                return string.Empty;
            }
        }
        /// <summary>
        /// 将Json格式字符串转换成对应类对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        public static T JsonToObj<T>(this string str)
        {
            try
            {
                T obj = Activator.CreateInstance<T>();
                byte[] array = Encoding.UTF8.GetBytes(str);
                using (MemoryStream ms = new MemoryStream(array))
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
                    return (T)serializer.ReadObject(ms);
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
                return default(T);
            }
        }
        #region Json 字符串 转换为 DataTable数据集合
        /// <summary>
        /// Json 字符串 转换为 DataTable数据集合
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static DataTable ToDataTable(this string json)
        {
            DataTable dataTable = new DataTable(); //实例化
            DataTable result;
            try
            {
                System.Web.Script.Serialization.JavaScriptSerializer javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                javaScriptSerializer.MaxJsonLength = Int32.MaxValue; //取得最大数值
                ArrayList arrayList = javaScriptSerializer.Deserialize<ArrayList>(json);
                if (arrayList.Count > 0)
                {
                    foreach (Dictionary<string, object> dictionary in arrayList)
                    {
                        if (dictionary.Keys.Count<string>() == 0)
                        {
                            result = dataTable;
                            return result;
                        }
                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (string current in dictionary.Keys)
                            {
                                //dataTable.Columns.Add(current, dictionary[current].GetType());
                                dataTable.Columns.Add(current, typeof(string));
                            }
                        }
                        DataRow dataRow = dataTable.NewRow();
                        foreach (string current in dictionary.Keys)
                        {
                            if (dictionary[current] != null && dictionary[current].GetType().ToSafeString() == "System.Collections.ArrayList")
                            {
                                //KeyValuePair<string, object> kvp = (KeyValuePair<string, object>)dictionary[current];
                                //dataRow[current] = kvp.ObjToJson();
                                System.Collections.ArrayList arr = (System.Collections.ArrayList)dictionary[current];
                                if (arr.Count != 0)
                                {
                                    DataTable dtSub = new DataTable(current);
                                    foreach (Dictionary<string, object> dicSub in arr)
                                    {
                                        if (dtSub.Columns.Count == 0)
                                        {
                                            foreach (string key in dicSub.Keys)
                                            {
                                                dtSub.Columns.Add(key, typeof(string));
                                            }
                                        }
                                        DataRow dataSubRow = dtSub.NewRow();
                                        foreach (string key in dicSub.Keys)
                                        {
                                            dataSubRow[key] = dicSub[key].ToSafeString();
                                        }
                                        dtSub.Rows.Add(dataSubRow); //循环添加行到DataTable中
                                    }
                                    dataRow[current] = dtSub.ObjToJson();
                                }
                            }
                            else
                            {
                                dataRow[current] = dictionary[current].ToSafeString();
                            }
                        }

                        dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
                    }
                }
            }
            catch(Exception e)
            {
                LogHelper.Error(e);
                return null;
            }
            result = dataTable;
            return result;
        }
        /// <summary>
        /// Json 字符串 格式化
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static string Format(this string json, int marginLen)
        {
            string sMarginStr = new string(' ', marginLen);
            string sFmt = string.Empty;
            try
            {
                System.Web.Script.Serialization.JavaScriptSerializer javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                javaScriptSerializer.MaxJsonLength = Int32.MaxValue; //取得最大数值
                ArrayList arrayList = javaScriptSerializer.Deserialize<ArrayList>(json);
                if (arrayList != null)
                {
                    sFmt = arrayList.Format(marginLen);
                }
            }
            catch (Exception e)
            {
                LogHelper.Error(e);
                return null;
            }
            return sFmt; 
        }
        public static string Format(this ArrayList arrayList, int marginLen)
        {
            string sMarginStr = new string(' ', marginLen);
            string sFmt = string.Empty;
            try
            {
                StringBuilder sbFmt = new StringBuilder();
                sbFmt.Append(sMarginStr).AppendLine("[");
                if (arrayList.Count > 0)
                {
                    foreach (Dictionary<string, object> dictionary in arrayList)
                    {
                        int iMarginLen = marginLen + 2;
                        string sMarginString = new string(' ', iMarginLen);
                        sbFmt.Append(sMarginString).AppendLine("{");
                        foreach (KeyValuePair<string, object> item in dictionary)
                        {
                            int iMarginLen_Pro = iMarginLen + 2;
                            string sMarginString_Pro = new string(' ', iMarginLen_Pro);
                            string sValue = string.Empty;
                            if (item.Value != null)
                            {
                                if (item.Value.GetType().ToSafeString() == "System.Collections.ArrayList")
                                {
                                    sValue = ((ArrayList)item.Value).Format(iMarginLen_Pro + 2);
                                    sbFmt.Append(sMarginString_Pro).Append("\"").Append(item.Key).Append("\"").Append(":").AppendLine(sValue);
                                }
                                else
                                {
                                    sValue = item.Value.ToSafeString();
                                    sbFmt.Append(sMarginString_Pro).Append("\"").Append(item.Key).Append("\"").Append(":").Append("\"").Append(sValue).Append("\"").AppendLine(",");
                                }
                            }
                            //sbFmt.Append(sMarginString_Pro).Append("\"").Append(item.Key).Append("\"").Append(":").Append("\"").Append(sValue).Append("\"").AppendLine(",");

                        }
                        sbFmt.Append(sMarginString).AppendLine("},");
                    }
                    int n = sbFmt.ToString().LastIndexOf(",");
                    sbFmt.Remove(n, 1);
                }
                sbFmt.Append(sMarginStr).AppendLine("]");
                sFmt = sbFmt.ToString();
            }
            catch (Exception e)
            {
                LogHelper.Error(e);
                return null;
            }
            return sFmt.TrimStart();
        }
        #endregion
    }
}
