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
            this.btnGuardarJugador = new System.Windows.Forms.Button();
            this.btnActualizarJugador = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.grdJugadores = new System.Windows.Forms.DataGridView();
            this.btnBorrarJugador = new System.Windows.Forms.Button();
            this.cmbClub = new System.Windows.Forms.ComboBox();
            this.cmbSocio = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJugadores
            // 
            this.lblJugadores.AutoSize = true;
            this.lblJugadores.BackColor = System.Drawing.Color.Transparent;
            this.lblJugadores.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugadores.Location = new System.Drawing.Point(178, 29);
            this.lblJugadores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJugadores.Name = "lblJugadores";
            this.lblJugadores.Size = new System.Drawing.Size(263, 65);
            this.lblJugadores.TabIndex = 7;
            this.lblJugadores.Text = "Jugadores";
            // 
            // lblIdClub
            // 
            this.lblIdClub.AutoSize = true;
            this.lblIdClub.BackColor = System.Drawing.Color.Transparent;
            this.lblIdClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdClub.Location = new System.Drawing.Point(30, 166);
            this.lblIdClub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdClub.Name = "lblIdClub";
            this.lblIdClub.Size = new System.Drawing.Size(75, 29);
            this.lblIdClub.TabIndex = 9;
            this.lblIdClub.Text = "Club: ";
            this.lblIdClub.Click += new System.EventHandler(this.lblIdClub_Click);
            // 
            // lblIdSocio
            // 
            this.lblIdSocio.AutoSize = true;
            this.lblIdSocio.BackColor = System.Drawing.Color.Transparent;
            this.lblIdSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSocio.Location = new System.Drawing.Point(30, 243);
            this.lblIdSocio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdSocio.Name = "lblIdSocio";
            this.lblIdSocio.Size = new System.Drawing.Size(87, 29);
            this.lblIdSocio.TabIndex = 10;
            this.lblIdSocio.Text = "Socio: ";
            this.lblIdSocio.Click += new System.EventHandler(this.lblIdSocio_Click);
            // 
            // btnGuardarJugador
            // 
            this.btnGuardarJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarJugador.Location = new System.Drawing.Point(762, 493);
            this.btnGuardarJugador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarJugador.Name = "btnGuardarJugador";
            this.btnGuardarJugador.Size = new System.Drawing.Size(162, 74);
            this.btnGuardarJugador.TabIndex = 14;
            this.btnGuardarJugador.Text = "Guardar Jugador";
            this.btnGuardarJugador.UseVisualStyleBackColor = true;
            this.btnGuardarJugador.Click += new System.EventHandler(this.btnGuardarJugador_Click);
            // 
            // btnActualizarJugador
            // 
            this.btnActualizarJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarJugador.Location = new System.Drawing.Point(294, 493);
            this.btnActualizarJugador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizarJugador.Name = "btnActualizarJugador";
            this.btnActualizarJugador.Size = new System.Drawing.Size(162, 74);
            this.btnActualizarJugador.TabIndex = 15;
            this.btnActualizarJugador.Text = "Actualizar Jugador";
            this.btnActualizarJugador.UseVisualStyleBackColor = true;
            this.btnActualizarJugador.Click += new System.EventHandler(this.btnActualizarJugador_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(80, 493);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(162, 74);
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
            this.id,
            this.nombreSocio,
            this.nombreClub});
            this.grdJugadores.Location = new System.Drawing.Point(398, 129);
            this.grdJugadores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdJugadores.Name = "grdJugadores";
            this.grdJugadores.ReadOnly = true;
            this.grdJugadores.RowHeadersWidth = 62;
            this.grdJugadores.Size = new System.Drawing.Size(669, 289);
            this.grdJugadores.TabIndex = 17;
            this.grdJugadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdJugadores_CellClick);
            // 
            // btnBorrarJugador
            // 
            this.btnBorrarJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarJugador.Location = new System.Drawing.Point(517, 493);
            this.btnBorrarJugador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrarJugador.Name = "btnBorrarJugador";
            this.btnBorrarJugador.Size = new System.Drawing.Size(162, 74);
            this.btnBorrarJugador.TabIndex = 18;
            this.btnBorrarJugador.Text = "Borrar Jugador";
            this.btnBorrarJugador.UseVisualStyleBackColor = true;
            this.btnBorrarJugador.Click += new System.EventHandler(this.btnBorrarJugador_Click);
            // 
            // cmbClub
            // 
            this.cmbClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClub.FormattingEnabled = true;
            this.cmbClub.Location = new System.Drawing.Point(140, 170);
            this.cmbClub.Name = "cmbClub";
            this.cmbClub.Size = new System.Drawing.Size(180, 28);
            this.cmbClub.TabIndex = 19;
            this.cmbClub.SelectedIndexChanged += new System.EventHandler(this.cmbClub_SelectedIndexChanged);
            // 
            // cmbSocio
            // 
            this.cmbSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSocio.FormattingEnabled = true;
            this.cmbSocio.Location = new System.Drawing.Point(140, 247);
            this.cmbSocio.Name = "cmbSocio";
            this.cmbSocio.Size = new System.Drawing.Size(180, 28);
            this.cmbSocio.TabIndex = 20;
            this.cmbSocio.SelectedIndexChanged += new System.EventHandler(this.cmbSocio_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID_JUGADOR";
            this.id.HeaderText = "ID Jugador";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 75;
            // 
            // nombreSocio
            // 
            this.nombreSocio.DataPropertyName = "SOCIO";
            this.nombreSocio.HeaderText = "Socio";
            this.nombreSocio.MinimumWidth = 8;
            this.nombreSocio.Name = "nombreSocio";
            this.nombreSocio.ReadOnly = true;
            // 
            // nombreClub
            // 
            this.nombreClub.DataPropertyName = "CLUB";
            this.nombreClub.HeaderText = "Club";
            this.nombreClub.MinimumWidth = 8;
            this.nombreClub.Name = "nombreClub";
            this.nombreClub.ReadOnly = true;
            // 
            // frmJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 669);
            this.Controls.Add(this.cmbSocio);
            this.Controls.Add(this.cmbClub);
            this.Controls.Add(this.btnBorrarJugador);
            this.Controls.Add(this.grdJugadores);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnActualizarJugador);
            this.Controls.Add(this.btnGuardarJugador);
            this.Controls.Add(this.lblIdSocio);
            this.Controls.Add(this.lblIdClub);
            this.Controls.Add(this.lblJugadores);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button btnGuardarJugador;
        private System.Windows.Forms.Button btnActualizarJugador;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridView grdJugadores;
        private System.Windows.Forms.Button btnBorrarJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.ComboBox cmbClub;
        private System.Windows.Forms.ComboBox cmbSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClub;
    }
}