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
    public partial class TrangChuScreen : Form
    {
        public TrangChuScreen()
        {
          
            InitializeComponent();
        }

        private void TrangChuScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void TrangChuScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
            
        }

        private void btnChuyenTien_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChuyenTienScreen chuyenTien = new ChuyenTienScreen();
            chuyenTien.ShowDialog();
            this.Show();
            
        }

        private void TrangChuScreen_Load(object sender, EventArgs e)
        {
          
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRutTien_Click(object sender, EventArgs e)
        {
            this.Hide();
            RutTienScreen rutTien = new RutTienScreen();
            rutTien.ShowDialog();
            this.Show();
        }

        private void btnThanhToanHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThanhToanHoaDonScreen thanhToanHoaDon = new ThanhToanHoaDonScreen();
            thanhToanHoaDon.ShowDialog();
            this.Show();
        }

        private void btnDoiMatMa_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatMaScreen doiMatMa = new DoiMatMaScreen();
            doiMatMa.ShowDialog();
            this.Show();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TraCuuSoDu traCuu = new TraCuuSoDu();
            traCuu.ShowDialog();
            this.Show();
        }
    }
}
