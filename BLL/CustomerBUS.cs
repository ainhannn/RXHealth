using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class CustomerBUS
    {
        public static List<Customer> SelectAll()
            => CustomerDAO.SelectAll();

        public static Customer Select(int cusId)
            => CustomerDAO.Select(cusId);

        public static List<Customer> SearchOnContactNumber(string con)
            => CustomerDAO.SearchOnContactNumber(con);

        public static List<SaleInvoice> GetPurchaseHistory(int cusId)
            => SaleDAO.GetOnCustomer(cusId);
    }
}
