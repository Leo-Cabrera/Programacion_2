namespace Práctica_1_Ejercicio_5
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
            this.texto1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bb = new System.Windows.Forms.Label();
            this.numeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // texto1
            // 
            this.texto1.AutoSize = true;
            this.texto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto1.Location = new System.Drawing.Point(50, 41);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(147, 17);
            this.texto1.TabIndex = 0;
            this.texto1.Text = "Cantidad de paquetes";
            this.texto1.Click += new System.EventHandler(this.texto1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Importe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bb
            // 
            this.bb.AutoSize = true;
            this.bb.Location = new System.Drawing.Point(167, 76);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(67, 13);
            this.bb.TabIndex = 3;
            this.bb.Text = "                    ";
            this.bb.Click += new System.EventHandler(this.bb_Click);
            // 
            // numeric
            // 
            this.numeric.Location = new System.Drawing.Point(242, 38);
            this.numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric.Name = "numeric";
            this.numeric.Size = new System.Drawing.Size(120, 20);
            this.numeric.TabIndex = 5;
            this.numeric.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 126);
            this.Controls.Add(this.numeric);
            this.Controls.Add(this.bb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bb;
        private System.Windows.Forms.NumericUpDown numeric;
    }
}

