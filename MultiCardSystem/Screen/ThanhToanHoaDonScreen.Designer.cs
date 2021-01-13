namespace MultiCardSystem.Screen
{
    partial class ThanhToanHoaDonScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanhToanHoaDonScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.PictureBox();
            this.btnXacNhan = new System.Windows.Forms.PictureBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.txbMaHoaDon = new System.Windows.Forms.TextBox();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDBillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceMachineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusBillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuayLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXacNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 103);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "DỊCH VỤ THANH TOÁN HÓA ĐƠN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txbMaHoaDon);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(101, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 67);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã số hóa đơn:\r\n";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.Transparent;
            this.btnQuayLai.BackgroundImage = global::MultiCardSystem.Properties.Resources.btnQuayLai;
            this.btnQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuayLai.Location = new System.Drawing.Point(12, 431);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(249, 52);
            this.btnQuayLai.TabIndex = 10;
            this.btnQuayLai.TabStop = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Transparent;
            this.btnXacNhan.BackgroundImage = global::MultiCardSystem.Properties.Resources.btnTiepTuc;
            this.btnXacNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXacNhan.Location = new System.Drawing.Point(601, 431);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(249, 52);
            this.btnXacNhan.TabIndex = 9;
            this.btnXacNhan.TabStop = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoGenerateColumns = false;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBillDataGridViewTextBoxColumn,
            this.serviceNameDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.serviceMachineDataGridViewTextBoxColumn,
            this.totalMoneyDataGridViewTextBoxColumn,
            this.statusBillDataGridViewTextBoxColumn});
            this.dgvHoaDon.DataSource = this.billBindingSource;
            this.dgvHoaDon.Location = new System.Drawing.Point(15, 127);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(836, 214);
            this.dgvHoaDon.TabIndex = 11;
            // 
            // txbMaHoaDon
            // 
            this.txbMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaHoaDon.Location = new System.Drawing.Point(333, 20);
            this.txbMaHoaDon.Name = "txbMaHoaDon";
            this.txbMaHoaDon.Size = new System.Drawing.Size(302, 26);
            this.txbMaHoaDon.TabIndex = 2;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataSource = typeof(MultiCardSystem.Data.Entities.Bill);
            // 
            // iDBillDataGridViewTextBoxColumn
            // 
            this.iDBillDataGridViewTextBoxColumn.DataPropertyName = "IDBill";
            this.iDBillDataGridViewTextBoxColumn.HeaderText = "IDBill";
            this.iDBillDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDBillDataGridViewTextBoxColumn.Name = "iDBillDataGridViewTextBoxColumn";
            this.iDBillDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            this.serviceNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceMachineDataGridViewTextBoxColumn
            // 
            this.serviceMachineDataGridViewTextBoxColumn.DataPropertyName = "ServiceMachine";
            this.serviceMachineDataGridViewTextBoxColumn.HeaderText = "ServiceMachine";
            this.serviceMachineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceMachineDataGridViewTextBoxColumn.Name = "serviceMachineDataGridViewTextBoxColumn";
            this.serviceMachineDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalMoneyDataGridViewTextBoxColumn
            // 
            this.totalMoneyDataGridViewTextBoxColumn.DataPropertyName = "TotalMoney";
            this.totalMoneyDataGridViewTextBoxColumn.HeaderText = "TotalMoney";
            this.totalMoneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalMoneyDataGridViewTextBoxColumn.Name = "totalMoneyDataGridViewTextBoxColumn";
            this.totalMoneyDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusBillDataGridViewTextBoxColumn
            // 
            this.statusBillDataGridViewTextBoxColumn.DataPropertyName = "statusBill";
            this.statusBillDataGridViewTextBoxColumn.HeaderText = "statusBill";
            this.statusBillDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusBillDataGridViewTextBoxColumn.Name = "statusBillDataGridViewTextBoxColumn";
            this.statusBillDataGridViewTextBoxColumn.Width = 125;
            // 
            // ThanhToanHoaDonScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiCardSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 493);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThanhToanHoaDonScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán hóa đơn";
            this.Load += new System.EventHandler(this.ThanhToanHoaDonScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuayLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXacNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnQuayLai;
        private System.Windows.Forms.PictureBox btnXacNhan;
        private System.Windows.Forms.TextBox txbMaHoaDon;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceMachineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusBillDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource billBindingSource;
    }
}