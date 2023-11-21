using System;
using DotNetEnv;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace GLB
{
    public class HandleGlobal
    {
        public static string encodeByMD5(string data)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(data);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2")); // Format the byte as a hexadecimal string
                }
                return sb.ToString();
            }
        }
        //Load environment variable on .env file ----  Note: no push .env
        public static void LoadEnv()
        {
            try
            {
                string pathCurrent = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));
                string envPath = Path.Combine(pathCurrent, ".env");
                DotNetEnv.Env.Load(envPath);
                Console.WriteLine(envPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static bool checkIsEnglish(string e)
        {
            string pattern = Env.GetString("RegUsername");
            Regex regex = new Regex(pattern);
            return regex.IsMatch(e);
        }
        public static string covertEnglish(string e)
        {
            Dictionary<string, string> covertEnglish = new Dictionary<string, string>{
                { "áàảãạâấầẩẫậăắằẳẵặ", "a" },
                { "éèẻẽẹêếềểễệ", "e" },
                { "íìỉĩị", "i" },
                { "óòỏõọôốồổỗộơớờởỡợ", "o" },
                { "úùủũụưứừửữự", "u" },
                { "ýỳỷỹỵ", "y" },
                { "đ", "d" }
            };
            e = e.Replace(" ", "");
            foreach (var item in covertEnglish)
            {
                foreach (char itemKey in item.Key)
                {
                    e = e.Replace(itemKey, item.Value[0]);
                }
            }
            return e.ToString();
        }


    }
}
