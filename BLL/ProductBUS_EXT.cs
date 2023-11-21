using DAL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public partial class ProductBUS
    {

        //public List<ProductOnSale> getAllSale()
        //{
        //    return ProductDAO.SelectAll_Sale() != null ? ProductDAO.SelectAll_Sale() : null;
        //}

        public List<ProductOnSale> getAllWSale()
        {
            return ProductDAO.Select_WholeSale2() != null ? ProductDAO.Select_WholeSale2() : null;
        }

        //public List<ProductOnSale> getAllRSale()
        //{
        //    return ProductDAO.Select_RetailSale2() != null ? ProductDAO.Select_RetailSale2() : null;
        //}
        //public List<ProductOnSale> getAllWholeSale(String text)
        //{
        //    return ProductDAO.Select_WholeSale(text);
        //}

        public List<ProductOnSale> getAllWholelSale(String text)
        {
            return ProductDAO.Select_WholeSale1(text);
        }

        //public ArrayList timkiemDGV(String text)
        //{
        //    return ProductDAO.Select_WholeSale1(text);
        //}
    }
}
