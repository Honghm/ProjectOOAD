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
    public partial class SuaTaiKhoan : Form
    {
        string idAccount;
        string userName;
        public SuaTaiKhoan(string idAccount, string userName)
        {
            this.idAccount = idAccount;
            this.userName = userName;
            InitializeComponent();
        }

        private void SuaTaiKhoan_Load(object sender, EventArgs e)
        {
            this.txbTenTaiKhoan.Text = this.userName;
            this.txbSoTaiKhoan.Text = this.idAccount;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
