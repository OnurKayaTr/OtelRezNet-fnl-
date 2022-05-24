
namespace OtelRezNet
{
    partial class OteldeOlanMusteri
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OtelRezervasyonDataSet1 = new OtelRezNet.OtelRezervasyonDataSet1();
            this.BugunOteledeOlanMusterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BugunOteledeOlanMusterilerTableAdapter = new OtelRezNet.OtelRezervasyonDataSet1TableAdapters.BugunOteledeOlanMusterilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OtelRezervasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BugunOteledeOlanMusterilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BugunOteledeOlanMusterilerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtelRezNet.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // OtelRezervasyonDataSet1
            // 
            this.OtelRezervasyonDataSet1.DataSetName = "OtelRezervasyonDataSet1";
            this.OtelRezervasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BugunOteledeOlanMusterilerBindingSource
            // 
            this.BugunOteledeOlanMusterilerBindingSource.DataMember = "BugunOteledeOlanMusteriler";
            this.BugunOteledeOlanMusterilerBindingSource.DataSource = this.OtelRezervasyonDataSet1;
            // 
            // BugunOteledeOlanMusterilerTableAdapter
            // 
            this.BugunOteledeOlanMusterilerTableAdapter.ClearBeforeFill = true;
            // 
            // OteldeOlanMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "OteldeOlanMusteri";
            this.Text = "OteldeOlanMüşteri";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OtelRezervasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BugunOteledeOlanMusterilerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BugunOteledeOlanMusterilerBindingSource;
        private OtelRezervasyonDataSet1 OtelRezervasyonDataSet1;
        private OtelRezervasyonDataSet1TableAdapters.BugunOteledeOlanMusterilerTableAdapter BugunOteledeOlanMusterilerTableAdapter;
    }
}