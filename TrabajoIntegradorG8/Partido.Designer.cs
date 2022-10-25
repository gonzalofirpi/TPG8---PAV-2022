namespace TrabajoIntegradorG8
{
    partial class frmPartido
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
            this.lblPartidos = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblClubLocal = new System.Windows.Forms.Label();
            this.lblNroCancha = new System.Windows.Forms.Label();
            this.lblClubVisitante = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.cmbClubLocal = new System.Windows.Forms.ComboBox();
            this.cmbNroCancha = new System.Windows.Forms.ComboBox();
            this.cmbClubVisitante = new System.Windows.Forms.ComboBox();
            this.grbJugadores = new System.Windows.Forms.GroupBox();
            this.cmbTitular = new System.Windows.Forms.ComboBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.txtApellidoJugador = new System.Windows.Forms.TextBox();
            this.lblApellidoJugador = new System.Windows.Forms.Label();
            this.grdJugadores = new System.Windows.Forms.DataGridView();
            this.idJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPuestos = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtNroCamiseta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.txtClub = new System.Windows.Forms.TextBox();
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.lblNombreJugador = new System.Windows.Forms.Label();
            this.btnBuscarJugador = new System.Windows.Forms.Button();
            this.lblClub = new System.Windows.Forms.Label();
            this.txtIdJugador = new System.Windows.Forms.TextBox();
            this.lblIdJugador = new System.Windows.Forms.Label();
            this.grbArbitros = new System.Windows.Forms.GroupBox();
            this.grdArbitros = new System.Windows.Forms.DataGridView();
            this.idArbitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreArbitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoArbitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarArbitro = new System.Windows.Forms.Button();
            this.cmbCargos = new System.Windows.Forms.ComboBox();
            this.txtApellidoArbitro = new System.Windows.Forms.TextBox();
            this.txtNombreArbitro = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblApellidoArbitro = new System.Windows.Forms.Label();
            this.lblNombreArbitro = new System.Windows.Forms.Label();
            this.btnBuscarArbitro = new System.Windows.Forms.Button();
            this.txtIdArbitro = new System.Windows.Forms.TextBox();
            this.lblIdArbitro = new System.Windows.Forms.Label();
            this.btnGuardarPartido = new System.Windows.Forms.Button();
            this.grbJugadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdJugadores)).BeginInit();
            this.grbArbitros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArbitros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPartidos
            // 
            this.lblPartidos.AutoSize = true;
            this.lblPartidos.BackColor = System.Drawing.Color.Transparent;
            this.lblPartidos.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidos.Location = new System.Drawing.Point(361, 9);
            this.lblPartidos.Name = "lblPartidos";
            this.lblPartidos.Size = new System.Drawing.Size(162, 43);
            this.lblPartidos.TabIndex = 7;
            this.lblPartidos.Text = "PARTIDOS";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(32, 71);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 20);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha: ";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(8, 108);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(86, 20);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria: ";
            // 
            // lblClubLocal
            // 
            this.lblClubLocal.AutoSize = true;
            this.lblClubLocal.BackColor = System.Drawing.Color.Transparent;
            this.lblClubLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubLocal.Location = new System.Drawing.Point(278, 73);
            this.lblClubLocal.Name = "lblClubLocal";
            this.lblClubLocal.Size = new System.Drawing.Size(85, 20);
            this.lblClubLocal.TabIndex = 10;
            this.lblClubLocal.Text = "Club local: ";
            // 
            // lblNroCancha
            // 
            this.lblNroCancha.AutoSize = true;
            this.lblNroCancha.BackColor = System.Drawing.Color.Transparent;
            this.lblNroCancha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCancha.Location = new System.Drawing.Point(517, 74);
            this.lblNroCancha.Name = "lblNroCancha";
            this.lblNroCancha.Size = new System.Drawing.Size(129, 20);
            this.lblNroCancha.TabIndex = 11;
            this.lblNroCancha.Text = "Número cancha: ";
            // 
            // lblClubVisitante
            // 
            this.lblClubVisitante.AutoSize = true;
            this.lblClubVisitante.BackColor = System.Drawing.Color.Transparent;
            this.lblClubVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubVisitante.Location = new System.Drawing.Point(252, 111);
            this.lblClubVisitante.Name = "lblClubVisitante";
            this.lblClubVisitante.Size = new System.Drawing.Size(111, 20);
            this.lblClubVisitante.TabIndex = 12;
            this.lblClubVisitante.Text = "Club visitante: ";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(100, 73);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(67, 20);
            this.txtFecha.TabIndex = 13;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(100, 110);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(121, 21);
            this.cmbCategorias.TabIndex = 14;
            // 
            // cmbClubLocal
            // 
            this.cmbClubLocal.FormattingEnabled = true;
            this.cmbClubLocal.Location = new System.Drawing.Point(369, 73);
            this.cmbClubLocal.Name = "cmbClubLocal";
            this.cmbClubLocal.Size = new System.Drawing.Size(121, 21);
            this.cmbClubLocal.TabIndex = 15;
            this.cmbClubLocal.SelectedIndexChanged += new System.EventHandler(this.cmbClubLocal_SelectedIndexChanged);
            // 
            // cmbNroCancha
            // 
            this.cmbNroCancha.FormattingEnabled = true;
            this.cmbNroCancha.Location = new System.Drawing.Point(652, 75);
            this.cmbNroCancha.Name = "cmbNroCancha";
            this.cmbNroCancha.Size = new System.Drawing.Size(121, 21);
            this.cmbNroCancha.TabIndex = 16;
            // 
            // cmbClubVisitante
            // 
            this.cmbClubVisitante.Enabled = false;
            this.cmbClubVisitante.FormattingEnabled = true;
            this.cmbClubVisitante.Location = new System.Drawing.Point(369, 113);
            this.cmbClubVisitante.Name = "cmbClubVisitante";
            this.cmbClubVisitante.Size = new System.Drawing.Size(121, 21);
            this.cmbClubVisitante.TabIndex = 17;
            // 
            // grbJugadores
            // 
            this.grbJugadores.Controls.Add(this.cmbTitular);
            this.grbJugadores.Controls.Add(this.lblTitular);
            this.grbJugadores.Controls.Add(this.txtApellidoJugador);
            this.grbJugadores.Controls.Add(this.lblApellidoJugador);
            this.grbJugadores.Controls.Add(this.grdJugadores);
            this.grbJugadores.Controls.Add(this.cmbPuestos);
            this.grbJugadores.Controls.Add(this.lblPuesto);
            this.grbJugadores.Controls.Add(this.txtNroCamiseta);
            this.grbJugadores.Controls.Add(this.label1);
            this.grbJugadores.Controls.Add(this.btnAgregarJugador);
            this.grbJugadores.Controls.Add(this.txtClub);
            this.grbJugadores.Controls.Add(this.txtNombreJugador);
            this.grbJugadores.Controls.Add(this.lblNombreJugador);
            this.grbJugadores.Controls.Add(this.btnBuscarJugador);
            this.grbJugadores.Controls.Add(this.lblClub);
            this.grbJugadores.Controls.Add(this.txtIdJugador);
            this.grbJugadores.Controls.Add(this.lblIdJugador);
            this.grbJugadores.Location = new System.Drawing.Point(12, 152);
            this.grbJugadores.Name = "grbJugadores";
            this.grbJugadores.Size = new System.Drawing.Size(905, 297);
            this.grbJugadores.TabIndex = 18;
            this.grbJugadores.TabStop = false;
            this.grbJugadores.Text = "Jugadores del partido";
            // 
            // cmbTitular
            // 
            this.cmbTitular.FormattingEnabled = true;
            this.cmbTitular.Location = new System.Drawing.Point(756, 92);
            this.cmbTitular.Name = "cmbTitular";
            this.cmbTitular.Size = new System.Drawing.Size(100, 21);
            this.cmbTitular.TabIndex = 35;
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.BackColor = System.Drawing.Color.Transparent;
            this.lblTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitular.Location = new System.Drawing.Point(694, 92);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(56, 20);
            this.lblTitular.TabIndex = 34;
            this.lblTitular.Text = "Titular:";
            // 
            // txtApellidoJugador
            // 
            this.txtApellidoJugador.Enabled = false;
            this.txtApellidoJugador.Location = new System.Drawing.Point(619, 41);
            this.txtApellidoJugador.Name = "txtApellidoJugador";
            this.txtApellidoJugador.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoJugador.TabIndex = 33;
            // 
            // lblApellidoJugador
            // 
            this.lblApellidoJugador.AutoSize = true;
            this.lblApellidoJugador.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoJugador.Location = new System.Drawing.Point(544, 41);
            this.lblApellidoJugador.Name = "lblApellidoJugador";
            this.lblApellidoJugador.Size = new System.Drawing.Size(69, 20);
            this.lblApellidoJugador.TabIndex = 32;
            this.lblApellidoJugador.Text = "Apellido:";
            // 
            // grdJugadores
            // 
            this.grdJugadores.AllowUserToAddRows = false;
            this.grdJugadores.AllowUserToDeleteRows = false;
            this.grdJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJugador,
            this.nombreJugador,
            this.apellidoJugador,
            this.club,
            this.numero,
            this.puesto});
            this.grdJugadores.Location = new System.Drawing.Point(20, 134);
            this.grdJugadores.Name = "grdJugadores";
            this.grdJugadores.ReadOnly = true;
            this.grdJugadores.Size = new System.Drawing.Size(438, 150);
            this.grdJugadores.TabIndex = 31;
            // 
            // idJugador
            // 
            this.idJugador.HeaderText = "Id";
            this.idJugador.Name = "idJugador";
            this.idJugador.ReadOnly = true;
            this.idJugador.Width = 25;
            // 
            // nombreJugador
            // 
            this.nombreJugador.HeaderText = "Nombre";
            this.nombreJugador.Name = "nombreJugador";
            this.nombreJugador.ReadOnly = true;
            this.nombreJugador.Width = 75;
            // 
            // apellidoJugador
            // 
            this.apellidoJugador.HeaderText = "Apellido";
            this.apellidoJugador.Name = "apellidoJugador";
            this.apellidoJugador.ReadOnly = true;
            this.apellidoJugador.Width = 75;
            // 
            // club
            // 
            this.club.HeaderText = "Club";
            this.club.Name = "club";
            this.club.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 50;
            // 
            // puesto
            // 
            this.puesto.HeaderText = "Puesto";
            this.puesto.Name = "puesto";
            this.puesto.ReadOnly = true;
            this.puesto.Width = 75;
            // 
            // cmbPuestos
            // 
            this.cmbPuestos.FormattingEnabled = true;
            this.cmbPuestos.Location = new System.Drawing.Point(570, 91);
            this.cmbPuestos.Name = "cmbPuestos";
            this.cmbPuestos.Size = new System.Drawing.Size(100, 21);
            this.cmbPuestos.TabIndex = 30;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(501, 89);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(63, 20);
            this.lblPuesto.TabIndex = 29;
            this.lblPuesto.Text = "Puesto:";
            // 
            // txtNroCamiseta
            // 
            this.txtNroCamiseta.Location = new System.Drawing.Point(424, 89);
            this.txtNroCamiseta.Name = "txtNroCamiseta";
            this.txtNroCamiseta.Size = new System.Drawing.Size(50, 20);
            this.txtNroCamiseta.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nro camiseta:";
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarJugador.Location = new System.Drawing.Point(790, 134);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(75, 50);
            this.btnAgregarJugador.TabIndex = 26;
            this.btnAgregarJugador.Text = "Agregar jugador";
            this.btnAgregarJugador.UseVisualStyleBackColor = true;
            this.btnAgregarJugador.Click += new System.EventHandler(this.btnAgregarJugador_Click);
            // 
            // txtClub
            // 
            this.txtClub.Enabled = false;
            this.txtClub.Location = new System.Drawing.Point(790, 41);
            this.txtClub.Name = "txtClub";
            this.txtClub.Size = new System.Drawing.Size(82, 20);
            this.txtClub.TabIndex = 25;
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.Enabled = false;
            this.txtNombreJugador.Location = new System.Drawing.Point(424, 41);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.Size = new System.Drawing.Size(100, 20);
            this.txtNombreJugador.TabIndex = 24;
            // 
            // lblNombreJugador
            // 
            this.lblNombreJugador.AutoSize = true;
            this.lblNombreJugador.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreJugador.Location = new System.Drawing.Point(349, 39);
            this.lblNombreJugador.Name = "lblNombreJugador";
            this.lblNombreJugador.Size = new System.Drawing.Size(69, 20);
            this.lblNombreJugador.TabIndex = 23;
            this.lblNombreJugador.Text = "Nombre:";
            // 
            // btnBuscarJugador
            // 
            this.btnBuscarJugador.Location = new System.Drawing.Point(240, 27);
            this.btnBuscarJugador.Name = "btnBuscarJugador";
            this.btnBuscarJugador.Size = new System.Drawing.Size(90, 39);
            this.btnBuscarJugador.TabIndex = 22;
            this.btnBuscarJugador.Text = "Buscar jugador";
            this.btnBuscarJugador.UseVisualStyleBackColor = true;
            this.btnBuscarJugador.Click += new System.EventHandler(this.btnBuscarJugador_Click);
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.BackColor = System.Drawing.Color.Transparent;
            this.lblClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClub.Location = new System.Drawing.Point(739, 41);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(45, 20);
            this.lblClub.TabIndex = 21;
            this.lblClub.Text = "Club:";
            // 
            // txtIdJugador
            // 
            this.txtIdJugador.Location = new System.Drawing.Point(121, 37);
            this.txtIdJugador.Name = "txtIdJugador";
            this.txtIdJugador.Size = new System.Drawing.Size(100, 20);
            this.txtIdJugador.TabIndex = 20;
            // 
            // lblIdJugador
            // 
            this.lblIdJugador.AutoSize = true;
            this.lblIdJugador.BackColor = System.Drawing.Color.Transparent;
            this.lblIdJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdJugador.Location = new System.Drawing.Point(6, 37);
            this.lblIdJugador.Name = "lblIdJugador";
            this.lblIdJugador.Size = new System.Drawing.Size(109, 20);
            this.lblIdJugador.TabIndex = 19;
            this.lblIdJugador.Text = "Id del jugador:";
            // 
            // grbArbitros
            // 
            this.grbArbitros.Controls.Add(this.grdArbitros);
            this.grbArbitros.Controls.Add(this.btnAgregarArbitro);
            this.grbArbitros.Controls.Add(this.cmbCargos);
            this.grbArbitros.Controls.Add(this.txtApellidoArbitro);
            this.grbArbitros.Controls.Add(this.txtNombreArbitro);
            this.grbArbitros.Controls.Add(this.lblCargo);
            this.grbArbitros.Controls.Add(this.lblApellidoArbitro);
            this.grbArbitros.Controls.Add(this.lblNombreArbitro);
            this.grbArbitros.Controls.Add(this.btnBuscarArbitro);
            this.grbArbitros.Controls.Add(this.txtIdArbitro);
            this.grbArbitros.Controls.Add(this.lblIdArbitro);
            this.grbArbitros.Location = new System.Drawing.Point(12, 455);
            this.grbArbitros.Name = "grbArbitros";
            this.grbArbitros.Size = new System.Drawing.Size(905, 180);
            this.grbArbitros.TabIndex = 19;
            this.grbArbitros.TabStop = false;
            this.grbArbitros.Text = "Arbitros del partido";
            // 
            // grdArbitros
            // 
            this.grdArbitros.AllowUserToAddRows = false;
            this.grdArbitros.AllowUserToDeleteRows = false;
            this.grdArbitros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArbitros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArbitro,
            this.nombreArbitro,
            this.apellidoArbitro,
            this.cargo});
            this.grdArbitros.Location = new System.Drawing.Point(20, 86);
            this.grdArbitros.Name = "grdArbitros";
            this.grdArbitros.ReadOnly = true;
            this.grdArbitros.Size = new System.Drawing.Size(341, 78);
            this.grdArbitros.TabIndex = 35;
            // 
            // idArbitro
            // 
            this.idArbitro.HeaderText = "Id";
            this.idArbitro.Name = "idArbitro";
            this.idArbitro.ReadOnly = true;
            // 
            // nombreArbitro
            // 
            this.nombreArbitro.HeaderText = "Nombre";
            this.nombreArbitro.Name = "nombreArbitro";
            this.nombreArbitro.ReadOnly = true;
            this.nombreArbitro.Width = 75;
            // 
            // apellidoArbitro
            // 
            this.apellidoArbitro.HeaderText = "Apellido";
            this.apellidoArbitro.Name = "apellidoArbitro";
            this.apellidoArbitro.ReadOnly = true;
            this.apellidoArbitro.Width = 75;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 75;
            // 
            // btnAgregarArbitro
            // 
            this.btnAgregarArbitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArbitro.Location = new System.Drawing.Point(780, 77);
            this.btnAgregarArbitro.Name = "btnAgregarArbitro";
            this.btnAgregarArbitro.Size = new System.Drawing.Size(75, 48);
            this.btnAgregarArbitro.TabIndex = 34;
            this.btnAgregarArbitro.Text = "Agregar arbitro";
            this.btnAgregarArbitro.UseVisualStyleBackColor = true;
            this.btnAgregarArbitro.Click += new System.EventHandler(this.btnAgregarArbitro_Click);
            // 
            // cmbCargos
            // 
            this.cmbCargos.FormattingEnabled = true;
            this.cmbCargos.Location = new System.Drawing.Point(790, 37);
            this.cmbCargos.Name = "cmbCargos";
            this.cmbCargos.Size = new System.Drawing.Size(100, 21);
            this.cmbCargos.TabIndex = 34;
            // 
            // txtApellidoArbitro
            // 
            this.txtApellidoArbitro.Enabled = false;
            this.txtApellidoArbitro.Location = new System.Drawing.Point(619, 38);
            this.txtApellidoArbitro.Name = "txtApellidoArbitro";
            this.txtApellidoArbitro.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoArbitro.TabIndex = 34;
            // 
            // txtNombreArbitro
            // 
            this.txtNombreArbitro.Enabled = false;
            this.txtNombreArbitro.Location = new System.Drawing.Point(424, 38);
            this.txtNombreArbitro.Name = "txtNombreArbitro";
            this.txtNombreArbitro.Size = new System.Drawing.Size(100, 20);
            this.txtNombreArbitro.TabIndex = 34;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(728, 38);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(56, 20);
            this.lblCargo.TabIndex = 34;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblApellidoArbitro
            // 
            this.lblApellidoArbitro.AutoSize = true;
            this.lblApellidoArbitro.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoArbitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoArbitro.Location = new System.Drawing.Point(544, 38);
            this.lblApellidoArbitro.Name = "lblApellidoArbitro";
            this.lblApellidoArbitro.Size = new System.Drawing.Size(69, 20);
            this.lblApellidoArbitro.TabIndex = 34;
            this.lblApellidoArbitro.Text = "Apellido:";
            // 
            // lblNombreArbitro
            // 
            this.lblNombreArbitro.AutoSize = true;
            this.lblNombreArbitro.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreArbitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArbitro.Location = new System.Drawing.Point(349, 38);
            this.lblNombreArbitro.Name = "lblNombreArbitro";
            this.lblNombreArbitro.Size = new System.Drawing.Size(69, 20);
            this.lblNombreArbitro.TabIndex = 34;
            this.lblNombreArbitro.Text = "Nombre:";
            // 
            // btnBuscarArbitro
            // 
            this.btnBuscarArbitro.Location = new System.Drawing.Point(240, 30);
            this.btnBuscarArbitro.Name = "btnBuscarArbitro";
            this.btnBuscarArbitro.Size = new System.Drawing.Size(90, 39);
            this.btnBuscarArbitro.TabIndex = 34;
            this.btnBuscarArbitro.Text = "Buscar arbitro";
            this.btnBuscarArbitro.UseVisualStyleBackColor = true;
            this.btnBuscarArbitro.Click += new System.EventHandler(this.btnBuscarArbitro_Click);
            // 
            // txtIdArbitro
            // 
            this.txtIdArbitro.Location = new System.Drawing.Point(113, 38);
            this.txtIdArbitro.Name = "txtIdArbitro";
            this.txtIdArbitro.Size = new System.Drawing.Size(100, 20);
            this.txtIdArbitro.TabIndex = 34;
            // 
            // lblIdArbitro
            // 
            this.lblIdArbitro.AutoSize = true;
            this.lblIdArbitro.BackColor = System.Drawing.Color.Transparent;
            this.lblIdArbitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdArbitro.Location = new System.Drawing.Point(6, 38);
            this.lblIdArbitro.Name = "lblIdArbitro";
            this.lblIdArbitro.Size = new System.Drawing.Size(101, 20);
            this.lblIdArbitro.TabIndex = 34;
            this.lblIdArbitro.Text = "Id del arbitro:";
            // 
            // btnGuardarPartido
            // 
            this.btnGuardarPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPartido.Location = new System.Drawing.Point(776, 653);
            this.btnGuardarPartido.Name = "btnGuardarPartido";
            this.btnGuardarPartido.Size = new System.Drawing.Size(108, 48);
            this.btnGuardarPartido.TabIndex = 20;
            this.btnGuardarPartido.Text = "Guardar partido";
            this.btnGuardarPartido.UseVisualStyleBackColor = true;
            this.btnGuardarPartido.Click += new System.EventHandler(this.btnGuardarPartido_Click);
            // 
            // frmPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 714);
            this.Controls.Add(this.btnGuardarPartido);
            this.Controls.Add(this.grbArbitros);
            this.Controls.Add(this.grbJugadores);
            this.Controls.Add(this.cmbClubVisitante);
            this.Controls.Add(this.cmbNroCancha);
            this.Controls.Add(this.cmbClubLocal);
            this.Controls.Add(this.cmbCategorias);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblClubVisitante);
            this.Controls.Add(this.lblNroCancha);
            this.Controls.Add(this.lblClubLocal);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblPartidos);
            this.Name = "frmPartido";
            this.Text = "Partido";
            this.grbJugadores.ResumeLayout(false);
            this.grbJugadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdJugadores)).EndInit();
            this.grbArbitros.ResumeLayout(false);
            this.grbArbitros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArbitros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPartidos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblClubLocal;
        private System.Windows.Forms.Label lblNroCancha;
        private System.Windows.Forms.Label lblClubVisitante;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.ComboBox cmbClubLocal;
        private System.Windows.Forms.ComboBox cmbNroCancha;
        private System.Windows.Forms.ComboBox cmbClubVisitante;
        private System.Windows.Forms.GroupBox grbJugadores;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.TextBox txtIdJugador;
        private System.Windows.Forms.Label lblIdJugador;
        private System.Windows.Forms.TextBox txtClub;
        private System.Windows.Forms.TextBox txtNombreJugador;
        private System.Windows.Forms.Label lblNombreJugador;
        private System.Windows.Forms.Button btnBuscarJugador;
        private System.Windows.Forms.TextBox txtApellidoJugador;
        private System.Windows.Forms.Label lblApellidoJugador;
        private System.Windows.Forms.DataGridView grdJugadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn club;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn puesto;
        private System.Windows.Forms.ComboBox cmbPuestos;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.TextBox txtNroCamiseta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarJugador;
        private System.Windows.Forms.GroupBox grbArbitros;
        private System.Windows.Forms.DataGridView grdArbitros;
        private System.Windows.Forms.Button btnAgregarArbitro;
        private System.Windows.Forms.ComboBox cmbCargos;
        private System.Windows.Forms.TextBox txtApellidoArbitro;
        private System.Windows.Forms.TextBox txtNombreArbitro;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblApellidoArbitro;
        private System.Windows.Forms.Label lblNombreArbitro;
        private System.Windows.Forms.Button btnBuscarArbitro;
        private System.Windows.Forms.TextBox txtIdArbitro;
        private System.Windows.Forms.Label lblIdArbitro;
        private System.Windows.Forms.Button btnGuardarPartido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArbitro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreArbitro;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoArbitro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.ComboBox cmbTitular;
        private System.Windows.Forms.Label lblTitular;
    }
}