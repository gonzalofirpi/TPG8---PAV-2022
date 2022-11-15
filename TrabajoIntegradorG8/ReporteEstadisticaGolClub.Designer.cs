namespace TrabajoIntegradorG8
{
    partial class ReporteEstadisticaGolClub
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
            this.lblRepPartidos = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // lblRepPartidos
            // 
            this.lblRepPartidos.AutoSize = true;
            this.lblRepPartidos.BackColor = System.Drawing.Color.Transparent;
            this.lblRepPartidos.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepPartidos.Location = new System.Drawing.Point(208, 30);
            this.lblRepPartidos.Name = "lblRepPartidos";
            this.lblRepPartidos.Size = new System.Drawing.Size(374, 43);
            this.lblRepPartidos.TabIndex = 11;
            this.lblRepPartidos.Text = "GOLEADOR DE CADA CLUB";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.ReportGolesCclub.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 128);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 310);
            this.reportViewer1.TabIndex = 12;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // ReporteEstadisticaGolClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblRepPartidos);
            this.Name = "ReporteEstadisticaGolClub";
            this.Text = "ReporteEstadisticaGolClub";
            this.Load += new System.EventHandler(this.ReporteEstadisticaGolClub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepPartidos;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}