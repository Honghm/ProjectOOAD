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
    public partial class ThanhToanHoaDonScreen : Form
    {
        String ID;
     
       
        public ThanhToanHoaDonScreen(String id)
        {
            this.ID = id;
            InitializeComponent();
        }
        private readonly BillService _billService = new BillService();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            ThanhToanHoaDon2 thanhToan = new ThanhToanHoaDon2(ID, txbMaHoaDon.Text);
            thanhToan.ShowDialog();
            this.Show();
        }

        private void ThanhToanHoaDonScreen_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = _billService.GetAllBills(ID).ToList();
        }
    }
}
