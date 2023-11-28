using BLL;
using DTO;
using GLB;
using iText.Layout.Splitting;
using System;
using System.Collections.Generic;
using System.Drawing;
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
                tableCus.Rows.Add(item.Id, item.ContactNumber);
            }
            tableCus.CurrentCell = null;
        }

        private void SetCustomerDisplay(Customer cus)
        {
            if (cus != null)
            {
                inpName.Text = cus.Name;
                inpContactNumber.Text = cus.ContactNumber;
                inpPoint.Text = cus.TotalPoint.ToString();
                inpTimes.Text = cus.Times.ToString();

                table.Rows.Clear();
                cus.PurchaseHistory = CustomerBUS.GetPurchaseHistory(cus.Id);
                int i = 1;
                foreach (var item in cus.PurchaseHistory)
                {
                    table.Rows.Add(i++, item.Code, item.DateInit, item.StaffNickName, item.TotalAmount);
                }

                Changable(false);
            }
            else
            {
                inpName.Text = "";
                inpContactNumber.Text = "";
                inpPoint.Text = "0";
                inpTimes.Text = "0";

                table.Rows.Clear();
            }
        }

        private void Changable(bool input)
            => inpName.Enabled = inpContactNumber.Enabled = input;

        private void FormCateCus_Load(object sender, EventArgs e)
        {
            LoadIntoTableCus(CustomerBUS.SelectAll());
            SetCustomerDisplay(CustomerBUS.Select(1));
        }

        private void tableCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Int16.TryParse(tableCus.Rows[e.RowIndex].Cells[0].Value.ToString(), out var id);
                SetCustomerDisplay(CustomerBUS.Select(id));
            }
        }

        private void inpSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inpSearch.Text))
                LoadIntoTableCus(CustomerBUS.SearchOnContactNumber(inpSearch.Text));
            else
                LoadIntoTableCus(CustomerBUS.SelectAll());
        }

        private void create_Click(object sender, EventArgs e)
        {
            tableCus.CurrentCell = null;
            SetCustomerDisplay(null);
            Changable(true);
        }
               
        private void update_Click(object sender, EventArgs e)
        {
            if (tableCus.CurrentRow != null)
            {
                Int16.TryParse(tableCus.CurrentRow.Cells[0].Value.ToString(), out var id);
                SetCustomerDisplay(CustomerBUS.Select(id));
                Changable(id!=1);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!inpName.Enabled) return;
            if (string.IsNullOrEmpty(inpName.Text) || string.IsNullOrEmpty(inpContactNumber.Text))
            {
                MessageBox.Show("Vui lòng không bỏ trống!");
                return;
            }
            if (!Retreat.IsPhoneNumber(inpContactNumber.Text))
            {
                MessageBox.Show("Sai định dạng số điện thoại!");
                return;
            }

            if (tableCus.CurrentRow != null)  // sửa
            {
                Int16.TryParse(tableCus.CurrentRow.Cells[0].Value.ToString(), out var id);
                var cus = CustomerBUS.Select(id);
                cus.Name = inpName.Text;
                cus.ContactNumber = inpContactNumber.Text;
                if (CustomerBUS.Update(cus))
                {
                    Changable(false);
                    LoadIntoTableCus(CustomerBUS.SelectAll());
                    MessageBox.Show("Cập nhật thành công!");
                    SetCustomerDisplay(null);
                }
                else
                    MessageBox.Show("Cập nhật thất bại!");
            }
            else //thêm
            {
                var cus = new Customer(inpName.Text, inpContactNumber.Text);
                if (CustomerBUS.Insert(cus))
                {
                    Changable(false);
                    LoadIntoTableCus(CustomerBUS.SelectAll());
                    MessageBox.Show("Thêm thành công!");
                    SetCustomerDisplay(null);
                }
                else
                    MessageBox.Show("Thêm thất bại!");
            }
        }
    }
}
