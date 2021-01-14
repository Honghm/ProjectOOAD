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
    public partial class InHoaDon : Form
    {
        String tenHD;
        String soThe;
        String soTK;
        String noiDung;
        String thoiGian; 
        String soTien;
        public InHoaDon(String tenHoaDon, String soThe, String soTK,
            String noiDung,String thoiGian, String soTien)
        {
            this.tenHD = tenHoaDon;
            this.soThe = soThe;
            this.soTK = soTK;
            this.noiDung = noiDung;
            this.thoiGian = thoiGian;
            this.soTien = soTien;
            InitializeComponent();
           
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            tenHoaDon.Text = tenHD;
            lbSoThe.Text = soTien;
            lbSTK.Text = soTK;
            lbThoiGian.Text = thoiGian;
            lbNoiDung.Text = noiDung;
            lbSoTien.Text = soTien;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
