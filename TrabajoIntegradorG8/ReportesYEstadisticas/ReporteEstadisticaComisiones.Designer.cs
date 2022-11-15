namespace TrabajoIntegradorG8
{
    partial class ReporteEstadisticaComisiones
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
            this.reportViewerEstCom = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerEstCom
            // 
            this.reportViewerEstCom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerEstCom.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.EstadisticaComisiones.rdlc";
            this.reportViewerEstCom.Location = new System.Drawing.Point(0, 0);
            this.reportViewerEstCom.Name = "reportViewerEstCom";
            this.reportViewerEstCom.ServerReport.BearerToken = null;
            this.reportViewerEstCom.Size = new System.Drawing.Size(800, 450);
            this.reportViewerEstCom.TabIndex = 0;
            this.reportViewerEstCom.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ReporteEstadisticaComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerEstCom);
            this.Name = "ReporteEstadisticaComisiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de estadistica de comisiones";
            this.Load += new System.EventHandler(this.ReporteEstadisticaComisiones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerEstCom;
    }
}