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
        public ThanhToanHoaDon2()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hóa đơn thanh toán thành công!", "Thông báo", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
