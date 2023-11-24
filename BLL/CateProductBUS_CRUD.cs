using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public partial class ProductBUS
    {
        public static int GetId(string barcode)
            => ProductDAO.GetProductId(barcode);

        public static List<CateProduct> SelectAllCateProduct()
            => ProductDAO.SelectAllCateProduct();

        public static List<CateProduct> Search(string condition)
        {
            var rs = new List<CateProduct>();
            foreach (var item in SelectAllCateProduct())
            {
                if (item.ToString().Contains(condition))
                    rs.Add(item);
            }
            return rs;
        }

        public static List<CateProduct> AdvancedSearch(Dictionary<string, string> conditions)
            => ProductDAO.AdvancedSearch(conditions);

        public static bool Update(CateProduct product)
            => ProductDAO.Update(product);

        public static bool Insert(CateProduct product)
            => ProductDAO.Insert(product);

        public static bool Delete(int productId)
            => ProductDAO.Delete(productId);

        public static List<CateProduct> GetTrash()
            => ProductDAO.SelectAllTrash();

        public static bool Recover(int productId)
            => ProductDAO.Recover(productId);

        public static bool DeleteTrash(int productId)
            => ProductDAO.DeleteTrash(productId);

        public static bool EmptyTrash()
            => ProductDAO.EmptyTrash();

    }
}
