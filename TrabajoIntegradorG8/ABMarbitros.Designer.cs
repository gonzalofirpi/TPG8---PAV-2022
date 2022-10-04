namespace TrabajoIntegradorG8
{
    partial class ABMarbitros
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnGuardarArbitro = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.grillaArbitros = new System.Windows.Forms.DataGridView();
            this.idarbitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArbitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblListaArbitros = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblBarrios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaArbitros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(54, 154);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 147);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(108, 188);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(155, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(54, 195);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // btnGuardarArbitro
            // 
            this.btnGuardarArbitro.Location = new System.Drawing.Point(188, 226);
            this.btnGuardarArbitro.Name = "btnGuardarArbitro";
            this.btnGuardarArbitro.Size = new System.Drawing.Size(75, 49);
            this.btnGuardarArbitro.TabIndex = 6;
            this.btnGuardarArbitro.Text = "Guardar";
            this.btnGuardarArbitro.UseVisualStyleBackColor = true;
            this.btnGuardarArbitro.Click += new System.EventHandler(this.btnGuardarArbitro_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(107, 226);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(75, 49);
            this.btnLimpiarCampos.TabIndex = 7;
            this.btnLimpiarCampos.Text = " Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // grillaArbitros
            // 
            this.grillaArbitros.AllowUserToAddRows = false;
            this.grillaArbitros.AllowUserToDeleteRows = false;
            this.grillaArbitros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaArbitros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idarbitro,
            this.NombreArbitro,
            this.Apellido});
            this.grillaArbitros.Location = new System.Drawing.Point(313, 74);
            this.grillaArbitros.Name = "grillaArbitros";
            this.grillaArbitros.ReadOnly = true;
            this.grillaArbitros.Size = new System.Drawing.Size(268, 134);
            this.grillaArbitros.TabIndex = 8;
            this.grillaArbitros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaArbitros_CellClick);
            // 
            // idarbitro
            // 
            this.idarbitro.DataPropertyName = "ID_ARBITRO";
            this.idarbitro.HeaderText = "ID";
            this.idarbitro.Name = "idarbitro";
            this.idarbitro.ReadOnly = true;
            this.idarbitro.Width = 40;
            // 
            // NombreArbitro
            // 
            this.NombreArbitro.DataPropertyName = "NOMBRE";
            this.NombreArbitro.HeaderText = "Nombre";
            this.NombreArbitro.Name = "NombreArbitro";
            this.NombreArbitro.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "APELLIDO";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // lblListaArbitros
            // 
            this.lblListaArbitros.AutoSize = true;
            this.lblListaArbitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaArbitros.Location = new System.Drawing.Point(310, 40);
            this.lblListaArbitros.Name = "lblListaArbitros";
            this.lblListaArbitros.Size = new System.Drawing.Size(98, 13);
            this.lblListaArbitros.TabIndex = 9;
            this.lblListaArbitros.Text = "Lista de arbitros";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(394, 226);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 49);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar arbitro";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(313, 226);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 49);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar arbitro";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblBarrios
            // 
            this.lblBarrios.AutoSize = true;
            this.lblBarrios.BackColor = System.Drawing.Color.Transparent;
            this.lblBarrios.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrios.Location = new System.Drawing.Point(49, 22);
            this.lblBarrios.Name = "lblBarrios";
            this.lblBarrios.Size = new System.Drawing.Size(164, 43);
            this.lblBarrios.TabIndex = 12;
            this.lblBarrios.Text = "ARBITROS";
            // 
            // ABMarbitros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 307);
            this.Controls.Add(this.lblBarrios);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblListaArbitros);
            this.Controls.Add(this.grillaArbitros);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnGuardarArbitro);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "ABMarbitros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbitros";
            this.Load += new System.EventHandler(this.AltaArbitro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaArbitros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnGuardarArbitro;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridView grillaArbitros;
        private System.Windows.Forms.Label lblListaArbitros;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idarbitro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArbitro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.Label lblBarrios;
    }
}