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
                MessageBox.Show("aaa");
                txbID.Focus();
            }
            else if(txbHo.Text == "")
            {
                txbHo.Focus();
            }
            else if (txbTen.Text == "")
            {
                txbTen.Focus();
            }
            else if (txbNgaySinh.Text == "")
            {
                txbNgaySinh.Focus();
            }
            else if (txbCMND.Text == "")
            {
                txbCMND.Focus();
            }
            else if (txbSDT.Text == "")
            {
                txbSDT.Focus();
            }
            else if (txbDiaChi.Text == "")
            {
                txbDiaChi.Focus();
            }
            else
            {
                Customer customer = new Customer()
                {
                    ID = txbID.Text,
                    FirstName = txbHo.Text,
                    LastName = txbTen.Text,
                    Dob = txbNgaySinh.Text,
                    CMND = txbCMND.Text,
                    PhoneNumber = txbSDT.Text,
                    Address = txbDiaChi.Text,
                };
                bool result = await  _customerService.Insert(customer);
                if (result)
                {
                    MessageBox.Show("them thanh cong");
                }
                else
                {
                    MessageBox.Show("them that bai");
                }
            }
        }
    }
}
