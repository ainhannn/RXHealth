using BLL;
using GUI.Handle;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormRequest : Form
    {
        public FormRequest()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void FormRequest_MouseDown(object sender, MouseEventArgs e)
        {
            HandleGUI.ReleaseCapture();
            HandleGUI.SendMessage(Handle, 0x112, 0xf012, 8);
        }
        private void load_Data()
        {
            dataGridView1.Rows.Clear();
            List<int> list = AccountBLL.getAllIRequest();
            try
            {
                foreach (int i in list)
                {
                    string fullname = StaffBLL.getFullName(i);
                    string acccount_name = AccountBLL.getUsernameAccount(i);
                    dataGridView1.Rows.Add(i.ToString(), fullname, acccount_name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void delete_Click(object sender, System.EventArgs e)
        {
            int count = 0;
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (Convert.ToBoolean(row.Cells[4].Value) == true)
                {
                    int id = Convert.ToInt16(row.Cells[0].Value);
                    AccountBLL.cancleRequest(id);
                    count++;
                }
            }
            MessageBox.Show("Đã từ chối "+count+" yêu cầu cấp lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(count > 0)
            {
                load_Data();
            }
        }
        private void form_Load(object sender, System.EventArgs e) {
            load_Data();
        }
        private void dataGridView1_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Lấy giá trị từ dòng được chọn
                string id = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                if (MessageBox.Show("Xác nhận cấp lại mật khẩu với tài khoản có id: "+id, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bool rs = AccountBLL.resetPwd(Convert.ToInt16(id));
                    if (rs)
                    {
                        MessageBox.Show("Cấp lại mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cấp lại mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    load_Data();
                }
            }
        }
    }
}
