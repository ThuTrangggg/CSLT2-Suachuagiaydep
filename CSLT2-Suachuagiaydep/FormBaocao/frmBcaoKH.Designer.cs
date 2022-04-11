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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bcaoKHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bcaoKHDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bcaoKHDataset = new CSLT2_Suachuagiaydep.DatasetReport.BcaoKHDataset();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rpvKH = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnThongke = new System.Windows.Forms.Button();
            this.cboLuachon = new System.Windows.Forms.ComboBox();
            this.rdoQuy = new System.Windows.Forms.RadioButton();
            this.rdoThang = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rdoSoluongHD = new System.Windows.Forms.RadioButton();
            this.rdoTongtien = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rpvKHmax = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BcaoKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bcaoKHTableAdapter = new CSLT2_Suachuagiaydep.DatasetReport.BcaoKHDatasetTableAdapters.BcaoKHTableAdapter();
            this.bcaoKHDatasetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bcaoHDnhanhang = new CSLT2_Suachuagiaydep.DatasetReport.BcaoHDnhanhang();
            this.tblHDnhanhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHDnhanhangTableAdapter = new CSLT2_Suachuagiaydep.DatasetReport.BcaoHDnhanhangTableAdapters.tblHDnhanhangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoKHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoKHDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoKHDataset)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BcaoKHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoKHDatasetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoHDnhanhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHDnhanhangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bcaoKHBindingSource1
            // 
            this.bcaoKHBindingSource1.DataMember = "BcaoKH";
            this.bcaoKHBindingSource1.DataSource = this.bcaoKHDatasetBindingSource;
            // 
            // bcaoKHDatasetBindingSource
            // 
            this.bcaoKHDatasetBindingSource.DataSource = this.bcaoKHDataset;
            this.bcaoKHDatasetBindingSource.Position = 0;
            // 
            // bcaoKHDataset
            // 
            this.bcaoKHDataset.DataSetName = "BcaoKHDataset";
            this.bcaoKHDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            reportDataSource3.Name = "BcaoKHDS";
            reportDataSource3.Value = this.bcaoKHBindingSource1;
            this.rpvKH.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvKH.LocalReport.ReportEmbeddedResource = "CSLT2_Suachuagiaydep.DatasetReport.BcaoKHrpv.rdlc";
            this.rpvKH.Location = new System.Drawing.Point(30, 61);
            this.rpvKH.Name = "rpvKH";
            this.rpvKH.ServerReport.BearerToken = null;
            this.rpvKH.Size = new System.Drawing.Size(703, 314);
            this.rpvKH.TabIndex = 6;
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(392, 21);
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
            this.cboLuachon.Location = new System.Drawing.Point(283, 22);
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
            this.tabPage2.Controls.Add(this.rdoSoluongHD);
            this.tabPage2.Controls.Add(this.rdoTongtien);
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
            // rdoSoluongHD
            // 
            this.rdoSoluongHD.AutoSize = true;
            this.rdoSoluongHD.Location = new System.Drawing.Point(199, 16);
            this.rdoSoluongHD.Name = "rdoSoluongHD";
            this.rdoSoluongHD.Size = new System.Drawing.Size(108, 17);
            this.rdoSoluongHD.TabIndex = 7;
            this.rdoSoluongHD.TabStop = true;
            this.rdoSoluongHD.Text = "số lượng hoá đơn";
            this.rdoSoluongHD.UseVisualStyleBackColor = true;
            this.rdoSoluongHD.CheckedChanged += new System.EventHandler(this.rdoSoluongHD_CheckedChanged);
            // 
            // rdoTongtien
            // 
            this.rdoTongtien.AutoSize = true;
            this.rdoTongtien.Location = new System.Drawing.Point(123, 17);
            this.rdoTongtien.Name = "rdoTongtien";
            this.rdoTongtien.Size = new System.Drawing.Size(70, 17);
            this.rdoTongtien.TabIndex = 4;
            this.rdoTongtien.TabStop = true;
            this.rdoTongtien.Text = "Tổng tiền";
            this.rdoTongtien.UseVisualStyleBackColor = true;
            this.rdoTongtien.CheckedChanged += new System.EventHandler(this.rdoTongtien_CheckedChanged);
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
            reportDataSource2.Name = "DataSetBcaoHDnhanhang";
            reportDataSource2.Value = this.tblHDnhanhangBindingSource;
            this.rpvKHmax.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvKHmax.LocalReport.ReportEmbeddedResource = "CSLT2_Suachuagiaydep.DatasetReport.BcaoHDnhanhangrp.rdlc";
            this.rpvKHmax.Location = new System.Drawing.Point(25, 55);
            this.rpvKHmax.Name = "rpvKHmax";
            this.rpvKHmax.ServerReport.BearerToken = null;
            this.rpvKHmax.Size = new System.Drawing.Size(702, 314);
            this.rpvKHmax.TabIndex = 0;
            // 
            // BcaoKHBindingSource
            // 
            this.BcaoKHBindingSource.DataMember = "BcaoKH";
            this.BcaoKHBindingSource.DataSource = this.bcaoKHDataset;
            // 
            // bcaoKHTableAdapter
            // 
            this.bcaoKHTableAdapter.ClearBeforeFill = true;
            // 
            // bcaoKHDatasetBindingSource1
            // 
            this.bcaoKHDatasetBindingSource1.DataSource = this.bcaoKHDataset;
            this.bcaoKHDatasetBindingSource1.Position = 0;
            // 
            // bcaoHDnhanhang
            // 
            this.bcaoHDnhanhang.DataSetName = "BcaoHDnhanhang";
            this.bcaoHDnhanhang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHDnhanhangBindingSource
            // 
            this.tblHDnhanhangBindingSource.DataMember = "tblHDnhanhang";
            this.tblHDnhanhangBindingSource.DataSource = this.bcaoHDnhanhang;
            // 
            // tblHDnhanhangTableAdapter
            // 
            this.tblHDnhanhangTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.bcaoKHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoKHDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoKHDataset)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BcaoKHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoKHDatasetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoHDnhanhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHDnhanhangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.ComboBox cboLuachon;
        private System.Windows.Forms.RadioButton rdoQuy;
        private System.Windows.Forms.RadioButton rdoThang;
        private System.Windows.Forms.TextBox textBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvKH;
        private System.Windows.Forms.RadioButton rdoTongtien;
        private System.Windows.Forms.TextBox textBox2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvKHmax;
        private System.Windows.Forms.BindingSource bcaoKHBindingSource1;
        private System.Windows.Forms.BindingSource bcaoKHDatasetBindingSource;
        private DatasetReport.BcaoKHDataset bcaoKHDataset;
        private System.Windows.Forms.BindingSource BcaoKHBindingSource;
        private DatasetReport.BcaoKHDatasetTableAdapters.BcaoKHTableAdapter bcaoKHTableAdapter;
        private System.Windows.Forms.BindingSource bcaoKHDatasetBindingSource1;
        private System.Windows.Forms.RadioButton rdoSoluongHD;
        private System.Windows.Forms.BindingSource tblHDnhanhangBindingSource;
        private DatasetReport.BcaoHDnhanhang bcaoHDnhanhang;
        private DatasetReport.BcaoHDnhanhangTableAdapters.tblHDnhanhangTableAdapter tblHDnhanhangTableAdapter;
    }
}