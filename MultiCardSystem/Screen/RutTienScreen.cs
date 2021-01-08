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
    public partial class RutTienScreen : Form
    {
        public RutTienScreen()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRut200_Click(object sender, EventArgs e)
        {
            this.Hide();
            XacNhanMaPIN xacNhan = new XacNhanMaPIN("200.000");
            xacNhan.ShowDialog();
            this.Show();
        }

        private void btnRut500_Click(object sender, EventArgs e)
        {
            this.Hide();
            XacNhanMaPIN xacNhan = new XacNhanMaPIN("500.000");
            xacNhan.ShowDialog();
            this.Show();
        }

        private void btnRut1tr_Click(object sender, EventArgs e)
        {
            this.Hide();
            XacNhanMaPIN xacNhan = new XacNhanMaPIN("1.000.000");
            xacNhan.ShowDialog();
            this.Show();
        }

        private void btnRut2tr_Click(object sender, EventArgs e)
        {
            this.Hide();
            XacNhanMaPIN xacNhan = new XacNhanMaPIN("2.000.000");
            xacNhan.ShowDialog();
            this.Show();
        }

        private void btnRut3tr_Click(object sender, EventArgs e)
        {
            this.Hide();
            XacNhanMaPIN xacNhan = new XacNhanMaPIN("3.000.000");
            xacNhan.ShowDialog();
            this.Show();
        }

        private void btnRut5tr_Click(object sender, EventArgs e)
        {
            this.Hide();
            XacNhanMaPIN xacNhan = new XacNhanMaPIN("5.000.000");
            xacNhan.ShowDialog();
            this.Show();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            RutTienSoKhac rutTienSoKhac = new RutTienSoKhac();
            rutTienSoKhac.ShowDialog();
            this.Show();
        }
    }
}
