namespace Ejercicio08
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bSorteo = new System.Windows.Forms.Button();
            this.bJugar = new System.Windows.Forms.Button();
            this.bResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSorteo
            // 
            this.bSorteo.Location = new System.Drawing.Point(-1, 117);
            this.bSorteo.Name = "bSorteo";
            this.bSorteo.Size = new System.Drawing.Size(178, 107);
            this.bSorteo.TabIndex = 0;
            this.bSorteo.Text = "Realizar Sorteo";
            this.bSorteo.UseVisualStyleBackColor = true;
            this.bSorteo.Click += new System.EventHandler(this.bSorteo_Click);
            // 
            // bJugar
            // 
            this.bJugar.Location = new System.Drawing.Point(144, 99);
            this.bJugar.Name = "bJugar";
            this.bJugar.Size = new System.Drawing.Size(177, 43);
            this.bJugar.TabIndex = 1;
            this.bJugar.Text = "Introducir números a jugar";
            this.bJugar.UseVisualStyleBackColor = true;
            this.bJugar.Click += new System.EventHandler(this.bJugar_Click);
            // 
            // bResultado
            // 
            this.bResultado.Location = new System.Drawing.Point(132, 179);
            this.bResultado.Name = "bResultado";
            this.bResultado.Size = new System.Drawing.Size(198, 118);
            this.bResultado.TabIndex = 2;
            this.bResultado.Text = "Resultado";
            this.bResultado.UseVisualStyleBackColor = true;
            this.bResultado.Click += new System.EventHandler(this.bResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 298);
            this.Controls.Add(this.bResultado);
            this.Controls.Add(this.bJugar);
            this.Controls.Add(this.bSorteo);
            this.Name = "Form1";
            this.Text = "Ejercicio 8. Pablo de Madaria Pascual. DAW-Z";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSorteo;
        private System.Windows.Forms.Button bJugar;
        private System.Windows.Forms.Button bResultado;
    }
}

