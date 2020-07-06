namespace sistemacompra.vista.frmNuevos
{
    partial class frmNuevoProvedor
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomProv = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtSwift = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Size = new System.Drawing.Size(331, 36);
            this.label1.Text = "NUEVO PROVEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "NOMBRE PROVIDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "COUNTRY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "SWIFT BANK";
            // 
            // txtNomProv
            // 
            this.txtNomProv.Location = new System.Drawing.Point(148, 129);
            this.txtNomProv.Name = "txtNomProv";
            this.txtNomProv.Size = new System.Drawing.Size(220, 20);
            this.txtNomProv.TabIndex = 29;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(148, 197);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(220, 20);
            this.txtCountry.TabIndex = 30;
            // 
            // txtSwift
            // 
            this.txtSwift.Location = new System.Drawing.Point(148, 270);
            this.txtSwift.Name = "txtSwift";
            this.txtSwift.Size = new System.Drawing.Size(220, 20);
            this.txtSwift.TabIndex = 31;
            // 
            // frmNuevoProvedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 475);
            this.Controls.Add(this.txtSwift);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtNomProv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmNuevoProvedor";
            this.Text = "frmNuevoProvedor";
            this.Load += new System.EventHandler(this.frmNuevoProvedor_Load);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtNomProv, 0);
            this.Controls.SetChildIndex(this.txtCountry, 0);
            this.Controls.SetChildIndex(this.txtSwift, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomProv;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtSwift;
    }
}