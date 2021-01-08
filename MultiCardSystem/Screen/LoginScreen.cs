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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picbLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.txbSoTaiKhoan.Text == "1")
            {
                TrangChuScreen trangChu = new TrangChuScreen();
                trangChu.ShowDialog();
            }
            else
            {
                QuanLyScreen quanLy = new QuanLyScreen();
                quanLy.ShowDialog();
            }
            
            
            this.Show();
        }

        private void LoginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
