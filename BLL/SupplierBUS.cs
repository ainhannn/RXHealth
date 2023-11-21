﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class SupplierBUS
    {
        public static List<Supplier> SelectAll()
            => SupplierDAO.SelectAll();

        public static Supplier Select(int id)
            => SupplierDAO.Select(id);

        public static List<Supplier> SearchOnName(string name)
            => SupplierDAO.SearchOnName(name);

        public static List<ImportInvoice> GetExchangeHistory(int supId)
            => ImportDAO.GetOnSupplier(supId);

        public static bool Update(Supplier supplier)
            => SupplierDAO.UpdateInformation(supplier);

        public static bool Insert(Supplier supplier)
            => SupplierDAO.Insert(supplier);
    }
}
