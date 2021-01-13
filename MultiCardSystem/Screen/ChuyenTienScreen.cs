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
    public partial class ChuyenTienScreen : Form
    {
        String ID;
        public ChuyenTienScreen(String id)
        {
            this.ID = id;
            InitializeComponent();
        }
        private readonly AccountService _accountService = new AccountService();
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txbSTKChuyen.Text == "")
            { 
                txbSTKChuyen.Focus();
                MessageBox.Show("Bạn chưa nhập số tài khoản cần chuyển đến!", "CẢNH BÁO");
                return;
            }
            if (txbSoTienChuyen.Text == "")
            {
                txbSoTienChuyen.Focus();
                MessageBox.Show("Bạn chưa nhập số tiền cần chuyển!", "CẢNH BÁO");
                return;
            }
           bool result = await _accountService.ChuyenTien(this.ID, txbSTKChuyen.Text, decimal.Parse(txbSoTienChuyen.Text));
            if (result)
            { 
                MessageBox.Show("Bạn đã chuyển " + txbSoTienChuyen.Text + "cho STK " + txbSTKChuyen.Text, "THÔNG BÁO");
                this.txbSTKChuyen.Text = "";
                this.txbSoTienChuyen.Text = "";
            }
            else
                MessageBox.Show("Chuyển tiền không thành công", "THÔNG BÁO");
        }

        private void ChuyenTien_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
