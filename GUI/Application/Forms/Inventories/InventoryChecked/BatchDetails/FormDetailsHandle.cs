using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDetails : Form
    {
        private StoProduct pd = new StoProduct();

        private void ReloadForm()
        {
            if (pd != null)
            {
                inpCode.Text = pd.Barcode;
                name.Text = pd.Name;
                cate.Text = pd.Category.Name;
                unit.Text = pd.Unit;
                rUnit.Text = pd.RetailUnit;
                iNum.Text = pd.ImportNumber.ToString();
                eNum.Text = pd.NumberSoldOut.ToString();
                currentNum.Text = pd.TotalNumber.ToString();
                rNum.Text = pd.RetailNumber.ToString();
                capacity.Text = pd.Capacity.ToString(); 
                speci.Text = pd.RetailUnit + "/" + pd.Unit;
                
                ReloadTable();
            }
        }
        
        private void ReloadTable()
        {
            pd.Batches = ProductBUS.GetBatches(pd.Id, avai.Checked);
            table.Rows.Clear();
            int i = 1;
            foreach (var item in pd.Batches)
            {
                table.Rows.Add(i++, item.LocalCode, item.MFGDate.ToString(), item.EXPDate.ToString(), item.Number);
            }
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            ReloadForm();
        }

        private void avai_CheckedChanged(object sender, EventArgs e)
        {
            ReloadTable();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(capacity.Text) ||
                string.IsNullOrEmpty(inpNum.Text))
            {
                MessageBox.Show("Hãy nhập đủ thông tin!");
                return;
            }

            if (!int.TryParse(capacity.Text, out var cap) ||
                !int.TryParse(inpNum.Text, out var num))
            {
                MessageBox.Show("Sai định dạng số!");
                return;
            };

            if (ProductBUS.ExportForRetail(pd.Id, cap, num))
            {
                MessageBox.Show("Xuất thành công!");
                pd.NumberSoldOut += num;
                pd.TotalNumber -= num;
                pd.RetailNumber += cap * num;
                pd.Capacity = cap;
                ReloadForm();
            }
            else
                MessageBox.Show("Đã có lỗi xảy ra! Xuất thất bại!");
        }
    }
}
