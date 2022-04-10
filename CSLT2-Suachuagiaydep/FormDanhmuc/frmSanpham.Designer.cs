namespace CSLT2_Suachuagiaydep
{
    partial class frmSanpham
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.DataGridViewSP = new System.Windows.Forms.DataGridView();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnHienthi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(292, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn giá ";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(78, 279);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 39);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(176, 279);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 39);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(372, 279);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 39);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(274, 279);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 39);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(768, 279);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(92, 39);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(659, 279);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(92, 39);
            this.btnBoqua.TabIndex = 1;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // DataGridViewSP
            // 
            this.DataGridViewSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSP.Location = new System.Drawing.Point(78, 340);
            this.DataGridViewSP.Name = "DataGridViewSP";
            this.DataGridViewSP.RowHeadersWidth = 51;
            this.DataGridViewSP.RowTemplate.Height = 24;
            this.DataGridViewSP.Size = new System.Drawing.Size(803, 201);
            this.DataGridViewSP.TabIndex = 2;
            this.DataGridViewSP.Click += new System.EventHandler(this.DataGridViewSP_Click);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(225, 88);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(100, 22);
            this.txtMaSP.TabIndex = 3;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(605, 85);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(100, 22);
            this.txtSoluong.TabIndex = 3;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(230, 135);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(212, 22);
            this.txtTenSP.TabIndex = 3;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(605, 135);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(100, 22);
            this.txtDongia.TabIndex = 4;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(470, 279);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(85, 39);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(568, 279);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(85, 39);
            this.btnHienthi.TabIndex = 5;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // frmSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 583);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.DataGridViewSP);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSanpham";
            this.Text = "frmSanpham";
            this.Load += new System.EventHandler(this.frmSanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.DataGridView DataGridViewSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnHienthi;
    }
}