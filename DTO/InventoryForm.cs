using System;
using System.Collections.Generic;

namespace DTO
{
    public class InventoryForm : FormInvoice
    {
        public List<InventoryDetail> Details { get; set; } = new List<InventoryDetail>();

        public InventoryForm() { }
        public InventoryForm(int id, string code) : base(id, code) { }
        public InventoryForm(int id, string code, DateTime dateInit, string staffNickName) : base(id, code, dateInit, staffNickName) { }

        public void AddDetail(InventoryDetail detail) => Details.Add(detail);
    }
}
