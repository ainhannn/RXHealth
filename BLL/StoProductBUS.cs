using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public partial class ProductBUS
    {
        public static List<StoProduct> SelectAllStoProduct()
            => ProductDAO.SelectAllStoProduct();

        public static List<StoProduct> SearchOnCategory(int cateId)
            => ProductDAO.SearchOnCategory(cateId);

        public static List<StoProduct> Search(List<StoProduct> list, string condition)
        {
            var rs = new List<StoProduct>();
            foreach (var item in list)
            {
                if (item.ToString().Contains(condition))
                    rs.Add(item);
            }
            return rs;
        }

        public static List<ProductBatch> GetBatches(int productId, bool avaiOnly)
            => ProductDAO.SelectProductBatch(productId, avaiOnly);

        public static bool ExportForRetail(int id, int cap, int num)
        {
            if (num > ProductDAO.GetCurrentNumber(id))
                return false;
            return ProductDAO.ExportForRetail(id, cap, num);
        }
    }
}