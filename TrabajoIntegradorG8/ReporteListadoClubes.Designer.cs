﻿namespace TrabajoIntegradorG8
{
    partial class ReporteListadoClubes
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
            this.lblRepPartidos = new System.Windows.Forms.Label();
            this.rdbtnBarrio = new System.Windows.Forms.RadioButton();
            this.rdbtnAntiguedad = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.cmbBarrios = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // lblRepPartidos
            // 
            this.lblRepPartidos.AutoSize = true;
            this.lblRepPartidos.BackColor = System.Drawing.Color.Transparent;
            this.lblRepPartidos.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepPartidos.Location = new System.Drawing.Point(221, 23);
            this.lblRepPartidos.Name = "lblRepPartidos";
            this.lblRepPartidos.Size = new System.Drawing.Size(325, 43);
            this.lblRepPartidos.TabIndex = 10;
            this.lblRepPartidos.Text = "REPORTES DE CLUBES";
            // 
            // rdbtnBarrio
            // 
            this.rdbtnBarrio.AutoSize = true;
            this.rdbtnBarrio.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnBarrio.Location = new System.Drawing.Point(44, 115);
            this.rdbtnBarrio.Name = "rdbtnBarrio";
            this.rdbtnBarrio.Size = new System.Drawing.Size(169, 22);
            this.rdbtnBarrio.TabIndex = 12;
            this.rdbtnBarrio.TabStop = true;
            this.rdbtnBarrio.Text = "Restringido por barrio";
            this.rdbtnBarrio.UseVisualStyleBackColor = false;
            this.rdbtnBarrio.CheckedChanged += new System.EventHandler(this.rdbtnBarrio_CheckedChanged);
            // 
            // rdbtnAntiguedad
            // 
            this.rdbtnAntiguedad.AutoSize = true;
            this.rdbtnAntiguedad.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnAntiguedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnAntiguedad.Location = new System.Drawing.Point(44, 87);
            this.rdbtnAntiguedad.Name = "rdbtnAntiguedad";
            this.rdbtnAntiguedad.Size = new System.Drawing.Size(202, 22);
            this.rdbtnAntiguedad.TabIndex = 11;
            this.rdbtnAntiguedad.TabStop = true;
            this.rdbtnAntiguedad.Text = "Restringido por antigüedad";
            this.rdbtnAntiguedad.UseVisualStyleBackColor = false;
            this.rdbtnAntiguedad.CheckedChanged += new System.EventHandler(this.rdbtnAntiguedad_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Location = new System.Drawing.Point(569, 112);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 31);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.BackColor = System.Drawing.Color.Transparent;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(326, 118);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(60, 18);
            this.lblBarrio.TabIndex = 14;
            this.lblBarrio.Text = "Barrios:";
            // 
            // cmbBarrios
            // 
            this.cmbBarrios.Enabled = false;
            this.cmbBarrios.FormattingEnabled = true;
            this.cmbBarrios.Location = new System.Drawing.Point(416, 117);
            this.cmbBarrios.Name = "cmbBarrios";
            this.cmbBarrios.Size = new System.Drawing.Size(130, 21);
            this.cmbBarrios.TabIndex = 13;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoIntegradorG8.ReportListadoClubes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 170);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 268);
            this.reportViewer1.TabIndex = 16;
            // 
            // ReporteListadoClubes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoIntegradorG8.Properties.Resources.fondo___copia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.cmbBarrios);
            this.Controls.Add(this.rdbtnBarrio);
            this.Controls.Add(this.rdbtnAntiguedad);
            this.Controls.Add(this.lblRepPartidos);
            this.Name = "ReporteListadoClubes";
            this.Text = "ReporteListadoClubes";
            this.Load += new System.EventHandler(this.ReporteListadoClubes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepPartidos;
        private System.Windows.Forms.RadioButton rdbtnBarrio;
        private System.Windows.Forms.RadioButton rdbtnAntiguedad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.ComboBox cmbBarrios;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}