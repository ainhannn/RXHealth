using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class Check
    {
        public static bool IsPhoneNumber(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;
            return Regex.IsMatch(text, @"^([\+]?33[-]?|[0])?[1-9][0-9]{8}$");
        }
    }
}
