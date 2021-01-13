namespace MultiCardSystem.Screen
{
    partial class QuanLyScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyScreen));
            this.tcQuanLy = new System.Windows.Forms.TabControl();
            this.qlKhachHang = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaKhachHang = new System.Windows.Forms.Button();
            this.btnSuaKhachHang = new System.Windows.Forms.Button();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.qlTaiKhoan = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnXoaTaiKhoan = new System.Windows.Forms.Button();
            this.btnSuaTaiKhoan = new System.Windows.Forms.Button();
            this.btnThemTaiKhoan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.qlThe = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnXoaThe = new System.Windows.Forms.Button();
            this.btnThemThe = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvThe = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.TabPage();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passWordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pINCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcQuanLy.SuspendLayout();
            this.qlKhachHang.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.qlTaiKhoan.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.qlThe.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcQuanLy
            // 
            this.tcQuanLy.Controls.Add(this.qlKhachHang);
            this.tcQuanLy.Controls.Add(this.qlTaiKhoan);
            this.tcQuanLy.Controls.Add(this.qlThe);
            this.tcQuanLy.Controls.Add(this.btnThoat);
            this.tcQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcQuanLy.Location = new System.Drawing.Point(1, -4);
            this.tcQuanLy.Name = "tcQuanLy";
            this.tcQuanLy.SelectedIndex = 0;
            this.tcQuanLy.Size = new System.Drawing.Size(860, 499);
            this.tcQuanLy.TabIndex = 0;
            this.tcQuanLy.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcQuanLy_Selecting);
            this.tcQuanLy.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcQuanLy_Selected);
            // 
            // qlKhachHang
            // 
            this.qlKhachHang.Controls.Add(this.panel2);
            this.qlKhachHang.Controls.Add(this.panel1);
            this.qlKhachHang.Controls.Add(this.label1);
            this.qlKhachHang.Controls.Add(this.dgvKhachHang);
            this.qlKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlKhachHang.Location = new System.Drawing.Point(4, 29);
            this.qlKhachHang.Name = "qlKhachHang";
            this.qlKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.qlKhachHang.Size = new System.Drawing.Size(852, 466);
            this.qlKhachHang.TabIndex = 0;
            this.qlKhachHang.Text = "Khách hàng";
            this.qlKhachHang.UseVisualStyleBackColor = true;
            
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(57, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 45);
            this.panel2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(623, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoaKhachHang);
            this.panel1.Controls.Add(this.btnSuaKhachHang);
            this.panel1.Controls.Add(this.btnThemKhachHang);
            this.panel1.Location = new System.Drawing.Point(61, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 80);
            this.panel1.TabIndex = 2;
            // 
            // btnXoaKhachHang
            // 
            this.btnXoaKhachHang.BackColor = System.Drawing.Color.Red;
            this.btnXoaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnXoaKhachHang.Location = new System.Drawing.Point(553, 22);
            this.btnXoaKhachHang.Name = "btnXoaKhachHang";
            this.btnXoaKhachHang.Size = new System.Drawing.Size(139, 37);
            this.btnXoaKhachHang.TabIndex = 7;
            this.btnXoaKhachHang.Text = "Xóa";
            this.btnXoaKhachHang.UseVisualStyleBackColor = false;
            this.btnXoaKhachHang.Click += new System.EventHandler(this.btnXoaKhachHang_Click);
            // 
            // btnSuaKhachHang
            // 
            this.btnSuaKhachHang.BackColor = System.Drawing.Color.DimGray;
            this.btnSuaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnSuaKhachHang.Location = new System.Drawing.Point(299, 22);
            this.btnSuaKhachHang.Name = "btnSuaKhachHang";
            this.btnSuaKhachHang.Size = new System.Drawing.Size(139, 37);
            this.btnSuaKhachHang.TabIndex = 6;
            this.btnSuaKhachHang.Text = "Sửa";
            this.btnSuaKhachHang.UseVisualStyleBackColor = false;
            this.btnSuaKhachHang.Click += new System.EventHandler(this.btnSuaKhachHang_Click);
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.BackColor = System.Drawing.Color.Blue;
            this.btnThemKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnThemKhachHang.Location = new System.Drawing.Point(36, 22);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(139, 37);
            this.btnThemKhachHang.TabIndex = 5;
            this.btnThemKhachHang.Text = "Thêm";
            this.btnThemKhachHang.UseVisualStyleBackColor = false;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoGenerateColumns = false;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.cMNDDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dgvKhachHang.DataSource = this.customerBindingSource;
            this.dgvKhachHang.Location = new System.Drawing.Point(57, 105);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(733, 222);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
           
            this.dgvKhachHang.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKhachHang_CellMouseClick);
            // 
            // qlTaiKhoan
            // 
            this.qlTaiKhoan.Controls.Add(this.panel3);
            this.qlTaiKhoan.Controls.Add(this.panel4);
            this.qlTaiKhoan.Controls.Add(this.label4);
            this.qlTaiKhoan.Controls.Add(this.dgvTaiKhoan);
            this.qlTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlTaiKhoan.Location = new System.Drawing.Point(4, 29);
            this.qlTaiKhoan.Name = "qlTaiKhoan";
            this.qlTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.qlTaiKhoan.Size = new System.Drawing.Size(852, 466);
            this.qlTaiKhoan.TabIndex = 1;
            this.qlTaiKhoan.Text = "Tài khoản";
            this.qlTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(57, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(732, 45);
            this.panel3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(623, 26);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm kiếm:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnXoaTaiKhoan);
            this.panel4.Controls.Add(this.btnSuaTaiKhoan);
            this.panel4.Controls.Add(this.btnThemTaiKhoan);
            this.panel4.Location = new System.Drawing.Point(61, 345);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(728, 80);
            this.panel4.TabIndex = 2;
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.BackColor = System.Drawing.Color.Red;
            this.btnXoaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(553, 22);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(139, 37);
            this.btnXoaTaiKhoan.TabIndex = 7;
            this.btnXoaTaiKhoan.Text = "Xóa";
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = false;
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // btnSuaTaiKhoan
            // 
            this.btnSuaTaiKhoan.BackColor = System.Drawing.Color.DimGray;
            this.btnSuaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnSuaTaiKhoan.Location = new System.Drawing.Point(299, 22);
            this.btnSuaTaiKhoan.Name = "btnSuaTaiKhoan";
            this.btnSuaTaiKhoan.Size = new System.Drawing.Size(139, 37);
            this.btnSuaTaiKhoan.TabIndex = 6;
            this.btnSuaTaiKhoan.Text = "Sửa";
            this.btnSuaTaiKhoan.UseVisualStyleBackColor = false;
            this.btnSuaTaiKhoan.Click += new System.EventHandler(this.btnSuaTaiKhoan_Click);
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.BackColor = System.Drawing.Color.Blue;
            this.btnThemTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(36, 22);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(139, 37);
            this.btnThemTaiKhoan.TabIndex = 5;
            this.btnThemTaiKhoan.Text = "Thêm";
            this.btnThemTaiKhoan.UseVisualStyleBackColor = false;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(619, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "QUẢN LÝ TÀI KHOẢN NGƯỜI DÙNG";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AutoGenerateColumns = false;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDAccountDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passWordDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.roleNameDataGridViewTextBoxColumn});
            this.dgvTaiKhoan.DataSource = this.accountBindingSource;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(57, 105);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 24;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(733, 222);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
           
            this.dgvTaiKhoan.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTaiKhoan_CellMouseClick);
            // 
            // qlThe
            // 
            this.qlThe.Controls.Add(this.panel5);
            this.qlThe.Controls.Add(this.panel6);
            this.qlThe.Controls.Add(this.label6);
            this.qlThe.Controls.Add(this.dgvThe);
            this.qlThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlThe.Location = new System.Drawing.Point(4, 29);
            this.qlThe.Name = "qlThe";
            this.qlThe.Padding = new System.Windows.Forms.Padding(3);
            this.qlThe.Size = new System.Drawing.Size(852, 466);
            this.qlThe.TabIndex = 2;
            this.qlThe.Text = "Thẻ đa năng";
            this.qlThe.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(57, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(732, 45);
            this.panel5.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(623, 26);
            this.textBox3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm kiếm:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnXoaThe);
            this.panel6.Controls.Add(this.btnThemThe);
            this.panel6.Location = new System.Drawing.Point(61, 345);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(728, 80);
            this.panel6.TabIndex = 2;
            // 
            // btnXoaThe
            // 
            this.btnXoaThe.BackColor = System.Drawing.Color.Red;
            this.btnXoaThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThe.ForeColor = System.Drawing.Color.White;
            this.btnXoaThe.Location = new System.Drawing.Point(553, 22);
            this.btnXoaThe.Name = "btnXoaThe";
            this.btnXoaThe.Size = new System.Drawing.Size(139, 37);
            this.btnXoaThe.TabIndex = 7;
            this.btnXoaThe.Text = "Xóa";
            this.btnXoaThe.UseVisualStyleBackColor = false;
            this.btnXoaThe.Click += new System.EventHandler(this.btnXoaThe_Click);
            // 
            // btnThemThe
            // 
            this.btnThemThe.BackColor = System.Drawing.Color.Blue;
            this.btnThemThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThe.ForeColor = System.Drawing.Color.White;
            this.btnThemThe.Location = new System.Drawing.Point(36, 22);
            this.btnThemThe.Name = "btnThemThe";
            this.btnThemThe.Size = new System.Drawing.Size(139, 37);
            this.btnThemThe.TabIndex = 5;
            this.btnThemThe.Text = "Thêm";
            this.btnThemThe.UseVisualStyleBackColor = false;
            this.btnThemThe.Click += new System.EventHandler(this.btnThemThe_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(231, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(428, 39);
            this.label6.TabIndex = 1;
            this.label6.Text = "QUẢN LÝ THẺ ĐA NĂNG";
            // 
            // dgvThe
            // 
            this.dgvThe.AutoGenerateColumns = false;
            this.dgvThe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.iDCardDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.pINCodeDataGridViewTextBoxColumn});
            this.dgvThe.DataSource = this.cardBindingSource;
            this.dgvThe.Location = new System.Drawing.Point(57, 105);
            this.dgvThe.Name = "dgvThe";
            this.dgvThe.RowHeadersWidth = 51;
            this.dgvThe.RowTemplate.Height = 24;
            this.dgvThe.Size = new System.Drawing.Size(733, 222);
            this.dgvThe.TabIndex = 0;
            this.dgvThe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThe_CellClick);
           
            this.dgvThe.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvThe_CellMouseClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(4, 29);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(852, 466);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Dob";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.Width = 125;
            // 
            // cMNDDataGridViewTextBoxColumn
            // 
            this.cMNDDataGridViewTextBoxColumn.DataPropertyName = "CMND";
            this.cMNDDataGridViewTextBoxColumn.HeaderText = "CMND";
            this.cMNDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cMNDDataGridViewTextBoxColumn.Name = "cMNDDataGridViewTextBoxColumn";
            this.cMNDDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(MultiCardSystem.Data.Entities.Customer);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDAccountDataGridViewTextBoxColumn
            // 
            this.iDAccountDataGridViewTextBoxColumn.DataPropertyName = "IDAccount";
            this.iDAccountDataGridViewTextBoxColumn.HeaderText = "IDAccount";
            this.iDAccountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDAccountDataGridViewTextBoxColumn.Name = "iDAccountDataGridViewTextBoxColumn";
            this.iDAccountDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passWordDataGridViewTextBoxColumn
            // 
            this.passWordDataGridViewTextBoxColumn.DataPropertyName = "PassWord";
            this.passWordDataGridViewTextBoxColumn.HeaderText = "PassWord";
            this.passWordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passWordDataGridViewTextBoxColumn.Name = "passWordDataGridViewTextBoxColumn";
            this.passWordDataGridViewTextBoxColumn.Width = 125;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "Money";
            this.moneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleNameDataGridViewTextBoxColumn
            // 
            this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.HeaderText = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            this.roleNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(MultiCardSystem.Data.Entities.Account);
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // iDCardDataGridViewTextBoxColumn
            // 
            this.iDCardDataGridViewTextBoxColumn.DataPropertyName = "IDCard";
            this.iDCardDataGridViewTextBoxColumn.HeaderText = "IDCard";
            this.iDCardDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCardDataGridViewTextBoxColumn.Name = "iDCardDataGridViewTextBoxColumn";
            this.iDCardDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.Width = 125;
            // 
            // pINCodeDataGridViewTextBoxColumn
            // 
            this.pINCodeDataGridViewTextBoxColumn.DataPropertyName = "PINCode";
            this.pINCodeDataGridViewTextBoxColumn.HeaderText = "PINCode";
            this.pINCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pINCodeDataGridViewTextBoxColumn.Name = "pINCodeDataGridViewTextBoxColumn";
            this.pINCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cardBindingSource
            // 
            this.cardBindingSource.DataSource = typeof(MultiCardSystem.Data.Entities.Card);
            // 
            // QuanLyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiCardSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 493);
            this.Controls.Add(this.tcQuanLy);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuanLyScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.Load += new System.EventHandler(this.QuanLyScreen_Load);
            this.tcQuanLy.ResumeLayout(false);
            this.qlKhachHang.ResumeLayout(false);
            this.qlKhachHang.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.qlTaiKhoan.ResumeLayout(false);
            this.qlTaiKhoan.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.qlThe.ResumeLayout(false);
            this.qlThe.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcQuanLy;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoaKhachHang;
        private System.Windows.Forms.Button btnSuaKhachHang;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage qlTaiKhoan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnXoaTaiKhoan;
        private System.Windows.Forms.Button btnThemTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.TabPage qlThe;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnXoaThe;
        private System.Windows.Forms.Button btnThemThe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvThe;
        private System.Windows.Forms.TabPage qlKhachHang;
        private System.Windows.Forms.TabPage btnThoat;
        private System.Windows.Forms.Button btnSuaTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passWordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pINCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cardBindingSource;
    }
}