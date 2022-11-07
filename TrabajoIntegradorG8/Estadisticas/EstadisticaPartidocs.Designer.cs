
namespace TrabajoIntegradorG8.Estadisticas
{
    partial class EstadisticaPartidocs
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
            this.rv4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblPartidos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rv4
            // 
            this.rv4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv4.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.Estadisticas.ReportEstadisticaPartido.rdlc";
            this.rv4.Location = new System.Drawing.Point(12, 151);
            this.rv4.Name = "rv4";
            this.rv4.ServerReport.BearerToken = null;
            this.rv4.Size = new System.Drawing.Size(942, 498);
            this.rv4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Año: ";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(514, 92);
            this.txtYear.Mask = "9999";
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 30);
            this.txtYear.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(696, 90);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 38);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblPartidos
            // 
            this.lblPartidos.AutoSize = true;
            this.lblPartidos.BackColor = System.Drawing.Color.Transparent;
            this.lblPartidos.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidos.Location = new System.Drawing.Point(354, 9);
            this.lblPartidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartidos.Name = "lblPartidos";
            this.lblPartidos.Size = new System.Drawing.Size(200, 54);
            this.lblPartidos.TabIndex = 9;
            this.lblPartidos.Text = "PARTIDOS";
            // 
            // EstadisticaPartidocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 661);
            this.Controls.Add(this.lblPartidos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rv4);
            this.Name = "EstadisticaPartidocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadisticaPartidocs";
            this.Load += new System.EventHandler(this.EstadisticaPartidocs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtYear;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblPartidos;
    }
}