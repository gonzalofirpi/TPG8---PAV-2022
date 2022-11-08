namespace TrabajoIntegradorG8
{
    partial class ReporteListadoArbitros
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
            this.lblReporteArbitros = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbArbitrosAlfabeticamente = new System.Windows.Forms.RadioButton();
            this.rbArbitrosLetra = new System.Windows.Forms.RadioButton();
            this.txtApellidoArbitro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.ListadoArbitrosAlfabetico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 189);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 263);
            this.reportViewer1.TabIndex = 0;
            // 
            // lblReporteArbitros
            // 
            this.lblReporteArbitros.AutoSize = true;
            this.lblReporteArbitros.Font = new System.Drawing.Font("Britannic Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporteArbitros.Location = new System.Drawing.Point(192, 9);
            this.lblReporteArbitros.Name = "lblReporteArbitros";
            this.lblReporteArbitros.Size = new System.Drawing.Size(406, 44);
            this.lblReporteArbitros.TabIndex = 1;
            this.lblReporteArbitros.Text = "Reportes de Arbitros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(660, 92);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 33);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rbArbitrosAlfabeticamente
            // 
            this.rbArbitrosAlfabeticamente.AutoSize = true;
            this.rbArbitrosAlfabeticamente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbArbitrosAlfabeticamente.Location = new System.Drawing.Point(30, 67);
            this.rbArbitrosAlfabeticamente.Name = "rbArbitrosAlfabeticamente";
            this.rbArbitrosAlfabeticamente.Size = new System.Drawing.Size(280, 24);
            this.rbArbitrosAlfabeticamente.TabIndex = 3;
            this.rbArbitrosAlfabeticamente.TabStop = true;
            this.rbArbitrosAlfabeticamente.Text = "Arbitros ordenados alfabeticamente";
            this.rbArbitrosAlfabeticamente.UseVisualStyleBackColor = true;
            this.rbArbitrosAlfabeticamente.CheckedChanged += new System.EventHandler(this.rbArbitrosAlfabeticamente_CheckedChanged);
            // 
            // rbArbitrosLetra
            // 
            this.rbArbitrosLetra.AutoSize = true;
            this.rbArbitrosLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbArbitrosLetra.Location = new System.Drawing.Point(30, 113);
            this.rbArbitrosLetra.Name = "rbArbitrosLetra";
            this.rbArbitrosLetra.Size = new System.Drawing.Size(167, 24);
            this.rbArbitrosLetra.TabIndex = 5;
            this.rbArbitrosLetra.TabStop = true;
            this.rbArbitrosLetra.Text = "Arbitros por apellido";
            this.rbArbitrosLetra.UseVisualStyleBackColor = true;
            this.rbArbitrosLetra.CheckedChanged += new System.EventHandler(this.rbArbitrosLetra_CheckedChanged);
            // 
            // txtApellidoArbitro
            // 
            this.txtApellidoArbitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoArbitro.Location = new System.Drawing.Point(239, 111);
            this.txtApellidoArbitro.Name = "txtApellidoArbitro";
            this.txtApellidoArbitro.Size = new System.Drawing.Size(169, 26);
            this.txtApellidoArbitro.TabIndex = 6;
            // 
            // ReporteListadoArbitros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtApellidoArbitro);
            this.Controls.Add(this.rbArbitrosLetra);
            this.Controls.Add(this.rbArbitrosAlfabeticamente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblReporteArbitros);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteListadoArbitros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Arbitros";
            this.Load += new System.EventHandler(this.ReporteListadoArbitros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblReporteArbitros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rbArbitrosAlfabeticamente;
        private System.Windows.Forms.RadioButton rbArbitrosLetra;
        private System.Windows.Forms.TextBox txtApellidoArbitro;
    }
}