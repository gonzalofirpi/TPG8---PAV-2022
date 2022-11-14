namespace TrabajoIntegradorG8
{
    partial class frmSocios
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
            this.lblSocios = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblNroCalle = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNroCalle = new System.Windows.Forms.MaskedTextBox();
            this.cmbBarrios = new System.Windows.Forms.ComboBox();
            this.btnGuardarSocio = new System.Windows.Forms.Button();
            this.btnActualizarSocio = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.grdSocios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrarSocio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSocios
            // 
            this.lblSocios.AutoSize = true;
            this.lblSocios.BackColor = System.Drawing.Color.Transparent;
            this.lblSocios.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocios.Location = new System.Drawing.Point(264, 37);
            this.lblSocios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSocios.Name = "lblSocios";
            this.lblSocios.Size = new System.Drawing.Size(190, 65);
            this.lblSocios.TabIndex = 6;
            this.lblSocios.Text = "SOCIOS";
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
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(150, 238);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(114, 29);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido: ";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(12, 374);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(249, 29);
            this.lblFechaNacimiento.TabIndex = 10;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento: ";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.BackColor = System.Drawing.Color.Transparent;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(171, 503);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(90, 29);
            this.lblBarrio.TabIndex = 9;
            this.lblBarrio.Text = "Barrio: ";
            // 
            // lblNroCalle
            // 
            this.lblNroCalle.AutoSize = true;
            this.lblNroCalle.BackColor = System.Drawing.Color.Transparent;
            this.lblNroCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCalle.Location = new System.Drawing.Point(63, 434);
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
            this.lblCalle.Location = new System.Drawing.Point(182, 309);
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
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(274, 229);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(184, 35);
            this.txtApellido.TabIndex = 3;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.Location = new System.Drawing.Point(276, 365);
            this.txtFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFechaNacimiento.Mask = "00/00/0000";
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(138, 35);
            this.txtFechaNacimiento.TabIndex = 6;
            this.txtFechaNacimiento.ValidatingType = typeof(System.DateTime);
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
            this.txtNroCalle.Location = new System.Drawing.Point(276, 425);
            this.txtNroCalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNroCalle.Mask = "99999";
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(76, 35);
            this.txtNroCalle.TabIndex = 4;
            this.txtNroCalle.ValidatingType = typeof(int);
            // 
            // cmbBarrios
            // 
            this.cmbBarrios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarrios.FormattingEnabled = true;
            this.cmbBarrios.Location = new System.Drawing.Point(276, 491);
            this.cmbBarrios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBarrios.Name = "cmbBarrios";
            this.cmbBarrios.Size = new System.Drawing.Size(180, 37);
            this.cmbBarrios.TabIndex = 5;
            this.cmbBarrios.SelectedIndexChanged += new System.EventHandler(this.cmbBarrios_SelectedIndexChanged);
            // 
            // btnGuardarSocio
            // 
            this.btnGuardarSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarSocio.Location = new System.Drawing.Point(602, 602);
            this.btnGuardarSocio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarSocio.Name = "btnGuardarSocio";
            this.btnGuardarSocio.Size = new System.Drawing.Size(162, 74);
            this.btnGuardarSocio.TabIndex = 7;
            this.btnGuardarSocio.Text = "Guardar socio";
            this.btnGuardarSocio.UseVisualStyleBackColor = true;
            this.btnGuardarSocio.Click += new System.EventHandler(this.btnGuardarSocio_Click);
            // 
            // btnActualizarSocio
            // 
            this.btnActualizarSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarSocio.Location = new System.Drawing.Point(207, 602);
            this.btnActualizarSocio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizarSocio.Name = "btnActualizarSocio";
            this.btnActualizarSocio.Size = new System.Drawing.Size(162, 74);
            this.btnActualizarSocio.TabIndex = 8;
            this.btnActualizarSocio.Text = "Actualizar socio";
            this.btnActualizarSocio.UseVisualStyleBackColor = true;
            this.btnActualizarSocio.Click += new System.EventHandler(this.btnActualizarSocio_Click);
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
            // grdSocios
            // 
            this.grdSocios.AllowUserToAddRows = false;
            this.grdSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.apellido,
            this.fechaNacimiento,
            this.calle,
            this.nroCalle,
            this.barrio});
            this.grdSocios.Location = new System.Drawing.Point(525, 160);
            this.grdSocios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdSocios.Name = "grdSocios";
            this.grdSocios.ReadOnly = true;
            this.grdSocios.RowHeadersWidth = 62;
            this.grdSocios.Size = new System.Drawing.Size(632, 392);
            this.grdSocios.TabIndex = 15;
            this.grdSocios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSocios_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID_SOCIO";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 35;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "NOMBRE";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "APELLIDO";
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 8;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 150;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "FECHA_NACIMIENTO";
            this.fechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.fechaNacimiento.MinimumWidth = 8;
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            this.fechaNacimiento.Width = 150;
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
            this.nroCalle.Width = 150;
            // 
            // barrio
            // 
            this.barrio.DataPropertyName = "BARRIO";
            this.barrio.HeaderText = "Barrio";
            this.barrio.MinimumWidth = 8;
            this.barrio.Name = "barrio";
            this.barrio.ReadOnly = true;
            this.barrio.Width = 150;
            // 
            // btnBorrarSocio
            // 
            this.btnBorrarSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarSocio.Location = new System.Drawing.Point(404, 602);
            this.btnBorrarSocio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrarSocio.Name = "btnBorrarSocio";
            this.btnBorrarSocio.Size = new System.Drawing.Size(162, 74);
            this.btnBorrarSocio.TabIndex = 18;
            this.btnBorrarSocio.Text = "Borrar socio";
            this.btnBorrarSocio.UseVisualStyleBackColor = true;
            this.btnBorrarSocio.Click += new System.EventHandler(this.btnBorrarSocio_Click);
            // 
            // frmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 722);
            this.Controls.Add(this.btnBorrarSocio);
            this.Controls.Add(this.grdSocios);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnActualizarSocio);
            this.Controls.Add(this.btnGuardarSocio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.cmbBarrios);
            this.Controls.Add(this.lblSocios);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblNroCalle);
            this.Controls.Add(this.lblBarrio);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socios";
            this.Load += new System.EventHandler(this.frmSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSocios;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblNroCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.MaskedTextBox txtNroCalle;
        private System.Windows.Forms.ComboBox cmbBarrios;
        private System.Windows.Forms.MaskedTextBox txtFechaNacimiento;
        private System.Windows.Forms.Button btnGuardarSocio;
        private System.Windows.Forms.Button btnActualizarSocio;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridView grdSocios;
        private System.Windows.Forms.Button btnBorrarSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrio;
    }
}