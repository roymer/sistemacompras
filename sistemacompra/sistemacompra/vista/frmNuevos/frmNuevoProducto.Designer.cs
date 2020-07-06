namespace sistemacompra.vista.frmNuevos
{
    partial class frmNuevoProducto
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombrePrd = new System.Windows.Forms.TextBox();
            this.txtDescPrd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.proveedores = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(56, 370);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(212, 370);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Size = new System.Drawing.Size(330, 36);
            this.label1.Text = "NUEVO PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "NOMBRE";
            // 
            // txtNombrePrd
            // 
            this.txtNombrePrd.Location = new System.Drawing.Point(141, 171);
            this.txtNombrePrd.Name = "txtNombrePrd";
            this.txtNombrePrd.Size = new System.Drawing.Size(196, 20);
            this.txtNombrePrd.TabIndex = 27;
            // 
            // txtDescPrd
            // 
            this.txtDescPrd.Location = new System.Drawing.Point(141, 208);
            this.txtDescPrd.Name = "txtDescPrd";
            this.txtDescPrd.Size = new System.Drawing.Size(196, 20);
            this.txtDescPrd.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "DESCRIPCION";
            // 
            // proveedores
            // 
            this.proveedores.FormattingEnabled = true;
            this.proveedores.Location = new System.Drawing.Point(141, 254);
            this.proveedores.Name = "proveedores";
            this.proveedores.Size = new System.Drawing.Size(121, 21);
            this.proveedores.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "PROVEEDOR";
            // 
            // frmNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 475);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.proveedores);
            this.Controls.Add(this.txtDescPrd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombrePrd);
            this.Controls.Add(this.label2);
            this.Name = "frmNuevoProducto";
            this.Text = "frmNuevoProducto";
            this.Load += new System.EventHandler(this.frmNuevoProducto_Load);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNombrePrd, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtDescPrd, 0);
            this.Controls.SetChildIndex(this.proveedores, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombrePrd;
        private System.Windows.Forms.TextBox txtDescPrd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox proveedores;
    }
}