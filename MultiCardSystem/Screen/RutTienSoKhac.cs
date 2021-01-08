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
    public partial class RutTienSoKhac : Form
    {
        public RutTienSoKhac()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            XacNhanMaPIN xacNhan = new XacNhanMaPIN();
            xacNhan.ShowDialog();
            this.Show();
        }
    }
}
