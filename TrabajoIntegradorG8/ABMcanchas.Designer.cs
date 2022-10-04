namespace TrabajoIntegradorG8
{
    partial class ABMcanchas
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
            this.lblBarrios = new System.Windows.Forms.Label();
            this.btnBorrarCancha = new System.Windows.Forms.Button();
            this.btnActualizarCancha = new System.Windows.Forms.Button();
            this.lblListaArbitros = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnGuardarCancha = new System.Windows.Forms.Button();
            this.txtIdClub = new System.Windows.Forms.TextBox();
            this.lblIdeclub = new System.Windows.Forms.Label();
            this.txtNroCancha = new System.Windows.Forms.TextBox();
            this.lblNrocancha = new System.Windows.Forms.Label();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.lblNroCalle = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtCodPiso = new System.Windows.Forms.TextBox();
            this.lblCodpiso = new System.Windows.Forms.Label();
            this.txtCodBarrio = new System.Windows.Forms.TextBox();
            this.lblCodbarrio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodEstado = new System.Windows.Forms.TextBox();
            this.lblCodigoEstado = new System.Windows.Forms.Label();
            this.grillaCanchas = new System.Windows.Forms.DataGridView();
            this.txtFechaUltMant = new System.Windows.Forms.MaskedTextBox();
            this.NroCancha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCanchas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarrios
            // 
            this.lblBarrios.AutoSize = true;
            this.lblBarrios.BackColor = System.Drawing.Color.Transparent;
            this.lblBarrios.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrios.Location = new System.Drawing.Point(37, 24);
            this.lblBarrios.Name = "lblBarrios";
            this.lblBarrios.Size = new System.Drawing.Size(154, 43);
            this.lblBarrios.TabIndex = 23;
            this.lblBarrios.Text = "CANCHAS";
            // 
            // btnBorrarCancha
            // 
            this.btnBorrarCancha.Enabled = false;
            this.btnBorrarCancha.Location = new System.Drawing.Point(456, 378);
            this.btnBorrarCancha.Name = "btnBorrarCancha";
            this.btnBorrarCancha.Size = new System.Drawing.Size(75, 49);
            this.btnBorrarCancha.TabIndex = 22;
            this.btnBorrarCancha.Text = "Borrar Cancha";
            this.btnBorrarCancha.UseVisualStyleBackColor = true;
            this.btnBorrarCancha.Click += new System.EventHandler(this.btnBorrarCancha_Click);
            // 
            // btnActualizarCancha
            // 
            this.btnActualizarCancha.Enabled = false;
            this.btnActualizarCancha.Location = new System.Drawing.Point(552, 378);
            this.btnActualizarCancha.Name = "btnActualizarCancha";
            this.btnActualizarCancha.Size = new System.Drawing.Size(75, 49);
            this.btnActualizarCancha.TabIndex = 21;
            this.btnActualizarCancha.Text = "Actualizar Cancha";
            this.btnActualizarCancha.UseVisualStyleBackColor = true;
            this.btnActualizarCancha.Click += new System.EventHandler(this.btnActualizarCancha_Click);
            // 
            // lblListaArbitros
            // 
            this.lblListaArbitros.AutoSize = true;
            this.lblListaArbitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaArbitros.Location = new System.Drawing.Point(498, 76);
            this.lblListaArbitros.Name = "lblListaArbitros";
            this.lblListaArbitros.Size = new System.Drawing.Size(104, 13);
            this.lblListaArbitros.TabIndex = 20;
            this.lblListaArbitros.Text = "Lista de canchas";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(208, 378);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(75, 49);
            this.btnLimpiarCampos.TabIndex = 18;
            this.btnLimpiarCampos.Text = " Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCancha
            // 
            this.btnGuardarCancha.Location = new System.Drawing.Point(302, 378);
            this.btnGuardarCancha.Name = "btnGuardarCancha";
            this.btnGuardarCancha.Size = new System.Drawing.Size(75, 49);
            this.btnGuardarCancha.TabIndex = 17;
            this.btnGuardarCancha.Text = "Guardar";
            this.btnGuardarCancha.UseVisualStyleBackColor = true;
            this.btnGuardarCancha.Click += new System.EventHandler(this.btnGuardarCancha_Click);
            // 
            // txtIdClub
            // 
            this.txtIdClub.Location = new System.Drawing.Point(206, 130);
            this.txtIdClub.Name = "txtIdClub";
            this.txtIdClub.Size = new System.Drawing.Size(171, 20);
            this.txtIdClub.TabIndex = 16;
            // 
            // lblIdeclub
            // 
            this.lblIdeclub.AutoSize = true;
            this.lblIdeclub.Location = new System.Drawing.Point(80, 137);
            this.lblIdeclub.Name = "lblIdeclub";
            this.lblIdeclub.Size = new System.Drawing.Size(108, 13);
            this.lblIdeclub.TabIndex = 15;
            this.lblIdeclub.Text = "Identificador del club:";
            // 
            // txtNroCancha
            // 
            this.txtNroCancha.Location = new System.Drawing.Point(206, 97);
            this.txtNroCancha.Name = "txtNroCancha";
            this.txtNroCancha.Size = new System.Drawing.Size(171, 20);
            this.txtNroCancha.TabIndex = 14;
            // 
            // lblNrocancha
            // 
            this.lblNrocancha.AutoSize = true;
            this.lblNrocancha.Location = new System.Drawing.Point(87, 104);
            this.lblNrocancha.Name = "lblNrocancha";
            this.lblNrocancha.Size = new System.Drawing.Size(101, 13);
            this.lblNrocancha.TabIndex = 13;
            this.lblNrocancha.Text = "Numero de cancha:";
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(206, 201);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(171, 20);
            this.txtNroCalle.TabIndex = 27;
            // 
            // lblNroCalle
            // 
            this.lblNroCalle.AutoSize = true;
            this.lblNroCalle.Location = new System.Drawing.Point(101, 204);
            this.lblNroCalle.Name = "lblNroCalle";
            this.lblNroCalle.Size = new System.Drawing.Size(87, 13);
            this.lblNroCalle.TabIndex = 26;
            this.lblNroCalle.Text = "Numero de calle:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(206, 168);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(171, 20);
            this.txtCalle.TabIndex = 25;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(155, 175);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 24;
            this.lblCalle.Text = "Calle:";
            // 
            // txtCodPiso
            // 
            this.txtCodPiso.Location = new System.Drawing.Point(206, 269);
            this.txtCodPiso.Name = "txtCodPiso";
            this.txtCodPiso.Size = new System.Drawing.Size(171, 20);
            this.txtCodPiso.TabIndex = 31;
            // 
            // lblCodpiso
            // 
            this.lblCodpiso.AutoSize = true;
            this.lblCodpiso.Location = new System.Drawing.Point(108, 276);
            this.lblCodpiso.Name = "lblCodpiso";
            this.lblCodpiso.Size = new System.Drawing.Size(80, 13);
            this.lblCodpiso.TabIndex = 30;
            this.lblCodpiso.Text = "Codigo de piso:";
            // 
            // txtCodBarrio
            // 
            this.txtCodBarrio.Location = new System.Drawing.Point(205, 240);
            this.txtCodBarrio.Name = "txtCodBarrio";
            this.txtCodBarrio.Size = new System.Drawing.Size(171, 20);
            this.txtCodBarrio.TabIndex = 29;
            // 
            // lblCodbarrio
            // 
            this.lblCodbarrio.AutoSize = true;
            this.lblCodbarrio.Location = new System.Drawing.Point(100, 243);
            this.lblCodbarrio.Name = "lblCodbarrio";
            this.lblCodbarrio.Size = new System.Drawing.Size(88, 13);
            this.lblCodbarrio.TabIndex = 28;
            this.lblCodbarrio.Text = "Codigo de Barrio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Fecha de ultimo mantenimiento:";
            // 
            // txtCodEstado
            // 
            this.txtCodEstado.Location = new System.Drawing.Point(205, 308);
            this.txtCodEstado.Name = "txtCodEstado";
            this.txtCodEstado.Size = new System.Drawing.Size(172, 20);
            this.txtCodEstado.TabIndex = 33;
            // 
            // lblCodigoEstado
            // 
            this.lblCodigoEstado.AutoSize = true;
            this.lblCodigoEstado.Location = new System.Drawing.Point(95, 315);
            this.lblCodigoEstado.Name = "lblCodigoEstado";
            this.lblCodigoEstado.Size = new System.Drawing.Size(93, 13);
            this.lblCodigoEstado.TabIndex = 32;
            this.lblCodigoEstado.Text = "Codigo de estado:";
            // 
            // grillaCanchas
            // 
            this.grillaCanchas.AllowUserToAddRows = false;
            this.grillaCanchas.AllowUserToDeleteRows = false;
            this.grillaCanchas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCanchas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroCancha,
            this.Club,
            this.Fecha});
            this.grillaCanchas.Location = new System.Drawing.Point(412, 97);
            this.grillaCanchas.Name = "grillaCanchas";
            this.grillaCanchas.ReadOnly = true;
            this.grillaCanchas.Size = new System.Drawing.Size(283, 220);
            this.grillaCanchas.TabIndex = 36;
            this.grillaCanchas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaCanchas_CellClick);
            // 
            // txtFechaUltMant
            // 
            this.txtFechaUltMant.Location = new System.Drawing.Point(205, 345);
            this.txtFechaUltMant.Mask = "00/00/0000";
            this.txtFechaUltMant.Name = "txtFechaUltMant";
            this.txtFechaUltMant.Size = new System.Drawing.Size(171, 20);
            this.txtFechaUltMant.TabIndex = 37;
            this.txtFechaUltMant.ValidatingType = typeof(System.DateTime);
            // 
            // NroCancha
            // 
            this.NroCancha.DataPropertyName = "NRO_CANCHA";
            this.NroCancha.HeaderText = "Nro de Cancha";
            this.NroCancha.Name = "NroCancha";
            this.NroCancha.ReadOnly = true;
            this.NroCancha.Width = 50;
            // 
            // Club
            // 
            this.Club.DataPropertyName = "ID_CLUB";
            this.Club.HeaderText = "id del club";
            this.Club.Name = "Club";
            this.Club.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FECHA_ULT_MANTENIMIENTO";
            this.Fecha.HeaderText = "Fecha de ultimo mantenimiento";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // ABMcanchas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 451);
            this.Controls.Add(this.txtFechaUltMant);
            this.Controls.Add(this.grillaCanchas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodEstado);
            this.Controls.Add(this.lblCodigoEstado);
            this.Controls.Add(this.txtCodPiso);
            this.Controls.Add(this.lblCodpiso);
            this.Controls.Add(this.txtCodBarrio);
            this.Controls.Add(this.lblCodbarrio);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.lblNroCalle);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblBarrios);
            this.Controls.Add(this.btnBorrarCancha);
            this.Controls.Add(this.btnActualizarCancha);
            this.Controls.Add(this.lblListaArbitros);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnGuardarCancha);
            this.Controls.Add(this.txtIdClub);
            this.Controls.Add(this.lblIdeclub);
            this.Controls.Add(this.txtNroCancha);
            this.Controls.Add(this.lblNrocancha);
            this.Name = "ABMcanchas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMcanchas";
            this.Load += new System.EventHandler(this.ABMcanchas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaCanchas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarrios;
        private System.Windows.Forms.Button btnBorrarCancha;
        private System.Windows.Forms.Button btnActualizarCancha;
        private System.Windows.Forms.Label lblListaArbitros;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnGuardarCancha;
        private System.Windows.Forms.TextBox txtIdClub;
        private System.Windows.Forms.Label lblIdeclub;
        private System.Windows.Forms.TextBox txtNroCancha;
        private System.Windows.Forms.Label lblNrocancha;
        private System.Windows.Forms.TextBox txtNroCalle;
        private System.Windows.Forms.Label lblNroCalle;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtCodPiso;
        private System.Windows.Forms.Label lblCodpiso;
        private System.Windows.Forms.TextBox txtCodBarrio;
        private System.Windows.Forms.Label lblCodbarrio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodEstado;
        private System.Windows.Forms.Label lblCodigoEstado;
        private System.Windows.Forms.DataGridView grillaCanchas;
        private System.Windows.Forms.MaskedTextBox txtFechaUltMant;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCancha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}