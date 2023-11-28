using Microsoft.SqlServer.Server;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BLL
{
    public class Retreat
    {
        public static bool IsPhoneNumber(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;
            return Regex.IsMatch(text, @"^([\+]?33[-]?|[0])?[1-9][0-9]{8}$");
        }

        public static bool IsDateTime(string o)
        {
            if (o == null) return false;
            if (string.IsNullOrEmpty(o.ToString())) return false;

            string[] formats = { "d/M/yyyy", "d-M-yyyy", "d.M.yyyy" };

            return System.DateTime.TryParseExact(o.ToString(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }


        public static DateTime DateTime(string str)
        {
            string[] formats = { "d/M/yyyy", "d-M-yyyy", "d.M.yyyy", "M/yyyy" };

            try { return System.DateTime.ParseExact(str, formats, CultureInfo.InvariantCulture, DateTimeStyles.None); }
            catch { return System.DateTime.Today; }
        }
    }
}
