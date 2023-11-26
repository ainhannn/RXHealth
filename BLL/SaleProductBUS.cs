using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public partial class ProductBUS
    {
        public static List<ProductOnSale> SelectAllSaleProduct()
            => ProductDAO.SelectAllSaleProduct();

        public static List<ProductOnSale> SearchForSale(string condition)
        {
            var rs = new List<ProductOnSale>();
            foreach (var item in SelectAllSaleProduct())
            {
                if (item.ToString().Contains(condition))
                    rs.Add(item);
            }
            return rs;
        }
    }
}