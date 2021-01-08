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
    public partial class XacNhanMaPIN : Form
    {
        String soTien;
        public XacNhanMaPIN()
        {
            InitializeComponent();
        }
        public XacNhanMaPIN(String soTien)
        {
            InitializeComponent();
            this.soTien = soTien;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XacNhanMaPIN_Load(object sender, EventArgs e)
        {
            this.lbSoTien.Text = this.soTien + " VNĐ";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
