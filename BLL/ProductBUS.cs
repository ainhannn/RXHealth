using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public partial class ProductBUS
    {
        public static int CountSalesByCate(string cate) 
            => ProductDAO.CountSalesByCate(cate);

        public static Dictionary<string, int> GetBestSellingByCate(string cate, int limit)
            => ProductDAO.GetBestSellingByCate(cate, limit);




        //public static List<Product> Search(string keyWords)
        //{
        //    var list = new List<Product>();
        //    foreach (var e in ProductDAO.SelectAll())
        //    {
        //        if (e.Information.ToString().Contains(keyWords))
        //            list.Add(e);
        //    }
        //    return list;
        //}

        //public static List<Product> AdvancedSearch(Dictionary<string, string> conditions)
        //{
        //    return ProductDAO.AdvancedSearch(conditions);
        //}
    }
}
