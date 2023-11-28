using System;
using System.Collections.Generic;

namespace DTO
{
    public class OrderForm : FormInvoice
    {
        public Provider Provider { get; set; }
        public List<OrderDetail> Details { get; set; } = new List<OrderDetail>();
        public int TotalNumber
        {
            get {
                int t = 0;
                foreach (var detail in Details) { t += detail.Number; }
                return t;
            }
        }
        
        public OrderForm() { }
        public OrderForm(int id, string code) : base(id, code) { }

        public OrderForm(int id, string code, DateTime dateInit, string staffNickName, Provider provider, List<OrderDetail> details) : base(id, code, dateInit, staffNickName)
        {
            Provider = provider;
            Details = details;
        }
        public void AddDetails(OrderDetail detail) => Details.Add(detail);
    }
}