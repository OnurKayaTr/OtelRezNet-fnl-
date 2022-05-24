
namespace OtelRezNet
{
    partial class OteleGelenMusteri
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
            this.OtelRezervasyonDataSet4 = new OtelRezNet.OtelRezervasyonDataSet4();
            this.BugunOteleGelenMusterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BugunOteleGelenMusterilerTableAdapter = new OtelRezNet.OtelRezervasyonDataSet4TableAdapters.BugunOteleGelenMusterilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OtelRezervasyonDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BugunOteleGelenMusterilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BugunOteleGelenMusterilerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtelRezNet.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // OtelRezervasyonDataSet4
            // 
            this.OtelRezervasyonDataSet4.DataSetName = "OtelRezervasyonDataSet4";
            this.OtelRezervasyonDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BugunOteleGelenMusterilerBindingSource
            // 
            this.BugunOteleGelenMusterilerBindingSource.DataMember = "BugunOteleGelenMusteriler";
            this.BugunOteleGelenMusterilerBindingSource.DataSource = this.OtelRezervasyonDataSet4;
            // 
            // BugunOteleGelenMusterilerTableAdapter
            // 
            this.BugunOteleGelenMusterilerTableAdapter.ClearBeforeFill = true;
            // 
            // OteleGelenMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "OteleGelenMusteri";
            this.Text = "OteleGelenMüşteri";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OtelRezervasyonDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BugunOteleGelenMusterilerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BugunOteleGelenMusterilerBindingSource;
        private OtelRezervasyonDataSet4 OtelRezervasyonDataSet4;
        private OtelRezervasyonDataSet4TableAdapters.BugunOteleGelenMusterilerTableAdapter BugunOteleGelenMusterilerTableAdapter;
    }
}