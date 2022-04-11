namespace CSLT2_Suachuagiaydep.FormBaocao
{
    partial class frmBcaoKH
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rpvKH = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnThongke = new System.Windows.Forms.Button();
            this.cboLuachon = new System.Windows.Forms.ComboBox();
            this.rdoQuy = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoThang = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnThongkeMax = new System.Windows.Forms.Button();
            this.cboLuachonmax = new System.Windows.Forms.ComboBox();
            this.rdoNammax = new System.Windows.Forms.RadioButton();
            this.rdoQuymax = new System.Windows.Forms.RadioButton();
            this.rdoThangmax = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rpvKHmax = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rpvKH);
            this.tabPage1.Controls.Add(this.btnThongke);
            this.tabPage1.Controls.Add(this.cboLuachon);
            this.tabPage1.Controls.Add(this.rdoQuy);
            this.tabPage1.Controls.Add(this.rdoNam);
            this.tabPage1.Controls.Add(this.rdoThang);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(758, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách khách hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rpvKH
            // 
            this.rpvKH.Location = new System.Drawing.Point(30, 61);
            this.rpvKH.Name = "rpvKH";
            this.rpvKH.ServerReport.BearerToken = null;
            this.rpvKH.Size = new System.Drawing.Size(703, 314);
            this.rpvKH.TabIndex = 6;
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(478, 21);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(120, 23);
            this.btnThongke.TabIndex = 5;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // cboLuachon
            // 
            this.cboLuachon.FormattingEnabled = true;
            this.cboLuachon.Location = new System.Drawing.Point(369, 22);
            this.cboLuachon.Name = "cboLuachon";
            this.cboLuachon.Size = new System.Drawing.Size(83, 21);
            this.cboLuachon.TabIndex = 4;
            this.cboLuachon.DropDown += new System.EventHandler(this.cboLuachon_DropDown);
            // 
            // rdoQuy
            // 
            this.rdoQuy.AutoSize = true;
            this.rdoQuy.Location = new System.Drawing.Point(217, 24);
            this.rdoQuy.Name = "rdoQuy";
            this.rdoQuy.Size = new System.Drawing.Size(44, 17);
            this.rdoQuy.TabIndex = 3;
            this.rdoQuy.TabStop = true;
            this.rdoQuy.Text = "Quý";
            this.rdoQuy.UseVisualStyleBackColor = true;
            this.rdoQuy.CheckedChanged += new System.EventHandler(this.rdoQuy_CheckedChanged);
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(292, 23);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(47, 17);
            this.rdoNam.TabIndex = 2;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Năm";
            this.rdoNam.UseVisualStyleBackColor = true;
            this.rdoNam.CheckedChanged += new System.EventHandler(this.rdoNam_CheckedChanged);
            // 
            // rdoThang
            // 
            this.rdoThang.AutoSize = true;
            this.rdoThang.Location = new System.Drawing.Point(136, 24);
            this.rdoThang.Name = "rdoThang";
            this.rdoThang.Size = new System.Drawing.Size(56, 17);
            this.rdoThang.TabIndex = 1;
            this.rdoThang.TabStop = true;
            this.rdoThang.Text = "Tháng";
            this.rdoThang.UseVisualStyleBackColor = true;
            this.rdoThang.CheckedChanged += new System.EventHandler(this.rdoThang_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(30, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Báo cáo theo";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnThongkeMax);
            this.tabPage2.Controls.Add(this.cboLuachonmax);
            this.tabPage2.Controls.Add(this.rdoNammax);
            this.tabPage2.Controls.Add(this.rdoQuymax);
            this.tabPage2.Controls.Add(this.rdoThangmax);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.rpvKHmax);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(758, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách khách hàng sử dụng dịch vụ nhiều nhất ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnThongkeMax
            // 
            this.btnThongkeMax.Location = new System.Drawing.Point(460, 15);
            this.btnThongkeMax.Name = "btnThongkeMax";
            this.btnThongkeMax.Size = new System.Drawing.Size(136, 21);
            this.btnThongkeMax.TabIndex = 6;
            this.btnThongkeMax.Text = "Thống kê";
            this.btnThongkeMax.UseVisualStyleBackColor = true;
            // 
            // cboLuachonmax
            // 
            this.cboLuachonmax.FormattingEnabled = true;
            this.cboLuachonmax.Location = new System.Drawing.Point(352, 16);
            this.cboLuachonmax.Name = "cboLuachonmax";
            this.cboLuachonmax.Size = new System.Drawing.Size(70, 21);
            this.cboLuachonmax.TabIndex = 5;
            this.cboLuachonmax.DropDown += new System.EventHandler(this.cboLuachonmax_DropDown);
            // 
            // rdoNammax
            // 
            this.rdoNammax.AutoSize = true;
            this.rdoNammax.Location = new System.Drawing.Point(271, 19);
            this.rdoNammax.Name = "rdoNammax";
            this.rdoNammax.Size = new System.Drawing.Size(47, 17);
            this.rdoNammax.TabIndex = 4;
            this.rdoNammax.TabStop = true;
            this.rdoNammax.Text = "Năm";
            this.rdoNammax.UseVisualStyleBackColor = true;
            this.rdoNammax.CheckedChanged += new System.EventHandler(this.rdoNammax_CheckedChanged);
            // 
            // rdoQuymax
            // 
            this.rdoQuymax.AutoSize = true;
            this.rdoQuymax.Location = new System.Drawing.Point(197, 19);
            this.rdoQuymax.Name = "rdoQuymax";
            this.rdoQuymax.Size = new System.Drawing.Size(44, 17);
            this.rdoQuymax.TabIndex = 3;
            this.rdoQuymax.TabStop = true;
            this.rdoQuymax.Text = "Quý";
            this.rdoQuymax.UseVisualStyleBackColor = true;
            this.rdoQuymax.CheckedChanged += new System.EventHandler(this.rdoQuymax_CheckedChanged);
            // 
            // rdoThangmax
            // 
            this.rdoThangmax.AutoSize = true;
            this.rdoThangmax.Location = new System.Drawing.Point(122, 18);
            this.rdoThangmax.Name = "rdoThangmax";
            this.rdoThangmax.Size = new System.Drawing.Size(56, 17);
            this.rdoThangmax.TabIndex = 2;
            this.rdoThangmax.TabStop = true;
            this.rdoThangmax.Text = "Tháng";
            this.rdoThangmax.UseVisualStyleBackColor = true;
            this.rdoThangmax.CheckedChanged += new System.EventHandler(this.rdoThangmax_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(40, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Báo cáo theo";
            // 
            // rpvKHmax
            // 
            this.rpvKHmax.Location = new System.Drawing.Point(25, 55);
            this.rpvKHmax.Name = "rpvKHmax";
            this.rpvKHmax.ServerReport.BearerToken = null;
            this.rpvKHmax.Size = new System.Drawing.Size(702, 314);
            this.rpvKHmax.TabIndex = 0;
            // 
            // frmBcaoKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmBcaoKH";
            this.Text = "Báo cáo danh sách khách hàng";
            this.Load += new System.EventHandler(this.frmBcaoKH_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.ComboBox cboLuachon;
        private System.Windows.Forms.RadioButton rdoQuy;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoThang;
        private System.Windows.Forms.TextBox textBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvKH;
        private System.Windows.Forms.Button btnThongkeMax;
        private System.Windows.Forms.ComboBox cboLuachonmax;
        private System.Windows.Forms.RadioButton rdoNammax;
        private System.Windows.Forms.RadioButton rdoQuymax;
        private System.Windows.Forms.RadioButton rdoThangmax;
        private System.Windows.Forms.TextBox textBox2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvKHmax;
    }
}