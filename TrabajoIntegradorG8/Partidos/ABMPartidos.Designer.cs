
namespace TrabajoIntegradorG8.Partidos
{
    partial class ABMPartidos
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
            this.PARTIDOS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.MaskedTextBox();
            this.txtcod = new System.Windows.Forms.MaskedTextBox();
            this.txtclub = new System.Windows.Forms.MaskedTextBox();
            this.txtvisitante = new System.Windows.Forms.MaskedTextBox();
            this.txtcancha = new System.Windows.Forms.MaskedTextBox();
            this.txtlocal = new System.Windows.Forms.MaskedTextBox();
            this.Btnaceptar = new System.Windows.Forms.Button();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.Btnborrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCancha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVisitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PARTIDOS
            // 
            this.PARTIDOS.AutoSize = true;
            this.PARTIDOS.Font = new System.Drawing.Font("Stencil", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PARTIDOS.ForeColor = System.Drawing.Color.Black;
            this.PARTIDOS.Location = new System.Drawing.Point(384, 35);
            this.PARTIDOS.Name = "PARTIDOS";
            this.PARTIDOS.Size = new System.Drawing.Size(188, 40);
            this.PARTIDOS.TabIndex = 0;
            this.PARTIDOS.Text = "PARTIDOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id Club Visitante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nro de Cacha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id Club Local:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cod Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Id Club:";
            // 
            // txtfecha
            // 
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.Location = new System.Drawing.Point(170, 109);
            this.txtfecha.Mask = "00/00/0000";
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(120, 30);
            this.txtfecha.TabIndex = 7;
            this.txtfecha.ValidatingType = typeof(System.DateTime);
            // 
            // txtcod
            // 
            this.txtcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.Location = new System.Drawing.Point(170, 156);
            this.txtcod.Mask = "9999999999";
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(120, 30);
            this.txtcod.TabIndex = 8;
            this.txtcod.ValidatingType = typeof(int);
            // 
            // txtclub
            // 
            this.txtclub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclub.Location = new System.Drawing.Point(170, 346);
            this.txtclub.Mask = "9999999999";
            this.txtclub.Name = "txtclub";
            this.txtclub.Size = new System.Drawing.Size(120, 30);
            this.txtclub.TabIndex = 9;
            this.txtclub.ValidatingType = typeof(int);
            // 
            // txtvisitante
            // 
            this.txtvisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvisitante.Location = new System.Drawing.Point(170, 296);
            this.txtvisitante.Mask = "9999999999";
            this.txtvisitante.Name = "txtvisitante";
            this.txtvisitante.Size = new System.Drawing.Size(120, 30);
            this.txtvisitante.TabIndex = 10;
            this.txtvisitante.ValidatingType = typeof(int);
            // 
            // txtcancha
            // 
            this.txtcancha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcancha.Location = new System.Drawing.Point(170, 246);
            this.txtcancha.Mask = "9999999999";
            this.txtcancha.Name = "txtcancha";
            this.txtcancha.Size = new System.Drawing.Size(120, 30);
            this.txtcancha.TabIndex = 11;
            this.txtcancha.ValidatingType = typeof(int);
            // 
            // txtlocal
            // 
            this.txtlocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocal.Location = new System.Drawing.Point(170, 200);
            this.txtlocal.Mask = "9999999999";
            this.txtlocal.Name = "txtlocal";
            this.txtlocal.Size = new System.Drawing.Size(120, 30);
            this.txtlocal.TabIndex = 12;
            this.txtlocal.ValidatingType = typeof(int);
            // 
            // Btnaceptar
            // 
            this.Btnaceptar.Location = new System.Drawing.Point(13, 419);
            this.Btnaceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Btnaceptar.Name = "Btnaceptar";
            this.Btnaceptar.Size = new System.Drawing.Size(188, 68);
            this.Btnaceptar.TabIndex = 13;
            this.Btnaceptar.Text = "Guardar";
            this.Btnaceptar.UseVisualStyleBackColor = true;
            // 
            // Btnlimpiar
            // 
            this.Btnlimpiar.Location = new System.Drawing.Point(227, 419);
            this.Btnlimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.Btnlimpiar.Name = "Btnlimpiar";
            this.Btnlimpiar.Size = new System.Drawing.Size(188, 68);
            this.Btnlimpiar.TabIndex = 14;
            this.Btnlimpiar.Text = "Limpiar";
            this.Btnlimpiar.UseVisualStyleBackColor = true;
            this.Btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click);
            // 
            // Btnborrar
            // 
            this.Btnborrar.Location = new System.Drawing.Point(114, 521);
            this.Btnborrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btnborrar.Name = "Btnborrar";
            this.Btnborrar.Size = new System.Drawing.Size(188, 68);
            this.Btnborrar.TabIndex = 15;
            this.Btnborrar.Text = "Borrar";
            this.Btnborrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.CodCategoria,
            this.IDLocal,
            this.NroCancha,
            this.IdVisitante,
            this.IdClub});
            this.dataGridView1.Location = new System.Drawing.Point(460, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 280);
            this.dataGridView1.TabIndex = 16;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // CodCategoria
            // 
            this.CodCategoria.HeaderText = "CodCategoria";
            this.CodCategoria.MinimumWidth = 6;
            this.CodCategoria.Name = "CodCategoria";
            this.CodCategoria.Width = 125;
            // 
            // IDLocal
            // 
            this.IDLocal.HeaderText = "IdLocal";
            this.IDLocal.MinimumWidth = 6;
            this.IDLocal.Name = "IDLocal";
            this.IDLocal.Width = 125;
            // 
            // NroCancha
            // 
            this.NroCancha.HeaderText = "NroCancha";
            this.NroCancha.MinimumWidth = 6;
            this.NroCancha.Name = "NroCancha";
            this.NroCancha.Width = 125;
            // 
            // IdVisitante
            // 
            this.IdVisitante.HeaderText = "IdVisitante";
            this.IdVisitante.MinimumWidth = 6;
            this.IdVisitante.Name = "IdVisitante";
            this.IdVisitante.Width = 125;
            // 
            // IdClub
            // 
            this.IdClub.HeaderText = "IdClub";
            this.IdClub.MinimumWidth = 6;
            this.IdClub.Name = "IdClub";
            this.IdClub.Width = 125;
            // 
            // ABMPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 656);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btnborrar);
            this.Controls.Add(this.Btnlimpiar);
            this.Controls.Add(this.Btnaceptar);
            this.Controls.Add(this.txtlocal);
            this.Controls.Add(this.txtcancha);
            this.Controls.Add(this.txtvisitante);
            this.Controls.Add(this.txtclub);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PARTIDOS);
            this.Name = "ABMPartidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMPartidos";
            this.Load += new System.EventHandler(this.ABMPartidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PARTIDOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtfecha;
        private System.Windows.Forms.MaskedTextBox txtcod;
        private System.Windows.Forms.MaskedTextBox txtclub;
        private System.Windows.Forms.MaskedTextBox txtvisitante;
        private System.Windows.Forms.MaskedTextBox txtcancha;
        private System.Windows.Forms.MaskedTextBox txtlocal;
        public System.Windows.Forms.Button Btnaceptar;
        public System.Windows.Forms.Button Btnlimpiar;
        public System.Windows.Forms.Button Btnborrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCancha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVisitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClub;
    }
}