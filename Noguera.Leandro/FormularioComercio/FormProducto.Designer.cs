﻿namespace FormularioComercio
{
    partial class formProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProducto));
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCargarProducto = new System.Windows.Forms.Label();
            this.btnCargarProd = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(311, 72);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(334, 29);
            this.txtDescripcion.TabIndex = 0;
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(311, 122);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(334, 29);
            this.txtPrecio.TabIndex = 1;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(311, 178);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(334, 29);
            this.txtStock.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(121, 72);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(114, 25);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(121, 122);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(67, 25);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(121, 181);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(62, 25);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stock";
            // 
            // lblCargarProducto
            // 
            this.lblCargarProducto.AutoSize = true;
            this.lblCargarProducto.Location = new System.Drawing.Point(265, 20);
            this.lblCargarProducto.Name = "lblCargarProducto";
            this.lblCargarProducto.Size = new System.Drawing.Size(234, 25);
            this.lblCargarProducto.TabIndex = 6;
            this.lblCargarProducto.Text = "CARGA DE PRODUCTO";
            // 
            // btnCargarProd
            // 
            this.btnCargarProd.Location = new System.Drawing.Point(252, 305);
            this.btnCargarProd.Name = "btnCargarProd";
            this.btnCargarProd.Size = new System.Drawing.Size(109, 50);
            this.btnCargarProd.TabIndex = 7;
            this.btnCargarProd.Text = "Cargar ";
            this.btnCargarProd.UseVisualStyleBackColor = true;
            this.btnCargarProd.Click += new System.EventHandler(this.btnCargarProd_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(536, 305);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 50);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(252, 378);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(393, 50);
            this.btnStock.TabIndex = 9;
            this.btnStock.Text = "Mostrar stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(311, 239);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(334, 29);
            this.txtId.TabIndex = 10;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(126, 243);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 25);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "ID";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(390, 305);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 50);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // formProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargarProd);
            this.Controls.Add(this.lblCargarProducto);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCargarProducto;
        private System.Windows.Forms.Button btnCargarProd;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnLimpiar;
    }
}