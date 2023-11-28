using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public partial class ProductBUS
    {
        public static int Count { get => ProductDAO.Count; }

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

        public static int Update(CateProduct product)
        {
            if (GetId(product.Barcode) < 0)
                return 0;
            return ProductDAO.Update(product) ? 1 : -1;
        }

        public static int Insert(CateProduct product)
        {
            if (GetId(product.Barcode) > -1)
                return 0;
            if (product.Category.Id == 0)
                product.Category.Id = CategoryDAO.GetId(product.Category.Name);
            return ProductDAO.Insert(product) ? 1 : -1;
        }

        public static int Delete(int productId)
            => ProductDAO.Delete(productId) ? 1 : -1;

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
