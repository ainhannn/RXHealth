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

        public static bool Insert(ImportInvoice invoice)
        {
            if (invoice == null || invoice.Details.Count < 1) 
                return false;
            return ImportDAO.Insert(invoice);
        }
            
    }
}
