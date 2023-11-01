using System;
using System.Collections.Generic;

namespace DTO
{
    public class ImportInvoice : FormInvoice
    {
        public Provider Provider { get; set; }
        public List<ImportDetail> Details { get; set; } = new List<ImportDetail>();
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
        
        public ImportInvoice() { }
        public ImportInvoice(int id, string code) : base(id, code) { }
        public ImportInvoice(int id, string code, DateTime dateInit, string staffNickName) : base(id, code, dateInit, staffNickName) { }

        public ImportInvoice(int id, string code, DateTime dateInit, string staffNickName, Provider provider, List<ImportDetail> details) : base(id, code, dateInit, staffNickName)
        {
            Provider = provider;
            Details = details;
        }
        public void AddDetail(ImportDetail detail) => Details.Add(detail);
    }
}
