namespace TrabajoIntegradorG8
{
    partial class ReporteListadoCanchas
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
            this.lblRepCanchas = new System.Windows.Forms.Label();
            this.maskedTextBoxFecha = new System.Windows.Forms.MaskedTextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnBuscarCancha = new System.Windows.Forms.Button();
            this.reportViewerCanchas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.checkBoxCanchaFecha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblRepCanchas
            // 
            this.lblRepCanchas.AutoSize = true;
            this.lblRepCanchas.BackColor = System.Drawing.Color.Transparent;
            this.lblRepCanchas.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepCanchas.Location = new System.Drawing.Point(228, 9);
            this.lblRepCanchas.Name = "lblRepCanchas";
            this.lblRepCanchas.Size = new System.Drawing.Size(351, 43);
            this.lblRepCanchas.TabIndex = 9;
            this.lblRepCanchas.Text = "REPORTES DE CANCHAS";
            // 
            // maskedTextBoxFecha
            // 
            this.maskedTextBoxFecha.Location = new System.Drawing.Point(518, 74);
            this.maskedTextBoxFecha.Mask = "00/00/0000";
            this.maskedTextBoxFecha.Name = "maskedTextBoxFecha";
            this.maskedTextBoxFecha.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxFecha.TabIndex = 20;
            this.maskedTextBoxFecha.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxFecha.Visible = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(457, 73);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 18);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.Visible = false;
            // 
            // btnBuscarCancha
            // 
            this.btnBuscarCancha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarCancha.Enabled = false;
            this.btnBuscarCancha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarCancha.Location = new System.Drawing.Point(680, 73);
            this.btnBuscarCancha.Name = "btnBuscarCancha";
            this.btnBuscarCancha.Size = new System.Drawing.Size(78, 26);
            this.btnBuscarCancha.TabIndex = 21;
            this.btnBuscarCancha.Text = "Buscar";
            this.btnBuscarCancha.UseVisualStyleBackColor = false;
            this.btnBuscarCancha.Click += new System.EventHandler(this.btnBuscarCancha_Click);
            // 
            // reportViewerCanchas
            // 
            this.reportViewerCanchas.Location = new System.Drawing.Point(12, 121);
            this.reportViewerCanchas.Name = "reportViewerCanchas";
            this.reportViewerCanchas.ServerReport.BearerToken = null;
            this.reportViewerCanchas.Size = new System.Drawing.Size(776, 317);
            this.reportViewerCanchas.TabIndex = 22;
            // 
            // checkBoxCanchaFecha
            // 
            this.checkBoxCanchaFecha.AutoSize = true;
            this.checkBoxCanchaFecha.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxCanchaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCanchaFecha.Location = new System.Drawing.Point(35, 71);
            this.checkBoxCanchaFecha.Name = "checkBoxCanchaFecha";
            this.checkBoxCanchaFecha.Size = new System.Drawing.Size(317, 22);
            this.checkBoxCanchaFecha.TabIndex = 23;
            this.checkBoxCanchaFecha.Text = "Canchas por fecha de último mantenimiento";
            this.checkBoxCanchaFecha.UseVisualStyleBackColor = false;
            this.checkBoxCanchaFecha.CheckedChanged += new System.EventHandler(this.checkBoxCanchaFecha_CheckedChanged);
            // 
            // ReporteListadoCanchas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = global::TrabajoIntegradorG8.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxCanchaFecha);
            this.Controls.Add(this.reportViewerCanchas);
            this.Controls.Add(this.btnBuscarCancha);
            this.Controls.Add(this.maskedTextBoxFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblRepCanchas);
            this.Name = "ReporteListadoCanchas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado De Canchas";
            this.Load += new System.EventHandler(this.ReporteListadoCanchas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepCanchas;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnBuscarCancha;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCanchas;
        private System.Windows.Forms.CheckBox checkBoxCanchaFecha;
    }
}