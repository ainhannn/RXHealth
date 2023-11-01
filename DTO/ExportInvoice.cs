using System;
using System.Collections.Generic;

namespace DTO
{
    public class ExportInvoice : FormInvoice
    {
        public List<ExportDetail> Details { get; set; } = new List<ExportDetail>();
        public int TotalNumber 
        {
            get
            {
                int t = 0;
                foreach (var detail in Details) { t += detail.Number; }
                return t;
            }
        }
        
        public ExportInvoice() { }
        public ExportInvoice(int id, string code) : base(id, code) { }
        public ExportInvoice(int id, string code, DateTime dateInit, string staffNickName) : base(id, code, dateInit, staffNickName) { }
        public void AddDetail(ExportDetail detail) => Details.Add(detail);
    }
}
