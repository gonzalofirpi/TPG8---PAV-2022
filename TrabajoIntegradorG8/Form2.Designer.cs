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
            this.txtAgregarCtegoria = new System.Windows.Forms.TextBox();
            this.lblAgregarCategoria = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.lblCodigoCategoria = new System.Windows.Forms.Label();
            this.txtCodigoCategoria = new System.Windows.Forms.TextBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.dgrCategorias = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAgregarCtegoria
            // 
            this.txtAgregarCtegoria.Location = new System.Drawing.Point(245, 113);
            this.txtAgregarCtegoria.Name = "txtAgregarCtegoria";
            this.txtAgregarCtegoria.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarCtegoria.TabIndex = 0;
            // 
            // lblAgregarCategoria
            // 
            this.lblAgregarCategoria.AutoSize = true;
            this.lblAgregarCategoria.Location = new System.Drawing.Point(147, 113);
            this.lblAgregarCategoria.Name = "lblAgregarCategoria";
            this.lblAgregarCategoria.Size = new System.Drawing.Size(92, 13);
            this.lblAgregarCategoria.TabIndex = 1;
            this.lblAgregarCategoria.Text = "Agregar Categoria";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(259, 166);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(123, 23);
            this.btnAgregarCategoria.TabIndex = 2;
            this.btnAgregarCategoria.Text = "Guardar Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // lblCodigoCategoria
            // 
            this.lblCodigoCategoria.AutoSize = true;
            this.lblCodigoCategoria.Location = new System.Drawing.Point(151, 64);
            this.lblCodigoCategoria.Name = "lblCodigoCategoria";
            this.lblCodigoCategoria.Size = new System.Drawing.Size(88, 13);
            this.lblCodigoCategoria.TabIndex = 3;
            this.lblCodigoCategoria.Text = "Codigo Categoria";
            // 
            // txtCodigoCategoria
            // 
            this.txtCodigoCategoria.Location = new System.Drawing.Point(245, 64);
            this.txtCodigoCategoria.Name = "txtCodigoCategoria";
            this.txtCodigoCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCategoria.TabIndex = 4;
            this.txtCodigoCategoria.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(110, 166);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(129, 23);
            this.btnLimpiarCampos.TabIndex = 5;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgrCategorias
            // 
            this.dgrCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrCategorias.Location = new System.Drawing.Point(529, 12);
            this.dgrCategorias.Name = "dgrCategorias";
            this.dgrCategorias.Size = new System.Drawing.Size(563, 374);
            this.dgrCategorias.TabIndex = 7;
            this.dgrCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrCategorias_CellContentClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(142, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(240, 46);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "CATEGORÍAS";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 596);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgrCategorias);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.txtCodigoCategoria);
            this.Controls.Add(this.lblCodigoCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.lblAgregarCategoria);
            this.Controls.Add(this.txtAgregarCtegoria);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgrCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAgregarCtegoria;
        private System.Windows.Forms.Label lblAgregarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Label lblCodigoCategoria;
        private System.Windows.Forms.TextBox txtCodigoCategoria;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridView dgrCategorias;
        private System.Windows.Forms.Label lblTitulo;
    }
}