namespace TrabajoIntegradorG8
{
    partial class ReporteEstadisticaFastGol
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblRepPartidos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.EstadisticaGol.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 72);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 366);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // lblRepPartidos
            // 
            this.lblRepPartidos.AutoSize = true;
            this.lblRepPartidos.BackColor = System.Drawing.Color.Transparent;
            this.lblRepPartidos.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepPartidos.Location = new System.Drawing.Point(164, 26);
            this.lblRepPartidos.Name = "lblRepPartidos";
            this.lblRepPartidos.Size = new System.Drawing.Size(450, 43);
            this.lblRepPartidos.TabIndex = 10;
            this.lblRepPartidos.Text = "ESTADISTICA GOL MAS RAPIDO";
            // 
            // ReporteEstadisticaFastGol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRepPartidos);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteEstadisticaFastGol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica Gol mas rapido";
            this.Load += new System.EventHandler(this.ReporteEstadisticaFastGol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblRepPartidos;
    }
}