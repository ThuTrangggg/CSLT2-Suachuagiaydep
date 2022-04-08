namespace CSLT2_Suachuagiaydep
{
    partial class frmBaocao
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
            this.tblHDduaxuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baocaoHDduaxuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baocaoHDduaxuong = new CSLT2_Suachuagiaydep.FormBaocao.BaocaoHDduaxuong();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnThongke = new System.Windows.Forms.Button();
            this.dtpNgaydua = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tblHDduaxuongTableAdapter = new CSLT2_Suachuagiaydep.FormBaocao.BaocaoHDduaxuongTableAdapters.tblHDduaxuongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblHDduaxuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baocaoHDduaxuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baocaoHDduaxuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(215, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(70, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 334);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Controls.Add(this.btnThongke);
            this.tabPage1.Controls.Add(this.dtpNgaydua);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Báo cáo HĐ và tổng tiền ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblHDduaxuongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CSLT2_Suachuagiaydep.FormBaocao.BaocaoHDduaxuong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(17, 36);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(551, 252);
            this.reportViewer1.TabIndex = 7;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(241, 3);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(121, 23);
            this.btnThongke.TabIndex = 6;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpNgaydua
            // 
            this.dtpNgaydua.Location = new System.Drawing.Point(17, 6);
            this.dtpNgaydua.Name = "dtpNgaydua";
            this.dtpNgaydua.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaydua.TabIndex = 4;
            this.dtpNgaydua.Value = new System.DateTime(2022, 4, 8, 0, 0, 0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tblHDduaxuongTableAdapter
            // 
            this.tblHDduaxuongTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBaocao";
            this.Text = "frmBaocao";
            this.Load += new System.EventHandler(this.frmBaocao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblHDduaxuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baocaoHDduaxuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baocaoHDduaxuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtpNgaydua;
        private System.Windows.Forms.Button btnThongke;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource baocaoHDduaxuongBindingSource;
        private FormBaocao.BaocaoHDduaxuong baocaoHDduaxuong;
        private System.Windows.Forms.BindingSource tblHDduaxuongBindingSource;
        private FormBaocao.BaocaoHDduaxuongTableAdapters.tblHDduaxuongTableAdapter tblHDduaxuongTableAdapter;
    }
}