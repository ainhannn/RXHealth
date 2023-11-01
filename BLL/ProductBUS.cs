using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductBUS
    {
        public static List<Product> Search(string keyWords)
        {
            var list = new List<Product>();
            foreach (var e in ProductDAO.SelectAll())
            {
                if (e.Information.ToString().Contains(keyWords))
                    list.Add(e);
            }
            return list;
        }

        public static List<Product> AdvancedSearch(Dictionary<string, string> conditions)
        {
            return ProductDAO.AdvancedSearch(conditions);
        }
    }
}
