namespace CSLT2_Suachuagiaydep
{
    partial class frmTimkiemSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimkiemSP));
            this.label1 = new System.Windows.Forms.Label();
            this.bt_tim = new System.Windows.Forms.Button();
            this.dtgw_sp = new System.Windows.Forms.DataGridView();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.lb_tenkhach = new System.Windows.Forms.Label();
            this.lb_ténp = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimlai = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_sp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(323, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "TÌM KIẾM SẢN PHẨM ";
            // 
            // bt_tim
            // 
            this.bt_tim.BackColor = System.Drawing.Color.MistyRose;
            this.bt_tim.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tim.Image = ((System.Drawing.Image)(resources.GetObject("bt_tim.Image")));
            this.bt_tim.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bt_tim.Location = new System.Drawing.Point(536, 69);
            this.bt_tim.Margin = new System.Windows.Forms.Padding(2);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(105, 40);
            this.bt_tim.TabIndex = 16;
            this.bt_tim.Text = "Tìm kiếm";
            this.bt_tim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_tim.UseVisualStyleBackColor = false;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // dtgw_sp
            // 
            this.dtgw_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgw_sp.Location = new System.Drawing.Point(149, 241);
            this.dtgw_sp.Margin = new System.Windows.Forms.Padding(2);
            this.dtgw_sp.Name = "dtgw_sp";
            this.dtgw_sp.RowHeadersWidth = 51;
            this.dtgw_sp.RowTemplate.Height = 24;
            this.dtgw_sp.Size = new System.Drawing.Size(505, 189);
            this.dtgw_sp.TabIndex = 15;
            this.dtgw_sp.DoubleClick += new System.EventHandler(this.dtgw_sp_DoubleClick);
            // 
            // txtMasp
            // 
            this.txtMasp.Location = new System.Drawing.Point(266, 69);
            this.txtMasp.Margin = new System.Windows.Forms.Padding(2);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(138, 20);
            this.txtMasp.TabIndex = 14;
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(266, 112);
            this.txtTensp.Margin = new System.Windows.Forms.Padding(2);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(138, 20);
            this.txtTensp.TabIndex = 13;
            // 
            // lb_tenkhach
            // 
            this.lb_tenkhach.AutoSize = true;
            this.lb_tenkhach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenkhach.Location = new System.Drawing.Point(145, 68);
            this.lb_tenkhach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tenkhach.Name = "lb_tenkhach";
            this.lb_tenkhach.Size = new System.Drawing.Size(100, 19);
            this.lb_tenkhach.TabIndex = 12;
            this.lb_tenkhach.Text = "Mã sản phẩm";
            // 
            // lb_ténp
            // 
            this.lb_ténp.AutoSize = true;
            this.lb_ténp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ténp.Location = new System.Drawing.Point(145, 111);
            this.lb_ténp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ténp.Name = "lb_ténp";
            this.lb_ténp.Size = new System.Drawing.Size(102, 19);
            this.lb_ténp.TabIndex = 11;
            this.lb_ténp.Text = "Tên sản phẩm";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(266, 200);
            this.txtSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(138, 20);
            this.txtSize.TabIndex = 21;
            // 
            // txtMau
            // 
            this.txtMau.Location = new System.Drawing.Point(266, 158);
            this.txtMau.Margin = new System.Windows.Forms.Padding(2);
            this.txtMau.Name = "txtMau";
            this.txtMau.Size = new System.Drawing.Size(138, 20);
            this.txtMau.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Màu";
            // 
            // btnTimlai
            // 
            this.btnTimlai.BackColor = System.Drawing.Color.MistyRose;
            this.btnTimlai.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimlai.Image = ((System.Drawing.Image)(resources.GetObject("btnTimlai.Image")));
            this.btnTimlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimlai.Location = new System.Drawing.Point(536, 128);
            this.btnTimlai.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimlai.Name = "btnTimlai";
            this.btnTimlai.Size = new System.Drawing.Size(105, 40);
            this.btnTimlai.TabIndex = 22;
            this.btnTimlai.Text = "Tìm lại";
            this.btnTimlai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimlai.UseVisualStyleBackColor = false;
            this.btnTimlai.Click += new System.EventHandler(this.btnTimlai_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.MistyRose;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(536, 187);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(105, 40);
            this.btnDong.TabIndex = 23;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmTimkiemSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CSLT2_Suachuagiaydep.Properties.Resources.anh1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimlai);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtMau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.dtgw_sp);
            this.Controls.Add(this.txtMasp);
            this.Controls.Add(this.txtTensp);
            this.Controls.Add(this.lb_tenkhach);
            this.Controls.Add(this.lb_ténp);
            this.Name = "frmTimkiemSP";
            this.Text = "frmTimkiemSP";
            this.Load += new System.EventHandler(this.frmTimkiemSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgw_sp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.DataGridView dtgw_sp;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.Label lb_tenkhach;
        private System.Windows.Forms.Label lb_ténp;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtMau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimlai;
        private System.Windows.Forms.Button btnDong;
    }
}