using System;
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

        public static DateTime DateTime(Object o)
        {
            return System.DateTime.Now;
        }
    }
}
