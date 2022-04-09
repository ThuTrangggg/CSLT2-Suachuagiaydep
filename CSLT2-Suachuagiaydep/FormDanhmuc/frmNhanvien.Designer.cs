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
            this.label1 = new System.Windows.Forms.Label();
            this.chkGioitinh = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColManv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNamsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCongviec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.mskNamsinh = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 22);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColManv,
            this.ColTennv,
            this.ColGioitinh,
            this.ColDiachi,
            this.ColNamsinh,
            this.ColCongviec,
            this.ColLuong});
            this.dataGridView.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView.Location = new System.Drawing.Point(73, 338);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1061, 246);
            this.dataGridView.TabIndex = 4;
            // 
            // ColManv
            // 
            this.ColManv.HeaderText = "Mã nhân viên";
            this.ColManv.MinimumWidth = 6;
            this.ColManv.Name = "ColManv";
            this.ColManv.Width = 125;
            // 
            // ColTennv
            // 
            this.ColTennv.HeaderText = "Tên nhân viên";
            this.ColTennv.MinimumWidth = 6;
            this.ColTennv.Name = "ColTennv";
            this.ColTennv.Width = 125;
            // 
            // ColGioitinh
            // 
            this.ColGioitinh.HeaderText = "Giới tính";
            this.ColGioitinh.MinimumWidth = 6;
            this.ColGioitinh.Name = "ColGioitinh";
            this.ColGioitinh.Width = 125;
            // 
            // ColDiachi
            // 
            this.ColDiachi.HeaderText = "Địa chỉ";
            this.ColDiachi.MinimumWidth = 6;
            this.ColDiachi.Name = "ColDiachi";
            this.ColDiachi.Width = 125;
            // 
            // ColNamsinh
            // 
            this.ColNamsinh.HeaderText = "Năm sinh";
            this.ColNamsinh.MinimumWidth = 6;
            this.ColNamsinh.Name = "ColNamsinh";
            this.ColNamsinh.Width = 125;
            // 
            // ColCongviec
            // 
            this.ColCongviec.HeaderText = "Công việc";
            this.ColCongviec.MinimumWidth = 6;
            this.ColCongviec.Name = "ColCongviec";
            this.ColCongviec.Width = 125;
            // 
            // ColLuong
            // 
            this.ColLuong.HeaderText = "Lương";
            this.ColLuong.MinimumWidth = 6;
            this.ColLuong.Name = "ColLuong";
            this.ColLuong.Width = 125;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(311, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 208);
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(311, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 22);
            this.textBox3.TabIndex = 3;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(474, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(591, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 53);
            this.button4.TabIndex = 2;
            this.button4.Text = "Lưu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(917, 250);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 53);
            this.button5.TabIndex = 2;
            this.button5.Text = "Đóng";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(785, 250);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 53);
            this.button6.TabIndex = 2;
            this.button6.Text = "Bỏ qua";
            this.button6.UseVisualStyleBackColor = true;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(754, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(220, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(754, 153);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(91, 22);
            this.textBox5.TabIndex = 10;
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 596);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskNamsinh);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkGioitinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNhanvien";
            this.Text = "frmNhanvien";
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkGioitinh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColManv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNamsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCongviec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskNamsinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}