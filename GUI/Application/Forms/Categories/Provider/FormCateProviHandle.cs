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
            tableProvi.CurrentCell = null;
        }

        private void SetSupplierDisplay(Supplier sup)
        {
            if (sup != null)
            {
                inpName.Text = sup.Name;
                inpContactNumber.Text = sup.ContactNumber;
                inpAddress.Text = sup.Address;
                inpTimes.Text = sup.Times.ToString();

                table.Rows.Clear();
                sup.ExchangeHistory = SupplierBUS.GetExchangeHistory(sup.Id);
                int i = 1;
                foreach (var item in sup.ExchangeHistory)
                {
                    table.Rows.Add(i++, item.Code, item.DateInit, item.StaffNickName, item.TotalAmount);
                }

                Changable(false);
            }
            else
            {
                inpName.Text = "";
                inpContactNumber.Text = "";
                inpAddress.Text = "";
                inpTimes.Text = "0";

                table.Rows.Clear();
            }
        }

        private void Changable(bool input)
            => inpName.Enabled = inpContactNumber.Enabled = inpAddress.Enabled = input;

        private void FormCateProvi_Load(object sender, EventArgs e)
        {
            LoadIntoTableProvi(SupplierBUS.SelectAll());
        }

        private void tableProvi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Int16.TryParse(tableProvi.Rows[e.RowIndex].Cells[0].Value.ToString(), out var id);
                SetSupplierDisplay(SupplierBUS.Select(id));
            }
        }

        private void inpSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inpSearch.Text))
                LoadIntoTableProvi(SupplierBUS.SearchOnName(inpSearch.Text));
            else
                LoadIntoTableProvi(SupplierBUS.SelectAll());
        }

        private void create_Click(object sender, EventArgs e)
        {
            tableProvi.CurrentCell = null;
            SetSupplierDisplay(null);
            Changable(true);
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (tableProvi.CurrentRow != null)
            {
                Int16.TryParse(tableProvi.CurrentRow.Cells[0].Value.ToString(), out var id);
                SetSupplierDisplay(SupplierBUS.Select(id));
                Changable(true);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!inpName.Enabled) return;
            if (string.IsNullOrEmpty(inpName.Text) || string.IsNullOrEmpty(inpContactNumber.Text) || string.IsNullOrEmpty(inpAddress.Text))
            {
                MessageBox.Show("Vui lòng không bỏ trống!");
                return;
            }
            if (!Retreat.IsPhoneNumber(inpContactNumber.Text))
            {
                MessageBox.Show("Sai định dạng số điện thoại!");
                return;
            }

            if (tableProvi.CurrentRow != null)  // sửa
            {
                Int16.TryParse(tableProvi.CurrentRow.Cells[0].Value.ToString(), out var id);
                var sup = SupplierBUS.Select(id);
                sup.Name = inpName.Text;
                sup.ContactNumber = inpContactNumber.Text;
                sup.Address = inpAddress.Text;
                if (SupplierBUS.Update(sup))
                {
                    Changable(false);
                    LoadIntoTableProvi(SupplierBUS.SelectAll());
                    MessageBox.Show("Cập nhật thành công!");
                    SetSupplierDisplay(null);
                }
                else
                    MessageBox.Show("Cập nhật thất bại!");
            }
            else //thêm
            {
                var sup = new Supplier(inpName.Text, inpContactNumber.Text, inpAddress.Text);
                if (SupplierBUS.Insert(sup))
                {
                    Changable(false);
                    LoadIntoTableProvi(SupplierBUS.SelectAll());
                    MessageBox.Show("Thêm thành công!");
                    SetSupplierDisplay(null);
                }
                else
                    MessageBox.Show("Thêm thất bại!");
            }
        }
    }
}
