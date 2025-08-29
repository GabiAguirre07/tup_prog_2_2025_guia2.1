namespace Guia2._1
{
    partial class Form1
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
            this.tbRegistrar = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbListarRegistros = new System.Windows.Forms.TextBox();
            this.btnListarRegistros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRegistrar
            // 
            this.tbRegistrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegistrar.Location = new System.Drawing.Point(12, 29);
            this.tbRegistrar.Multiline = true;
            this.tbRegistrar.Name = "tbRegistrar";
            this.tbRegistrar.Size = new System.Drawing.Size(619, 189);
            this.tbRegistrar.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(637, 78);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(151, 80);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbListarRegistros
            // 
            this.tbListarRegistros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbListarRegistros.Location = new System.Drawing.Point(12, 241);
            this.tbListarRegistros.Multiline = true;
            this.tbListarRegistros.Name = "tbListarRegistros";
            this.tbListarRegistros.Size = new System.Drawing.Size(619, 197);
            this.tbListarRegistros.TabIndex = 2;
            // 
            // btnListarRegistros
            // 
            this.btnListarRegistros.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarRegistros.Location = new System.Drawing.Point(637, 286);
            this.btnListarRegistros.Name = "btnListarRegistros";
            this.btnListarRegistros.Size = new System.Drawing.Size(161, 79);
            this.btnListarRegistros.TabIndex = 3;
            this.btnListarRegistros.Text = "Listar Registros";
            this.btnListarRegistros.UseVisualStyleBackColor = true;
            this.btnListarRegistros.Click += new System.EventHandler(this.btnListarRegistros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarRegistros);
            this.Controls.Add(this.tbListarRegistros);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbRegistrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRegistrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbListarRegistros;
        private System.Windows.Forms.Button btnListarRegistros;
    }
}

