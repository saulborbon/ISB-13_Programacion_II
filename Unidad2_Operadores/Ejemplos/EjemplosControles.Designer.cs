namespace Unidad2_Operadores.Ejemplos
{
    partial class EjemplosControles
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(38, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 160);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(72, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 26);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "CONTROLES";
            // 
            // btnAzul
            // 
            this.btnAzul.Location = new System.Drawing.Point(119, 245);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(75, 23);
            this.btnAzul.TabIndex = 2;
            this.btnAzul.Text = "Azul";
            this.btnAzul.UseVisualStyleBackColor = true;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnRojo
            // 
            this.btnRojo.Location = new System.Drawing.Point(38, 245);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(75, 23);
            this.btnRojo.TabIndex = 3;
            this.btnRojo.Text = "Rojo";
            this.btnRojo.UseVisualStyleBackColor = true;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.Location = new System.Drawing.Point(200, 245);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(75, 23);
            this.btnVerde.TabIndex = 4;
            this.btnVerde.Text = "Verde";
            this.btnVerde.UseVisualStyleBackColor = true;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // EjemplosControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 293);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.listBox1);
            this.Name = "EjemplosControles";
            this.Text = "EjemplosControles";
            this.Load += new System.EventHandler(this.EjemplosControles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnVerde;
    }
}