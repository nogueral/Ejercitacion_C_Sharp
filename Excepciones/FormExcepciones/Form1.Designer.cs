namespace FormExcepciones
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
            this.btnException = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnException
            // 
            this.btnException.Location = new System.Drawing.Point(278, 194);
            this.btnException.Name = "btnException";
            this.btnException.Size = new System.Drawing.Size(231, 52);
            this.btnException.TabIndex = 0;
            this.btnException.Text = "Excepcion";
            this.btnException.UseVisualStyleBackColor = true;
            this.btnException.Click += new System.EventHandler(this.btnException_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnException);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excepciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnException;
    }
}

