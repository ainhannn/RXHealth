using BLL;
using DTO;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormCateProvi : Form
    {
        private void LoadIntoTableProvi(List<Supplier> list)
        {
            tableProvi.Rows.Clear();
            foreach (var item in list)
            {
                tableProvi.Rows.Add(item.Id, item.Name);
            }
        }

        private void FormCateProvi_Load(object sender, EventArgs e)
        {
            LoadIntoTableProvi(SupplierBUS.SelectAll());
        }

        private void tableProvi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Int16.TryParse(tableProvi.Rows[e.RowIndex].Cells[0].Value.ToString(), out var id);
                var provi = SupplierBUS.Select(id);
                inpName.Text = provi.Name;
                inpContactNumber.Text = provi.ContactNumber;
                inpAddress.Text = provi.Address;
                inpTimes.Text = provi.Times.ToString();

                table.Rows.Clear();
                provi.ExchangeHistory = SupplierBUS.GetExchangeHistory(provi.Id);
                int i = 1;
                foreach (var item in provi.ExchangeHistory)
                {
                    table.Rows.Add(i++, item.Code, item.DateInit, item.StaffNickName, item.TotalAmount);
                }
            }
        }

        private void inpSearch_TextChanged(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(inpSearch.Text))
                LoadIntoTableProvi(SupplierBUS.SearchOnName(inpSearch.Text));
            else
                LoadIntoTableProvi(SupplierBUS.SelectAll());
        }
    }
}
