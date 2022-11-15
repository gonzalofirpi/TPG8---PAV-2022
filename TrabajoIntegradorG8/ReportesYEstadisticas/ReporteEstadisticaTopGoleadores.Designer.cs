namespace TrabajoIntegradorG8
{
    partial class ReporteEstadisticaTopGoleadores
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
            this.reportViewerTopGoleadores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerTopGoleadores
            // 
            this.reportViewerTopGoleadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerTopGoleadores.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.EstadisticaTopGoleadores.rdlc";
            this.reportViewerTopGoleadores.Location = new System.Drawing.Point(0, 0);
            this.reportViewerTopGoleadores.Name = "reportViewerTopGoleadores";
            this.reportViewerTopGoleadores.ServerReport.BearerToken = null;
            this.reportViewerTopGoleadores.Size = new System.Drawing.Size(800, 450);
            this.reportViewerTopGoleadores.TabIndex = 0;
            this.reportViewerTopGoleadores.Load += new System.EventHandler(this.reportViewerTopGoleadores_Load);
            // 
            // ReporteEstadisticaTopGoleadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerTopGoleadores);
            this.Name = "ReporteEstadisticaTopGoleadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Estadistica Top Goleadores";
            this.Load += new System.EventHandler(this.ReporteEstadisticaTopGoleadores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerTopGoleadores;
    }
}