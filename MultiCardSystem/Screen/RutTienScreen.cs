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
        string ID;
        public RutTienScreen(string id)
        {
            this.ID = id;
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRut200_Click(object sender, EventArgs e)
        {
            this.Hide();
            XacNhanMaPIN xacNhan = new XacNhanMaPIN("200000", ID);
            xacNhan.ShowDialog();
            this.Show();
        }

        private void btnRut500_Click(object sender, EventArgs e)
        {
            this.Hide();
            XacNhanMaPIN xacNhan = new XacNhanMaPIN("500000",ID);
            xacNhan.ShowDialog();
            this.Show();
        }

        private void btnRut1tr_Click(object sender, EventArgs e)
        {
            this.Hide();
            XacNhanMaPIN xacNhan = new XacNhanMaPIN("1000000", ID);
            xacNhan.ShowDialog();
            this.Show();
        }

        private void btnRut2tr_Click(object sender, EventArgs e)
        {
            this.Hide();
            XacNhanMaPIN xacNhan = new XacNhanMaPIN("2000000", ID);
            xacNhan.ShowDialog();
            this.Show();
        }

        private void btnRut3tr_Click(object sender, EventArgs e)
        {
            this.Hide();
            XacNhanMaPIN xacNhan = new XacNhanMaPIN("3000000", ID);
            xacNhan.ShowDialog();
            this.Show();
        }

        private void btnRut5tr_Click(object sender, EventArgs e)
        {
            this.Hide();
            XacNhanMaPIN xacNhan = new XacNhanMaPIN("5000000", ID);
            xacNhan.ShowDialog();
            this.Show();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            RutTienSoKhac rutTienSoKhac = new RutTienSoKhac(ID);
            rutTienSoKhac.ShowDialog();
            this.Show();
        }
    }
}
