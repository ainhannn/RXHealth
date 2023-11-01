using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace DTO
{
    public class SaleInvoice : FormInvoice
    {
        public Customer Customer { get; set; }
        public List<SaleDetail> Details { get; set; } = new List<SaleDetail>();
        public int SumNumber
        {
            get
            {
                int t = 0;
                foreach (var detail in Details) { t += detail.Number; }
                return t;
            }
        }
        public double Subtotal
        {
            get
            {
                float t = 0;
                foreach (var detail in Details) { t += detail.Amount; }
                return t;
            }
        }
        public double Discount { get; set; } = 0;
        public double Tax { get => Subtotal * 1.08; }
        public double Total { get => Subtotal - Discount + Tax; }
        public double Cash { get; set; }
        public double ExcessCash { get => Cash - Total; }
        public int Point { get; set; }

        public SaleInvoice() { }
        public SaleInvoice(int id, string code) : base(id, code) { }
        public SaleInvoice(int id, string code, DateTime dateInit, string staffNickName) : 
            base(id, code, dateInit, staffNickName) { }

        public SaleInvoice(
                int id, string code, DateTime dateInit, string staffNickName, 
                Customer customer, List<SaleDetail> details, double discount, 
                double cash, int point) : 
            base(id, code, dateInit, staffNickName)
        {
            Customer = customer;
            Details = details;
            Discount = discount;
            Cash = cash;
            Point = point;
        }
    }
}
