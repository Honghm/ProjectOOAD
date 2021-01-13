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
    public partial class TraCuuSoDu : Form
    {
        String nameAccount;
        String idAccount;
        String idCard;
        String money;
        public TraCuuSoDu(String nameAccount, String idAccount, String idCard, String money)
        {
            InitializeComponent();
            this.nameAccount = nameAccount;
            this.idAccount = idAccount;
            this.idCard = idCard;
            this.money = money;
        }

        private void TraCuuSoDu_Load(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Text = this.nameAccount;
            txbSTK.Text = this.idAccount;
            txbSoThe.Text = this.idCard;
            this.txbSoDu.Text = this.money+" VNĐ" ;

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
