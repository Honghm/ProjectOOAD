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
    public partial class ThemKhachHang : Form
    {
        public ThemKhachHang()
        {
            InitializeComponent();
        }
        private readonly CustomerService _customerService = new CustomerService();


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ThemKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnTao_Click(object sender, EventArgs e)
        {
            if(txbID.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ID khách hàng", "CẢNH BÁO");
                txbID.Focus();
                return;
            }
            else if(txbHo.Text == "")
            {
                MessageBox.Show("Bạn phải nhập Họ tên khách hàng", "CẢNH BÁO");
                txbHo.Focus();
                return;
            }
            else if (txbTen.Text == "")
            {
                MessageBox.Show("Bạn phải nhập Họ tên khách hàng", "CẢNH BÁO");
                txbTen.Focus();
                return;
            }
            else if (dtpDob.Value ==null)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh khách hàng", "CẢNH BÁO");
                dtpDob.Focus();
                return;
            }
            else if (txbCMND.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số CMND khách hàng", "CẢNH BÁO");
                txbCMND.Focus();
                return;
            }
            else if (txbSDT.Text == "")
            {
                MessageBox.Show("Bạn phải nhập SĐT khách hàng", "CẢNH BÁO");
                txbSDT.Focus();
                return;
            }
            else if (txbDiaChi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ khách hàng", "CẢNH BÁO");
                txbDiaChi.Focus();
                return;
            }
            else
            {
                Customer customer = new Customer()
                {
                    ID = txbID.Text,
                    FirstName = txbHo.Text,
                    LastName = txbTen.Text,
                    Dob = dtpDob.Value.ToString(),
                    CMND = txbCMND.Text,
                    PhoneNumber = txbSDT.Text,
                    Address = txbDiaChi.Text,
                };
                bool result = await  _customerService.Insert(customer);
                if (result)
                {
                    MessageBox.Show("Đã thêm 1 khách hàng mới", "THÔNG BÁO");
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng không thành công","THÔNG BÁO");
                }
            }
        }
    }
}
