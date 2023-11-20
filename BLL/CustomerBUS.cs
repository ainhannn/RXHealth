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

        public static List<Customer> SearchOnContactNumber(string con)
            => CustomerDAO.SearchOnContactNumber(con);

        public static Customer SelectByContactNumber(string contactNumber)
            => CustomerDAO.Select(contactNumber);

        public static List<SaleInvoice> GetPurchaseHistory(int cusId)
            => SaleDAO.GetByCustomer(cusId);
    }
}
