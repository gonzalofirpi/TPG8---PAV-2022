namespace TrabajoIntegradorG8
{
    partial class Form2
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
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.lblAgregarCategoria = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.lblTituloCategorias = new System.Windows.Forms.Label();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnBorrarCategoria = new System.Windows.Forms.Button();
            this.txtCodCategoria = new System.Windows.Forms.TextBox();
            this.lblCodCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCategoria.Location = new System.Drawing.Point(153, 83);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(100, 26);
            this.txtNombreCategoria.TabIndex = 0;
            // 
            // lblAgregarCategoria
            // 
            this.lblAgregarCategoria.AutoSize = true;
            this.lblAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarCategoria.Location = new System.Drawing.Point(8, 89);
            this.lblAgregarCategoria.Name = "lblAgregarCategoria";
            this.lblAgregarCategoria.Size = new System.Drawing.Size(136, 20);
            this.lblAgregarCategoria.TabIndex = 1;
            this.lblAgregarCategoria.Text = "Agregar categoria";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.Location = new System.Drawing.Point(349, 202);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(97, 54);
            this.btnAgregarCategoria.TabIndex = 2;
            this.btnAgregarCategoria.Text = "Agregar Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(12, 202);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(92, 50);
            this.btnLimpiarCampos.TabIndex = 5;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(329, 83);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(253, 80);
            this.dgvCategorias.TabIndex = 7;
            this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick);
            // 
            // lblTituloCategorias
            // 
            this.lblTituloCategorias.AutoSize = true;
            this.lblTituloCategorias.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCategorias.Location = new System.Drawing.Point(113, 9);
            this.lblTituloCategorias.Name = "lblTituloCategorias";
            this.lblTituloCategorias.Size = new System.Drawing.Size(196, 43);
            this.lblTituloCategorias.TabIndex = 9;
            this.lblTituloCategorias.Text = "CATEGORÍAS";
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCategoria.Location = new System.Drawing.Point(121, 202);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(89, 51);
            this.btnModificarCategoria.TabIndex = 10;
            this.btnModificarCategoria.Text = "Modificar Categoria";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnBorrarCategoria
            // 
            this.btnBorrarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarCategoria.Location = new System.Drawing.Point(235, 202);
            this.btnBorrarCategoria.Name = "btnBorrarCategoria";
            this.btnBorrarCategoria.Size = new System.Drawing.Size(88, 53);
            this.btnBorrarCategoria.TabIndex = 11;
            this.btnBorrarCategoria.Text = "Borrar Categoria";
            this.btnBorrarCategoria.UseVisualStyleBackColor = true;
            this.btnBorrarCategoria.Click += new System.EventHandler(this.btnBorrarCategoria_Click);
            // 
            // txtCodCategoria
            // 
            this.txtCodCategoria.Enabled = false;
            this.txtCodCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCategoria.Location = new System.Drawing.Point(153, 137);
            this.txtCodCategoria.Name = "txtCodCategoria";
            this.txtCodCategoria.Size = new System.Drawing.Size(100, 26);
            this.txtCodCategoria.TabIndex = 12;
            // 
            // lblCodCategoria
            // 
            this.lblCodCategoria.AutoSize = true;
            this.lblCodCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCategoria.Location = new System.Drawing.Point(18, 143);
            this.lblCodCategoria.Name = "lblCodCategoria";
            this.lblCodCategoria.Size = new System.Drawing.Size(129, 20);
            this.lblCodCategoria.TabIndex = 13;
            this.lblCodCategoria.Text = "Codigo categoria";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 293);
            this.Controls.Add(this.lblCodCategoria);
            this.Controls.Add(this.txtCodCategoria);
            this.Controls.Add(this.btnBorrarCategoria);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.lblTituloCategorias);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.lblAgregarCategoria);
            this.Controls.Add(this.txtNombreCategoria);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label lblAgregarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Label lblTituloCategorias;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnBorrarCategoria;
        private System.Windows.Forms.TextBox txtCodCategoria;
        private System.Windows.Forms.Label lblCodCategoria;
    }
}