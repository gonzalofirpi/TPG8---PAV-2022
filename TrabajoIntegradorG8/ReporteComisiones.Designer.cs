namespace TrabajoIntegradorG8
{
    partial class ReporteComisiones
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
            this.lblRepComisiones = new System.Windows.Forms.Label();
            this.reportViewerComisiones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.radioButtonRestringidoPorFecha = new System.Windows.Forms.RadioButton();
            this.radioButtonRestringidoEntreFechas = new System.Windows.Forms.RadioButton();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRepComisiones
            // 
            this.lblRepComisiones.AutoSize = true;
            this.lblRepComisiones.BackColor = System.Drawing.Color.Transparent;
            this.lblRepComisiones.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepComisiones.Location = new System.Drawing.Point(317, 9);
            this.lblRepComisiones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepComisiones.Name = "lblRepComisiones";
            this.lblRepComisiones.Size = new System.Drawing.Size(588, 65);
            this.lblRepComisiones.TabIndex = 10;
            this.lblRepComisiones.Text = "REPORTES DE COMISIONES";
            this.lblRepComisiones.Click += new System.EventHandler(this.lblRepCanchas_Click);
            // 
            // reportViewerComisiones
            // 
            this.reportViewerComisiones.Location = new System.Drawing.Point(56, 258);
            this.reportViewerComisiones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewerComisiones.Name = "reportViewerComisiones";
            this.reportViewerComisiones.ServerReport.BearerToken = null;
            this.reportViewerComisiones.Size = new System.Drawing.Size(1107, 401);
            this.reportViewerComisiones.TabIndex = 23;
            this.reportViewerComisiones.Load += new System.EventHandler(this.reportViewerCanchas_Load);
            // 
            // radioButtonRestringidoPorFecha
            // 
            this.radioButtonRestringidoPorFecha.AutoSize = true;
            this.radioButtonRestringidoPorFecha.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonRestringidoPorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRestringidoPorFecha.Location = new System.Drawing.Point(118, 123);
            this.radioButtonRestringidoPorFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonRestringidoPorFecha.Name = "radioButtonRestringidoPorFecha";
            this.radioButtonRestringidoPorFecha.Size = new System.Drawing.Size(226, 30);
            this.radioButtonRestringidoPorFecha.TabIndex = 24;
            this.radioButtonRestringidoPorFecha.TabStop = true;
            this.radioButtonRestringidoPorFecha.Text = "Restringido por año";
            this.radioButtonRestringidoPorFecha.UseVisualStyleBackColor = false;
            this.radioButtonRestringidoPorFecha.CheckedChanged += new System.EventHandler(this.radioButtonRestringidoPorFecha_CheckedChanged);
            // 
            // radioButtonRestringidoEntreFechas
            // 
            this.radioButtonRestringidoEntreFechas.AutoSize = true;
            this.radioButtonRestringidoEntreFechas.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonRestringidoEntreFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRestringidoEntreFechas.Location = new System.Drawing.Point(118, 192);
            this.radioButtonRestringidoEntreFechas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonRestringidoEntreFechas.Name = "radioButtonRestringidoEntreFechas";
            this.radioButtonRestringidoEntreFechas.Size = new System.Drawing.Size(255, 30);
            this.radioButtonRestringidoEntreFechas.TabIndex = 25;
            this.radioButtonRestringidoEntreFechas.TabStop = true;
            this.radioButtonRestringidoEntreFechas.Text = "Restringido entre años";
            this.radioButtonRestringidoEntreFechas.UseVisualStyleBackColor = false;
            this.radioButtonRestringidoEntreFechas.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(597, 127);
            this.txtFecha.Mask = "9999";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(99, 26);
            this.txtFecha.TabIndex = 26;
            this.txtFecha.ValidatingType = typeof(int);
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(597, 196);
            this.txtFechaDesde.Mask = "9999";
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(99, 26);
            this.txtFechaDesde.TabIndex = 27;
            this.txtFechaDesde.ValidatingType = typeof(int);
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(928, 196);
            this.txtFechaHasta.Mask = "9999";
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(99, 26);
            this.txtFechaHasta.TabIndex = 28;
            this.txtFechaHasta.ValidatingType = typeof(int);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(508, 201);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(60, 20);
            this.lblDesde.TabIndex = 29;
            this.lblDesde.Text = "Desde:";
            this.lblDesde.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(834, 202);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(56, 20);
            this.lblHasta.TabIndex = 30;
            this.lblHasta.Text = "Hasta:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(878, 86);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 67);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ReporteComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 688);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.txtFechaHasta);
            this.Controls.Add(this.txtFechaDesde);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.radioButtonRestringidoEntreFechas);
            this.Controls.Add(this.radioButtonRestringidoPorFecha);
            this.Controls.Add(this.reportViewerComisiones);
            this.Controls.Add(this.lblRepComisiones);
            this.Name = "ReporteComisiones";
            this.Text = "Reporte de Comisiones";
            this.Load += new System.EventHandler(this.ReporteComisiones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepComisiones;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerComisiones;
        private System.Windows.Forms.RadioButton radioButtonRestringidoPorFecha;
        private System.Windows.Forms.RadioButton radioButtonRestringidoEntreFechas;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.MaskedTextBox txtFechaDesde;
        private System.Windows.Forms.MaskedTextBox txtFechaHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnBuscar;
    }
}