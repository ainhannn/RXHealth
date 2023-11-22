using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public partial class ProductBUS
    {
        public static List<Product> SelectAll()
            => ProductDAO.SelectAll();

        public static List<Product> AdvancedSearch(Dictionary<string, string> conditions)
        {
            return ProductDAO.AdvancedSearch(conditions);
        }
    }
}
