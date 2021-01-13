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
    public partial class XacNhanMaPIN : Form
    {
        string soTien;
        string ID;
        
        public XacNhanMaPIN()
        {
            
            InitializeComponent();
        }
        private readonly AccountService _accountService = new AccountService();
        public XacNhanMaPIN(string soTien, string id)
        {
            InitializeComponent();
            this.soTien = soTien;
            this.ID = id;
        }
       
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XacNhanMaPIN_Load(object sender, EventArgs e)
        {
            this.lbSoTien.Text = this.soTien + " VNĐ";
        }

        private async void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txbPINCode.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã PIN!", "CẢNH BÁO");
                return;
            }
            bool result = await _accountService.RutTien(ID, txbPINCode.Text, decimal.Parse(soTien));

            if (result == true)
                MessageBox.Show("Bạn đã rút " + soTien+" VND", "THÔNG BÁO");
            else
                MessageBox.Show("Rút tiền không thành công", "THÔNG BÁO");
            this.Close(); 

        }
    }
}
