namespace Ej2
{
    partial class GenerarLiquidaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMes = new System.Windows.Forms.TextBox();
            this.btnGenerarLiquidaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(201, 57);
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(100, 20);
            this.tbAño.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número de Mes:";
            // 
            // tbMes
            // 
            this.tbMes.Location = new System.Drawing.Point(201, 113);
            this.tbMes.Name = "tbMes";
            this.tbMes.Size = new System.Drawing.Size(100, 20);
            this.tbMes.TabIndex = 4;
            // 
            // btnGenerarLiquidaciones
            // 
            this.btnGenerarLiquidaciones.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGenerarLiquidaciones.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarLiquidaciones.Location = new System.Drawing.Point(74, 165);
            this.btnGenerarLiquidaciones.Name = "btnGenerarLiquidaciones";
            this.btnGenerarLiquidaciones.Size = new System.Drawing.Size(260, 45);
            this.btnGenerarLiquidaciones.TabIndex = 5;
            this.btnGenerarLiquidaciones.Text = "Generar Liquidaciones";
            this.btnGenerarLiquidaciones.UseVisualStyleBackColor = true;
            // 
            // GenerarLiquidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 233);
            this.Controls.Add(this.btnGenerarLiquidaciones);
            this.Controls.Add(this.tbMes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAño);
            this.Controls.Add(this.label1);
            this.Name = "GenerarLiquidaciones";
            this.Text = "GenerarLiquidaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbMes;
        private System.Windows.Forms.Button btnGenerarLiquidaciones;
    }
}