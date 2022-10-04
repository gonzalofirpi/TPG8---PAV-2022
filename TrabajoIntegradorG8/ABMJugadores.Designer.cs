namespace TrabajoIntegradorG8
{
    partial class frmJugadores
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
            this.lblJugadores = new System.Windows.Forms.Label();
            this.lblIdClub = new System.Windows.Forms.Label();
            this.lblIdSocio = new System.Windows.Forms.Label();
            this.txtIdClub = new System.Windows.Forms.TextBox();
            this.txtIdSocio = new System.Windows.Forms.TextBox();
            this.btnGuardarJugador = new System.Windows.Forms.Button();
            this.btnActualizarJugador = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.grdJugadores = new System.Windows.Forms.DataGridView();
            this.idClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrarJugador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJugadores
            // 
            this.lblJugadores.AutoSize = true;
            this.lblJugadores.BackColor = System.Drawing.Color.Transparent;
            this.lblJugadores.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugadores.Location = new System.Drawing.Point(119, 19);
            this.lblJugadores.Name = "lblJugadores";
            this.lblJugadores.Size = new System.Drawing.Size(177, 43);
            this.lblJugadores.TabIndex = 7;
            this.lblJugadores.Text = "Jugadores";
            // 
            // lblIdClub
            // 
            this.lblIdClub.AutoSize = true;
            this.lblIdClub.BackColor = System.Drawing.Color.Transparent;
            this.lblIdClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdClub.Location = new System.Drawing.Point(20, 108);
            this.lblIdClub.Name = "lblIdClub";
            this.lblIdClub.Size = new System.Drawing.Size(67, 20);
            this.lblIdClub.TabIndex = 9;
            this.lblIdClub.Text = "ID club: ";
            // 
            // lblIdSocio
            // 
            this.lblIdSocio.AutoSize = true;
            this.lblIdSocio.BackColor = System.Drawing.Color.Transparent;
            this.lblIdSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSocio.Location = new System.Drawing.Point(12, 158);
            this.lblIdSocio.Name = "lblIdSocio";
            this.lblIdSocio.Size = new System.Drawing.Size(75, 20);
            this.lblIdSocio.TabIndex = 10;
            this.lblIdSocio.Text = "ID socio: ";
            // 
            // txtIdClub
            // 
            this.txtIdClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdClub.Location = new System.Drawing.Point(93, 102);
            this.txtIdClub.Name = "txtIdClub";
            this.txtIdClub.Size = new System.Drawing.Size(124, 26);
            this.txtIdClub.TabIndex = 11;
            // 
            // txtIdSocio
            // 
            this.txtIdSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSocio.Location = new System.Drawing.Point(93, 152);
            this.txtIdSocio.Name = "txtIdSocio";
            this.txtIdSocio.Size = new System.Drawing.Size(121, 26);
            this.txtIdSocio.TabIndex = 12;
            // 
            // btnGuardarJugador
            // 
            this.btnGuardarJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarJugador.Location = new System.Drawing.Point(393, 278);
            this.btnGuardarJugador.Name = "btnGuardarJugador";
            this.btnGuardarJugador.Size = new System.Drawing.Size(108, 48);
            this.btnGuardarJugador.TabIndex = 14;
            this.btnGuardarJugador.Text = "Guardar Jugador";
            this.btnGuardarJugador.UseVisualStyleBackColor = true;
            this.btnGuardarJugador.Click += new System.EventHandler(this.btnGuardarJugador_Click);
            // 
            // btnActualizarJugador
            // 
            this.btnActualizarJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarJugador.Location = new System.Drawing.Point(140, 278);
            this.btnActualizarJugador.Name = "btnActualizarJugador";
            this.btnActualizarJugador.Size = new System.Drawing.Size(108, 48);
            this.btnActualizarJugador.TabIndex = 15;
            this.btnActualizarJugador.Text = "Actualizar Jugador";
            this.btnActualizarJugador.UseVisualStyleBackColor = true;
            this.btnActualizarJugador.Click += new System.EventHandler(this.btnActualizarJugador_Click);
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
            // grdJugadores
            // 
            this.grdJugadores.AllowUserToAddRows = false;
            this.grdJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClub,
            this.idSocio});
            this.grdJugadores.Location = new System.Drawing.Point(294, 83);
            this.grdJugadores.Name = "grdJugadores";
            this.grdJugadores.ReadOnly = true;
            this.grdJugadores.Size = new System.Drawing.Size(194, 141);
            this.grdJugadores.TabIndex = 17;
            this.grdJugadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdJugadores_CellClick);
            // 
            // idClub
            // 
            this.idClub.DataPropertyName = "ID_CLUB";
            this.idClub.HeaderText = "idClub";
            this.idClub.Name = "idClub";
            this.idClub.ReadOnly = true;
            this.idClub.Width = 50;
            // 
            // idSocio
            // 
            this.idSocio.DataPropertyName = "ID_SOCIO";
            this.idSocio.HeaderText = "idSocio";
            this.idSocio.Name = "idSocio";
            this.idSocio.ReadOnly = true;
            // 
            // btnBorrarJugador
            // 
            this.btnBorrarJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarJugador.Location = new System.Drawing.Point(265, 278);
            this.btnBorrarJugador.Name = "btnBorrarJugador";
            this.btnBorrarJugador.Size = new System.Drawing.Size(108, 48);
            this.btnBorrarJugador.TabIndex = 18;
            this.btnBorrarJugador.Text = "Borrar Jugador";
            this.btnBorrarJugador.UseVisualStyleBackColor = true;
            this.btnBorrarJugador.Click += new System.EventHandler(this.btnBorrarJugador_Click);
            // 
            // frmJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 348);
            this.Controls.Add(this.btnBorrarJugador);
            this.Controls.Add(this.grdJugadores);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnActualizarJugador);
            this.Controls.Add(this.btnGuardarJugador);
            this.Controls.Add(this.txtIdSocio);
            this.Controls.Add(this.txtIdClub);
            this.Controls.Add(this.lblIdSocio);
            this.Controls.Add(this.lblIdClub);
            this.Controls.Add(this.lblJugadores);
            this.Name = "frmJugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jugadores";
            this.Load += new System.EventHandler(this.frmJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJugadores;
        private System.Windows.Forms.Label lblIdClub;
        private System.Windows.Forms.Label lblIdSocio;
        private System.Windows.Forms.TextBox txtIdClub;
        private System.Windows.Forms.TextBox txtIdSocio;
        private System.Windows.Forms.Button btnGuardarJugador;
        private System.Windows.Forms.Button btnActualizarJugador;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridView grdJugadores;
        private System.Windows.Forms.Button btnBorrarJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
    }
}