using MultiCardSystem.Data.Entities;
using MultiCardSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiCardSystem.Screen
{
    public partial class SuaKhachHang : Form
    {
        string ID;
        Customer customer;
        private readonly CustomerService _customerService = new CustomerService();
        public  SuaKhachHang(string id)
        {
           
            this.ID = id;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private async void SuaKhachHang_Load(object sender, EventArgs e)
        {
            customer = await _customerService.GetCustomerById(ID);
            this.txbID.Text = ID;
            this.txbHo.Text = customer.FirstName;
            this.txbTen.Text = customer.LastName;
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Value = DateTime.Parse(customer.Dob);
            this.txbCMND.Text = customer.CMND;
            this.txbSDT.Text = customer.PhoneNumber;
            this.txbDiaChi.Text = customer.Address;
            
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                ID = txbID.Text,
                FirstName = txbHo.Text,
                LastName = txbTen.Text,
                Dob = dtpNgaySinh.Value.ToString(),
                CMND = txbCMND.Text,
                PhoneNumber = txbSDT.Text,
                Address = txbDiaChi.Text,
            };
           bool update =  await _customerService.Update(customer);
            if (update == true)
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("Sửa thông tin khách hàng không thành công", "THÔNG BÁO");
            }
        }
    }
}
