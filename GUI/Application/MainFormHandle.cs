using BLL;
using GUI.Components;
using GUI.Forms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        FormStatistic fmStatistic;
        FormCateCate fmCateCate;
        FormCateIngre fmCateIngre;
        FormCateDrug fmCateDrug;
        FormCateProvi fmCateProvi;
        FormCateCus fmCateCus;
        FormInvenImp fmInvenImp;
        FormInvenChk fmInvenChk;
        FormSell fmSell;
        FormSell fmBuy;
        FormStaff fmStaff;
        FormAccount fmAccount;
        FormSetting fmSetting;

        private void statistic_Click(object sender, EventArgs e)
        {
            SetDefault();
            statistic.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Báo Cáo Thống Kê", fmStatistic, new FormStatistic(), this);
        }

        private void cateCate_Click(object sender, EventArgs e)
        {
            SetDefault();
            cateCate.BackColor = Color.LightSteelBlue;
            category.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Danh Mục", fmCateCate, new FormCateCate(), this);
        }

        private void cateIngre_Click(object sender, EventArgs e)
        {
            SetDefault();
            cateIngre.BackColor = Color.LightSteelBlue;
            category.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Hoạt Chất", fmCateIngre, new FormCateIngre(), this);
        }

        private void cateDrug_Click(object sender, EventArgs e)
        {
            SetDefault();
            cateDrug.BackColor = Color.LightSteelBlue;
            category.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Sản Phẩm", fmCateDrug, new FormCateDrug(), this);
        }

        private void cateProvi_Click(object sender, EventArgs e)
        {
            SetDefault();
            cateProvi.BackColor = Color.LightSteelBlue;
            category.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Nhà Cung Cấp", fmCateProvi, new FormCateProvi(), this);
        }

        private void cateCus_Click(object sender, EventArgs e)
        {
            SetDefault();
            cateCus.BackColor = Color.LightSteelBlue;
            category.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Quản Lý Khách Hàng", fmCateCus, new FormCateCus(), this);
        }

        private void invenImp_Click(object sender, EventArgs e)
        {
            SetDefault();
            invenImp.BackColor = Color.LightSteelBlue;
            inventory.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Nhập Kho", fmInvenImp, new FormInvenImp(), this);
        }

        private void invenChk_Click(object sender, EventArgs e)
        {
            SetDefault();
            invenChk.BackColor = Color.LightSteelBlue;
            inventory.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Kiểm Kho", fmInvenChk, new FormInvenChk(), this);
        }

        private void sell_Click(object sender, EventArgs e)
        {
            SetDefault();
            sell.BackColor = Color.LightSteelBlue;
            transaction.BackColor = Color.Navy;
            if (transaction.Visible == false)
                sell.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Lập Hóa Đơn Bán", fmSell, new FormSell(), this);
        }

        private void buy_Click(object sender, EventArgs e)
        {
            SetDefault();
            buy.BackColor = Color.LightSteelBlue;
            transaction.BackColor = Color.Navy;
            if (transaction.Visible == false)
                buy.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Lập Đơn Đặt Hàng", fmBuy, new FormBuy(), this);
        }

        private void staff_Click(object sender, EventArgs e)
        {
            SetDefault();
            staff.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Quản Lý Nhân Sự", fmStaff, new FormStaff(), this);
        }

        private void username_Click(object sender, EventArgs e)
        {
            SetDefault();
            foreach (Control ctrl in pnlAccount.Controls)
                ctrl.Visible = false;
            Navigate.Form(formTitle, "Thông Tin Cá Nhân", fmAccount, new FormAccount(idUser), this);
            username.Text = StaffBLL.getNickName(idUser);
            username.Visible = true;
        }

        private void setting_Click(object sender, EventArgs e)
        {
            SetDefault();
            setting.BackColor = Color.Navy;
            Navigate.Form(formTitle, "Cài Đặt Chung", fmSetting, new FormSetting(), this);
        }
    }
}
