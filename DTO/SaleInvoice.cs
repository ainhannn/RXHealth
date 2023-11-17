using System;
using System.Collections.Generic;

namespace DTO
{
    public class SaleInvoice : FormInvoice
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public double TotalAmount { get; set; }
        public int Point { get; set; }
        public List<SaleDetail> Details { get; set; } = new List<SaleDetail>();

        public SaleInvoice() { }
        public SaleInvoice(int id, string code) : base(id, code) { }
        public SaleInvoice(int id, string code, DateTime dateInit, string staffNickName) : 
            base(id, code, dateInit, staffNickName) { }

        public void AddDetail(SaleDetail detail) => Details.Add(detail);
    }
}
