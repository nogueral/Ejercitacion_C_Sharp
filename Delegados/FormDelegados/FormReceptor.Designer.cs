namespace FormDelegados
{
    partial class FormReceptor
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
            this.txtmensajeRecibido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtmensajeRecibido
            // 
            this.txtmensajeRecibido.Location = new System.Drawing.Point(168, 97);
            this.txtmensajeRecibido.Multiline = true;
            this.txtmensajeRecibido.Name = "txtmensajeRecibido";
            this.txtmensajeRecibido.Size = new System.Drawing.Size(452, 80);
            this.txtmensajeRecibido.TabIndex = 1;
            // 
            // FormReceptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtmensajeRecibido);
            this.Name = "FormReceptor";
            this.Text = "FormReceptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmensajeRecibido;
    }
}