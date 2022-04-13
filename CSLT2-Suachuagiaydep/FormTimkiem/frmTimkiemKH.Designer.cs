namespace CSLT2_Suachuagiaydep
{
    partial class frmTimkiemKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimkiemKH));
            this.label1 = new System.Windows.Forms.Label();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.dtgw_KH = new System.Windows.Forms.DataGridView();
            this.tb_tennkhach = new System.Windows.Forms.TextBox();
            this.tb_makhach = new System.Windows.Forms.TextBox();
            this.lb_makhach = new System.Windows.Forms.Label();
            this.lb_tenkhach = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTimlai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_KH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "TÌM KIẾM KHÁCH HÀNG";
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.MistyRose;
            this.bt_timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiem.Image = global::CSLT2_Suachuagiaydep.Properties.Resources.Search;
            this.bt_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_timkiem.Location = new System.Drawing.Point(170, 148);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(112, 39);
            this.bt_timkiem.TabIndex = 12;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_timkiem.UseVisualStyleBackColor = false;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // dtgw_KH
            // 
            this.dtgw_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgw_KH.Location = new System.Drawing.Point(109, 209);
            this.dtgw_KH.Name = "dtgw_KH";
            this.dtgw_KH.RowHeadersWidth = 51;
            this.dtgw_KH.RowTemplate.Height = 24;
            this.dtgw_KH.Size = new System.Drawing.Size(578, 229);
            this.dtgw_KH.TabIndex = 11;
            this.dtgw_KH.DoubleClick += new System.EventHandler(this.dtgw_KH_DoubleClick);
            // 
            // tb_tennkhach
            // 
            this.tb_tennkhach.Location = new System.Drawing.Point(523, 80);
            this.tb_tennkhach.Name = "tb_tennkhach";
            this.tb_tennkhach.Size = new System.Drawing.Size(159, 20);
            this.tb_tennkhach.TabIndex = 10;
            // 
            // tb_makhach
            // 
            this.tb_makhach.Location = new System.Drawing.Point(209, 80);
            this.tb_makhach.Name = "tb_makhach";
            this.tb_makhach.Size = new System.Drawing.Size(151, 20);
            this.tb_makhach.TabIndex = 9;
            // 
            // lb_makhach
            // 
            this.lb_makhach.AutoSize = true;
            this.lb_makhach.BackColor = System.Drawing.Color.Transparent;
            this.lb_makhach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_makhach.Location = new System.Drawing.Point(130, 83);
            this.lb_makhach.Name = "lb_makhach";
            this.lb_makhach.Size = new System.Drawing.Size(73, 17);
            this.lb_makhach.TabIndex = 8;
            this.lb_makhach.Text = "Mã khách ";
            // 
            // lb_tenkhach
            // 
            this.lb_tenkhach.AutoSize = true;
            this.lb_tenkhach.BackColor = System.Drawing.Color.Transparent;
            this.lb_tenkhach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenkhach.Location = new System.Drawing.Point(441, 83);
            this.lb_tenkhach.Name = "lb_tenkhach";
            this.lb_tenkhach.Size = new System.Drawing.Size(76, 17);
            this.lb_tenkhach.TabIndex = 7;
            this.lb_tenkhach.Text = "Tên khách ";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.MistyRose;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(523, 151);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(112, 33);
            this.btnDong.TabIndex = 31;
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
            this.btnTimlai.Location = new System.Drawing.Point(351, 151);
            this.btnTimlai.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimlai.Name = "btnTimlai";
            this.btnTimlai.Size = new System.Drawing.Size(112, 33);
            this.btnTimlai.TabIndex = 30;
            this.btnTimlai.Text = "Tìm lại";
            this.btnTimlai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimlai.UseVisualStyleBackColor = false;
            this.btnTimlai.Click += new System.EventHandler(this.btnTimlai_Click);
            // 
            // frmTimkiemKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSLT2_Suachuagiaydep.Properties.Resources.anh2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimlai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.dtgw_KH);
            this.Controls.Add(this.tb_tennkhach);
            this.Controls.Add(this.tb_makhach);
            this.Controls.Add(this.lb_makhach);
            this.Controls.Add(this.lb_tenkhach);
            this.Name = "frmTimkiemKH";
            this.Text = "frmTimkiemKH";
            this.Load += new System.EventHandler(this.frmTimkiemKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_KH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.DataGridView dtgw_KH;
        private System.Windows.Forms.TextBox tb_tennkhach;
        private System.Windows.Forms.TextBox tb_makhach;
        private System.Windows.Forms.Label lb_makhach;
        private System.Windows.Forms.Label lb_tenkhach;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTimlai;
    }
}