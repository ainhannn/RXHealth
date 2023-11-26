using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class CustomerBUS
    {
        public static int Count { get => CustomerDAO.Count; } 

        public static List<Customer> SelectAll()
            => CustomerDAO.SelectAll();

        public static Customer Select(int cusId)
            => CustomerDAO.Select(cusId);

        public static int GetId(string contactNumber)
            => Check.IsPhoneNumber(contactNumber) ? CustomerDAO.GetId(contactNumber) : 1;

        public static bool ReducePoint(int cusId, int point)
            => CustomerDAO.ReducePoint(cusId, point);

        public static List<Customer> SearchOnContactNumber(string con)
            => CustomerDAO.SearchOnContactNumber(con);

        public static List<SaleInvoice> GetPurchaseHistory(int cusId)
            => SaleDAO.GetOnCustomer(cusId);

        public static bool Update(Customer customer)
            => CustomerDAO.UpdateInformation(customer);

        public static bool Insert(Customer customer)
            => CustomerDAO.Insert(customer);
    }
}
