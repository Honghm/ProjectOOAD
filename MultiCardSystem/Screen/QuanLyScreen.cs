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
    public partial class QuanLyScreen : Form
    {
        int tabSelected = 1;
        public QuanLyScreen()
        {
            InitializeComponent();
        }

 

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }

        private void tcQuanLy_Selected(object sender, TabControlEventArgs e)
        {
           
           if(e.TabPage.Name == "btnThoat")
            {
                if (MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    this.tcQuanLy.SelectedIndex = tabSelected;
                }
            }
            else
            {
                tabSelected = e.TabPageIndex;
            }
        }

        private void tcQuanLy_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemTaiKhoan them = new ThemTaiKhoan();
            them.ShowDialog();
            this.Show();
        }

        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuaTaiKhoan sua = new SuaTaiKhoan();
            sua.ShowDialog();
            this.Show();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemKhachHang them = new ThemKhachHang();
            them.ShowDialog();
            this.Show();
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuaKhachHang them = new SuaKhachHang();
            them.ShowDialog();
            this.Show();
        }

        private void btnThemThe_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemThe them = new ThemThe();
            them.ShowDialog();
            this.Show();
        }
    }
}
