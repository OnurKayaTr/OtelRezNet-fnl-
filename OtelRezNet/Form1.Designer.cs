
namespace OtelRezNet
{
    partial class BosOda
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
            this.OtelRezervasyonDataSet = new OtelRezNet.OtelRezervasyonDataSet();
            this.BosOdaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BosOdaTableAdapter = new OtelRezNet.OtelRezervasyonDataSetTableAdapters.BosOdaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OtelRezervasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BosOdaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BosOdaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtelRezNet.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // OtelRezervasyonDataSet
            // 
            this.OtelRezervasyonDataSet.DataSetName = "OtelRezervasyonDataSet";
            this.OtelRezervasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BosOdaBindingSource
            // 
            this.BosOdaBindingSource.DataMember = "BosOda";
            this.BosOdaBindingSource.DataSource = this.OtelRezervasyonDataSet;
            // 
            // BosOdaTableAdapter
            // 
            this.BosOdaTableAdapter.ClearBeforeFill = true;
            // 
            // BosOda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BosOda";
            this.Text = "BoşOda";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OtelRezervasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BosOdaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BosOdaBindingSource;
        private OtelRezervasyonDataSet OtelRezervasyonDataSet;
        private OtelRezervasyonDataSetTableAdapters.BosOdaTableAdapter BosOdaTableAdapter;
    }
}