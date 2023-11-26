using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class ImportBUS
    {
        public static List<ImportInvoice> SelectAll()
            => ImportDAO.SelectAllForm();

        public static ImportInvoice Select(string impCode)
            => ImportDAO.SelectForm(impCode);

        public static ImportInvoice Insert(ImportInvoice invoice)
        {
            if (invoice == null) return null;

            var newList = new List<ImportDetail>();
            foreach (var item in invoice.Details)
            {
                if (ProductDAO.GetProductId(item.Barcode) != -1)
                    newList.Add(item);
            }
            
            if (newList.Count < 1) { return null; }

            invoice.Details = newList;
            return ImportDAO.Insert(invoice) ? invoice : null;
        }
            
    }
}
