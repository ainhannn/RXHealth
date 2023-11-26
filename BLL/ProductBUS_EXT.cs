using DAL;
using System.Collections.Generic;

namespace BLL
{
    public partial class ProductBUS
    {
        public static int CountSalesByCate(string cate) 
            => ProductDAO.CountSalesByCate(cate);

        public static Dictionary<string, int> GetBestSellingByCate(string cate, int limit)
            => ProductDAO.GetBestSellingByCate(cate, limit);

        public static Dictionary<string, int> GetBestSelling(int limit)
            => ProductDAO.GetBestSelling(limit);

    }
}
