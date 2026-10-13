namespace Unidad3_MessageBox
{
    partial class frmEjemploSwitch
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDiaDeLaSemana = new System.Windows.Forms.Button();
            this.txtDiaDeLaSemana = new System.Windows.Forms.TextBox();
            this.lblDiaDeLaSemana = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDiaDeLaSemana
            // 
            this.btnDiaDeLaSemana.Location = new System.Drawing.Point(272, 56);
            this.btnDiaDeLaSemana.Name = "btnDiaDeLaSemana";
            this.btnDiaDeLaSemana.Size = new System.Drawing.Size(75, 23);
            this.btnDiaDeLaSemana.TabIndex = 0;
            this.btnDiaDeLaSemana.Text = "Mostrar";
            this.btnDiaDeLaSemana.UseVisualStyleBackColor = true;
            this.btnDiaDeLaSemana.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDiaDeLaSemana
            // 
            this.txtDiaDeLaSemana.Location = new System.Drawing.Point(156, 58);
            this.txtDiaDeLaSemana.Name = "txtDiaDeLaSemana";
            this.txtDiaDeLaSemana.Size = new System.Drawing.Size(100, 20);
            this.txtDiaDeLaSemana.TabIndex = 1;
            // 
            // lblDiaDeLaSemana
            // 
            this.lblDiaDeLaSemana.AutoSize = true;
            this.lblDiaDeLaSemana.Location = new System.Drawing.Point(12, 61);
            this.lblDiaDeLaSemana.Name = "lblDiaDeLaSemana";
            this.lblDiaDeLaSemana.Size = new System.Drawing.Size(138, 13);
            this.lblDiaDeLaSemana.TabIndex = 2;
            this.lblDiaDeLaSemana.Text = "Ingrese el día de la semana";
            this.lblDiaDeLaSemana.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmEjemploSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 128);
            this.Controls.Add(this.lblDiaDeLaSemana);
            this.Controls.Add(this.txtDiaDeLaSemana);
            this.Controls.Add(this.btnDiaDeLaSemana);
            this.Name = "frmEjemploSwitch";
            this.Text = "Ejemplo Switch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiaDeLaSemana;
        private System.Windows.Forms.TextBox txtDiaDeLaSemana;
        private System.Windows.Forms.Label lblDiaDeLaSemana;
    }
}

