namespace CSLT2_Suachuagiaydep
{
    partial class frmTimkiemHDdua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimkiemHDdua));
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nam = new System.Windows.Forms.TextBox();
            this.tb_masp = new System.Windows.Forms.TextBox();
            this.lb_nam = new System.Windows.Forms.Label();
            this.lb_masp = new System.Windows.Forms.Label();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.dtgw_HDD = new System.Windows.Forms.DataGridView();
            this.tb_ngay = new System.Windows.Forms.TextBox();
            this.tb_thang = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_thang = new System.Windows.Forms.Label();
            this.lb_ngay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_HDD)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(260, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "TÌM KIẾM HÓA ĐƠN ĐƯA XƯỞNG";
            // 
            // tb_nam
            // 
            this.tb_nam.Location = new System.Drawing.Point(283, 111);
            this.tb_nam.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nam.Name = "tb_nam";
            this.tb_nam.Size = new System.Drawing.Size(130, 20);
            this.tb_nam.TabIndex = 24;
            // 
            // tb_masp
            // 
            this.tb_masp.Location = new System.Drawing.Point(283, 146);
            this.tb_masp.Margin = new System.Windows.Forms.Padding(2);
            this.tb_masp.Name = "tb_masp";
            this.tb_masp.Size = new System.Drawing.Size(130, 20);
            this.tb_masp.TabIndex = 23;
            // 
            // lb_nam
            // 
            this.lb_nam.AutoSize = true;
            this.lb_nam.BackColor = System.Drawing.Color.Transparent;
            this.lb_nam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nam.Location = new System.Drawing.Point(118, 229);
            this.lb_nam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_nam.Name = "lb_nam";
            this.lb_nam.Size = new System.Drawing.Size(41, 19);
            this.lb_nam.TabIndex = 22;
            this.lb_nam.Text = "Năm";
            // 
            // lb_masp
            // 
            this.lb_masp.AutoSize = true;
            this.lb_masp.BackColor = System.Drawing.Color.Transparent;
            this.lb_masp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_masp.Location = new System.Drawing.Point(112, 104);
            this.lb_masp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_masp.Name = "lb_masp";
            this.lb_masp.Size = new System.Drawing.Size(55, 19);
            this.lb_masp.TabIndex = 21;
            this.lb_masp.Text = "Mã SP";
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.MistyRose;
            this.bt_timkiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiem.ForeColor = System.Drawing.Color.Black;
            this.bt_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("bt_timkiem.Image")));
            this.bt_timkiem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_timkiem.Location = new System.Drawing.Point(598, 205);
            this.bt_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(104, 64);
            this.bt_timkiem.TabIndex = 20;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // dtgw_HDD
            // 
            this.dtgw_HDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgw_HDD.Location = new System.Drawing.Point(140, 274);
            this.dtgw_HDD.Margin = new System.Windows.Forms.Padding(2);
            this.dtgw_HDD.Name = "dtgw_HDD";
            this.dtgw_HDD.RowHeadersWidth = 51;
            this.dtgw_HDD.RowTemplate.Height = 24;
            this.dtgw_HDD.Size = new System.Drawing.Size(533, 232);
            this.dtgw_HDD.TabIndex = 19;
            // 
            // tb_ngay
            // 
            this.tb_ngay.Location = new System.Drawing.Point(283, 188);
            this.tb_ngay.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ngay.Name = "tb_ngay";
            this.tb_ngay.Size = new System.Drawing.Size(130, 20);
            this.tb_ngay.TabIndex = 18;
            // 
            // tb_thang
            // 
            this.tb_thang.Location = new System.Drawing.Point(283, 232);
            this.tb_thang.Margin = new System.Windows.Forms.Padding(2);
            this.tb_thang.Name = "tb_thang";
            this.tb_thang.Size = new System.Drawing.Size(130, 20);
            this.tb_thang.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 73);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 16;
            // 
            // lb_thang
            // 
            this.lb_thang.AutoSize = true;
            this.lb_thang.BackColor = System.Drawing.Color.Transparent;
            this.lb_thang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thang.Location = new System.Drawing.Point(118, 188);
            this.lb_thang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_thang.Name = "lb_thang";
            this.lb_thang.Size = new System.Drawing.Size(51, 19);
            this.lb_thang.TabIndex = 15;
            this.lb_thang.Text = "Tháng";
            // 
            // lb_ngay
            // 
            this.lb_ngay.AutoSize = true;
            this.lb_ngay.BackColor = System.Drawing.Color.Transparent;
            this.lb_ngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngay.Location = new System.Drawing.Point(118, 146);
            this.lb_ngay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ngay.Name = "lb_ngay";
            this.lb_ngay.Size = new System.Drawing.Size(49, 19);
            this.lb_ngay.TabIndex = 14;
            this.lb_ngay.Text = "Ngày ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã hóa đơn đưa xưởng";
            // 
            // frmTimkiemHDdua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSLT2_Suachuagiaydep.Properties.Resources.anh1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nam);
            this.Controls.Add(this.tb_masp);
            this.Controls.Add(this.lb_nam);
            this.Controls.Add(this.lb_masp);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.dtgw_HDD);
            this.Controls.Add(this.tb_ngay);
            this.Controls.Add(this.tb_thang);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_thang);
            this.Controls.Add(this.lb_ngay);
            this.Controls.Add(this.label1);
            this.Name = "frmTimkiemHDdua";
            this.Text = "frmTimkiemHDdua";
            this.Load += new System.EventHandler(this.frmTimkiemHDdua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_HDD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nam;
        private System.Windows.Forms.TextBox tb_masp;
        private System.Windows.Forms.Label lb_nam;
        private System.Windows.Forms.Label lb_masp;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.DataGridView dtgw_HDD;
        private System.Windows.Forms.TextBox tb_ngay;
        private System.Windows.Forms.TextBox tb_thang;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_thang;
        private System.Windows.Forms.Label lb_ngay;
        private System.Windows.Forms.Label label1;
    }
}