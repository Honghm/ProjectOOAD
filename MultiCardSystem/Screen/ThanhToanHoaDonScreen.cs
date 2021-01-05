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
        public ThanhToanHoaDonScreen()
        {
            InitializeComponent();
        }

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
            ThanhToanHoaDon2 thanhToan = new ThanhToanHoaDon2();
            thanhToan.ShowDialog();
            this.Show();
        }
    }
}
