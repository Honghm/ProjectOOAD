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
    public partial class ThemThe : Form
    {
        public ThemThe()
        {
            InitializeComponent();
        }
        private readonly CardService _cardService = new CardService();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnTao_Click(object sender, EventArgs e)
        {
            var chars = "01234567890123";
            var stringChars = new char[13];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(9)];
            }
            var finalString = new string(stringChars);

            if (txbID.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ID thẻ", "CẢNH CÁO");
                txbID.Focus();
                return;            
            }
            if (txbMaPIN.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã PIN", "CẢNH CÁO");
                txbMaPIN.Focus();
                return;
            }
            if (txbNhapLaiMaPIN.Text == "")
            {
                MessageBox.Show("Bạn phải lại nhập mã PIN", "CẢNH CÁO");
                txbNhapLaiMaPIN.Focus();
                return;
            }
            if (txbMaPIN.Text != txbNhapLaiMaPIN.Text)
            {
                MessageBox.Show("Nhập lại mã PIN không đúng", "CẢNH CÁO");
                txbNhapLaiMaPIN.Focus();
                return;
            }
            Card card = new Card()
            {
                ID = txbID.Text,
                IDCard = finalString,
                DateCreated = dtpNgayTao.Value.ToString(),
                PINCode = txbMaPIN.Text,
            };
            bool result = await _cardService.Insert(card);
            if (result == true)
                MessageBox.Show("Tạo thẻ thành công", "THÔNG BÁO");
            else
                MessageBox.Show("Tạo thẻ không thành công", "THÔNG BÁO");
        }
    }
}
