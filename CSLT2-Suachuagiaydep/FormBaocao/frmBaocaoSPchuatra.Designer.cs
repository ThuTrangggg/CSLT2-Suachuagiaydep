namespace CSLT2_Suachuagiaydep.FormBaocao
{
    partial class frmBaocaoSPchuatra
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
            this.bcaodanhsachhdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bCaoSPchuatrakhachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bCaoSPchuatrakhach = new CSLT2_Suachuagiaydep.DatasetReport.BCaoSPchuatrakhach();
            this.bcaoSPxuongchuatraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bcaoSPxuongchuatra = new CSLT2_Suachuagiaydep.DatasetReport.BcaoSPxuongchuatra();
            this.bcaoSPxuongchuatraTableAdapter = new CSLT2_Suachuagiaydep.DatasetReport.BcaoSPxuongchuatraTableAdapters.BcaoSPxuongchuatraTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnThongkedatra = new System.Windows.Forms.Button();
            this.rptSPdatra = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpSPdatra = new System.Windows.Forms.DateTimePicker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rpvSPchuatracuahang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSPchuatracuahang = new System.Windows.Forms.Button();
            this.dtpSPchuatracuahang = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BcaodanhsachhdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bcaodanhsachhdTableAdapter = new CSLT2_Suachuagiaydep.DatasetReport.BCaoSPchuatrakhachTableAdapters.BcaodanhsachhdTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bcaodanhsachhdBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCaoSPchuatrakhachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCaoSPchuatrakhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoSPxuongchuatraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoSPxuongchuatra)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BcaodanhsachhdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bcaodanhsachhdBindingSource1
            // 
            this.bcaodanhsachhdBindingSource1.DataMember = "Bcaodanhsachhd";
            this.bcaodanhsachhdBindingSource1.DataSource = this.bCaoSPchuatrakhachBindingSource;
            // 
            // bCaoSPchuatrakhachBindingSource
            // 
            this.bCaoSPchuatrakhachBindingSource.DataSource = this.bCaoSPchuatrakhach;
            this.bCaoSPchuatrakhachBindingSource.Position = 0;
            // 
            // bCaoSPchuatrakhach
            // 
            this.bCaoSPchuatrakhach.DataSetName = "BCaoSPchuatrakhach";
            this.bCaoSPchuatrakhach.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bcaoSPxuongchuatraBindingSource1
            // 
            this.bcaoSPxuongchuatraBindingSource1.DataMember = "BcaoSPxuongchuatra";
            this.bcaoSPxuongchuatraBindingSource1.DataSource = this.bcaoSPxuongchuatra;
            // 
            // bcaoSPxuongchuatra
            // 
            this.bcaoSPxuongchuatra.DataSetName = "BcaoSPxuongchuatra";
            this.bcaoSPxuongchuatra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bcaoSPxuongchuatraTableAdapter
            // 
            this.bcaoSPxuongchuatraTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnThongkedatra);
            this.tabPage2.Controls.Add(this.rptSPdatra);
            this.tabPage2.Controls.Add(this.dtpSPdatra);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Danh sách sản phẩm chưa trả khách hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnThongkedatra
            // 
            this.btnThongkedatra.Location = new System.Drawing.Point(180, 20);
            this.btnThongkedatra.Name = "btnThongkedatra";
            this.btnThongkedatra.Size = new System.Drawing.Size(110, 20);
            this.btnThongkedatra.TabIndex = 2;
            this.btnThongkedatra.Text = "Thống kê";
            this.btnThongkedatra.UseVisualStyleBackColor = true;
            this.btnThongkedatra.Click += new System.EventHandler(this.btnThongkedatra_Click_1);
            // 
            // rptSPdatra
            // 
            reportDataSource1.Name = "DatasetSPchuatrakhach";
            reportDataSource1.Value = this.bcaodanhsachhdBindingSource1;
            this.rptSPdatra.LocalReport.DataSources.Add(reportDataSource1);
            this.rptSPdatra.LocalReport.ReportEmbeddedResource = "CSLT2_Suachuagiaydep.DatasetReport.RpBcaoSPchuatrakhach.rdlc";
            this.rptSPdatra.Location = new System.Drawing.Point(21, 56);
            this.rptSPdatra.Name = "rptSPdatra";
            this.rptSPdatra.ServerReport.BearerToken = null;
            this.rptSPdatra.Size = new System.Drawing.Size(727, 338);
            this.rptSPdatra.TabIndex = 1;
            // 
            // dtpSPdatra
            // 
            this.dtpSPdatra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSPdatra.Location = new System.Drawing.Point(21, 20);
            this.dtpSPdatra.Name = "dtpSPdatra";
            this.dtpSPdatra.Size = new System.Drawing.Size(137, 20);
            this.dtpSPdatra.TabIndex = 0;
            this.dtpSPdatra.Value = new System.DateTime(2022, 4, 10, 0, 0, 0, 0);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rpvSPchuatracuahang);
            this.tabPage1.Controls.Add(this.btnSPchuatracuahang);
            this.tabPage1.Controls.Add(this.dtpSPchuatracuahang);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Danh sách sản phẩm chưa trả cửa hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rpvSPchuatracuahang
            // 
            reportDataSource2.Name = "BcaoSPxuongchuatraDataSet";
            reportDataSource2.Value = this.bcaoSPxuongchuatraBindingSource1;
            this.rpvSPchuatracuahang.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvSPchuatracuahang.LocalReport.ReportEmbeddedResource = "CSLT2_Suachuagiaydep.DatasetReport.BcaoSPxuongchuatra.rdlc";
            this.rpvSPchuatracuahang.Location = new System.Drawing.Point(20, 51);
            this.rpvSPchuatracuahang.Name = "rpvSPchuatracuahang";
            this.rpvSPchuatracuahang.ServerReport.BearerToken = null;
            this.rpvSPchuatracuahang.Size = new System.Drawing.Size(727, 343);
            this.rpvSPchuatracuahang.TabIndex = 2;
            // 
            // btnSPchuatracuahang
            // 
            this.btnSPchuatracuahang.Location = new System.Drawing.Point(182, 16);
            this.btnSPchuatracuahang.Name = "btnSPchuatracuahang";
            this.btnSPchuatracuahang.Size = new System.Drawing.Size(115, 20);
            this.btnSPchuatracuahang.TabIndex = 1;
            this.btnSPchuatracuahang.Text = "Thống kế";
            this.btnSPchuatracuahang.UseVisualStyleBackColor = true;
            this.btnSPchuatracuahang.Click += new System.EventHandler(this.btnSPchuatracuahang_Click);
            // 
            // dtpSPchuatracuahang
            // 
            this.dtpSPchuatracuahang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSPchuatracuahang.Location = new System.Drawing.Point(20, 16);
            this.dtpSPchuatracuahang.Name = "dtpSPchuatracuahang";
            this.dtpSPchuatracuahang.Size = new System.Drawing.Size(136, 20);
            this.dtpSPchuatracuahang.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // BcaodanhsachhdBindingSource
            // 
            this.BcaodanhsachhdBindingSource.DataMember = "Bcaodanhsachhd";
            this.BcaodanhsachhdBindingSource.DataSource = this.bCaoSPchuatrakhach;
            // 
            // bcaodanhsachhdTableAdapter
            // 
            this.bcaodanhsachhdTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaocaoSPchuatra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmBaocaoSPchuatra";
            this.Text = "frmBaocaoSPchuatra";
            this.Load += new System.EventHandler(this.frmBaocaoSPchuatra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bcaodanhsachhdBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCaoSPchuatrakhachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCaoSPchuatrakhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoSPxuongchuatraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcaoSPxuongchuatra)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BcaodanhsachhdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bcaoSPxuongchuatraBindingSource1;
        private DatasetReport.BcaoSPxuongchuatra bcaoSPxuongchuatra;
        private DatasetReport.BcaoSPxuongchuatraTableAdapters.BcaoSPxuongchuatraTableAdapter bcaoSPxuongchuatraTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnThongkedatra;
        private Microsoft.Reporting.WinForms.ReportViewer rptSPdatra;
        private System.Windows.Forms.DateTimePicker dtpSPdatra;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvSPchuatracuahang;
        private System.Windows.Forms.Button btnSPchuatracuahang;
        private System.Windows.Forms.DateTimePicker dtpSPchuatracuahang;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource bCaoSPchuatrakhachBindingSource;
        private DatasetReport.BCaoSPchuatrakhach bCaoSPchuatrakhach;
        private System.Windows.Forms.BindingSource bcaodanhsachhdBindingSource1;
        private System.Windows.Forms.BindingSource BcaodanhsachhdBindingSource;
        private DatasetReport.BCaoSPchuatrakhachTableAdapters.BcaodanhsachhdTableAdapter bcaodanhsachhdTableAdapter;
    }
}