namespace CSLT2_Suachuagiaydep.FormBaocao
{
    partial class frmBcaoHDduaxuong
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblHDduaxuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baocaoHDduaxuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baocaoHDduaxuong = new CSLT2_Suachuagiaydep.DatasetReport.BaocaoHDduaxuong();
            this.bcaoHDmaxtongtienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bcaoHDmaxtongtienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bcaoHDmaxtongtien = new CSLT2_Suachuagiaydep.DatasetReport.BcaoHDmaxtongtien();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnThongke = new System.Windows.Forms.Button();
            this.dtpNgaydua = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rpvHDmaxtongtien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblHDduaxuongTableAdapter = new CSLT2_Suachuagiaydep.DatasetReport.BaocaoHDduaxuongTableAdapters.tblHDduaxuongTableAdapter();
            this.bcaoHDmaxtongtienTableAdapter = new CSLT2_Suachuagiaydep.DatasetReport.BcaoHDmaxtongtienTableAdapters.BcaoHDmaxtongtienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblHDduaxuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baocaoHDduaxuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baocaoHDduaxuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoHDmaxtongtienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoHDmaxtongtienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoHDmaxtongtien)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblHDduaxuongBindingSource
            // 
            this.tblHDduaxuongBindingSource.DataMember = "tblHDduaxuong";
            this.tblHDduaxuongBindingSource.DataSource = this.baocaoHDduaxuongBindingSource;
            // 
            // baocaoHDduaxuongBindingSource
            // 
            this.baocaoHDduaxuongBindingSource.DataSource = this.baocaoHDduaxuong;
            this.baocaoHDduaxuongBindingSource.Position = 0;
            // 
            // baocaoHDduaxuong
            // 
            this.baocaoHDduaxuong.DataSetName = "BaocaoHDduaxuong";
            this.baocaoHDduaxuong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bcaoHDmaxtongtienBindingSource1
            // 
            this.bcaoHDmaxtongtienBindingSource1.DataMember = "BcaoHDmaxtongtien";
            this.bcaoHDmaxtongtienBindingSource1.DataSource = this.bcaoHDmaxtongtienBindingSource;
            // 
            // bcaoHDmaxtongtienBindingSource
            // 
            this.bcaoHDmaxtongtienBindingSource.DataSource = this.bcaoHDmaxtongtien;
            this.bcaoHDmaxtongtienBindingSource.Position = 0;
            // 
            // bcaoHDmaxtongtien
            // 
            this.bcaoHDmaxtongtien.DataSetName = "BcaoHDmaxtongtien";
            this.bcaoHDmaxtongtien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Controls.Add(this.btnThongke);
            this.tabPage1.Controls.Add(this.dtpNgaydua);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Báo cáo danh sách hoá đơn đưa xưởng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "BaocaoHDduaxuongDataSet";
            reportDataSource1.Value = this.tblHDduaxuongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CSLT2_Suachuagiaydep.DatasetReport.BaocaoHDduaxuong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(721, 348);
            this.reportViewer1.TabIndex = 10;
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(170, 16);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(119, 20);
            this.btnThongke.TabIndex = 9;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // dtpNgaydua
            // 
            this.dtpNgaydua.Checked = false;
            this.dtpNgaydua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaydua.Location = new System.Drawing.Point(24, 16);
            this.dtpNgaydua.Name = "dtpNgaydua";
            this.dtpNgaydua.Size = new System.Drawing.Size(111, 20);
            this.dtpNgaydua.TabIndex = 8;
            this.dtpNgaydua.TabStop = false;
            this.dtpNgaydua.Value = new System.DateTime(2022, 4, 8, 0, 0, 0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rpvHDmaxtongtien);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kế hoá đơn tổng tiền nhiều nhất";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // rpvHDmaxtongtien
            // 
            reportDataSource2.Name = "BcaoHDmaxtongtien";
            reportDataSource2.Value = this.bcaoHDmaxtongtienBindingSource1;
            this.rpvHDmaxtongtien.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvHDmaxtongtien.LocalReport.ReportEmbeddedResource = "CSLT2_Suachuagiaydep.DatasetReport.BcaoHDmaxtongtien.rdlc";
            this.rpvHDmaxtongtien.Location = new System.Drawing.Point(18, 23);
            this.rpvHDmaxtongtien.Name = "rpvHDmaxtongtien";
            this.rpvHDmaxtongtien.ServerReport.BearerToken = null;
            this.rpvHDmaxtongtien.Size = new System.Drawing.Size(727, 361);
            this.rpvHDmaxtongtien.TabIndex = 0;
            // 
            // tblHDduaxuongTableAdapter
            // 
            this.tblHDduaxuongTableAdapter.ClearBeforeFill = true;
            // 
            // bcaoHDmaxtongtienTableAdapter
            // 
            this.bcaoHDmaxtongtienTableAdapter.ClearBeforeFill = true;
            // 
            // frmBcaoHDduaxuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmBcaoHDduaxuong";
            this.Text = "frmBcaoHDduaxuong";
            this.Load += new System.EventHandler(this.frmBcaoHDduaxuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblHDduaxuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baocaoHDduaxuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baocaoHDduaxuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoHDmaxtongtienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoHDmaxtongtienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoHDmaxtongtien)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.DateTimePicker dtpNgaydua;
        private System.Windows.Forms.TabPage tabPage2;
        private DatasetReport.BaocaoHDduaxuong baocaoHDduaxuong;
        private System.Windows.Forms.BindingSource baocaoHDduaxuongBindingSource;
        private System.Windows.Forms.BindingSource tblHDduaxuongBindingSource;
        private DatasetReport.BaocaoHDduaxuongTableAdapters.tblHDduaxuongTableAdapter tblHDduaxuongTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvHDmaxtongtien;
        private System.Windows.Forms.BindingSource bcaoHDmaxtongtienBindingSource;
        private DatasetReport.BcaoHDmaxtongtien bcaoHDmaxtongtien;
        private System.Windows.Forms.BindingSource bcaoHDmaxtongtienBindingSource1;
        private DatasetReport.BcaoHDmaxtongtienTableAdapters.BcaoHDmaxtongtienTableAdapter bcaoHDmaxtongtienTableAdapter;
    }
}