namespace TrabajoIntegradorG8
{
    partial class Form3
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
            this.lblTituloCargos = new System.Windows.Forms.Label();
            this.lblNombreCargo = new System.Windows.Forms.Label();
            this.txtNombreCargo = new System.Windows.Forms.TextBox();
            this.dgvCargos = new System.Windows.Forms.DataGridView();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnAgregarCargo = new System.Windows.Forms.Button();
            this.btnBorrarCargo = new System.Windows.Forms.Button();
            this.btnModificarCargo = new System.Windows.Forms.Button();
            this.lblTablaCargos = new System.Windows.Forms.Label();
            this.txtCodCargo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCargos
            // 
            this.lblTituloCargos.AutoSize = true;
            this.lblTituloCargos.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCargos.Location = new System.Drawing.Point(230, 9);
            this.lblTituloCargos.Name = "lblTituloCargos";
            this.lblTituloCargos.Size = new System.Drawing.Size(171, 46);
            this.lblTituloCargos.TabIndex = 0;
            this.lblTituloCargos.Text = "CARGOS";
            // 
            // lblNombreCargo
            // 
            this.lblNombreCargo.AutoSize = true;
            this.lblNombreCargo.Location = new System.Drawing.Point(202, 96);
            this.lblNombreCargo.Name = "lblNombreCargo";
            this.lblNombreCargo.Size = new System.Drawing.Size(75, 13);
            this.lblNombreCargo.TabIndex = 2;
            this.lblNombreCargo.Text = "Nombre Cargo";
            // 
            // txtNombreCargo
            // 
            this.txtNombreCargo.Location = new System.Drawing.Point(283, 93);
            this.txtNombreCargo.Name = "txtNombreCargo";
            this.txtNombreCargo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCargo.TabIndex = 3;
            // 
            // dgvCargos
            // 
            this.dgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargos.Location = new System.Drawing.Point(685, 134);
            this.dgvCargos.Name = "dgvCargos";
            this.dgvCargos.Size = new System.Drawing.Size(529, 445);
            this.dgvCargos.TabIndex = 5;
            this.dgvCargos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargos_CellContentClick);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(70, 180);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(102, 23);
            this.btnLimpiarCampos.TabIndex = 6;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnAgregarCargo
            // 
            this.btnAgregarCargo.Location = new System.Drawing.Point(178, 180);
            this.btnAgregarCargo.Name = "btnAgregarCargo";
            this.btnAgregarCargo.Size = new System.Drawing.Size(106, 23);
            this.btnAgregarCargo.TabIndex = 7;
            this.btnAgregarCargo.Text = "Agregar Cargo";
            this.btnAgregarCargo.UseVisualStyleBackColor = true;
            this.btnAgregarCargo.Click += new System.EventHandler(this.btnAgregarCargo_Click);
            // 
            // btnBorrarCargo
            // 
            this.btnBorrarCargo.Location = new System.Drawing.Point(290, 180);
            this.btnBorrarCargo.Name = "btnBorrarCargo";
            this.btnBorrarCargo.Size = new System.Drawing.Size(111, 23);
            this.btnBorrarCargo.TabIndex = 8;
            this.btnBorrarCargo.Text = "Borrar Cargo";
            this.btnBorrarCargo.UseVisualStyleBackColor = true;
            this.btnBorrarCargo.Click += new System.EventHandler(this.btnBorrarCargo_Click);
            // 
            // btnModificarCargo
            // 
            this.btnModificarCargo.Location = new System.Drawing.Point(407, 180);
            this.btnModificarCargo.Name = "btnModificarCargo";
            this.btnModificarCargo.Size = new System.Drawing.Size(106, 23);
            this.btnModificarCargo.TabIndex = 9;
            this.btnModificarCargo.Text = "Modificar Cargo";
            this.btnModificarCargo.UseVisualStyleBackColor = true;
            this.btnModificarCargo.Click += new System.EventHandler(this.btnModificarCargo_Click);
            // 
            // lblTablaCargos
            // 
            this.lblTablaCargos.AutoSize = true;
            this.lblTablaCargos.Location = new System.Drawing.Point(1013, 27);
            this.lblTablaCargos.Name = "lblTablaCargos";
            this.lblTablaCargos.Size = new System.Drawing.Size(70, 13);
            this.lblTablaCargos.TabIndex = 10;
            this.lblTablaCargos.Text = "Tabla Cargos";
            // 
            // txtCodCargo
            // 
            this.txtCodCargo.Enabled = false;
            this.txtCodCargo.Location = new System.Drawing.Point(283, 143);
            this.txtCodCargo.Name = "txtCodCargo";
            this.txtCodCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCodCargo.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 793);
            this.Controls.Add(this.txtCodCargo);
            this.Controls.Add(this.lblTablaCargos);
            this.Controls.Add(this.btnModificarCargo);
            this.Controls.Add(this.btnBorrarCargo);
            this.Controls.Add(this.btnAgregarCargo);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.dgvCargos);
            this.Controls.Add(this.txtNombreCargo);
            this.Controls.Add(this.lblNombreCargo);
            this.Controls.Add(this.lblTituloCargos);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCargos;
        private System.Windows.Forms.Label lblNombreCargo;
        private System.Windows.Forms.TextBox txtNombreCargo;
        private System.Windows.Forms.DataGridView dgvCargos;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnAgregarCargo;
        private System.Windows.Forms.Button btnBorrarCargo;
        private System.Windows.Forms.Button btnModificarCargo;
        private System.Windows.Forms.Label lblTablaCargos;
        private System.Windows.Forms.TextBox txtCodCargo;
    }
}