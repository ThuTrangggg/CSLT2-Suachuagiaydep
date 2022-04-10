namespace CSLT2_Suachuagiaydep
{
    partial class frmNhanvien
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkGioitinh = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.mskNamsinh = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCongviec = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.quanLyGiayDepDataSet = new CSLT2_Suachuagiaydep.QuanLyGiayDepDataSet();
            this.tblNhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblNhanvienTableAdapter = new CSLT2_Suachuagiaydep.QuanLyGiayDepDataSetTableAdapters.tblNhanvienTableAdapter();
            this.DataGridViewNV = new System.Windows.Forms.DataGridView();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtAnh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiayDepDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // chkGioitinh
            // 
            this.chkGioitinh.AutoSize = true;
            this.chkGioitinh.Location = new System.Drawing.Point(741, 80);
            this.chkGioitinh.Name = "chkGioitinh";
            this.chkGioitinh.Size = new System.Drawing.Size(58, 20);
            this.chkGioitinh.TabIndex = 1;
            this.chkGioitinh.Text = "Nam";
            this.chkGioitinh.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(217, 250);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 53);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(311, 82);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(134, 22);
            this.txtManv.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhân viên";
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(311, 115);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(193, 22);
            this.txtTennv.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ảnh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(311, 153);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(274, 22);
            this.txtDiachi.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(681, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Giới tính";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(344, 250);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 53);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(474, 250);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 53);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(591, 250);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(111, 53);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(917, 250);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(111, 53);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(785, 250);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(111, 53);
            this.btnBoqua.TabIndex = 2;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(681, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Công việc";
            // 
            // mskNamsinh
            // 
            this.mskNamsinh.Location = new System.Drawing.Point(959, 79);
            this.mskNamsinh.Mask = "00/00/0000";
            this.mskNamsinh.Name = "mskNamsinh";
            this.mskNamsinh.Size = new System.Drawing.Size(104, 22);
            this.mskNamsinh.TabIndex = 5;
            this.mskNamsinh.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(681, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Lương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(890, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Năm sinh";
            // 
            // txtCongviec
            // 
            this.txtCongviec.Location = new System.Drawing.Point(754, 124);
            this.txtCongviec.Name = "txtCongviec";
            this.txtCongviec.Size = new System.Drawing.Size(220, 22);
            this.txtCongviec.TabIndex = 10;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(754, 153);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(91, 22);
            this.txtLuong.TabIndex = 10;
            // 
            // quanLyGiayDepDataSet
            // 
            this.quanLyGiayDepDataSet.DataSetName = "QuanLyGiayDepDataSet";
            this.quanLyGiayDepDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNhanvienBindingSource
            // 
            this.tblNhanvienBindingSource.DataMember = "tblNhanvien";
            this.tblNhanvienBindingSource.DataSource = this.quanLyGiayDepDataSet;
            // 
            // tblNhanvienTableAdapter
            // 
            this.tblNhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // DataGridViewNV
            // 
            this.DataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewNV.Location = new System.Drawing.Point(147, 323);
            this.DataGridViewNV.Name = "DataGridViewNV";
            this.DataGridViewNV.RowHeadersWidth = 51;
            this.DataGridViewNV.RowTemplate.Height = 24;
            this.DataGridViewNV.Size = new System.Drawing.Size(948, 246);
            this.DataGridViewNV.TabIndex = 11;
            this.DataGridViewNV.Click += new System.EventHandler(this.DataGridViewNV_Click);
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(31, 56);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(100, 134);
            this.picAnh.TabIndex = 12;
            this.picAnh.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(41, 206);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 13;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(311, 189);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(222, 22);
            this.txtAnh.TabIndex = 14;
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 596);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.DataGridViewNV);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtCongviec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskNamsinh);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTennv);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkGioitinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNhanvien";
            this.Text = "frmNhanvien";
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiayDepDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkGioitinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskNamsinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCongviec;
        private System.Windows.Forms.TextBox txtLuong;
        private QuanLyGiayDepDataSet quanLyGiayDepDataSet;
        private System.Windows.Forms.BindingSource tblNhanvienBindingSource;
        private QuanLyGiayDepDataSetTableAdapters.tblNhanvienTableAdapter tblNhanvienTableAdapter;
        private System.Windows.Forms.DataGridView DataGridViewNV;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtAnh;
    }
}