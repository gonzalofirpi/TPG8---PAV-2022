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
            this.lblRepComisiones.Location = new System.Drawing.Point(211, 6);
            this.lblRepComisiones.Name = "lblRepComisiones";
            this.lblRepComisiones.Size = new System.Drawing.Size(398, 43);
            this.lblRepComisiones.TabIndex = 10;
            this.lblRepComisiones.Text = "REPORTES DE COMISIONES";
            this.lblRepComisiones.Click += new System.EventHandler(this.lblRepCanchas_Click);
            // 
            // reportViewerComisiones
            // 
            this.reportViewerComisiones.Location = new System.Drawing.Point(37, 168);
            this.reportViewerComisiones.Name = "reportViewerComisiones";
            this.reportViewerComisiones.ServerReport.BearerToken = null;
            this.reportViewerComisiones.Size = new System.Drawing.Size(739, 261);
            this.reportViewerComisiones.TabIndex = 23;
            this.reportViewerComisiones.Load += new System.EventHandler(this.reportViewerCanchas_Load);
            // 
            // radioButtonRestringidoPorFecha
            // 
            this.radioButtonRestringidoPorFecha.AutoSize = true;
            this.radioButtonRestringidoPorFecha.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonRestringidoPorFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRestringidoPorFecha.Location = new System.Drawing.Point(79, 80);
            this.radioButtonRestringidoPorFecha.Name = "radioButtonRestringidoPorFecha";
            this.radioButtonRestringidoPorFecha.Size = new System.Drawing.Size(156, 22);
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
            this.radioButtonRestringidoEntreFechas.Location = new System.Drawing.Point(79, 125);
            this.radioButtonRestringidoEntreFechas.Name = "radioButtonRestringidoEntreFechas";
            this.radioButtonRestringidoEntreFechas.Size = new System.Drawing.Size(175, 22);
            this.radioButtonRestringidoEntreFechas.TabIndex = 25;
            this.radioButtonRestringidoEntreFechas.TabStop = true;
            this.radioButtonRestringidoEntreFechas.Text = "Restringido entre años";
            this.radioButtonRestringidoEntreFechas.UseVisualStyleBackColor = false;
            this.radioButtonRestringidoEntreFechas.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(398, 83);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtFecha.Mask = "9999";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(67, 20);
            this.txtFecha.TabIndex = 26;
            this.txtFecha.ValidatingType = typeof(int);
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(398, 127);
            this.txtFechaDesde.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaDesde.Mask = "9999";
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(67, 20);
            this.txtFechaDesde.TabIndex = 27;
            this.txtFechaDesde.ValidatingType = typeof(int);
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(619, 127);
            this.txtFechaHasta.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaHasta.Mask = "9999";
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(67, 20);
            this.txtFechaHasta.TabIndex = 28;
            this.txtFechaHasta.ValidatingType = typeof(int);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(339, 131);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 29;
            this.lblDesde.Text = "Desde:";
            this.lblDesde.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(556, 131);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 30;
            this.lblHasta.Text = "Hasta:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(585, 56);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 44);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ReporteComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoIntegradorG8.Properties.Resources.fondo___copia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 447);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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