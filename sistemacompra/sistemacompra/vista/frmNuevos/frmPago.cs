using sistemacompra.vista.frmNuevos;
using sistemacompra.vista.frmPadres;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemacompra.vista.frmNuevos
{
    public partial class frmPago : frmTitulo
    {
        private Bunifu.Framework.UI.BunifuDatepicker datePay;
        private Label label3;
        private Label label4;
        private Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeletePay;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtboxPay;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtboxBank;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditPay;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddPay;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtboxIDBuy;
        private Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBoxIDPay;
        private Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 btnVerRegistros;
        private DataGridView gvPayDetail;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBuscar;
        private Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtboxSearch;
        SqlConnection conexion = new SqlConnection("server=DAMAGED\\SQLEXPRESS;database=PURCHASES; integrated security=true ");
        public frmPago()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPago));
            this.datePay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddPay = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeletePay = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtboxPay = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtboxBank = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnEditPay = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtboxIDBuy = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxIDPay = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVerRegistros = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gvPayDetail = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.gvPayDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(242, 18);
            this.label1.Size = new System.Drawing.Size(112, 36);
            this.label1.Text = "PAGO";
            // 
            // datePay
            // 
            this.datePay.BackColor = System.Drawing.Color.SeaGreen;
            this.datePay.BorderRadius = 0;
            this.datePay.ForeColor = System.Drawing.Color.White;
            this.datePay.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datePay.FormatCustom = null;
            this.datePay.Location = new System.Drawing.Point(140, 325);
            this.datePay.Name = "datePay";
            this.datePay.Size = new System.Drawing.Size(250, 36);
            this.datePay.TabIndex = 17;
            this.datePay.Value = new System.DateTime(2020, 7, 4, 10, 56, 28, 132);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Coolvetica Rg", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(25, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pago";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Coolvetica Rg", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(25, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Banco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Coolvetica Rg", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(25, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha";
            // 
            // btnAddPay
            // 
            this.btnAddPay.ActiveBorderThickness = 1;
            this.btnAddPay.ActiveCornerRadius = 20;
            this.btnAddPay.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddPay.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddPay.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddPay.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPay.BackgroundImage")));
            this.btnAddPay.ButtonText = "Agregar";
            this.btnAddPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPay.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddPay.IdleBorderThickness = 1;
            this.btnAddPay.IdleCornerRadius = 20;
            this.btnAddPay.IdleFillColor = System.Drawing.Color.White;
            this.btnAddPay.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAddPay.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddPay.Location = new System.Drawing.Point(17, 427);
            this.btnAddPay.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddPay.Name = "btnAddPay";
            this.btnAddPay.Size = new System.Drawing.Size(106, 41);
            this.btnAddPay.TabIndex = 22;
            this.btnAddPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddPay.Click += new System.EventHandler(this.btnAceptarPago_Click);
            // 
            // btnDeletePay
            // 
            this.btnDeletePay.ActiveBorderThickness = 1;
            this.btnDeletePay.ActiveCornerRadius = 20;
            this.btnDeletePay.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDeletePay.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeletePay.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDeletePay.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeletePay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeletePay.BackgroundImage")));
            this.btnDeletePay.ButtonText = "Eliminar";
            this.btnDeletePay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePay.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDeletePay.IdleBorderThickness = 1;
            this.btnDeletePay.IdleCornerRadius = 20;
            this.btnDeletePay.IdleFillColor = System.Drawing.Color.White;
            this.btnDeletePay.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDeletePay.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDeletePay.Location = new System.Drawing.Point(580, 427);
            this.btnDeletePay.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeletePay.Name = "btnDeletePay";
            this.btnDeletePay.Size = new System.Drawing.Size(106, 41);
            this.btnDeletePay.TabIndex = 24;
            this.btnDeletePay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletePay.Click += new System.EventHandler(this.btnDeletePay_Click);
            // 
            // txtboxPay
            // 
            this.txtboxPay.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtboxPay.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxPay.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtboxPay.BorderThickness = 3;
            this.txtboxPay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxPay.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtboxPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxPay.isPassword = false;
            this.txtboxPay.Location = new System.Drawing.Point(140, 206);
            this.txtboxPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxPay.Name = "txtboxPay";
            this.txtboxPay.Size = new System.Drawing.Size(250, 36);
            this.txtboxPay.TabIndex = 25;
            this.txtboxPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtboxBank
            // 
            this.txtboxBank.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtboxBank.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxBank.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtboxBank.BorderThickness = 3;
            this.txtboxBank.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxBank.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtboxBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxBank.isPassword = false;
            this.txtboxBank.Location = new System.Drawing.Point(140, 270);
            this.txtboxBank.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxBank.Name = "txtboxBank";
            this.txtboxBank.Size = new System.Drawing.Size(250, 36);
            this.txtboxBank.TabIndex = 26;
            this.txtboxBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnEditPay
            // 
            this.btnEditPay.ActiveBorderThickness = 1;
            this.btnEditPay.ActiveCornerRadius = 20;
            this.btnEditPay.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEditPay.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditPay.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEditPay.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditPay.BackgroundImage")));
            this.btnEditPay.ButtonText = "Modificar";
            this.btnEditPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPay.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEditPay.IdleBorderThickness = 1;
            this.btnEditPay.IdleCornerRadius = 20;
            this.btnEditPay.IdleFillColor = System.Drawing.Color.White;
            this.btnEditPay.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEditPay.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEditPay.Location = new System.Drawing.Point(464, 427);
            this.btnEditPay.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditPay.Name = "btnEditPay";
            this.btnEditPay.Size = new System.Drawing.Size(106, 41);
            this.btnEditPay.TabIndex = 27;
            this.btnEditPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditPay.Click += new System.EventHandler(this.btnEditPay_Click);
            // 
            // txtboxIDBuy
            // 
            this.txtboxIDBuy.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtboxIDBuy.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxIDBuy.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtboxIDBuy.BorderThickness = 3;
            this.txtboxIDBuy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxIDBuy.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtboxIDBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxIDBuy.isPassword = false;
            this.txtboxIDBuy.Location = new System.Drawing.Point(140, 149);
            this.txtboxIDBuy.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxIDBuy.Name = "txtboxIDBuy";
            this.txtboxIDBuy.Size = new System.Drawing.Size(250, 36);
            this.txtboxIDBuy.TabIndex = 29;
            this.txtboxIDBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Coolvetica Rg", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(25, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID Compra";
            // 
            // txtBoxIDPay
            // 
            this.txtBoxIDPay.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtBoxIDPay.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxIDPay.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtBoxIDPay.BorderThickness = 3;
            this.txtBoxIDPay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxIDPay.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxIDPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxIDPay.isPassword = false;
            this.txtBoxIDPay.Location = new System.Drawing.Point(140, 90);
            this.txtBoxIDPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxIDPay.Name = "txtBoxIDPay";
            this.txtBoxIDPay.Size = new System.Drawing.Size(250, 36);
            this.txtBoxIDPay.TabIndex = 31;
            this.txtBoxIDPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Coolvetica Rg", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(25, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "ID Pago";
            // 
            // btnVerRegistros
            // 
            this.btnVerRegistros.ActiveBorderThickness = 1;
            this.btnVerRegistros.ActiveCornerRadius = 20;
            this.btnVerRegistros.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnVerRegistros.ActiveForecolor = System.Drawing.Color.White;
            this.btnVerRegistros.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnVerRegistros.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerRegistros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerRegistros.BackgroundImage")));
            this.btnVerRegistros.ButtonText = "Ver Registros";
            this.btnVerRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerRegistros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerRegistros.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnVerRegistros.IdleBorderThickness = 1;
            this.btnVerRegistros.IdleCornerRadius = 20;
            this.btnVerRegistros.IdleFillColor = System.Drawing.Color.White;
            this.btnVerRegistros.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnVerRegistros.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnVerRegistros.Location = new System.Drawing.Point(140, 427);
            this.btnVerRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerRegistros.Name = "btnVerRegistros";
            this.btnVerRegistros.Size = new System.Drawing.Size(122, 41);
            this.btnVerRegistros.TabIndex = 32;
            this.btnVerRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVerRegistros.Click += new System.EventHandler(this.btnVerRegistros_Click);
            // 
            // gvPayDetail
            // 
            this.gvPayDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPayDetail.Location = new System.Drawing.Point(397, 90);
            this.gvPayDetail.Name = "gvPayDetail";
            this.gvPayDetail.Size = new System.Drawing.Size(434, 271);
            this.gvPayDetail.TabIndex = 33;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ActiveBorderThickness = 1;
            this.btnBuscar.ActiveCornerRadius = 20;
            this.btnBuscar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.ActiveForecolor = System.Drawing.Color.White;
            this.btnBuscar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.ButtonText = "Buscar";
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.IdleBorderThickness = 1;
            this.btnBuscar.IdleCornerRadius = 20;
            this.btnBuscar.IdleFillColor = System.Drawing.Color.White;
            this.btnBuscar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.Location = new System.Drawing.Point(695, 428);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 41);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Coolvetica Rg", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(472, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 29);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ingrese id del pago";
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtboxSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxSearch.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtboxSearch.BorderThickness = 3;
            this.txtboxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtboxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxSearch.isPassword = false;
            this.txtboxSearch.Location = new System.Drawing.Point(695, 392);
            this.txtboxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(107, 29);
            this.txtboxSearch.TabIndex = 37;
            this.txtboxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(843, 482);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gvPayDetail);
            this.Controls.Add(this.btnVerRegistros);
            this.Controls.Add(this.txtBoxIDPay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtboxIDBuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditPay);
            this.Controls.Add(this.txtboxBank);
            this.Controls.Add(this.txtboxPay);
            this.Controls.Add(this.btnDeletePay);
            this.Controls.Add(this.btnAddPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datePay);
            this.Name = "frmPago";
            this.Load += new System.EventHandler(this.frmPago_Load);
            this.Controls.SetChildIndex(this.datePay, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnAddPay, 0);
            this.Controls.SetChildIndex(this.btnDeletePay, 0);
            this.Controls.SetChildIndex(this.txtboxPay, 0);
            this.Controls.SetChildIndex(this.txtboxBank, 0);
            this.Controls.SetChildIndex(this.btnEditPay, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtboxIDBuy, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtBoxIDPay, 0);
            this.Controls.SetChildIndex(this.btnVerRegistros, 0);
            this.Controls.SetChildIndex(this.gvPayDetail, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtboxSearch, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvPayDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmPago_Load(object sender, EventArgs e)
        {

        }

        private void txtboxBuyIdBuy_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptarPago_Click(object sender, EventArgs e)
        {
             //DateTime fecha = datePay.Value;
             //DateTime Fecha = Convert.ToDateTime(datePay.Value);
             //string fe=Fecha.ToString("yyyy-MM-dd");
             //MessageBox.Show(fe);
            String query= "insert into paydetail(id_pd,date_pd, pay_pd, bank_pd,Buy_id_buy) values(@IDPago,@Fecha, @Pago, @Banco,@IDCompra)";
            conexion.Open();
            

            SqlCommand comando = new SqlCommand(query, conexion);
            //comando.Parameters.AddWithValue("@idPago",1);
            comando.Parameters.AddWithValue("@Pago", txtboxPay.Text);
            comando.Parameters.AddWithValue("@Banco", txtboxBank.Text);
            comando.Parameters.AddWithValue("@Fecha",datePay.Value);
            comando.Parameters.AddWithValue("@IDCompra", txtboxIDBuy.Text);
            comando.Parameters.AddWithValue("@IDPago", txtBoxIDPay.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Datos insertados Correctamente", "Mensaje");
            conexion.Close();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEditPay_Click(object sender, EventArgs e)
        {


            conexion.Open();
            String idbuscar = txtboxSearch.Text;
            String query = "update paydetail set  id_pd=@IDPago,date_pd=@Fecha, pay_pd=@Pago, bank_pd=@Banco," +
                "Buy_id_buy=@IDCompra where id_pd=@Buscarid";
            SqlCommand comando = new SqlCommand(query, conexion);

            comando.Parameters.AddWithValue("@Pago", txtboxPay.Text);
            comando.Parameters.AddWithValue("@Banco", txtboxBank.Text);
            comando.Parameters.AddWithValue("@Fecha", datePay.Value);
            comando.Parameters.AddWithValue("@IDCompra", txtboxIDBuy.Text);
            comando.Parameters.AddWithValue("@IDPago", txtBoxIDPay.Text);
            comando.Parameters.AddWithValue("@Buscarid", txtboxSearch.Text);
            MessageBox.Show("se agregan los parametros");
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        private void btnVerRegistros_Click(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand("Select * from paydetail", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gvPayDetail.DataSource = tabla;
            conexion.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            //string buscar = txtboxSearch.Text;

            SqlCommand comando = new SqlCommand("Select * from paydetail where id_pd=@Buscarid ", conexion);
            comando.Parameters.AddWithValue("@Buscarid", txtboxSearch.Text);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gvPayDetail.DataSource = tabla;
            conexion.Close();
        }

        private void btnDeletePay_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "DELETE FROM paydetail where id_pd=@BuscarID ";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@BuscarID", txtboxSearch.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Registro Eliminado");
            
        }

        private void txtboxSearch_OnTextChange(object sender, EventArgs e)
        {

        }
    }

 }
    