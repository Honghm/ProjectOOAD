namespace MultiCardSystem.Screen
{
    partial class ChuyenTienScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSTKChuyen = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.PictureBox();
            this.btnQuayLai = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSoTienChuyen = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXacNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuayLai)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 97);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "DỊCH VỤ CHUYỂN TIỀN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tài khoản\r\nchuyển đến:\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbSTKChuyen
            // 
            this.txbSTKChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSTKChuyen.Location = new System.Drawing.Point(365, 25);
            this.txbSTKChuyen.Name = "txbSTKChuyen";
            this.txbSTKChuyen.Size = new System.Drawing.Size(236, 36);
            this.txbSTKChuyen.TabIndex = 1;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Transparent;
            this.btnXacNhan.BackgroundImage = global::MultiCardSystem.Properties.Resources.btnXacNhan;
            this.btnXacNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXacNhan.Location = new System.Drawing.Point(601, 384);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(249, 52);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.TabStop = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.Transparent;
            this.btnQuayLai.BackgroundImage = global::MultiCardSystem.Properties.Resources.btnQuayLai;
            this.btnQuayLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuayLai.Location = new System.Drawing.Point(12, 384);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(249, 52);
            this.btnQuayLai.TabIndex = 6;
            this.btnQuayLai.TabStop = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbSTKChuyen);
            this.panel2.Location = new System.Drawing.Point(98, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 85);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txbSoTienChuyen);
            this.panel3.Location = new System.Drawing.Point(98, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 85);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số tiền chuyển:\r\n";
            // 
            // txbSoTienChuyen
            // 
            this.txbSoTienChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSoTienChuyen.Location = new System.Drawing.Point(365, 25);
            this.txbSoTienChuyen.Name = "txbSoTienChuyen";
            this.txbSoTienChuyen.Size = new System.Drawing.Size(236, 36);
            this.txbSoTienChuyen.TabIndex = 2;
            // 
            // ChuyenTienScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiCardSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 493);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "ChuyenTienScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển tiền";
            this.Load += new System.EventHandler(this.ChuyenTien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXacNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuayLai)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSTKChuyen;
        private System.Windows.Forms.PictureBox btnXacNhan;
        private System.Windows.Forms.PictureBox btnQuayLai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSoTienChuyen;
    }
}