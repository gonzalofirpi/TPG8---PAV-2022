namespace TrabajoIntegradorG8
{
    partial class ReporteEstadisticaGolesClub
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
            this.reportViewerGoles = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerGoles
            // 
            this.reportViewerGoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerGoles.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.EstadisticaGolesClub.rdlc";
            this.reportViewerGoles.Location = new System.Drawing.Point(0, 0);
            this.reportViewerGoles.Name = "reportViewerGoles";
            this.reportViewerGoles.ServerReport.BearerToken = null;
            this.reportViewerGoles.Size = new System.Drawing.Size(800, 450);
            this.reportViewerGoles.TabIndex = 0;
            this.reportViewerGoles.Load += new System.EventHandler(this.reportViewerGoles_Load);
            // 
            // ReporteEstadisticaGolesClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerGoles);
            this.Name = "ReporteEstadisticaGolesClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Estadistica de goles por club";
            this.Load += new System.EventHandler(this.ReporteEstadisticaGolesClub_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerGoles;
    }
}