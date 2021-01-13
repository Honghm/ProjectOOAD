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
    public partial class RutTienSoKhac : Form
    {
        String ID;
        public RutTienSoKhac(string id)
        {
            this.ID = id;
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txbSoTien.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập số tiền cần rút!", "CẢNH BÁO");
                return;
            }
            if (decimal.Parse(txbSoTien.Text) < 0)
            {
                MessageBox.Show("Số tiền rút phải lớn hơn 0", "CẢNH BÁO");
                return;
            }
            if (decimal.Parse(txbSoTien.Text) % 50000 != 0)
            {
                MessageBox.Show("Số tiền rút phải làm bội số của 50000 VNĐ", "CẢNH BÁO");
                return;
            }
            this.Hide();
            XacNhanMaPIN xacNhan = new XacNhanMaPIN(this.txbSoTien.Text, this.ID);
            xacNhan.ShowDialog();
            this.Show();
        }
    }
}
