using MultiCardSystem.Data.Entities;
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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        private readonly AccountService _accountService = new AccountService();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picbLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txbSoTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số tài khoản", "CẢNH BÁO");
                txbSoTaiKhoan.Focus();
                return;
            }
            if (txbMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "CẢNH BÁO");
                txbMatKhau.Focus();
                return;
            }
            this.Hide();
            if (_accountService.LoginUser(txbSoTaiKhoan.Text, txbMatKhau.Text))
            {
                List<Account> lst = _accountService.GetAllAccounts();
                foreach(Account a in lst)
                {
                    if(a.UserName == txbSoTaiKhoan.Text)
                    {
                        Console.WriteLine(a.ID);
                        TrangChuScreen trangChu = new TrangChuScreen(a.ID);
                        trangChu.ShowDialog();
                    }
                }
               
            }
            else if (_accountService.LoginAdmin(txbSoTaiKhoan.Text, txbMatKhau.Text))
            {
                QuanLyScreen quanLy = new QuanLyScreen();
                quanLy.ShowDialog();
            }
            else
            {
                MessageBox.Show("dang nhap sai!");
            }
            this.Show();
        }

        private void LoginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void LoginScreen_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void LoginScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 13)
            //{
            //    btnDangNhap.PerformClick();
            //}
        }

        private void btnDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(e.KeyChar == 13)
            //{
            //    btnDangNhap.PerformClick();
            //}
        }

        private void txbMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnDangNhap.PerformClick();
            }
        }
    }
}
