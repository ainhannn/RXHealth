using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public partial class SaleBUS
    {
        public static List<SaleInvoice> SelectAll()
            => SaleDAO.SelectAllForm();

        public static bool Insert(SaleInvoice e)
            => SaleDAO.Insert(e);
        
        


        public List<SaleInvoice> OnCustomer(int cusId)
        {
            return SaleDAO.GetOnCustomer(cusId);
        }

        public static int getCountByCustomer(int cusId)
        {
            return SaleDAO.CountByCustomer(cusId);
        }

    }
}