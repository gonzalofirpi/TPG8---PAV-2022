namespace TrabajoIntegradorG8
{
    partial class ABMComisiones
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
            this.lblTituloComisiones = new System.Windows.Forms.Label();
            this.lblFechaInicioCom = new System.Windows.Forms.Label();
            this.txtFechaInicioCom = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaFinCom = new System.Windows.Forms.Label();
            this.txtFechaFinCom = new System.Windows.Forms.MaskedTextBox();
            this.lblNumSocio = new System.Windows.Forms.Label();
            this.lblVocal1 = new System.Windows.Forms.Label();
            this.lblVocal2 = new System.Windows.Forms.Label();
            this.lblVocal3 = new System.Windows.Forms.Label();
            this.lblPresidente = new System.Windows.Forms.Label();
            this.lblSecretario = new System.Windows.Forms.Label();
            this.lblTesorero = new System.Windows.Forms.Label();
            this.txtVocal1 = new System.Windows.Forms.MaskedTextBox();
            this.txtVocal2 = new System.Windows.Forms.MaskedTextBox();
            this.txtVocal3 = new System.Windows.Forms.MaskedTextBox();
            this.txtPresi = new System.Windows.Forms.MaskedTextBox();
            this.txtSecre = new System.Windows.Forms.MaskedTextBox();
            this.txtTesorero = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardarCom = new System.Windows.Forms.Button();
            this.btnBorrarCom = new System.Windows.Forms.Button();
            this.btnActualizarCom = new System.Windows.Forms.Button();
            this.btnLimpiarCamposCom = new System.Windows.Forms.Button();
            this.lblClub = new System.Windows.Forms.Label();
            this.cmbClub = new System.Windows.Forms.ComboBox();
            this.grdCom = new System.Windows.Forms.DataGridView();
            this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloComisiones
            // 
            this.lblTituloComisiones.AutoSize = true;
            this.lblTituloComisiones.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloComisiones.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloComisiones.Location = new System.Drawing.Point(231, 30);
            this.lblTituloComisiones.Name = "lblTituloComisiones";
            this.lblTituloComisiones.Size = new System.Drawing.Size(201, 43);
            this.lblTituloComisiones.TabIndex = 7;
            this.lblTituloComisiones.Text = "COMISIONES";
            // 
            // lblFechaInicioCom
            // 
            this.lblFechaInicioCom.AutoSize = true;
            this.lblFechaInicioCom.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaInicioCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicioCom.Location = new System.Drawing.Point(38, 140);
            this.lblFechaInicioCom.Name = "lblFechaInicioCom";
            this.lblFechaInicioCom.Size = new System.Drawing.Size(123, 20);
            this.lblFechaInicioCom.TabIndex = 8;
            this.lblFechaInicioCom.Text = "Fecha de inicio: ";
            // 
            // txtFechaInicioCom
            // 
            this.txtFechaInicioCom.Location = new System.Drawing.Point(158, 139);
            this.txtFechaInicioCom.Mask = "00/00/0000";
            this.txtFechaInicioCom.Name = "txtFechaInicioCom";
            this.txtFechaInicioCom.Size = new System.Drawing.Size(100, 20);
            this.txtFechaInicioCom.TabIndex = 9;
            this.txtFechaInicioCom.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaFinCom
            // 
            this.lblFechaFinCom.AutoSize = true;
            this.lblFechaFinCom.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaFinCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinCom.Location = new System.Drawing.Point(38, 175);
            this.lblFechaFinCom.Name = "lblFechaFinCom";
            this.lblFechaFinCom.Size = new System.Drawing.Size(166, 20);
            this.lblFechaFinCom.TabIndex = 10;
            this.lblFechaFinCom.Text = "Fecha de finalizacion: ";
            // 
            // txtFechaFinCom
            // 
            this.txtFechaFinCom.Location = new System.Drawing.Point(210, 177);
            this.txtFechaFinCom.Mask = "00/00/0000";
            this.txtFechaFinCom.Name = "txtFechaFinCom";
            this.txtFechaFinCom.Size = new System.Drawing.Size(100, 20);
            this.txtFechaFinCom.TabIndex = 11;
            this.txtFechaFinCom.ValidatingType = typeof(System.DateTime);
            // 
            // lblNumSocio
            // 
            this.lblNumSocio.AutoSize = true;
            this.lblNumSocio.BackColor = System.Drawing.Color.Transparent;
            this.lblNumSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSocio.Location = new System.Drawing.Point(38, 219);
            this.lblNumSocio.Name = "lblNumSocio";
            this.lblNumSocio.Size = new System.Drawing.Size(201, 20);
            this.lblNumSocio.TabIndex = 12;
            this.lblNumSocio.Text = "Ingresar números de socio:";
            // 
            // lblVocal1
            // 
            this.lblVocal1.AutoSize = true;
            this.lblVocal1.BackColor = System.Drawing.Color.Transparent;
            this.lblVocal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVocal1.Location = new System.Drawing.Point(57, 257);
            this.lblVocal1.Name = "lblVocal1";
            this.lblVocal1.Size = new System.Drawing.Size(102, 20);
            this.lblVocal1.TabIndex = 13;
            this.lblVocal1.Text = "Primer Vocal:";
            // 
            // lblVocal2
            // 
            this.lblVocal2.AutoSize = true;
            this.lblVocal2.BackColor = System.Drawing.Color.Transparent;
            this.lblVocal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVocal2.Location = new System.Drawing.Point(37, 290);
            this.lblVocal2.Name = "lblVocal2";
            this.lblVocal2.Size = new System.Drawing.Size(122, 20);
            this.lblVocal2.TabIndex = 14;
            this.lblVocal2.Text = "Segundo Vocal:";
            // 
            // lblVocal3
            // 
            this.lblVocal3.AutoSize = true;
            this.lblVocal3.BackColor = System.Drawing.Color.Transparent;
            this.lblVocal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVocal3.Location = new System.Drawing.Point(57, 319);
            this.lblVocal3.Name = "lblVocal3";
            this.lblVocal3.Size = new System.Drawing.Size(102, 20);
            this.lblVocal3.TabIndex = 15;
            this.lblVocal3.Text = "Tercer Vocal:";
            // 
            // lblPresidente
            // 
            this.lblPresidente.AutoSize = true;
            this.lblPresidente.BackColor = System.Drawing.Color.Transparent;
            this.lblPresidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresidente.Location = new System.Drawing.Point(281, 257);
            this.lblPresidente.Name = "lblPresidente";
            this.lblPresidente.Size = new System.Drawing.Size(89, 20);
            this.lblPresidente.TabIndex = 16;
            this.lblPresidente.Text = "Presidente:";
            // 
            // lblSecretario
            // 
            this.lblSecretario.AutoSize = true;
            this.lblSecretario.BackColor = System.Drawing.Color.Transparent;
            this.lblSecretario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretario.Location = new System.Drawing.Point(284, 290);
            this.lblSecretario.Name = "lblSecretario";
            this.lblSecretario.Size = new System.Drawing.Size(86, 20);
            this.lblSecretario.TabIndex = 17;
            this.lblSecretario.Text = "Secretario:";
            // 
            // lblTesorero
            // 
            this.lblTesorero.AutoSize = true;
            this.lblTesorero.BackColor = System.Drawing.Color.Transparent;
            this.lblTesorero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTesorero.Location = new System.Drawing.Point(294, 319);
            this.lblTesorero.Name = "lblTesorero";
            this.lblTesorero.Size = new System.Drawing.Size(76, 20);
            this.lblTesorero.TabIndex = 18;
            this.lblTesorero.Text = "Tesorero:";
            // 
            // txtVocal1
            // 
            this.txtVocal1.Location = new System.Drawing.Point(165, 257);
            this.txtVocal1.Mask = "9999999999";
            this.txtVocal1.Name = "txtVocal1";
            this.txtVocal1.Size = new System.Drawing.Size(100, 20);
            this.txtVocal1.TabIndex = 19;
            this.txtVocal1.ValidatingType = typeof(int);
            // 
            // txtVocal2
            // 
            this.txtVocal2.Location = new System.Drawing.Point(165, 290);
            this.txtVocal2.Mask = "9999999999";
            this.txtVocal2.Name = "txtVocal2";
            this.txtVocal2.Size = new System.Drawing.Size(100, 20);
            this.txtVocal2.TabIndex = 20;
            this.txtVocal2.ValidatingType = typeof(int);
            // 
            // txtVocal3
            // 
            this.txtVocal3.Location = new System.Drawing.Point(165, 321);
            this.txtVocal3.Mask = "9999999999";
            this.txtVocal3.Name = "txtVocal3";
            this.txtVocal3.Size = new System.Drawing.Size(100, 20);
            this.txtVocal3.TabIndex = 21;
            this.txtVocal3.ValidatingType = typeof(int);
            // 
            // txtPresi
            // 
            this.txtPresi.Location = new System.Drawing.Point(376, 257);
            this.txtPresi.Mask = "9999999999";
            this.txtPresi.Name = "txtPresi";
            this.txtPresi.Size = new System.Drawing.Size(100, 20);
            this.txtPresi.TabIndex = 22;
            this.txtPresi.ValidatingType = typeof(int);
            // 
            // txtSecre
            // 
            this.txtSecre.Location = new System.Drawing.Point(376, 290);
            this.txtSecre.Mask = "9999999999";
            this.txtSecre.Name = "txtSecre";
            this.txtSecre.Size = new System.Drawing.Size(100, 20);
            this.txtSecre.TabIndex = 23;
            this.txtSecre.ValidatingType = typeof(int);
            // 
            // txtTesorero
            // 
            this.txtTesorero.Location = new System.Drawing.Point(376, 319);
            this.txtTesorero.Mask = "9999999999";
            this.txtTesorero.Name = "txtTesorero";
            this.txtTesorero.Size = new System.Drawing.Size(100, 20);
            this.txtTesorero.TabIndex = 24;
            this.txtTesorero.ValidatingType = typeof(int);
            // 
            // btnGuardarCom
            // 
            this.btnGuardarCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCom.Location = new System.Drawing.Point(399, 379);
            this.btnGuardarCom.Name = "btnGuardarCom";
            this.btnGuardarCom.Size = new System.Drawing.Size(94, 50);
            this.btnGuardarCom.TabIndex = 28;
            this.btnGuardarCom.Text = "Guardar comisión";
            this.btnGuardarCom.UseVisualStyleBackColor = true;
            this.btnGuardarCom.Click += new System.EventHandler(this.btnGuardarCom_Click);
            // 
            // btnBorrarCom
            // 
            this.btnBorrarCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarCom.Location = new System.Drawing.Point(277, 379);
            this.btnBorrarCom.Name = "btnBorrarCom";
            this.btnBorrarCom.Size = new System.Drawing.Size(94, 50);
            this.btnBorrarCom.TabIndex = 27;
            this.btnBorrarCom.Text = "Borrar comisión";
            this.btnBorrarCom.UseVisualStyleBackColor = true;
            this.btnBorrarCom.Click += new System.EventHandler(this.btnBorrarCom_Click);
            // 
            // btnActualizarCom
            // 
            this.btnActualizarCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCom.Location = new System.Drawing.Point(158, 379);
            this.btnActualizarCom.Name = "btnActualizarCom";
            this.btnActualizarCom.Size = new System.Drawing.Size(94, 50);
            this.btnActualizarCom.TabIndex = 26;
            this.btnActualizarCom.Text = "Actualizar comisión";
            this.btnActualizarCom.UseVisualStyleBackColor = true;
            this.btnActualizarCom.Click += new System.EventHandler(this.btnActualizarCom_Click);
            // 
            // btnLimpiarCamposCom
            // 
            this.btnLimpiarCamposCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCamposCom.Location = new System.Drawing.Point(47, 379);
            this.btnLimpiarCamposCom.Name = "btnLimpiarCamposCom";
            this.btnLimpiarCamposCom.Size = new System.Drawing.Size(73, 50);
            this.btnLimpiarCamposCom.TabIndex = 25;
            this.btnLimpiarCamposCom.Text = "Limpiar campos";
            this.btnLimpiarCamposCom.UseVisualStyleBackColor = true;
            this.btnLimpiarCamposCom.Click += new System.EventHandler(this.btnLimpiarCamposCom_Click);
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.BackColor = System.Drawing.Color.Transparent;
            this.lblClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClub.Location = new System.Drawing.Point(37, 106);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(49, 20);
            this.lblClub.TabIndex = 29;
            this.lblClub.Text = "Club: ";
            // 
            // cmbClub
            // 
            this.cmbClub.FormattingEnabled = true;
            this.cmbClub.Location = new System.Drawing.Point(96, 105);
            this.cmbClub.Name = "cmbClub";
            this.cmbClub.Size = new System.Drawing.Size(121, 21);
            this.cmbClub.TabIndex = 30;
            // 
            // grdCom
            // 
            this.grdCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Club,
            this.IdClub,
            this.fechaDesde,
            this.fechaHasta});
            this.grdCom.Location = new System.Drawing.Point(365, 105);
            this.grdCom.Name = "grdCom";
            this.grdCom.Size = new System.Drawing.Size(294, 92);
            this.grdCom.TabIndex = 31;
            this.grdCom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCom_CellClick);
            // 
            // Club
            // 
            this.Club.DataPropertyName = "CLUB";
            this.Club.HeaderText = "Club";
            this.Club.Name = "Club";
            this.Club.Width = 50;
            // 
            // IdClub
            // 
            this.IdClub.DataPropertyName = "IDCLUB";
            this.IdClub.HeaderText = "ID Club";
            this.IdClub.Name = "IdClub";
            // 
            // fechaDesde
            // 
            this.fechaDesde.DataPropertyName = "FECHA_DESDE";
            this.fechaDesde.HeaderText = "Fecha Inicio";
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Width = 50;
            // 
            // fechaHasta
            // 
            this.fechaHasta.DataPropertyName = "FECHA_HASTA";
            this.fechaHasta.HeaderText = "Fecha Fin";
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Width = 50;
            // 
            // ABMComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdCom);
            this.Controls.Add(this.cmbClub);
            this.Controls.Add(this.lblClub);
            this.Controls.Add(this.btnGuardarCom);
            this.Controls.Add(this.btnBorrarCom);
            this.Controls.Add(this.btnActualizarCom);
            this.Controls.Add(this.btnLimpiarCamposCom);
            this.Controls.Add(this.txtTesorero);
            this.Controls.Add(this.txtSecre);
            this.Controls.Add(this.txtPresi);
            this.Controls.Add(this.txtVocal3);
            this.Controls.Add(this.txtVocal2);
            this.Controls.Add(this.txtVocal1);
            this.Controls.Add(this.lblTesorero);
            this.Controls.Add(this.lblSecretario);
            this.Controls.Add(this.lblPresidente);
            this.Controls.Add(this.lblVocal3);
            this.Controls.Add(this.lblVocal2);
            this.Controls.Add(this.lblVocal1);
            this.Controls.Add(this.lblNumSocio);
            this.Controls.Add(this.txtFechaFinCom);
            this.Controls.Add(this.lblFechaFinCom);
            this.Controls.Add(this.txtFechaInicioCom);
            this.Controls.Add(this.lblFechaInicioCom);
            this.Controls.Add(this.lblTituloComisiones);
            this.Name = "ABMComisiones";
            this.Text = "ABMComisiones";
            this.Load += new System.EventHandler(this.ABMComisiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloComisiones;
        private System.Windows.Forms.Label lblFechaInicioCom;
        private System.Windows.Forms.MaskedTextBox txtFechaInicioCom;
        private System.Windows.Forms.Label lblFechaFinCom;
        private System.Windows.Forms.MaskedTextBox txtFechaFinCom;
        private System.Windows.Forms.Label lblNumSocio;
        private System.Windows.Forms.Label lblVocal1;
        private System.Windows.Forms.Label lblVocal2;
        private System.Windows.Forms.Label lblVocal3;
        private System.Windows.Forms.Label lblPresidente;
        private System.Windows.Forms.Label lblSecretario;
        private System.Windows.Forms.Label lblTesorero;
        private System.Windows.Forms.MaskedTextBox txtVocal1;
        private System.Windows.Forms.MaskedTextBox txtVocal2;
        private System.Windows.Forms.MaskedTextBox txtVocal3;
        private System.Windows.Forms.MaskedTextBox txtPresi;
        private System.Windows.Forms.MaskedTextBox txtSecre;
        private System.Windows.Forms.MaskedTextBox txtTesorero;
        private System.Windows.Forms.Button btnGuardarCom;
        private System.Windows.Forms.Button btnBorrarCom;
        private System.Windows.Forms.Button btnActualizarCom;
        private System.Windows.Forms.Button btnLimpiarCamposCom;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.ComboBox cmbClub;
        private System.Windows.Forms.DataGridView grdCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHasta;
    }
}