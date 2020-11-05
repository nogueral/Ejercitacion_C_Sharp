namespace ClaseGenerica
{
    partial class Form2
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
            this.dgvPpal = new System.Windows.Forms.DataGridView();
            this.cmbPpal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPpal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPpal
            // 
            this.dgvPpal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPpal.Location = new System.Drawing.Point(30, 108);
            this.dgvPpal.Name = "dgvPpal";
            this.dgvPpal.RowHeadersWidth = 72;
            this.dgvPpal.RowTemplate.Height = 31;
            this.dgvPpal.Size = new System.Drawing.Size(927, 288);
            this.dgvPpal.TabIndex = 9;
            // 
            // cmbPpal
            // 
            this.cmbPpal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPpal.FormattingEnabled = true;
            this.cmbPpal.Items.AddRange(new object[] {
            "Productos",
            "Clientes",
            "Empleados"});
            this.cmbPpal.Location = new System.Drawing.Point(701, 37);
            this.cmbPpal.Name = "cmbPpal";
            this.cmbPpal.Size = new System.Drawing.Size(256, 32);
            this.cmbPpal.TabIndex = 10;
            this.cmbPpal.SelectedIndexChanged += new System.EventHandler(this.cmbPpal_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 450);
            this.Controls.Add(this.cmbPpal);
            this.Controls.Add(this.dgvPpal);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPpal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPpal;
        private System.Windows.Forms.ComboBox cmbPpal;
    }
}