
namespace TrabajoIntegradorG8.EstadoCancha
{
    partial class ABMTipoObservaciones
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
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnActualizarObservacion = new System.Windows.Forms.Button();
            this.btnBorrarObservacion = new System.Windows.Forms.Button();
            this.btnGuardarObservacion = new System.Windows.Forms.Button();
            this.grideEstado = new System.Windows.Forms.DataGridView();
            this.lblBarrios = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grideEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(116, 186);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 30);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(13, 360);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(144, 59);
            this.btnLimpiarCampos.TabIndex = 18;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnActualizarObservacion
            // 
            this.btnActualizarObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarObservacion.Location = new System.Drawing.Point(186, 360);
            this.btnActualizarObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarObservacion.Name = "btnActualizarObservacion";
            this.btnActualizarObservacion.Size = new System.Drawing.Size(144, 59);
            this.btnActualizarObservacion.TabIndex = 19;
            this.btnActualizarObservacion.Text = "Actualizar ";
            this.btnActualizarObservacion.UseVisualStyleBackColor = true;
            this.btnActualizarObservacion.Click += new System.EventHandler(this.btnActualizarObservacion_Click);
            // 
            // btnBorrarObservacion
            // 
            this.btnBorrarObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarObservacion.Location = new System.Drawing.Point(13, 440);
            this.btnBorrarObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarObservacion.Name = "btnBorrarObservacion";
            this.btnBorrarObservacion.Size = new System.Drawing.Size(144, 59);
            this.btnBorrarObservacion.TabIndex = 20;
            this.btnBorrarObservacion.Text = "Borrar ";
            this.btnBorrarObservacion.UseVisualStyleBackColor = true;
            this.btnBorrarObservacion.Click += new System.EventHandler(this.btnBorrarObservacion_Click);
            // 
            // btnGuardarObservacion
            // 
            this.btnGuardarObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarObservacion.Location = new System.Drawing.Point(186, 440);
            this.btnGuardarObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarObservacion.Name = "btnGuardarObservacion";
            this.btnGuardarObservacion.Size = new System.Drawing.Size(144, 59);
            this.btnGuardarObservacion.TabIndex = 21;
            this.btnGuardarObservacion.Text = "Guardar";
            this.btnGuardarObservacion.UseVisualStyleBackColor = true;
            this.btnGuardarObservacion.Click += new System.EventHandler(this.btnGuardarObservacion_Click_1);
            // 
            // grideEstado
            // 
            this.grideEstado.AllowUserToAddRows = false;
            this.grideEstado.AllowUserToDeleteRows = false;
            this.grideEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grideEstado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre});
            this.grideEstado.Location = new System.Drawing.Point(369, 186);
            this.grideEstado.Name = "grideEstado";
            this.grideEstado.ReadOnly = true;
            this.grideEstado.RowHeadersWidth = 51;
            this.grideEstado.RowTemplate.Height = 24;
            this.grideEstado.Size = new System.Drawing.Size(349, 313);
            this.grideEstado.TabIndex = 22;
            this.grideEstado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grideEstado_CellContentClick);
            // 
            // lblBarrios
            // 
            this.lblBarrios.AutoSize = true;
            this.lblBarrios.BackColor = System.Drawing.Color.Transparent;
            this.lblBarrios.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrios.Location = new System.Drawing.Point(177, 26);
            this.lblBarrios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrios.Name = "lblBarrios";
            this.lblBarrios.Size = new System.Drawing.Size(408, 54);
            this.lblBarrios.TabIndex = 23;
            this.lblBarrios.Text = "TIPO OBSERVACIONES";
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "COD_OBSERVACION";
            this.codigo.HeaderText = "Cod Observaciones";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "NOMBRE";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // ABMTipoObservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 570);
            this.Controls.Add(this.lblBarrios);
            this.Controls.Add(this.grideEstado);
            this.Controls.Add(this.btnGuardarObservacion);
            this.Controls.Add(this.btnBorrarObservacion);
            this.Controls.Add(this.btnActualizarObservacion);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Name = "ABMTipoObservaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMEstadoCancha";
            this.Load += new System.EventHandler(this.ABMTipoObservaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grideEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnActualizarObservacion;
        private System.Windows.Forms.Button btnBorrarObservacion;
        private System.Windows.Forms.Button btnGuardarObservacion;
        private System.Windows.Forms.DataGridView grideEstado;
        private System.Windows.Forms.Label lblBarrios;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}