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
    public partial class ChuyenTienScreen : Form
    {
        String ID;
        Account account;
        Card card;
        private readonly AccountService _accountService = new AccountService();
        private readonly CardService _cardService = new CardService();
        public ChuyenTienScreen(String id)
        {
            this.ID = id;
            
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txbSTKChuyen.Text == "")
            { 
                txbSTKChuyen.Focus();
                MessageBox.Show("Bạn chưa nhập số tài khoản cần chuyển đến!", "CẢNH BÁO");
                return;
            }
            if (txbSoTienChuyen.Text == "")
            {
                txbSoTienChuyen.Focus();
                MessageBox.Show("Bạn chưa nhập số tiền cần chuyển!", "CẢNH BÁO");
                return;
            }
           bool result = await _accountService.ChuyenTien(this.ID, txbSTKChuyen.Text, decimal.Parse(txbSoTienChuyen.Text));
            if (result)
            { 
                if(MessageBox.Show("Bạn đã chuyển " + txbSoTienChuyen.Text + "cho STK " + txbSTKChuyen.Text + 
                    "\n Bạn muốn in hóa đơn không?", "THÔNG BÁO", MessageBoxButtons.YesNo)!=DialogResult.No)
                {
                    this.Hide();
                    InHoaDon hoaDon = new InHoaDon("CHUYỂN TIỀN",
                        card.IDCard, account.IDAccount,
                        "Chuyển tiền cho tài khoản " + txbSTKChuyen.Text,
                        DateTime.Now.ToString(),
                        txbSoTienChuyen.Text
                        );
                    hoaDon.ShowDialog();
                    this.Show();
                   
                }
                this.txbSTKChuyen.Text = "";
                this.txbSoTienChuyen.Text = "";

            }
            else
                MessageBox.Show("Chuyển tiền không thành công", "THÔNG BÁO");
        }

        private async void ChuyenTien_Load(object sender, EventArgs e)
        {
            account = await _accountService.GetAccountByID(ID);
            card = await _cardService.GetCardById(ID);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
