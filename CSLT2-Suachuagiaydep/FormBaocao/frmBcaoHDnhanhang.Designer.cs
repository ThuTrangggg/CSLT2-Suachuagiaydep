namespace CSLT2_Suachuagiaydep.FormBaocao
{
    partial class frmBcaoHDnhanhang
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblHDnhanhangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bcaoHDnhanhangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bcaoHDnhanhang = new CSLT2_Suachuagiaydep.DatasetReport.BcaoHDnhanhang();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnThongke = new System.Windows.Forms.Button();
            this.rdoThang = new System.Windows.Forms.RadioButton();
            this.rdoQuy = new System.Windows.Forms.RadioButton();
            this.cboLuachon = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rpvBcaoHDnhan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bcaoHDnhanhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHDnhanhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHDnhanhangTableAdapter = new CSLT2_Suachuagiaydep.DatasetReport.BcaoHDnhanhangTableAdapters.tblHDnhanhangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblHDnhanhangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoHDnhanhangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoHDnhanhang)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoHDnhanhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHDnhanhangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblHDnhanhangBindingSource1
            // 
            this.tblHDnhanhangBindingSource1.DataMember = "tblHDnhanhang";
            this.tblHDnhanhangBindingSource1.DataSource = this.bcaoHDnhanhangBindingSource1;
            // 
            // bcaoHDnhanhangBindingSource1
            // 
            this.bcaoHDnhanhangBindingSource1.DataSource = this.bcaoHDnhanhang;
            this.bcaoHDnhanhangBindingSource1.Position = 0;
            // 
            // bcaoHDnhanhang
            // 
            this.bcaoHDnhanhang.DataSetName = "BcaoHDnhanhang";
            this.bcaoHDnhanhang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(28, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnThongke);
            this.tabPage1.Controls.Add(this.rdoThang);
            this.tabPage1.Controls.Add(this.rdoQuy);
            this.tabPage1.Controls.Add(this.cboLuachon);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.rpvBcaoHDnhan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách hoá đơn nhận ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(466, 15);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(133, 21);
            this.btnThongke.TabIndex = 5;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // rdoThang
            // 
            this.rdoThang.AutoSize = true;
            this.rdoThang.Location = new System.Drawing.Point(200, 15);
            this.rdoThang.Name = "rdoThang";
            this.rdoThang.Size = new System.Drawing.Size(56, 17);
            this.rdoThang.TabIndex = 4;
            this.rdoThang.TabStop = true;
            this.rdoThang.Text = "Tháng";
            this.rdoThang.UseVisualStyleBackColor = true;
            this.rdoThang.CheckedChanged += new System.EventHandler(this.rdoThang_CheckedChanged);
            // 
            // rdoQuy
            // 
            this.rdoQuy.AutoSize = true;
            this.rdoQuy.Location = new System.Drawing.Point(125, 16);
            this.rdoQuy.Name = "rdoQuy";
            this.rdoQuy.Size = new System.Drawing.Size(44, 17);
            this.rdoQuy.TabIndex = 3;
            this.rdoQuy.TabStop = true;
            this.rdoQuy.Text = "Quý";
            this.rdoQuy.UseVisualStyleBackColor = true;
            this.rdoQuy.CheckedChanged += new System.EventHandler(this.rdoQuy_CheckedChanged);
            // 
            // cboLuachon
            // 
            this.cboLuachon.FormattingEnabled = true;
            this.cboLuachon.Location = new System.Drawing.Point(314, 15);
            this.cboLuachon.Name = "cboLuachon";
            this.cboLuachon.Size = new System.Drawing.Size(121, 21);
            this.cboLuachon.TabIndex = 2;
            this.cboLuachon.DropDown += new System.EventHandler(this.cboLuachon_DropDown);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(33, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 13);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Báo cáo theo:";
            // 
            // rpvBcaoHDnhan
            // 
            reportDataSource1.Name = "DataSetBcaoHDnhanhang";
            reportDataSource1.Value = this.tblHDnhanhangBindingSource1;
            this.rpvBcaoHDnhan.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvBcaoHDnhan.LocalReport.ReportEmbeddedResource = "CSLT2_Suachuagiaydep.DatasetReport.BcaoHDnhanhangrp.rdlc";
            this.rpvBcaoHDnhan.Location = new System.Drawing.Point(22, 50);
            this.rpvBcaoHDnhan.Name = "rpvBcaoHDnhan";
            this.rpvBcaoHDnhan.ServerReport.BearerToken = null;
            this.rpvBcaoHDnhan.Size = new System.Drawing.Size(703, 306);
            this.rpvBcaoHDnhan.TabIndex = 0;
            // 
            // bcaoHDnhanhangBindingSource
            // 
            this.bcaoHDnhanhangBindingSource.DataSource = this.bcaoHDnhanhang;
            this.bcaoHDnhanhangBindingSource.Position = 0;
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
            // frmBcaoHDnhanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmBcaoHDnhanhang";
            this.Text = "Báo cáo HĐ nhận hàng";
            this.Load += new System.EventHandler(this.frmBcaoHDnhanhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblHDnhanhangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoHDnhanhangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoHDnhanhang)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoHDnhanhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHDnhanhangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBcaoHDnhan;
        private System.Windows.Forms.RadioButton rdoThang;
        private System.Windows.Forms.RadioButton rdoQuy;
        private System.Windows.Forms.ComboBox cboLuachon;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.BindingSource bcaoHDnhanhangBindingSource;
        private DatasetReport.BcaoHDnhanhang bcaoHDnhanhang;
        private System.Windows.Forms.BindingSource tblHDnhanhangBindingSource;
        private System.Windows.Forms.BindingSource bcaoHDnhanhangBindingSource1;
        private System.Windows.Forms.BindingSource tblHDnhanhangBindingSource1;
        private DatasetReport.BcaoHDnhanhangTableAdapters.tblHDnhanhangTableAdapter tblHDnhanhangTableAdapter;
    }
}