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
    public partial class TrangChuScreen : Form
    {
        string ID;
        public TrangChuScreen(string id)
        {
            this.ID = id;
            InitializeComponent();
        }

        private readonly AccountService _accountService = new AccountService();
        private readonly CustomerService _customerService = new CustomerService();
        private readonly CardService _cardService = new CardService();
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
            ChuyenTienScreen chuyenTien = new ChuyenTienScreen(this.ID);
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
            RutTienScreen rutTien = new RutTienScreen(this.ID);
            rutTien.ShowDialog();
            this.Show();
        }

        private void btnThanhToanHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThanhToanHoaDonScreen thanhToanHoaDon = new ThanhToanHoaDonScreen(ID);
            thanhToanHoaDon.ShowDialog();
            this.Show();
        }

        private void btnDoiMatMa_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatMaScreen doiMatMa = new DoiMatMaScreen(this.ID);
            doiMatMa.ShowDialog();
            this.Show();
        }

        private async void btnTraCuu_Click(object sender, EventArgs e)
        {
           
            Account account = await _accountService.GetAccountByID(ID);
            Customer customer = await _customerService.GetCustomerById(ID);
            Card card = await _cardService.GetCardById(ID);
            this.Hide();
            TraCuuSoDu traCuu = new TraCuuSoDu(customer.FirstName+" "+ customer.LastName,account.IDAccount,card.IDCard,account.Money.ToString());
            traCuu.ShowDialog();
            this.Show();
        }
    }
}
