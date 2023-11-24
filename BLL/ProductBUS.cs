using DAL;
using System.Collections.Generic;

namespace BLL
{
    public partial class ProductBUS
    {
        public static int CountSalesByCate(string cate) 
            => ActivityDAO.CountSalesByCate(cate);

        public static Dictionary<string, int> GetBestSellingByCate(string cate, int limit)
            => ActivityDAO.GetBestSellingByCate(cate, limit);


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
    }
}
