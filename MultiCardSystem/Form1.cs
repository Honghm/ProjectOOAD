using MultiCardSystem.Data.Entities;
using MultiCardSystem.DataAccess;
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

namespace MultiCardSystem
{
    public partial class Form1 : Form
    {
        private readonly SupplierService _supplierRepository = new SupplierService();
        private readonly AccountService _accountService = new AccountService();
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {

            //  supplierBindingSource.DataSource = SupplierService.GetAllSupplier();
           
            //supplierBindingSource.DataSource = _supplierRepository.GetAllSuppliers();
           // MessageBox.Show(_supplierRepository.GetAllSuppliers().Count.ToString());
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try {
                var supplier1 = new Supplier(){ IDSupplier = "2", SupplierName = "vinmart" };
                bool result = await _supplierRepository.Insert(supplier1);
                if(result)
                {
                    MessageBox.Show("them thanh cong");
                }
                else
                {
                    MessageBox.Show("them that bai");
                }
               // MessageBox.Show(_supplierRepository.GetAllSuppliers().Count.ToString());
              //  supplierBindingSource.DataSource = _supplierRepository.GetAllSuppliers();
            }
            catch ( Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // supplierBindingSource.DataSource = _supplierRepository.GetAllSuppliers();
            // accountBindingSource.DataSource = _accountService.GetAllAccounts();
            dataGridView1.DataSource = _accountService.GetAllAccounts();
            MessageBox.Show(_accountService.GetAllAccounts().Count.ToString());        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = await _supplierRepository.Delete("2");
                if (result)
                {
                    MessageBox.Show("xoa thanh cong");
                }
                else
                {
                    MessageBox.Show("xoa that bai");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
