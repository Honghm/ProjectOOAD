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
    public partial class QuanLyScreen : Form
    {
        int tabSelected = 1;

        string ID = "1" ;

       

        //Tài khoản
        string idAccount;
        string userName;
        public QuanLyScreen()
        {
            InitializeComponent();
        }
        private readonly AccountService _accountService = new AccountService();
        private readonly CustomerService _customerService = new CustomerService();
        private readonly CardService _cardService = new CardService();


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
        private void QuanLyScreen_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = _accountService.GetAllAccounts();
            dgvKhachHang.DataSource = _customerService.GetAllCustomers();
            dgvThe.DataSource = _cardService.GetAllCards();
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemTaiKhoan them = new ThemTaiKhoan();
            them.ShowDialog();
            this.Controls.Clear();
            this.InitializeComponent();
            dgvTaiKhoan.DataSource = _accountService.GetAllAccounts();
            this.Show();
        }

        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            if(ID!="")
            {
                this.Hide();
                SuaTaiKhoan sua = new SuaTaiKhoan(idAccount, userName);
                sua.ShowDialog();
                this.Controls.Clear();
                this.InitializeComponent();
                dgvTaiKhoan.DataSource = _accountService.GetAllAccounts();
                this.Show();
            }    
           
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemKhachHang them = new ThemKhachHang();
            them.ShowDialog();
            this.Controls.Clear();
            this.InitializeComponent();
            dgvKhachHang.DataSource = _customerService.GetAllCustomers();
            this.Show();
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            if(ID!="")
            {
                this.Hide();
                SuaKhachHang them = new SuaKhachHang(ID);
                them.ShowDialog();
                this.Controls.Clear();
                this.InitializeComponent();
                dgvKhachHang.DataSource = _customerService.GetAllCustomers();
                this.Show();
            }    
         
        }

        private void btnThemThe_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemThe them = new ThemThe();
            them.ShowDialog();
            this.Controls.Clear();
            this.InitializeComponent();
            dgvThe.DataSource = _cardService.GetAllCards();
            this.Show();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            foreach (DataGridViewRow row in dgvKhachHang.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                    this.ID = row.Cells[0].Value.ToString();
               
            }
        }

        private async void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if(await _cardService.Delete(ID))
                {
                    if(await _accountService.Delete(ID))
                    {
                        bool delete = await _customerService.Delete(ID);
                        if (delete == true)
                            MessageBox.Show("Đã xóa 1 khách hàng", "THÔNG BÁO");
                        else
                            MessageBox.Show("Xóa khách hàng không thành công", "THÔNG BÁO");
                        return;
                    }
                    MessageBox.Show("Xóa khách hàng không thành công", "THÔNG BÁO");
                    return;
                }
                MessageBox.Show("Xóa khách hàng không thành công", "THÔNG BÁO");
                return;
            }
            MessageBox.Show("Xóa khách hàng không thành công", "THÔNG BÁO");
            return;
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvTaiKhoan.SelectedRows)
            {
                if(row.Cells[0].Value != null)
                    this.ID = row.Cells[0].Value.ToString();
                if (row.Cells[1].Value != null)
                    this.idAccount = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value != null)
                    this.userName = row.Cells[2].Value.ToString();
               

            }
        }

        private async void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if(await _cardService.Delete(ID))
                {
                    bool delete = await _accountService.Delete(ID);
                    if (delete == true)
                        MessageBox.Show("Đã xóa 1 tài khoản", "THÔNG BÁO");
                    else
                        MessageBox.Show("Xóa tài khoản không thành công", "THÔNG BÁO");
                    return;
                }
                MessageBox.Show("Xóa tài khoản không thành công", "THÔNG BÁO");
                return;
            }
            MessageBox.Show("Xóa tài khoản không thành công", "THÔNG BÁO");
            return;
        }

        private async void btnXoaThe_Click(object sender, EventArgs e)
        {
          
            if (ID != "")
            {
                bool delete = await _cardService.Delete(ID);
                if (delete == true)
                    MessageBox.Show("Đã xóa 1 thẻ", "THÔNG BÁO");
                else
                    MessageBox.Show("Xóa thẻ không thành công", "THÔNG BÁO");
                return;
            }
            MessageBox.Show("Xóa tài khoản không thành công", "THÔNG BÁO");
            return;
        }

        private void dgvThe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvThe.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                    this.ID = row.Cells[0].Value.ToString();
            }
           
        }

      

        private void dgvKhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvKhachHang.Rows[e.RowIndex];
            ID = row.Cells[0].Value.ToString();
        }

        private void dgvTaiKhoan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvTaiKhoan.Rows[e.RowIndex];
            if (row.Cells[0].Value != null)
                this.ID = row.Cells[0].Value.ToString();
            if (row.Cells[1].Value != null)
                this.idAccount = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value != null)
                this.userName = row.Cells[2].Value.ToString();
        }

        private void dgvThe_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvThe.Rows[e.RowIndex];
            if (row.Cells[0].Value != null)
                this.ID = row.Cells[0].Value.ToString();
           
        }
    }
}
