namespace TrabajoIntegradorG8
{
    partial class ReporteListadoPartidos
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
            this.reportViewerPartidos1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblRepPartidos = new System.Windows.Forms.Label();
            this.radioButton1PartAño = new System.Windows.Forms.RadioButton();
            this.radioButton2RestrCan = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxAño = new System.Windows.Forms.MaskedTextBox();
            this.lblTipoCancha = new System.Windows.Forms.Label();
            this.cmbCancha = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.radioButton3RestrFecha = new System.Windows.Forms.RadioButton();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.maskedTextBoxDesde = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHasta = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // reportViewerPartidos1
            // 
            this.reportViewerPartidos1.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.ListadoDePartidos.rdlc";
            this.reportViewerPartidos1.Location = new System.Drawing.Point(12, 159);
            this.reportViewerPartidos1.Name = "reportViewerPartidos1";
            this.reportViewerPartidos1.ServerReport.BearerToken = null;
            this.reportViewerPartidos1.Size = new System.Drawing.Size(776, 268);
            this.reportViewerPartidos1.TabIndex = 0;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.BackColor = System.Drawing.Color.Transparent;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(468, 57);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(38, 18);
            this.lblAño.TabIndex = 1;
            this.lblAño.Text = "Año:";
            this.lblAño.Visible = false;
            // 
            // lblRepPartidos
            // 
            this.lblRepPartidos.AutoSize = true;
            this.lblRepPartidos.BackColor = System.Drawing.Color.Transparent;
            this.lblRepPartidos.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepPartidos.Location = new System.Drawing.Point(238, 9);
            this.lblRepPartidos.Name = "lblRepPartidos";
            this.lblRepPartidos.Size = new System.Drawing.Size(359, 43);
            this.lblRepPartidos.TabIndex = 8;
            this.lblRepPartidos.Text = "REPORTES DE PARTIDOS";
            // 
            // radioButton1PartAño
            // 
            this.radioButton1PartAño.AutoSize = true;
            this.radioButton1PartAño.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1PartAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1PartAño.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton1PartAño.Location = new System.Drawing.Point(60, 55);
            this.radioButton1PartAño.Name = "radioButton1PartAño";
            this.radioButton1PartAño.Size = new System.Drawing.Size(242, 22);
            this.radioButton1PartAño.TabIndex = 9;
            this.radioButton1PartAño.TabStop = true;
            this.radioButton1PartAño.Text = "Partidos en un año seleccionado";
            this.radioButton1PartAño.UseVisualStyleBackColor = false;
            this.radioButton1PartAño.CheckedChanged += new System.EventHandler(this.radioButton1PartAño_CheckedChanged);
            // 
            // radioButton2RestrCan
            // 
            this.radioButton2RestrCan.AutoSize = true;
            this.radioButton2RestrCan.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2RestrCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2RestrCan.Location = new System.Drawing.Point(60, 84);
            this.radioButton2RestrCan.Name = "radioButton2RestrCan";
            this.radioButton2RestrCan.Size = new System.Drawing.Size(227, 22);
            this.radioButton2RestrCan.TabIndex = 10;
            this.radioButton2RestrCan.TabStop = true;
            this.radioButton2RestrCan.Text = "Restringido por tipo de cancha";
            this.radioButton2RestrCan.UseVisualStyleBackColor = false;
            this.radioButton2RestrCan.CheckedChanged += new System.EventHandler(this.radioButton2RestrCan_CheckedChanged);
            // 
            // maskedTextBoxAño
            // 
            this.maskedTextBoxAño.BackColor = System.Drawing.Color.White;
            this.maskedTextBoxAño.Location = new System.Drawing.Point(512, 55);
            this.maskedTextBoxAño.Mask = "9999";
            this.maskedTextBoxAño.Name = "maskedTextBoxAño";
            this.maskedTextBoxAño.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxAño.TabIndex = 11;
            this.maskedTextBoxAño.ValidatingType = typeof(int);
            this.maskedTextBoxAño.Visible = false;
            // 
            // lblTipoCancha
            // 
            this.lblTipoCancha.AutoSize = true;
            this.lblTipoCancha.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoCancha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCancha.Location = new System.Drawing.Point(390, 86);
            this.lblTipoCancha.Name = "lblTipoCancha";
            this.lblTipoCancha.Size = new System.Drawing.Size(116, 18);
            this.lblTipoCancha.TabIndex = 12;
            this.lblTipoCancha.Text = "Tipo de Cancha:";
            this.lblTipoCancha.Visible = false;
            // 
            // cmbCancha
            // 
            this.cmbCancha.FormattingEnabled = true;
            this.cmbCancha.Location = new System.Drawing.Point(512, 84);
            this.cmbCancha.Name = "cmbCancha";
            this.cmbCancha.Size = new System.Drawing.Size(121, 21);
            this.cmbCancha.TabIndex = 13;
            this.cmbCancha.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Location = new System.Drawing.Point(680, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 26);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // radioButton3RestrFecha
            // 
            this.radioButton3RestrFecha.AutoSize = true;
            this.radioButton3RestrFecha.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3RestrFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3RestrFecha.Location = new System.Drawing.Point(60, 112);
            this.radioButton3RestrFecha.Name = "radioButton3RestrFecha";
            this.radioButton3RestrFecha.Size = new System.Drawing.Size(167, 22);
            this.radioButton3RestrFecha.TabIndex = 15;
            this.radioButton3RestrFecha.TabStop = true;
            this.radioButton3RestrFecha.Text = "Restringido por fecha";
            this.radioButton3RestrFecha.UseVisualStyleBackColor = false;
            this.radioButton3RestrFecha.CheckedChanged += new System.EventHandler(this.radioButton3RestrFecha_CheckedChanged);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.Location = new System.Drawing.Point(309, 112);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(55, 18);
            this.lblFechaDesde.TabIndex = 16;
            this.lblFechaDesde.Text = "Desde:";
            this.lblFechaDesde.Visible = false;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(476, 114);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(51, 18);
            this.lblFechaHasta.TabIndex = 17;
            this.lblFechaHasta.Text = "Hasta:";
            this.lblFechaHasta.Visible = false;
            // 
            // maskedTextBoxDesde
            // 
            this.maskedTextBoxDesde.Location = new System.Drawing.Point(370, 113);
            this.maskedTextBoxDesde.Mask = "00/00/0000";
            this.maskedTextBoxDesde.Name = "maskedTextBoxDesde";
            this.maskedTextBoxDesde.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDesde.TabIndex = 18;
            this.maskedTextBoxDesde.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDesde.Visible = false;
            // 
            // maskedTextBoxHasta
            // 
            this.maskedTextBoxHasta.Location = new System.Drawing.Point(533, 110);
            this.maskedTextBoxHasta.Mask = "00/00/0000";
            this.maskedTextBoxHasta.Name = "maskedTextBoxHasta";
            this.maskedTextBoxHasta.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxHasta.TabIndex = 19;
            this.maskedTextBoxHasta.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxHasta.Visible = false;
            // 
            // ReporteListadoPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoIntegradorG8.Properties.Resources.fondo___copia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBoxHasta);
            this.Controls.Add(this.maskedTextBoxDesde);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.radioButton3RestrFecha);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbCancha);
            this.Controls.Add(this.lblTipoCancha);
            this.Controls.Add(this.maskedTextBoxAño);
            this.Controls.Add(this.radioButton2RestrCan);
            this.Controls.Add(this.radioButton1PartAño);
            this.Controls.Add(this.lblRepPartidos);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.reportViewerPartidos1);
            this.Name = "ReporteListadoPartidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Partidos";
            this.Load += new System.EventHandler(this.ReporteListadoPartidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPartidos1;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblRepPartidos;
        private System.Windows.Forms.RadioButton radioButton1PartAño;
        private System.Windows.Forms.RadioButton radioButton2RestrCan;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAño;
        private System.Windows.Forms.Label lblTipoCancha;
        private System.Windows.Forms.ComboBox cmbCancha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton radioButton3RestrFecha;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDesde;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHasta;
    }
}