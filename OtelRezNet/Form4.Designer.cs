
namespace OtelRezNet
{
    partial class RezGoster
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
            this.OtelRezervasyonDataSet5 = new OtelRezNet.OtelRezervasyonDataSet5();
            this.ViewRezlerGosterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ViewRezlerGosterTableAdapter = new OtelRezNet.OtelRezervasyonDataSet5TableAdapters.ViewRezlerGosterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OtelRezervasyonDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewRezlerGosterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ViewRezlerGosterBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtelRezNet.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // OtelRezervasyonDataSet5
            // 
            this.OtelRezervasyonDataSet5.DataSetName = "OtelRezervasyonDataSet5";
            this.OtelRezervasyonDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewRezlerGosterBindingSource
            // 
            this.ViewRezlerGosterBindingSource.DataMember = "ViewRezlerGoster";
            this.ViewRezlerGosterBindingSource.DataSource = this.OtelRezervasyonDataSet5;
            // 
            // ViewRezlerGosterTableAdapter
            // 
            this.ViewRezlerGosterTableAdapter.ClearBeforeFill = true;
            // 
            // RezGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RezGoster";
            this.Text = "RezGöster";
            this.Load += new System.EventHandler(this.RezGöster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OtelRezervasyonDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewRezlerGosterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ViewRezlerGosterBindingSource;
        private OtelRezervasyonDataSet5 OtelRezervasyonDataSet5;
        private OtelRezervasyonDataSet5TableAdapters.ViewRezlerGosterTableAdapter ViewRezlerGosterTableAdapter;
    }
}