using MultiCardSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiCardSystem.Screen
{
    public partial class DoiMatMaScreen : Form
    {
        String ID;
        public DoiMatMaScreen(String id)
        {
            InitializeComponent();
            this.ID = id;
        }
        private readonly CardService _cardService = new CardService();
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txbMkHienTai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu hiện tại", "CẢNH BÁO");
                txbMkHienTai.Focus();
                return;
            }
            if (txbMkMoi.Text == "")
            {
                txbMkMoi.Focus();
                MessageBox.Show("Bạn chưa nhập mật khẩu mới", "CẢNH BÁO");
                return;
            }
            if (txbNhapLaiMk.Text == "")
            {
                MessageBox.Show("Bạn phải nhập lại mật khẩu mới", "CẢNH BÁO");
                txbNhapLaiMk.Focus();
                return;
            }
            if (txbMkMoi.Text == txbNhapLaiMk.Text)
            { 
                bool result = await _cardService.Update(ID, txbMkHienTai.Text, txbMkMoi.Text);
                if (result)
                {
                    MessageBox.Show("Đổi mất khẩu thành công", "THÔNG BÁO");
                    txbMkHienTai.Text = "";
                    txbMkMoi.Text = "";
                    txbNhapLaiMk.Text = "";
                }   
                else
                    MessageBox.Show("Thay đổi không thành công", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("Nhập lại mật khẩu không đúng", "CẢNH BÁO");
                txbNhapLaiMk.Focus();
                return;
            }
        }
    }
}
