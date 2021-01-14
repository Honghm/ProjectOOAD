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
    public partial class ThanhToanHoaDon2 : Form
    {
        String idBill;
        String ID;
        Account account;
        Card card;
        Bill bill;
        private readonly AccountService _accountService = new AccountService();
        private readonly CardService _cardService = new CardService();
        public ThanhToanHoaDon2(String id, String idBill)
        {
            this.ID = id;
            this.idBill = idBill;
            InitializeComponent();
        }
        private readonly BillService _billService = new BillService();
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnXacNhan_Click(object sender, EventArgs e)
        {
           
            bool result = await _billService.ThanhToan(idBill);
            if(result)
            {
                if (MessageBox.Show("Thanh toán hóa đơn thành công.\n Bạn muốn in hóa đơn không?", "THÔNG BÁO", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    this.Hide();
                    InHoaDon hoaDon = new InHoaDon("THANH TOÁN HÓA ĐƠN",
                        card.IDCard, account.IDAccount,
                        "Thanh toán hóa đơn " + bill.ServiceName,
                        DateTime.Now.ToString(),
                       bill.TotalMoney.ToString()
                        );
                    hoaDon.ShowDialog();
                    this.Close();
                }
                else
                    this.Close();
              
            }
            else
            {
                MessageBox.Show("Thanh toán hóa đơn không thành công", "THÔNG BÁO");
            }
          
        }

        private async void ThanhToanHoaDon2_Load(object sender, EventArgs e)
        {
            bill = await _billService.GetBillById(idBill);
            account = await _accountService.GetAccountByID(ID);
            card = await _cardService.GetCardById(ID);
            txbMaHoaDon.Text = bill.IDBill;
            txbSoTien.Text = bill.TotalMoney.ToString()+ " VNĐ"; 
        }
    }
}
