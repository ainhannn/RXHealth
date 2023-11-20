using BLL;
using DTO;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormCateCus : Form
    {
        private void LoadIntoTableCus(List<Customer> list)
        {
            tableCus.Rows.Clear();
            foreach (var item in list)
            {
                tableCus.Rows.Add(item.ContactNumber);
            }
        }

        private void FormCateCus_Load(object sender, EventArgs e)
        {
            LoadIntoTableCus(CustomerBUS.SelectAll());
        }

        private void tableCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string contactNumber = tableCus.Rows[e.RowIndex].Cells[0].Value.ToString();
                var cus = CustomerBUS.SelectByContactNumber(contactNumber);
                inpName.Text = cus.Name;
                inpContactNumber.Text = contactNumber;
                inpPoint.Text = cus.TotalPoint.ToString();
                inpTimes.Text = cus.Times.ToString();
                
                table.Rows.Clear();
                cus.PurchaseHistory = CustomerBUS.GetPurchaseHistory(cus.Id);
                int i = 1;
                foreach (var item in cus.PurchaseHistory)
                {
                    table.Rows.Add(i++,item.Code,item.DateInit,item.StaffNickName,item.TotalAmount);
                }
            }
        }

        private void inpSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inpSearch.Text))
                LoadIntoTableCus(CustomerBUS.SearchOnContactNumber(inpSearch.Text));
            else
                LoadIntoTableCus(CustomerBUS.SelectAll());
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inpSearch.Text))
                LoadIntoTableCus(CustomerBUS.SearchOnContactNumber(inpSearch.Text));
            else
                LoadIntoTableCus(CustomerBUS.SelectAll());
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inpContactNumber.Text) &&
                !string.IsNullOrEmpty(inpName.Text))
            {

            }
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
