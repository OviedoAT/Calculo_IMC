namespace Calculo_IMC
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
            this.lblMetros = new System.Windows.Forms.Label();
            this.TxtBxEstatura = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.TxtBxPeso = new System.Windows.Forms.TextBox();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.TxtBxSancada = new System.Windows.Forms.TextBox();
            this.lblPasos = new System.Windows.Forms.Label();
            this.TxtBxPasos = new System.Windows.Forms.TextBox();
            this.Mostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Location = new System.Drawing.Point(115, 75);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(149, 13);
            this.lblMetros.TabIndex = 0;
            this.lblMetros.Text = "Ingrese su estatura en metros:";
            // 
            // TxtBxEstatura
            // 
            this.TxtBxEstatura.Location = new System.Drawing.Point(118, 91);
            this.TxtBxEstatura.Name = "TxtBxEstatura";
            this.TxtBxEstatura.Size = new System.Drawing.Size(178, 20);
            this.TxtBxEstatura.TabIndex = 1;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(115, 141);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(154, 13);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Ingrese su peso en Kilogramos:";
            // 
            // TxtBxPeso
            // 
            this.TxtBxPeso.Location = new System.Drawing.Point(118, 157);
            this.TxtBxPeso.Name = "TxtBxPeso";
            this.TxtBxPeso.Size = new System.Drawing.Size(178, 20);
            this.TxtBxPeso.TabIndex = 3;
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(118, 210);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(223, 13);
            this.lblDistancia.TabIndex = 4;
            this.lblDistancia.Text = "Ingrese la distancia de su sancada en metros:";
            // 
            // TxtBxSancada
            // 
            this.TxtBxSancada.Location = new System.Drawing.Point(118, 226);
            this.TxtBxSancada.Name = "TxtBxSancada";
            this.TxtBxSancada.Size = new System.Drawing.Size(178, 20);
            this.TxtBxSancada.TabIndex = 5;
            // 
            // lblPasos
            // 
            this.lblPasos.AutoSize = true;
            this.lblPasos.Location = new System.Drawing.Point(118, 276);
            this.lblPasos.Name = "lblPasos";
            this.lblPasos.Size = new System.Drawing.Size(178, 13);
            this.lblPasos.TabIndex = 6;
            this.lblPasos.Text = "Ingrese la cantidad de pasos actual:";
            // 
            // TxtBxPasos
            // 
            this.TxtBxPasos.Location = new System.Drawing.Point(118, 292);
            this.TxtBxPasos.Name = "TxtBxPasos";
            this.TxtBxPasos.Size = new System.Drawing.Size(178, 20);
            this.TxtBxPasos.TabIndex = 7;
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(164, 354);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(80, 27);
            this.Mostrar.TabIndex = 8;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 437);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.TxtBxPasos);
            this.Controls.Add(this.lblPasos);
            this.Controls.Add(this.TxtBxSancada);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.TxtBxPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.TxtBxEstatura);
            this.Controls.Add(this.lblMetros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.TextBox TxtBxEstatura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox TxtBxPeso;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.TextBox TxtBxSancada;
        private System.Windows.Forms.Label lblPasos;
        private System.Windows.Forms.TextBox TxtBxPasos;
        private System.Windows.Forms.Button Mostrar;
    }
}

