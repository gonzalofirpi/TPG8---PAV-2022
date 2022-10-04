
namespace TrabajoIntegradorG8.Puestos
{
    partial class PuestosABM
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBarrios = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnActualizarBarrio = new System.Windows.Forms.Button();
            this.btnBorrarPuesto = new System.Windows.Forms.Button();
            this.btnGuardarBarrio = new System.Windows.Forms.Button();
            this.gridPuesto = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(148, 136);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 30);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // lblBarrios
            // 
            this.lblBarrios.AutoSize = true;
            this.lblBarrios.BackColor = System.Drawing.Color.Transparent;
            this.lblBarrios.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrios.Location = new System.Drawing.Point(268, 9);
            this.lblBarrios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrios.Name = "lblBarrios";
            this.lblBarrios.Size = new System.Drawing.Size(184, 54);
            this.lblBarrios.TabIndex = 8;
            this.lblBarrios.Text = "PUESTOS";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(13, 259);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(144, 59);
            this.btnLimpiarCampos.TabIndex = 17;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnActualizarBarrio
            // 
            this.btnActualizarBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarBarrio.Location = new System.Drawing.Point(176, 259);
            this.btnActualizarBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarBarrio.Name = "btnActualizarBarrio";
            this.btnActualizarBarrio.Size = new System.Drawing.Size(144, 59);
            this.btnActualizarBarrio.TabIndex = 18;
            this.btnActualizarBarrio.Text = "Actualizar Puesto";
            this.btnActualizarBarrio.UseVisualStyleBackColor = true;
            this.btnActualizarBarrio.Click += new System.EventHandler(this.btnActualizarBarrio_Click);
            // 
            // btnBorrarPuesto
            // 
            this.btnBorrarPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarPuesto.Location = new System.Drawing.Point(13, 345);
            this.btnBorrarPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarPuesto.Name = "btnBorrarPuesto";
            this.btnBorrarPuesto.Size = new System.Drawing.Size(144, 59);
            this.btnBorrarPuesto.TabIndex = 19;
            this.btnBorrarPuesto.Text = "Borrar Puesto";
            this.btnBorrarPuesto.UseVisualStyleBackColor = true;
            this.btnBorrarPuesto.Click += new System.EventHandler(this.btnBorrarPuesto_Click);
            // 
            // btnGuardarBarrio
            // 
            this.btnGuardarBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarBarrio.Location = new System.Drawing.Point(176, 345);
            this.btnGuardarBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarBarrio.Name = "btnGuardarBarrio";
            this.btnGuardarBarrio.Size = new System.Drawing.Size(144, 59);
            this.btnGuardarBarrio.TabIndex = 20;
            this.btnGuardarBarrio.Text = "Guardar Puesto";
            this.btnGuardarBarrio.UseVisualStyleBackColor = true;
            this.btnGuardarBarrio.Click += new System.EventHandler(this.btnGuardarBarrio_Click);
            // 
            // gridPuesto
            // 
            this.gridPuesto.AllowUserToAddRows = false;
            this.gridPuesto.AllowUserToDeleteRows = false;
            this.gridPuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre});
            this.gridPuesto.Location = new System.Drawing.Point(348, 118);
            this.gridPuesto.Name = "gridPuesto";
            this.gridPuesto.ReadOnly = true;
            this.gridPuesto.RowHeadersWidth = 51;
            this.gridPuesto.RowTemplate.Height = 24;
            this.gridPuesto.Size = new System.Drawing.Size(309, 286);
            this.gridPuesto.TabIndex = 21;
            this.gridPuesto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPuesto_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "COD_PUESTO";
            this.codigo.HeaderText = "CodPuestos";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "NOMBRE";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // PuestosABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 453);
            this.Controls.Add(this.gridPuesto);
            this.Controls.Add(this.btnGuardarBarrio);
            this.Controls.Add(this.btnBorrarPuesto);
            this.Controls.Add(this.btnActualizarBarrio);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.lblBarrios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Name = "PuestosABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puestos";
            this.Load += new System.EventHandler(this.Puestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBarrios;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnActualizarBarrio;
        private System.Windows.Forms.Button btnBorrarPuesto;
        private System.Windows.Forms.Button btnGuardarBarrio;
        private System.Windows.Forms.DataGridView gridPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}