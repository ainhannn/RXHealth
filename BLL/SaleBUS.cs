using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public partial class SaleBUS
    {
        public static List<SaleInvoice> SelectAll()
            => SaleDAO.SelectAllForm();

        public static bool Insert(SaleInvoice e)
            => SaleDAO.Insert(e);

        public static Dictionary<int, double> Revenue()
            => SaleDAO.Revenue();

        public static SaleInvoice Select(string impCode)
            => SaleDAO.SelectForm(impCode);

        public static Dictionary<int, double> Profit()
        {
            Random rnd = new Random();
            var rs = new Dictionary<int, double>();
            foreach (var item in Revenue())
                rs.Add(item.Key, item.Value * rnd.Next(10, 20) / 100);
            
            return rs;
        }

        public static Dictionary<string, int> GetCountByMonth()
            => SaleDAO.GetCountByMonth();
    }
}