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
    public partial class ThanhToanHoaDon2 : Form
    {
        String idBill;
        public ThanhToanHoaDon2(String idBill)
        {
            this.idBill = idBill;
            InitializeComponent();
        }
        private readonly BillService _billService = new BillService();
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnXacNhan_Click(object sender, EventArgs e)
        {
           
            bool result = await _billService.ThanhToan(idBill);
            if(result)
            {
                MessageBox.Show("Thanh toán hóa đơn thành công", "THÔNG BÁO");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thanh toán hóa đơn không thành công", "THÔNG BÁO");
            }
          
        }

        private async void ThanhToanHoaDon2_Load(object sender, EventArgs e)
        {
            Bill bill = await _billService.GetBillById(idBill);
            txbMaHoaDon.Text = bill.IDBill;
            txbSoTien.Text = bill.TotalMoney.ToString()+ " VNĐ"; 
        }
    }
}
