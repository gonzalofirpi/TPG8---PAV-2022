namespace TrabajoIntegradorG8
{
    partial class frmClubes
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
            this.lblClubes = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNroCuit = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblFechaFundacion = new System.Windows.Forms.Label();
            this.lblNroCalle = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNroCalle = new System.Windows.Forms.MaskedTextBox();
            this.cmbBarrios = new System.Windows.Forms.ComboBox();
            this.txtFechaFundacion = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardarClub = new System.Windows.Forms.Button();
            this.btnActualizarClub = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.grdClubes = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFundacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNroCuit = new System.Windows.Forms.MaskedTextBox();
            this.btnBorrarClub = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdClubes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClubes
            // 
            this.lblClubes.AutoSize = true;
            this.lblClubes.BackColor = System.Drawing.Color.Transparent;
            this.lblClubes.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubes.Location = new System.Drawing.Point(442, 55);
            this.lblClubes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClubes.Name = "lblClubes";
            this.lblClubes.Size = new System.Drawing.Size(190, 65);
            this.lblClubes.TabIndex = 6;
            this.lblClubes.Text = "CLUBES";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(156, 169);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(113, 29);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblNroCuit
            // 
            this.lblNroCuit.AutoSize = true;
            this.lblNroCuit.BackColor = System.Drawing.Color.Transparent;
            this.lblNroCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCuit.Location = new System.Drawing.Point(62, 238);
            this.lblNroCuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroCuit.Name = "lblNroCuit";
            this.lblNroCuit.Size = new System.Drawing.Size(208, 29);
            this.lblNroCuit.TabIndex = 8;
            this.lblNroCuit.Text = "Número de CUIT: ";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.BackColor = System.Drawing.Color.Transparent;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(177, 449);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(90, 29);
            this.lblBarrio.TabIndex = 9;
            this.lblBarrio.Text = "Barrio: ";
            // 
            // lblFechaFundacion
            // 
            this.lblFechaFundacion.AutoSize = true;
            this.lblFechaFundacion.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaFundacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFundacion.Location = new System.Drawing.Point(62, 522);
            this.lblFechaFundacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFundacion.Name = "lblFechaFundacion";
            this.lblFechaFundacion.Size = new System.Drawing.Size(202, 29);
            this.lblFechaFundacion.TabIndex = 10;
            this.lblFechaFundacion.Text = "Fecha fundación: ";
            // 
            // lblNroCalle
            // 
            this.lblNroCalle.AutoSize = true;
            this.lblNroCalle.BackColor = System.Drawing.Color.Transparent;
            this.lblNroCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCalle.Location = new System.Drawing.Point(69, 382);
            this.lblNroCalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroCalle.Name = "lblNroCalle";
            this.lblNroCalle.Size = new System.Drawing.Size(203, 29);
            this.lblNroCalle.TabIndex = 11;
            this.lblNroCalle.Text = "Número de calle: ";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.BackColor = System.Drawing.Color.Transparent;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(188, 309);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(81, 29);
            this.lblCalle.TabIndex = 12;
            this.lblCalle.Text = "Calle: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(274, 160);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 35);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(274, 300);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(202, 35);
            this.txtCalle.TabIndex = 3;
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroCalle.Location = new System.Drawing.Point(274, 372);
            this.txtNroCalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNroCalle.Mask = "99999";
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(76, 35);
            this.txtNroCalle.TabIndex = 4;
            this.txtNroCalle.ValidatingType = typeof(int);
            // 
            // cmbBarrios
            // 
            this.cmbBarrios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarrios.FormattingEnabled = true;
            this.cmbBarrios.Location = new System.Drawing.Point(274, 437);
            this.cmbBarrios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBarrios.Name = "cmbBarrios";
            this.cmbBarrios.Size = new System.Drawing.Size(180, 37);
            this.cmbBarrios.TabIndex = 5;
            this.cmbBarrios.SelectedIndexChanged += new System.EventHandler(this.cmbBarrios_SelectedIndexChanged);
            // 
            // txtFechaFundacion
            // 
            this.txtFechaFundacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFundacion.Location = new System.Drawing.Point(274, 512);
            this.txtFechaFundacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFechaFundacion.Mask = "00/00/0000";
            this.txtFechaFundacion.Name = "txtFechaFundacion";
            this.txtFechaFundacion.Size = new System.Drawing.Size(138, 35);
            this.txtFechaFundacion.TabIndex = 6;
            this.txtFechaFundacion.ValidatingType = typeof(System.DateTime);
            // 
            // btnGuardarClub
            // 
            this.btnGuardarClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarClub.Location = new System.Drawing.Point(602, 602);
            this.btnGuardarClub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarClub.Name = "btnGuardarClub";
            this.btnGuardarClub.Size = new System.Drawing.Size(162, 74);
            this.btnGuardarClub.TabIndex = 7;
            this.btnGuardarClub.Text = "Guardar club";
            this.btnGuardarClub.UseVisualStyleBackColor = true;
            this.btnGuardarClub.Click += new System.EventHandler(this.btnGuardarClub_Click);
            // 
            // btnActualizarClub
            // 
            this.btnActualizarClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarClub.Location = new System.Drawing.Point(207, 602);
            this.btnActualizarClub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizarClub.Name = "btnActualizarClub";
            this.btnActualizarClub.Size = new System.Drawing.Size(162, 74);
            this.btnActualizarClub.TabIndex = 8;
            this.btnActualizarClub.Text = "Actualizar club";
            this.btnActualizarClub.UseVisualStyleBackColor = true;
            this.btnActualizarClub.Click += new System.EventHandler(this.btnActualizarClub_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(18, 602);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(162, 74);
            this.btnLimpiarCampos.TabIndex = 9;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // grdClubes
            // 
            this.grdClubes.AllowUserToAddRows = false;
            this.grdClubes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClubes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.nroCuit,
            this.calle,
            this.nroCalle,
            this.barrio,
            this.fechaFundacion});
            this.grdClubes.Location = new System.Drawing.Point(550, 160);
            this.grdClubes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdClubes.Name = "grdClubes";
            this.grdClubes.ReadOnly = true;
            this.grdClubes.RowHeadersWidth = 62;
            this.grdClubes.Size = new System.Drawing.Size(632, 392);
            this.grdClubes.TabIndex = 15;
            this.grdClubes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClubes_CellClick);
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "NOMBRE";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 65;
            // 
            // nroCuit
            // 
            this.nroCuit.DataPropertyName = "NROCUIT";
            this.nroCuit.HeaderText = "CUIT";
            this.nroCuit.MinimumWidth = 8;
            this.nroCuit.Name = "nroCuit";
            this.nroCuit.ReadOnly = true;
            this.nroCuit.Width = 75;
            // 
            // calle
            // 
            this.calle.DataPropertyName = "CALLE";
            this.calle.HeaderText = "Calle";
            this.calle.MinimumWidth = 8;
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            this.calle.Width = 150;
            // 
            // nroCalle
            // 
            this.nroCalle.DataPropertyName = "NRO_CALLE";
            this.nroCalle.HeaderText = "Numero";
            this.nroCalle.MinimumWidth = 8;
            this.nroCalle.Name = "nroCalle";
            this.nroCalle.ReadOnly = true;
            this.nroCalle.Width = 55;
            // 
            // barrio
            // 
            this.barrio.DataPropertyName = "BARRIO";
            this.barrio.HeaderText = "Barrio";
            this.barrio.MinimumWidth = 8;
            this.barrio.Name = "barrio";
            this.barrio.ReadOnly = true;
            this.barrio.Width = 60;
            // 
            // fechaFundacion
            // 
            this.fechaFundacion.DataPropertyName = "FECHA_FUNDACION";
            this.fechaFundacion.HeaderText = "Fecha Fundacion";
            this.fechaFundacion.MinimumWidth = 8;
            this.fechaFundacion.Name = "fechaFundacion";
            this.fechaFundacion.ReadOnly = true;
            this.fechaFundacion.Width = 75;
            // 
            // txtNroCuit
            // 
            this.txtNroCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroCuit.Location = new System.Drawing.Point(276, 229);
            this.txtNroCuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNroCuit.Mask = "99999999999";
            this.txtNroCuit.Name = "txtNroCuit";
            this.txtNroCuit.Size = new System.Drawing.Size(160, 35);
            this.txtNroCuit.TabIndex = 2;
            this.txtNroCuit.ValidatingType = typeof(int);
            // 
            // btnBorrarClub
            // 
            this.btnBorrarClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarClub.Location = new System.Drawing.Point(404, 602);
            this.btnBorrarClub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrarClub.Name = "btnBorrarClub";
            this.btnBorrarClub.Size = new System.Drawing.Size(162, 74);
            this.btnBorrarClub.TabIndex = 16;
            this.btnBorrarClub.Text = "Borrar club";
            this.btnBorrarClub.UseVisualStyleBackColor = true;
            this.btnBorrarClub.Click += new System.EventHandler(this.btnBorrarClub_Click);
            // 
            // frmClubes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 722);
            this.Controls.Add(this.btnBorrarClub);
            this.Controls.Add(this.txtNroCuit);
            this.Controls.Add(this.grdClubes);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnActualizarClub);
            this.Controls.Add(this.btnGuardarClub);
            this.Controls.Add(this.txtFechaFundacion);
            this.Controls.Add(this.cmbBarrios);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblNroCalle);
            this.Controls.Add(this.lblFechaFundacion);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.lblNroCuit);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblClubes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmClubes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clubes";
            this.Load += new System.EventHandler(this.frmClubes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdClubes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClubes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNroCuit;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblFechaFundacion;
        private System.Windows.Forms.Label lblNroCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.MaskedTextBox txtNroCalle;
        private System.Windows.Forms.ComboBox cmbBarrios;
        private System.Windows.Forms.MaskedTextBox txtFechaFundacion;
        private System.Windows.Forms.Button btnGuardarClub;
        private System.Windows.Forms.Button btnActualizarClub;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridView grdClubes;
        private System.Windows.Forms.MaskedTextBox txtNroCuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFundacion;
        private System.Windows.Forms.Button btnBorrarClub;
    }
}