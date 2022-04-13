namespace CSLT2_Suachuagiaydep
{
    partial class frmTimkiemHDnhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimkiemHDnhan));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nam = new System.Windows.Forms.TextBox();
            this.lb_nam = new System.Windows.Forms.Label();
            this.tb_thang = new System.Windows.Forms.TextBox();
            this.lb_thang = new System.Windows.Forms.Label();
            this.bt_tim = new System.Windows.Forms.Button();
            this.dtgv_HD = new System.Windows.Forms.DataGridView();
            this.tb_ngay = new System.Windows.Forms.TextBox();
            this.tb_tenkhach = new System.Windows.Forms.TextBox();
            this.tb_maHD = new System.Windows.Forms.TextBox();
            this.lb_tenkhach = new System.Windows.Forms.Label();
            this.lb_ngay = new System.Windows.Forms.Label();
            this.lb_MHD = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTimlai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "TÌM KIẾM HÓA ĐƠN NHẬN";
            // 
            // tb_nam
            // 
            this.tb_nam.Location = new System.Drawing.Point(603, 114);
            this.tb_nam.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nam.Name = "tb_nam";
            this.tb_nam.Size = new System.Drawing.Size(95, 20);
            this.tb_nam.TabIndex = 25;
            // 
            // lb_nam
            // 
            this.lb_nam.AutoSize = true;
            this.lb_nam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nam.Location = new System.Drawing.Point(498, 147);
            this.lb_nam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_nam.Name = "lb_nam";
            this.lb_nam.Size = new System.Drawing.Size(41, 19);
            this.lb_nam.TabIndex = 24;
            this.lb_nam.Text = "Năm";
            // 
            // tb_thang
            // 
            this.tb_thang.Location = new System.Drawing.Point(603, 77);
            this.tb_thang.Margin = new System.Windows.Forms.Padding(2);
            this.tb_thang.Name = "tb_thang";
            this.tb_thang.Size = new System.Drawing.Size(146, 20);
            this.tb_thang.TabIndex = 23;
            // 
            // lb_thang
            // 
            this.lb_thang.AutoSize = true;
            this.lb_thang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thang.Location = new System.Drawing.Point(498, 112);
            this.lb_thang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_thang.Name = "lb_thang";
            this.lb_thang.Size = new System.Drawing.Size(51, 19);
            this.lb_thang.TabIndex = 22;
            this.lb_thang.Text = "Tháng";
            // 
            // bt_tim
            // 
            this.bt_tim.BackColor = System.Drawing.Color.MistyRose;
            this.bt_tim.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.ForeColor = System.Drawing.Color.Black;
            this.bt_tim.Image = global::CSLT2_Suachuagiaydep.Properties.Resources.Search;
            this.bt_tim.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_tim.Location = new System.Drawing.Point(238, 231);
            this.bt_tim.Margin = new System.Windows.Forms.Padding(2);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(113, 40);
            this.bt_tim.TabIndex = 21;
            this.bt_tim.Text = "Tìm kiếm";
            this.bt_tim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_tim.UseVisualStyleBackColor = false;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // dtgv_HD
            // 
            this.dtgv_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_HD.Location = new System.Drawing.Point(97, 298);
            this.dtgv_HD.Margin = new System.Windows.Forms.Padding(2);
            this.dtgv_HD.Name = "dtgv_HD";
            this.dtgv_HD.RowHeadersWidth = 51;
            this.dtgv_HD.RowTemplate.Height = 24;
            this.dtgv_HD.Size = new System.Drawing.Size(650, 196);
            this.dtgv_HD.TabIndex = 20;
            this.dtgv_HD.DoubleClick += new System.EventHandler(this.dtgv_HD_DoubleClick);
            // 
            // tb_ngay
            // 
            this.tb_ngay.Location = new System.Drawing.Point(603, 149);
            this.tb_ngay.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ngay.Name = "tb_ngay";
            this.tb_ngay.Size = new System.Drawing.Size(146, 20);
            this.tb_ngay.TabIndex = 19;
            // 
            // tb_tenkhach
            // 
            this.tb_tenkhach.Location = new System.Drawing.Point(204, 113);
            this.tb_tenkhach.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tenkhach.Name = "tb_tenkhach";
            this.tb_tenkhach.Size = new System.Drawing.Size(179, 20);
            this.tb_tenkhach.TabIndex = 18;
            // 
            // tb_maHD
            // 
            this.tb_maHD.Location = new System.Drawing.Point(204, 77);
            this.tb_maHD.Margin = new System.Windows.Forms.Padding(2);
            this.tb_maHD.Name = "tb_maHD";
            this.tb_maHD.Size = new System.Drawing.Size(110, 20);
            this.tb_maHD.TabIndex = 17;
            // 
            // lb_tenkhach
            // 
            this.lb_tenkhach.AutoSize = true;
            this.lb_tenkhach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenkhach.Location = new System.Drawing.Point(54, 113);
            this.lb_tenkhach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tenkhach.Name = "lb_tenkhach";
            this.lb_tenkhach.Size = new System.Drawing.Size(115, 19);
            this.lb_tenkhach.TabIndex = 16;
            this.lb_tenkhach.Text = "Tên khách hàng";
            // 
            // lb_ngay
            // 
            this.lb_ngay.AutoSize = true;
            this.lb_ngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngay.Location = new System.Drawing.Point(492, 73);
            this.lb_ngay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ngay.Name = "lb_ngay";
            this.lb_ngay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_ngay.Size = new System.Drawing.Size(81, 19);
            this.lb_ngay.TabIndex = 15;
            this.lb_ngay.Text = "Ngày nhận";
            // 
            // lb_MHD
            // 
            this.lb_MHD.AutoSize = true;
            this.lb_MHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MHD.Location = new System.Drawing.Point(54, 73);
            this.lb_MHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MHD.Name = "lb_MHD";
            this.lb_MHD.Size = new System.Drawing.Size(126, 19);
            this.lb_MHD.TabIndex = 14;
            this.lb_MHD.Text = "Mã hóa đơn nhận";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.MistyRose;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(526, 231);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(105, 40);
            this.btnDong.TabIndex = 29;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTimlai
            // 
            this.btnTimlai.BackColor = System.Drawing.Color.MistyRose;
            this.btnTimlai.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimlai.Image = ((System.Drawing.Image)(resources.GetObject("btnTimlai.Image")));
            this.btnTimlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimlai.Location = new System.Drawing.Point(387, 231);
            this.btnTimlai.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimlai.Name = "btnTimlai";
            this.btnTimlai.Size = new System.Drawing.Size(105, 40);
            this.btnTimlai.TabIndex = 28;
            this.btnTimlai.Text = "Tìm lại";
            this.btnTimlai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimlai.UseVisualStyleBackColor = false;
            this.btnTimlai.Click += new System.EventHandler(this.btnTimlai_Click);
            // 
            // frmTimkiemHDnhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSLT2_Suachuagiaydep.Properties.Resources.anh1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimlai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nam);
            this.Controls.Add(this.lb_nam);
            this.Controls.Add(this.tb_thang);
            this.Controls.Add(this.lb_thang);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.dtgv_HD);
            this.Controls.Add(this.tb_ngay);
            this.Controls.Add(this.tb_tenkhach);
            this.Controls.Add(this.tb_maHD);
            this.Controls.Add(this.lb_tenkhach);
            this.Controls.Add(this.lb_ngay);
            this.Controls.Add(this.lb_MHD);
            this.Name = "frmTimkiemHDnhan";
            this.Text = "frmTimkiemHDnhan";
            this.Load += new System.EventHandler(this.frmTimkiemHDnhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nam;
        private System.Windows.Forms.Label lb_nam;
        private System.Windows.Forms.TextBox tb_thang;
        private System.Windows.Forms.Label lb_thang;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.DataGridView dtgv_HD;
        private System.Windows.Forms.TextBox tb_ngay;
        private System.Windows.Forms.TextBox tb_tenkhach;
        private System.Windows.Forms.TextBox tb_maHD;
        private System.Windows.Forms.Label lb_tenkhach;
        private System.Windows.Forms.Label lb_ngay;
        private System.Windows.Forms.Label lb_MHD;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTimlai;
    }
}