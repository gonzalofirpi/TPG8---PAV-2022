namespace TrabajoIntegradorG8
{
    partial class ABMLocalidades
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
            this.lblTituloLocalidades = new System.Windows.Forms.Label();
            this.txtNombreLocalidad = new System.Windows.Forms.TextBox();
            this.lblNombreLocalidad = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnActualizarLoc = new System.Windows.Forms.Button();
            this.btnBorrarLoc = new System.Windows.Forms.Button();
            this.btnGuardarLoc = new System.Windows.Forms.Button();
            this.grdLocalidades = new System.Windows.Forms.DataGridView();
            this.NombreLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdLocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloLocalidades
            // 
            this.lblTituloLocalidades.AutoSize = true;
            this.lblTituloLocalidades.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloLocalidades.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLocalidades.Location = new System.Drawing.Point(183, 32);
            this.lblTituloLocalidades.Name = "lblTituloLocalidades";
            this.lblTituloLocalidades.Size = new System.Drawing.Size(208, 43);
            this.lblTituloLocalidades.TabIndex = 6;
            this.lblTituloLocalidades.Text = "LOCALIDADES";
            // 
            // txtNombreLocalidad
            // 
            this.txtNombreLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLocalidad.Location = new System.Drawing.Point(181, 125);
            this.txtNombreLocalidad.Name = "txtNombreLocalidad";
            this.txtNombreLocalidad.Size = new System.Drawing.Size(135, 26);
            this.txtNombreLocalidad.TabIndex = 8;
            // 
            // lblNombreLocalidad
            // 
            this.lblNombreLocalidad.AutoSize = true;
            this.lblNombreLocalidad.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLocalidad.Location = new System.Drawing.Point(113, 128);
            this.lblNombreLocalidad.Name = "lblNombreLocalidad";
            this.lblNombreLocalidad.Size = new System.Drawing.Size(73, 20);
            this.lblNombreLocalidad.TabIndex = 7;
            this.lblNombreLocalidad.Text = "Nombre: ";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(117, 258);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(73, 50);
            this.btnLimpiarCampos.TabIndex = 9;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnActualizarLoc
            // 
            this.btnActualizarLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarLoc.Location = new System.Drawing.Point(509, 258);
            this.btnActualizarLoc.Name = "btnActualizarLoc";
            this.btnActualizarLoc.Size = new System.Drawing.Size(94, 50);
            this.btnActualizarLoc.TabIndex = 10;
            this.btnActualizarLoc.Text = "Actualizar localidad";
            this.btnActualizarLoc.UseVisualStyleBackColor = true;
            this.btnActualizarLoc.Click += new System.EventHandler(this.btnActualizarLoc_Click_1);
            // 
            // btnBorrarLoc
            // 
            this.btnBorrarLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarLoc.Location = new System.Drawing.Point(398, 258);
            this.btnBorrarLoc.Name = "btnBorrarLoc";
            this.btnBorrarLoc.Size = new System.Drawing.Size(94, 50);
            this.btnBorrarLoc.TabIndex = 11;
            this.btnBorrarLoc.Text = "Borrar localidad";
            this.btnBorrarLoc.UseVisualStyleBackColor = true;
            this.btnBorrarLoc.Click += new System.EventHandler(this.btnBorrarLoc_Click_1);
            // 
            // btnGuardarLoc
            // 
            this.btnGuardarLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarLoc.Location = new System.Drawing.Point(222, 258);
            this.btnGuardarLoc.Name = "btnGuardarLoc";
            this.btnGuardarLoc.Size = new System.Drawing.Size(94, 50);
            this.btnGuardarLoc.TabIndex = 12;
            this.btnGuardarLoc.Text = "Guardar localidad";
            this.btnGuardarLoc.UseVisualStyleBackColor = true;
            this.btnGuardarLoc.Click += new System.EventHandler(this.btnGuardarLoc_Click_1);
            // 
            // grdLocalidades
            // 
            this.grdLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLocalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreLocalidad,
            this.codigoLoc});
            this.grdLocalidades.Location = new System.Drawing.Point(490, 83);
            this.grdLocalidades.Name = "grdLocalidades";
            this.grdLocalidades.Size = new System.Drawing.Size(243, 150);
            this.grdLocalidades.TabIndex = 13;
            this.grdLocalidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLocalidades_CellClick);
            // 
            // NombreLocalidad
            // 
            this.NombreLocalidad.DataPropertyName = "NOMBRE";
            this.NombreLocalidad.HeaderText = "Nombre";
            this.NombreLocalidad.Name = "NombreLocalidad";
            // 
            // codigoLoc
            // 
            this.codigoLoc.DataPropertyName = "COD_LOCALIDAD";
            this.codigoLoc.HeaderText = "Código de Localidad";
            this.codigoLoc.Name = "codigoLoc";
            // 
            // ABMLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 396);
            this.Controls.Add(this.grdLocalidades);
            this.Controls.Add(this.btnGuardarLoc);
            this.Controls.Add(this.btnBorrarLoc);
            this.Controls.Add(this.btnActualizarLoc);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.txtNombreLocalidad);
            this.Controls.Add(this.lblNombreLocalidad);
            this.Controls.Add(this.lblTituloLocalidades);
            this.Name = "ABMLocalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMLocalidades";
            this.Load += new System.EventHandler(this.ABMLocalidades_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grdLocalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloLocalidades;
        private System.Windows.Forms.TextBox txtNombreLocalidad;
        private System.Windows.Forms.Label lblNombreLocalidad;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnActualizarLoc;
        private System.Windows.Forms.Button btnBorrarLoc;
        private System.Windows.Forms.Button btnGuardarLoc;
        private System.Windows.Forms.DataGridView grdLocalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoLoc;
    }
}