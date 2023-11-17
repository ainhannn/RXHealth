using System;
using System.Collections.Generic;

namespace DTO
{
    public class ImportInvoice : FormInvoice
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public double TotalAmount { get; set; } = 0;
        public List<ImportDetail> Details { get; set; } = new List<ImportDetail>();
        
        public ImportInvoice() { }
        public ImportInvoice(int id, string code) : base(id, code) { }
        public ImportInvoice(int id, string code, DateTime dateInit, string staffNickName) : base(id, code, dateInit, staffNickName) { }
        public void AddDetail(ImportDetail detail) => Details.Add(detail);
    }
}
