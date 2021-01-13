using MultiCardSystem.Data.Entities;
using MultiCardSystem.Enum;
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
    public partial class ThemTaiKhoan : Form
    {
        public ThemTaiKhoan()
        {
            InitializeComponent();
                    
        }
        private readonly AccountService _accountService = new AccountService();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private async void btnTao_Click(object sender, EventArgs e)
        {
            var chars = "0123456789";
            var stringChars = new char[13];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(9)];
            }

            var finalString = new string(stringChars);
          
            RoleName roleName = Enum.RoleName.User;
            Status status = Enum.Status.InActive;
            if(txbID.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ID tài khoản", "CẢNH BÁO");
                txbID.Focus();
                return;
            }
            else if(txbTenTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên tài khoản", "CẢNH BÁO");
                txbTenTaiKhoan.Focus();
                return;
            }
            else if (txbMatKhau.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "CẢNH BÁO");
                txbMatKhau.Focus();
                return;
            }
            else if (txbNhapLaiMatKhau.Text == "" )
            {
                MessageBox.Show("Bạn phải nhập lại mật khẩu", "CẢNH BÁO");
                txbNhapLaiMatKhau.Focus();
                return;
            }
            else if (txbNhapLaiMatKhau.Text!= txbMatKhau.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không đúng","CẢNH BÁO");
                txbNhapLaiMatKhau.Focus();
                return;
            }
            else if (txbSoDu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số tiền ban đầu", "CẢNH BÁO");
                txbSoDu.Focus();
            }
            else if(cbLoaiTaiKhoan.SelectedIndex == 0)
            {
                roleName = Enum.RoleName.Admin;
            }
            else if(cbLoaiTaiKhoan.SelectedIndex == 1)
            {
                 roleName= Enum.RoleName.User;
            }
            else if(cbStatus.SelectedIndex == 0)
            {
                status = Enum.Status.Active;
            }
            else if (cbStatus.SelectedIndex == 1)
            {
                status = Enum.Status.InActive;
            }
            Account account = new Account()
            {
                ID = txbID.Text,
                IDAccount = finalString,
                UserName = txbTenTaiKhoan.Text,
                PassWord = txbMatKhau.Text,
                RoleName = roleName,
                Status = status,
                Money = decimal.Parse(txbSoDu.Text),
            };
            bool result = await _accountService.Insert(account);
            if (result)
            {
                MessageBox.Show("Đã thêm 1 tài khoản", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("Tạo tài khoản không thành công", "THÔNG BÁO");
            }
        }
    }
}
