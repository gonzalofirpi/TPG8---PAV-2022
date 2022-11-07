
namespace TrabajoIntegradorG8.Estadisticas
{
    partial class EstadisticaSocio
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
            this.rv3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rv3
            // 
            this.rv3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv3.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.Estadisticas.ReportEstadistica.rdlc";
            this.rv3.Location = new System.Drawing.Point(0, 0);
            this.rv3.Name = "rv3";
            this.rv3.ServerReport.BearerToken = null;
            this.rv3.Size = new System.Drawing.Size(800, 450);
            this.rv3.TabIndex = 0;
            this.rv3.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // EstadisticaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rv3);
            this.Name = "EstadisticaSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticaSocio";
            this.Load += new System.EventHandler(this.EstadisticaSocio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv3;
    }
}