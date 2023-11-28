using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CustomerMini : Form
    {
        public CustomerMini()
        {
            InitializeComponent();
        }

        private void Changable(bool input)
            => NameTextbox.Enabled = PhoneTextbox.Enabled = input;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!NameTextbox.Enabled) return;
            if (string.IsNullOrEmpty(NameTextbox.Text) || string.IsNullOrEmpty(PhoneTextbox.Text))
            {
                MessageBox.Show("Vui lòng không bỏ trống!");
                return;
            }
            if (!Retreat.IsPhoneNumber(PhoneTextbox.Text))
            {
                MessageBox.Show("Sai định dạng số điện thoại!");
                return;
            }
            else //thêm
            {
                var cus = new Customer(NameTextbox.Text, PhoneTextbox.Text);
                if (CustomerBUS.Insert(cus))
                {
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm thất bại!");
            }
        
    }
    }
}
