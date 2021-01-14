namespace MultiCardSystem.Screen
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.pnlMatKhau = new System.Windows.Forms.Panel();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.pnlSoTaiKhoan = new System.Windows.Forms.Panel();
            this.txbSoTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbSoTaikhoan = new System.Windows.Forms.Label();
            this.nameApp = new System.Windows.Forms.Label();
            this.picbLogin = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlMatKhau.SuspendLayout();
            this.pnlSoTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.nameApp);
            this.panel2.Location = new System.Drawing.Point(449, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 484);
            this.panel2.TabIndex = 1;
           
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDangNhap);
            this.panel3.Controls.Add(this.lbDangNhap);
            this.panel3.Controls.Add(this.pnlMatKhau);
            this.panel3.Controls.Add(this.pnlSoTaiKhoan);
            this.panel3.Location = new System.Drawing.Point(7, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 251);
            this.panel3.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.Location = new System.Drawing.Point(97, 192);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(178, 45);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
          
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.Location = new System.Drawing.Point(12, 18);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(312, 29);
            this.lbDangNhap.TabIndex = 3;
            this.lbDangNhap.Text = "THÔNG TIN ĐĂNG NHẬP";
            // 
            // pnlMatKhau
            // 
            this.pnlMatKhau.Controls.Add(this.txbMatKhau);
            this.pnlMatKhau.Controls.Add(this.lbMatKhau);
            this.pnlMatKhau.Location = new System.Drawing.Point(3, 134);
            this.pnlMatKhau.Name = "pnlMatKhau";
            this.pnlMatKhau.Size = new System.Drawing.Size(351, 43);
            this.pnlMatKhau.TabIndex = 2;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.Location = new System.Drawing.Point(128, 3);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(220, 30);
            this.txbMatKhau.TabIndex = 2;
            this.txbMatKhau.UseSystemPasswordChar = true;
            this.txbMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMatKhau_KeyPress);
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(3, 13);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(82, 20);
            this.lbMatKhau.TabIndex = 0;
            this.lbMatKhau.Text = "Mật khẩu:";
            // 
            // pnlSoTaiKhoan
            // 
            this.pnlSoTaiKhoan.Controls.Add(this.txbSoTaiKhoan);
            this.pnlSoTaiKhoan.Controls.Add(this.lbSoTaikhoan);
            this.pnlSoTaiKhoan.Location = new System.Drawing.Point(3, 66);
            this.pnlSoTaiKhoan.Name = "pnlSoTaiKhoan";
            this.pnlSoTaiKhoan.Size = new System.Drawing.Size(351, 43);
            this.pnlSoTaiKhoan.TabIndex = 0;
            // 
            // txbSoTaiKhoan
            // 
            this.txbSoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSoTaiKhoan.Location = new System.Drawing.Point(128, 6);
            this.txbSoTaiKhoan.Name = "txbSoTaiKhoan";
            this.txbSoTaiKhoan.Size = new System.Drawing.Size(220, 30);
            this.txbSoTaiKhoan.TabIndex = 1;
            // 
            // lbSoTaikhoan
            // 
            this.lbSoTaikhoan.AutoSize = true;
            this.lbSoTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTaikhoan.Location = new System.Drawing.Point(3, 13);
            this.lbSoTaikhoan.Name = "lbSoTaikhoan";
            this.lbSoTaikhoan.Size = new System.Drawing.Size(106, 20);
            this.lbSoTaikhoan.TabIndex = 0;
            this.lbSoTaikhoan.Text = "Số tài khoản:";
            // 
            // nameApp
            // 
            this.nameApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameApp.Location = new System.Drawing.Point(4, 47);
            this.nameApp.Name = "nameApp";
            this.nameApp.Size = new System.Drawing.Size(361, 88);
            this.nameApp.TabIndex = 0;
            this.nameApp.Text = "HỆ THỐNG GIAO DỊCH BẰNG THẺ ĐA NĂNG";
            this.nameApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picbLogin
            // 
            this.picbLogin.BackColor = System.Drawing.Color.Transparent;
            this.picbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbLogin.Image = global::MultiCardSystem.Properties.Resources.nganHang;
            this.picbLogin.Location = new System.Drawing.Point(-3, 2);
            this.picbLogin.Name = "picbLogin";
            this.picbLogin.Size = new System.Drawing.Size(450, 484);
            this.picbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbLogin.TabIndex = 2;
            this.picbLogin.TabStop = false;
           
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiCardSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 493);
            this.Controls.Add(this.picbLogin);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
          
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlMatKhau.ResumeLayout(false);
            this.pnlMatKhau.PerformLayout();
            this.pnlSoTaiKhoan.ResumeLayout(false);
            this.pnlSoTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label nameApp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.Panel pnlMatKhau;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Panel pnlSoTaiKhoan;
        private System.Windows.Forms.TextBox txbSoTaiKhoan;
        private System.Windows.Forms.Label lbSoTaikhoan;
        private System.Windows.Forms.PictureBox picbLogin;
    }
}