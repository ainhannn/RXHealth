using DTO;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BLL
{
    public class Retreat
    {
        public static bool IsPercentage(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;
            if (double.TryParse(text, out _)) return true;
            if (text.Contains("%") && double.TryParse(text.Split('%')[0], out _))
                return true;
            return false;
        }

        public static decimal Percentage(string text)
        {
            if (!IsPercentage(text)) return 0;
            try { return decimal.Parse(text); }
            catch { 
                try { return decimal.Parse(text.Split('%')[0])/100; }
                catch { return 0; }
            }
        }

        public static string ToPercentage(decimal num)
        {
            return Math.Round(num*100,2) + "%";
        }

        public static bool IsPhoneNumber(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;
            return Regex.IsMatch(text, @"^([\+]?33[-]?|[0])?[1-9][0-9]{8}$");
        }

        public static bool IsDateTime(string o)
        {
            if (o == null) return false;
            if (string.IsNullOrEmpty(o.ToString())) return false;

            string[] formats = { "d/M/yyyy", "d-M-yyyy", "d.M.yyyy", "M/yyyy" };

            return System.DateTime.TryParseExact(o.ToString(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }

        public static DateTime DateTime(string str)
        {
            string[] formats = { "d/M/yyyy", "d-M-yyyy", "d.M.yyyy", "M/yyyy" };

            try { return System.DateTime.ParseExact(str, formats, CultureInfo.InvariantCulture, DateTimeStyles.None); }
            catch { return System.DateTime.Today; }
        }

        [Obsolete]
        public static List<List<object>> ReadFromSheet(Worksheet sheet)
        {
            var list = new List<List<object>>();
            if (sheet != null)
            {
                for (int i = 0; i < sheet.Rows.Length; i++)
                {
                    var item = new List<object>();
                    var row = sheet.Rows[i];
                    for (var j = 0; j < row.Cells.Length; j++)
                    {
                        var cell = row.Cells[j];
                        if (cell.HasFormula)
                            item.Add(cell.FormulaValue);
                        else
                            item.Add(cell.Value2);
                    }

                    list.Add(item);
                }
            }
            return list;
        }

        public static object GetSetting(string fieldName)
            => !string.IsNullOrEmpty(fieldName) && "vat rate price point".Contains(fieldName) ? DAL.DBConnection.GetSetting(fieldName) : null;

        public static bool Setting(string fieldName, object value)
            => !string.IsNullOrEmpty(fieldName) && "vat rate price point".Contains(fieldName) && DAL.DBConnection.Setting(fieldName, value);
    }
}
