namespace TrabajoIntegradorG8
{
    partial class ReporteEstadisticaExpCate
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
            this.reportViewerExp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerExp
            // 
            this.reportViewerExp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerExp.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.EstadisticaExpulsionesCat.rdlc";
            this.reportViewerExp.Location = new System.Drawing.Point(0, 0);
            this.reportViewerExp.Name = "reportViewerExp";
            this.reportViewerExp.ServerReport.BearerToken = null;
            this.reportViewerExp.Size = new System.Drawing.Size(800, 450);
            this.reportViewerExp.TabIndex = 0;
            this.reportViewerExp.Load += new System.EventHandler(this.reportViewerExp_Load);
            // 
            // ReporteEstadisticaExpCate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerExp);
            this.Name = "ReporteEstadisticaExpCate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte  Estadistica de expulsiones por categoría";
            this.Load += new System.EventHandler(this.ReporteEstadisticaExpCate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerExp;
    }
}