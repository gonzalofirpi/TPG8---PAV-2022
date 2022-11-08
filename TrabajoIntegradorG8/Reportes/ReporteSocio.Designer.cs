
namespace TrabajoIntegradorG8.Reportes
{
    partial class ReporteSocio
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
            this.lblsocios = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.rv1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtYear2 = new System.Windows.Forms.MaskedTextBox();
            this.txtYear1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtletra = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbu03 = new System.Windows.Forms.RadioButton();
            this.rbu02 = new System.Windows.Forms.RadioButton();
            this.rbu01 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rv2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsocios
            // 
            this.lblsocios.AutoSize = true;
            this.lblsocios.BackColor = System.Drawing.Color.Transparent;
            this.lblsocios.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsocios.Location = new System.Drawing.Point(291, 36);
            this.lblsocios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsocios.Name = "lblsocios";
            this.lblsocios.Size = new System.Drawing.Size(402, 54);
            this.lblsocios.TabIndex = 13;
            this.lblsocios.Text = "REPORTES DE SOCIOS";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.rv1);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.txtYear2);
            this.tabPage1.Controls.Add(this.txtYear1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(969, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Por Fecha Alta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingrese los años para iniciar la consulta: ";
            // 
            // rv1
            // 
            this.rv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv1.BackColor = System.Drawing.Color.LightGray;
            this.rv1.Location = new System.Drawing.Point(6, 128);
            this.rv1.Name = "rv1";
            this.rv1.ServerReport.BearerToken = null;
            this.rv1.Size = new System.Drawing.Size(953, 323);
            this.rv1.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(693, 64);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 38);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtYear2
            // 
            this.txtYear2.BackColor = System.Drawing.SystemColors.Window;
            this.txtYear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtYear2.Location = new System.Drawing.Point(578, 70);
            this.txtYear2.Mask = "9999";
            this.txtYear2.Name = "txtYear2";
            this.txtYear2.Size = new System.Drawing.Size(64, 27);
            this.txtYear2.TabIndex = 5;
            // 
            // txtYear1
            // 
            this.txtYear1.BackColor = System.Drawing.SystemColors.Window;
            this.txtYear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtYear1.Location = new System.Drawing.Point(386, 70);
            this.txtYear1.Mask = "9999";
            this.txtYear1.Name = "txtYear1";
            this.txtYear1.Size = new System.Drawing.Size(64, 27);
            this.txtYear1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año Hasta: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año Desde: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(977, 534);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtletra);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.rv2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(969, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Por Apellido ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtletra
            // 
            this.txtletra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletra.Location = new System.Drawing.Point(467, 54);
            this.txtletra.Mask = "L";
            this.txtletra.Name = "txtletra";
            this.txtletra.Size = new System.Drawing.Size(60, 30);
            this.txtletra.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Letra: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbu03);
            this.groupBox1.Controls.Add(this.rbu02);
            this.groupBox1.Controls.Add(this.rbu01);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(369, 109);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Cálculo";
            // 
            // rbu03
            // 
            this.rbu03.AutoSize = true;
            this.rbu03.Location = new System.Drawing.Point(25, 71);
            this.rbu03.Margin = new System.Windows.Forms.Padding(4);
            this.rbu03.Name = "rbu03";
            this.rbu03.Size = new System.Drawing.Size(198, 29);
            this.rbu03.TabIndex = 2;
            this.rbu03.TabStop = true;
            this.rbu03.Text = "Todos los usuarios";
            this.rbu03.UseVisualStyleBackColor = true;
            // 
            // rbu02
            // 
            this.rbu02.AutoSize = true;
            this.rbu02.Location = new System.Drawing.Point(25, 47);
            this.rbu02.Margin = new System.Windows.Forms.Padding(4);
            this.rbu02.Name = "rbu02";
            this.rbu02.Size = new System.Drawing.Size(219, 29);
            this.rbu02.TabIndex = 1;
            this.rbu02.TabStop = true;
            this.rbu02.Text = "Que contenga la letra";
            this.rbu02.UseVisualStyleBackColor = true;
            // 
            // rbu01
            // 
            this.rbu01.AutoSize = true;
            this.rbu01.Location = new System.Drawing.Point(25, 23);
            this.rbu01.Margin = new System.Windows.Forms.Padding(4);
            this.rbu01.Name = "rbu01";
            this.rbu01.Size = new System.Drawing.Size(311, 29);
            this.rbu01.TabIndex = 0;
            this.rbu01.TabStop = true;
            this.rbu01.Text = "Que el apellido inicie con la letra";
            this.rbu01.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(803, 83);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Listado de Socios ";
            // 
            // rv2
            // 
            this.rv2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv2.BackColor = System.Drawing.Color.LightGray;
            this.rv2.Location = new System.Drawing.Point(17, 202);
            this.rv2.Name = "rv2";
            this.rv2.ServerReport.BearerToken = null;
            this.rv2.Size = new System.Drawing.Size(934, 291);
            this.rv2.TabIndex = 0;
            // 
            // ReporteSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 659);
            this.Controls.Add(this.lblsocios);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReporteSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.ReporteSocio_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsocios;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private Microsoft.Reporting.WinForms.ReportViewer rv1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.MaskedTextBox txtYear1;
        public System.Windows.Forms.MaskedTextBox txtYear2;
        private Microsoft.Reporting.WinForms.ReportViewer rv2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtletra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbu03;
        private System.Windows.Forms.RadioButton rbu02;
        private System.Windows.Forms.RadioButton rbu01;
    }
}