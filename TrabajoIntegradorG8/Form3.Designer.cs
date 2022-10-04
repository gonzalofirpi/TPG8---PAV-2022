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
            this.txtCodCargo = new System.Windows.Forms.TextBox();
            this.lblCodCargo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCargos
            // 
            this.lblTituloCargos.AutoSize = true;
            this.lblTituloCargos.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCargos.Location = new System.Drawing.Point(156, 18);
            this.lblTituloCargos.Name = "lblTituloCargos";
            this.lblTituloCargos.Size = new System.Drawing.Size(136, 43);
            this.lblTituloCargos.TabIndex = 0;
            this.lblTituloCargos.Text = "CARGOS";
            // 
            // lblNombreCargo
            // 
            this.lblNombreCargo.AutoSize = true;
            this.lblNombreCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCargo.Location = new System.Drawing.Point(12, 99);
            this.lblNombreCargo.Name = "lblNombreCargo";
            this.lblNombreCargo.Size = new System.Drawing.Size(109, 20);
            this.lblNombreCargo.TabIndex = 2;
            this.lblNombreCargo.Text = "Nombre cargo";
            // 
            // txtNombreCargo
            // 
            this.txtNombreCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCargo.Location = new System.Drawing.Point(136, 93);
            this.txtNombreCargo.Name = "txtNombreCargo";
            this.txtNombreCargo.Size = new System.Drawing.Size(100, 26);
            this.txtNombreCargo.TabIndex = 3;
            // 
            // dgvCargos
            // 
            this.dgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargos.Location = new System.Drawing.Point(316, 71);
            this.dgvCargos.Name = "dgvCargos";
            this.dgvCargos.Size = new System.Drawing.Size(298, 110);
            this.dgvCargos.TabIndex = 5;
            this.dgvCargos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargos_CellContentClick);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(12, 202);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(102, 57);
            this.btnLimpiarCampos.TabIndex = 6;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnAgregarCargo
            // 
            this.btnAgregarCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCargo.Location = new System.Drawing.Point(390, 202);
            this.btnAgregarCargo.Name = "btnAgregarCargo";
            this.btnAgregarCargo.Size = new System.Drawing.Size(106, 57);
            this.btnAgregarCargo.TabIndex = 7;
            this.btnAgregarCargo.Text = "Agregar Cargo";
            this.btnAgregarCargo.UseVisualStyleBackColor = true;
            this.btnAgregarCargo.Click += new System.EventHandler(this.btnAgregarCargo_Click);
            // 
            // btnBorrarCargo
            // 
            this.btnBorrarCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarCargo.Location = new System.Drawing.Point(255, 202);
            this.btnBorrarCargo.Name = "btnBorrarCargo";
            this.btnBorrarCargo.Size = new System.Drawing.Size(111, 57);
            this.btnBorrarCargo.TabIndex = 8;
            this.btnBorrarCargo.Text = "Borrar Cargo";
            this.btnBorrarCargo.UseVisualStyleBackColor = true;
            this.btnBorrarCargo.Click += new System.EventHandler(this.btnBorrarCargo_Click);
            // 
            // btnModificarCargo
            // 
            this.btnModificarCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCargo.Location = new System.Drawing.Point(130, 202);
            this.btnModificarCargo.Name = "btnModificarCargo";
            this.btnModificarCargo.Size = new System.Drawing.Size(106, 57);
            this.btnModificarCargo.TabIndex = 9;
            this.btnModificarCargo.Text = "Modificar Cargo";
            this.btnModificarCargo.UseVisualStyleBackColor = true;
            this.btnModificarCargo.Click += new System.EventHandler(this.btnModificarCargo_Click);
            // 
            // txtCodCargo
            // 
            this.txtCodCargo.Enabled = false;
            this.txtCodCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCargo.Location = new System.Drawing.Point(136, 137);
            this.txtCodCargo.Name = "txtCodCargo";
            this.txtCodCargo.Size = new System.Drawing.Size(100, 26);
            this.txtCodCargo.TabIndex = 11;
            // 
            // lblCodCargo
            // 
            this.lblCodCargo.AutoSize = true;
            this.lblCodCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCargo.Location = new System.Drawing.Point(12, 143);
            this.lblCodCargo.Name = "lblCodCargo";
            this.lblCodCargo.Size = new System.Drawing.Size(103, 20);
            this.lblCodCargo.TabIndex = 12;
            this.lblCodCargo.Text = "Codigo cargo";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 281);
            this.Controls.Add(this.lblCodCargo);
            this.Controls.Add(this.txtCodCargo);
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
        private System.Windows.Forms.TextBox txtCodCargo;
        private System.Windows.Forms.Label lblCodCargo;
    }
}