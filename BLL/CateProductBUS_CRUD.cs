using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public partial class ProductBUS
    {
        public static List<CateProduct> SelectAllCateProduct()
            => ProductDAO.SelectAllCateProduct();

        public static List<CateProduct> AdvancedSearch(Dictionary<string, string> conditions)
            => ProductDAO.AdvancedSearch(conditions);

        public static bool Update(CateProduct product)
            => ProductDAO.Update(product);
    }
}
