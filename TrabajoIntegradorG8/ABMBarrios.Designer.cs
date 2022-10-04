namespace TrabajoIntegradorG8
{
    partial class frmBarrios
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
            this.lblBarrios = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbLocalidades = new System.Windows.Forms.ComboBox();
            this.txtCodPostal = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardarBarrio = new System.Windows.Forms.Button();
            this.btnActualizarBarrio = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.grdBarrios = new System.Windows.Forms.DataGridView();
            this.btnBorrarBarrio = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBarrios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarrios
            // 
            this.lblBarrios.AutoSize = true;
            this.lblBarrios.BackColor = System.Drawing.Color.Transparent;
            this.lblBarrios.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrios.Location = new System.Drawing.Point(119, 19);
            this.lblBarrios.Name = "lblBarrios";
            this.lblBarrios.Size = new System.Drawing.Size(147, 43);
            this.lblBarrios.TabIndex = 7;
            this.lblBarrios.Text = "BARRIOS";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(48, 108);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(34, 160);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(85, 20);
            this.lblLocalidad.TabIndex = 9;
            this.lblLocalidad.Text = "Localidad: ";
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.BackColor = System.Drawing.Color.Transparent;
            this.lblCodPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPostal.Location = new System.Drawing.Point(7, 204);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(114, 20);
            this.lblCodPostal.TabIndex = 10;
            this.lblCodPostal.Text = "Codigo postal: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(127, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 26);
            this.txtNombre.TabIndex = 11;
            // 
            // cmbLocalidades
            // 
            this.cmbLocalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalidades.FormattingEnabled = true;
            this.cmbLocalidades.Location = new System.Drawing.Point(127, 152);
            this.cmbLocalidades.Name = "cmbLocalidades";
            this.cmbLocalidades.Size = new System.Drawing.Size(121, 28);
            this.cmbLocalidades.TabIndex = 12;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPostal.Location = new System.Drawing.Point(127, 198);
            this.txtCodPostal.Mask = "99999";
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(52, 26);
            this.txtCodPostal.TabIndex = 13;
            this.txtCodPostal.ValidatingType = typeof(int);
            // 
            // btnGuardarBarrio
            // 
            this.btnGuardarBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarBarrio.Location = new System.Drawing.Point(393, 278);
            this.btnGuardarBarrio.Name = "btnGuardarBarrio";
            this.btnGuardarBarrio.Size = new System.Drawing.Size(108, 48);
            this.btnGuardarBarrio.TabIndex = 14;
            this.btnGuardarBarrio.Text = "Guardar barrio";
            this.btnGuardarBarrio.UseVisualStyleBackColor = true;
            this.btnGuardarBarrio.Click += new System.EventHandler(this.btnGuardarBarrio_Click);
            // 
            // btnActualizarBarrio
            // 
            this.btnActualizarBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarBarrio.Location = new System.Drawing.Point(140, 278);
            this.btnActualizarBarrio.Name = "btnActualizarBarrio";
            this.btnActualizarBarrio.Size = new System.Drawing.Size(108, 48);
            this.btnActualizarBarrio.TabIndex = 15;
            this.btnActualizarBarrio.Text = "Actualizar barrio";
            this.btnActualizarBarrio.UseVisualStyleBackColor = true;
            this.btnActualizarBarrio.Click += new System.EventHandler(this.btnActualizarBarrio_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(11, 278);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(108, 48);
            this.btnLimpiarCampos.TabIndex = 16;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // grdBarrios
            // 
            this.grdBarrios.AllowUserToAddRows = false;
            this.grdBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBarrios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.localidad,
            this.codPostal});
            this.grdBarrios.Location = new System.Drawing.Point(294, 83);
            this.grdBarrios.Name = "grdBarrios";
            this.grdBarrios.ReadOnly = true;
            this.grdBarrios.Size = new System.Drawing.Size(332, 141);
            this.grdBarrios.TabIndex = 17;
            this.grdBarrios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBarrios_CellClick);
            // 
            // btnBorrarBarrio
            // 
            this.btnBorrarBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarBarrio.Location = new System.Drawing.Point(265, 278);
            this.btnBorrarBarrio.Name = "btnBorrarBarrio";
            this.btnBorrarBarrio.Size = new System.Drawing.Size(108, 48);
            this.btnBorrarBarrio.TabIndex = 18;
            this.btnBorrarBarrio.Text = "Borrar barrio";
            this.btnBorrarBarrio.UseVisualStyleBackColor = true;
            this.btnBorrarBarrio.Click += new System.EventHandler(this.btnBorrarBarrio_Click);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "COD_BARRIO";
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "NOMBRE";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // localidad
            // 
            this.localidad.DataPropertyName = "LOCALIDAD";
            this.localidad.HeaderText = "Localidad";
            this.localidad.Name = "localidad";
            this.localidad.ReadOnly = true;
            // 
            // codPostal
            // 
            this.codPostal.DataPropertyName = "COD_POSTAL";
            this.codPostal.HeaderText = "Codigo postal";
            this.codPostal.Name = "codPostal";
            this.codPostal.ReadOnly = true;
            // 
            // frmBarrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 348);
            this.Controls.Add(this.btnBorrarBarrio);
            this.Controls.Add(this.grdBarrios);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnActualizarBarrio);
            this.Controls.Add(this.btnGuardarBarrio);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.cmbLocalidades);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCodPostal);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblBarrios);
            this.Name = "frmBarrios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barrios";
            this.Load += new System.EventHandler(this.frmBarrios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBarrios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarrios;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbLocalidades;
        private System.Windows.Forms.MaskedTextBox txtCodPostal;
        private System.Windows.Forms.Button btnGuardarBarrio;
        private System.Windows.Forms.Button btnActualizarBarrio;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridView grdBarrios;
        private System.Windows.Forms.Button btnBorrarBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostal;
    }
}