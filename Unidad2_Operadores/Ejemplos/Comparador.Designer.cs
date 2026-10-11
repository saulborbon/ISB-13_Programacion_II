namespace Unidad2_Operadores.Ejemplos
{
    partial class Comparador
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
            this.lblNumeroUno = new System.Windows.Forms.Label();
            this.lblNumeroDos = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumeroUno
            // 
            this.lblNumeroUno.AutoSize = true;
            this.lblNumeroUno.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroUno.Location = new System.Drawing.Point(12, 64);
            this.lblNumeroUno.Name = "lblNumeroUno";
            this.lblNumeroUno.Size = new System.Drawing.Size(136, 13);
            this.lblNumeroUno.TabIndex = 0;
            this.lblNumeroUno.Text = "Ingresar Primer Número";
            this.lblNumeroUno.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumeroDos
            // 
            this.lblNumeroDos.AutoSize = true;
            this.lblNumeroDos.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDos.Location = new System.Drawing.Point(12, 116);
            this.lblNumeroDos.Name = "lblNumeroDos";
            this.lblNumeroDos.Size = new System.Drawing.Size(144, 13);
            this.lblNumeroDos.TabIndex = 1;
            this.lblNumeroDos.Text = "Ingresar Segundo Numero";
            this.lblNumeroDos.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(162, 61);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(162, 113);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnComparar
            // 
            this.btnComparar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.Location = new System.Drawing.Point(98, 165);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(75, 23);
            this.btnComparar.TabIndex = 4;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(45, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(181, 24);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "U-COMPARATOR";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Comparador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(278, 209);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNumeroDos);
            this.Controls.Add(this.lblNumeroUno);
            this.Name = "Comparador";
            this.Text = "Comparador";
            this.Load += new System.EventHandler(this.Comparador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroUno;
        private System.Windows.Forms.Label lblNumeroDos;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label lblTitulo;
    }
}