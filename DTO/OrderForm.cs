using System;
using System.Collections.Generic;
using System.Runtime.Versioning;

namespace DTO
{
    public class OrderForm
    {
        public int Id { get; }
        public string Code { get; }
        public DateTime FormDate { get; set; } = DateTime.Now;
        public string StaffNickName { get; set; }
        public Provider Provider { get; set; }
        public int TotalNumber
        {
            get {
                int t = 0;
                foreach (var detail in Details) { t += detail.Number; }
                return t;
            }
        }
        public List<OrderDetail> Details { get; set; } = new List<OrderDetail>();

        public OrderForm() { }
        public OrderForm(int id, string code)
        {
            Id = id;
            Code = code;
        }
        public OrderForm(int id, string code, DateTime formDate, string staffNickName, Provider provider) : this(id, code)
        {
            FormDate = formDate;
            StaffNickName = staffNickName;
            Provider = provider;
        }
        public void AddDetails(OrderDetail detail) => Details.Add(detail);
    }
}
