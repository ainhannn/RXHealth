using System;
using System.Collections.Generic;

namespace DTO
{
    public class ImportInvoice
    {
        public int Id { get; }
        public string Code { get; }
        public DateTime InvoiceDate { get; set; } = DateTime.Now;
        public string StaffNickName { get; set; }
        public Provider Provider { get; set; }
        public int TotalNumber 
        {
            get
            {
                int t = 0;
                foreach (var detail in Details) { t += detail.NumberActual; }
                return t;
            }
        }
        public double TotalAmount
        {
            get
            {
                double t = 0;
                foreach (var detail in Details) { t += detail.UnitPrice*detail.NumberActual; }
                return t;
            }
        }
        public List<ImportDetail> Details { get; set; } = new List<ImportDetail>();

        public ImportInvoice() { }
        public ImportInvoice(int id, string code)
        {
            Id = id;
            Code = code;
        }
        public ImportInvoice(int id, string code, DateTime invoiceDate, string staffNickName, Provider provider) : this(id, code)
        {
            InvoiceDate = invoiceDate;
            StaffNickName = staffNickName;
            Provider = provider;
        }
        public void AddDetail(ImportDetail detail) => Details.Add(detail);
    }
}
