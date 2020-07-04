namespace sistemacompra.vista.frmSecundarios
{
    partial class frmHistorialCompras
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label buy_db_IDLabel;
            System.Windows.Forms.Label product_id_prodLabel;
            System.Windows.Forms.Label id_prodLabel;
            System.Windows.Forms.Label name_prodLabel;
            System.Windows.Forms.Label description_prodLabel;
            System.Windows.Forms.Label provider_id_provLabel;
            System.Windows.Forms.Label total_buyLabel;
            this.purchasesDataSet = new sistemacompra.purchasesDataSet();
            this.buy_dbTableAdapter = new sistemacompra.purchasesDataSetTableAdapters.Buy_dbTableAdapter();
            this.tableAdapterManager = new sistemacompra.purchasesDataSetTableAdapters.TableAdapterManager();
            this.buyDetailTableAdapter = new sistemacompra.purchasesDataSetTableAdapters.BuyDetailTableAdapter();
            this.productTableAdapter = new sistemacompra.purchasesDataSetTableAdapters.ProductTableAdapter();
            this.buy_dbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buy_db_IDLabel1 = new System.Windows.Forms.Label();
            this.buyDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_id_prodLabel1 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_prodLabel1 = new System.Windows.Forms.Label();
            this.name_prodLabel1 = new System.Windows.Forms.Label();
            this.description_prodLabel1 = new System.Windows.Forms.Label();
            this.provider_id_provLabel1 = new System.Windows.Forms.Label();
            this.buy_dbDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_buyLabel1 = new System.Windows.Forms.Label();
            this.buyDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            buy_db_IDLabel = new System.Windows.Forms.Label();
            product_id_prodLabel = new System.Windows.Forms.Label();
            id_prodLabel = new System.Windows.Forms.Label();
            name_prodLabel = new System.Windows.Forms.Label();
            description_prodLabel = new System.Windows.Forms.Label();
            provider_id_provLabel = new System.Windows.Forms.Label();
            total_buyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_dbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_dbDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyDetailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.text = "";
            this.btnBuscar.OnTextChange += new System.EventHandler(this.btnBuscar_OnTextChange);
            // 
            // buy_db_IDLabel
            // 
            buy_db_IDLabel.AutoSize = true;
            buy_db_IDLabel.Location = new System.Drawing.Point(690, 146);
            buy_db_IDLabel.Name = "buy_db_IDLabel";
            buy_db_IDLabel.Size = new System.Drawing.Size(57, 13);
            buy_db_IDLabel.TabIndex = 25;
            buy_db_IDLabel.Text = "Buy db ID:";
            // 
            // product_id_prodLabel
            // 
            product_id_prodLabel.AutoSize = true;
            product_id_prodLabel.Location = new System.Drawing.Point(685, 242);
            product_id_prodLabel.Name = "product_id_prodLabel";
            product_id_prodLabel.Size = new System.Drawing.Size(82, 13);
            product_id_prodLabel.TabIndex = 26;
            product_id_prodLabel.Text = "Product id prod:";
            // 
            // id_prodLabel
            // 
            id_prodLabel.AutoSize = true;
            id_prodLabel.Location = new System.Drawing.Point(725, 334);
            id_prodLabel.Name = "id_prodLabel";
            id_prodLabel.Size = new System.Drawing.Size(42, 13);
            id_prodLabel.TabIndex = 28;
            id_prodLabel.Text = "id prod:";
            // 
            // name_prodLabel
            // 
            name_prodLabel.AutoSize = true;
            name_prodLabel.Location = new System.Drawing.Point(725, 366);
            name_prodLabel.Name = "name_prodLabel";
            name_prodLabel.Size = new System.Drawing.Size(60, 13);
            name_prodLabel.TabIndex = 29;
            name_prodLabel.Text = "name prod:";
            // 
            // description_prodLabel
            // 
            description_prodLabel.AutoSize = true;
            description_prodLabel.Location = new System.Drawing.Point(728, 402);
            description_prodLabel.Name = "description_prodLabel";
            description_prodLabel.Size = new System.Drawing.Size(85, 13);
            description_prodLabel.TabIndex = 30;
            description_prodLabel.Text = "description prod:";
            // 
            // provider_id_provLabel
            // 
            provider_id_provLabel.AutoSize = true;
            provider_id_provLabel.Location = new System.Drawing.Point(727, 438);
            provider_id_provLabel.Name = "provider_id_provLabel";
            provider_id_provLabel.Size = new System.Drawing.Size(84, 13);
            provider_id_provLabel.TabIndex = 31;
            provider_id_provLabel.Text = "Provider id prov:";
            // 
            // total_buyLabel
            // 
            total_buyLabel.AutoSize = true;
            total_buyLabel.Location = new System.Drawing.Point(735, 122);
            total_buyLabel.Name = "total_buyLabel";
            total_buyLabel.Size = new System.Drawing.Size(50, 13);
            total_buyLabel.TabIndex = 32;
            total_buyLabel.Text = "total buy:";
            // 
            // purchasesDataSet
            // 
            this.purchasesDataSet.DataSetName = "purchasesDataSet";
            this.purchasesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buy_dbTableAdapter
            // 
            this.buy_dbTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Buy_dbTableAdapter = this.buy_dbTableAdapter;
            this.tableAdapterManager.BuyDetailTableAdapter = this.buyDetailTableAdapter;
            this.tableAdapterManager.PayDetailTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sistemacompra.purchasesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buyDetailTableAdapter
            // 
            this.buyDetailTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // buy_dbBindingSource
            // 
            this.buy_dbBindingSource.DataMember = "Buy_db";
            this.buy_dbBindingSource.DataSource = this.purchasesDataSet;
            // 
            // buy_db_IDLabel1
            // 
            this.buy_db_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buy_dbBindingSource, "Buy_db_ID", true));
            this.buy_db_IDLabel1.Location = new System.Drawing.Point(753, 146);
            this.buy_db_IDLabel1.Name = "buy_db_IDLabel1";
            this.buy_db_IDLabel1.Size = new System.Drawing.Size(100, 23);
            this.buy_db_IDLabel1.TabIndex = 26;
            this.buy_db_IDLabel1.Text = "label2";
            // 
            // buyDetailBindingSource
            // 
            this.buyDetailBindingSource.DataMember = "BuyDetail";
            this.buyDetailBindingSource.DataSource = this.purchasesDataSet;
            // 
            // product_id_prodLabel1
            // 
            this.product_id_prodLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyDetailBindingSource, "Product_id_prod", true));
            this.product_id_prodLabel1.Location = new System.Drawing.Point(773, 242);
            this.product_id_prodLabel1.Name = "product_id_prodLabel1";
            this.product_id_prodLabel1.Size = new System.Drawing.Size(100, 23);
            this.product_id_prodLabel1.TabIndex = 27;
            this.product_id_prodLabel1.Text = "label2";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(756, 186);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(86, 32);
            this.btnVerificar.TabIndex = 28;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.purchasesDataSet;
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(117, 311);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(573, 165);
            this.productDataGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_prod";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_prod";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "name_prod";
            this.dataGridViewTextBoxColumn7.HeaderText = "name_prod";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "description_prod";
            this.dataGridViewTextBoxColumn8.HeaderText = "description_prod";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Provider_id_prov";
            this.dataGridViewTextBoxColumn9.HeaderText = "Provider_id_prov";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // id_prodLabel1
            // 
            this.id_prodLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "id_prod", true));
            this.id_prodLabel1.Location = new System.Drawing.Point(781, 334);
            this.id_prodLabel1.Name = "id_prodLabel1";
            this.id_prodLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_prodLabel1.TabIndex = 29;
            this.id_prodLabel1.Text = "label2";
            // 
            // name_prodLabel1
            // 
            this.name_prodLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "name_prod", true));
            this.name_prodLabel1.Location = new System.Drawing.Point(791, 366);
            this.name_prodLabel1.Name = "name_prodLabel1";
            this.name_prodLabel1.Size = new System.Drawing.Size(100, 23);
            this.name_prodLabel1.TabIndex = 30;
            this.name_prodLabel1.Text = "label2";
            // 
            // description_prodLabel1
            // 
            this.description_prodLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "description_prod", true));
            this.description_prodLabel1.Location = new System.Drawing.Point(819, 402);
            this.description_prodLabel1.Name = "description_prodLabel1";
            this.description_prodLabel1.Size = new System.Drawing.Size(100, 23);
            this.description_prodLabel1.TabIndex = 31;
            this.description_prodLabel1.Text = "label2";
            // 
            // provider_id_provLabel1
            // 
            this.provider_id_provLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Provider_id_prov", true));
            this.provider_id_provLabel1.Location = new System.Drawing.Point(817, 438);
            this.provider_id_provLabel1.Name = "provider_id_provLabel1";
            this.provider_id_provLabel1.Size = new System.Drawing.Size(100, 23);
            this.provider_id_provLabel1.TabIndex = 32;
            this.provider_id_provLabel1.Text = "label2";
            // 
            // buy_dbDataGridView
            // 
            this.buy_dbDataGridView.AutoGenerateColumns = false;
            this.buy_dbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buy_dbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.buy_dbDataGridView.DataSource = this.buy_dbBindingSource;
            this.buy_dbDataGridView.Location = new System.Drawing.Point(117, 137);
            this.buy_dbDataGridView.Name = "buy_dbDataGridView";
            this.buy_dbDataGridView.Size = new System.Drawing.Size(521, 142);
            this.buy_dbDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "date_buy";
            this.dataGridViewTextBoxColumn1.HeaderText = "date_buy";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "total_buy";
            this.dataGridViewTextBoxColumn2.HeaderText = "total_buy";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "obseration_buy";
            this.dataGridViewTextBoxColumn3.HeaderText = "obseration_buy";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "state_buy";
            this.dataGridViewTextBoxColumn4.HeaderText = "state_buy";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Buy_db_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Buy_db_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // total_buyLabel1
            // 
            this.total_buyLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buy_dbBindingSource, "total_buy", true));
            this.total_buyLabel1.Location = new System.Drawing.Point(791, 122);
            this.total_buyLabel1.Name = "total_buyLabel1";
            this.total_buyLabel1.Size = new System.Drawing.Size(100, 23);
            this.total_buyLabel1.TabIndex = 33;
            this.total_buyLabel1.Text = "label2";
            // 
            // buyDetailDataGridView
            // 
            this.buyDetailDataGridView.AutoGenerateColumns = false;
            this.buyDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.buyDetailDataGridView.DataSource = this.buyDetailBindingSource;
            this.buyDetailDataGridView.Location = new System.Drawing.Point(605, 285);
            this.buyDetailDataGridView.Name = "buyDetailDataGridView";
            this.buyDetailDataGridView.Size = new System.Drawing.Size(300, 220);
            this.buyDetailDataGridView.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "amount_bd";
            this.dataGridViewTextBoxColumn10.HeaderText = "amount_bd";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "price_bd";
            this.dataGridViewTextBoxColumn11.HeaderText = "price_bd";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "subtotal_bd";
            this.dataGridViewTextBoxColumn12.HeaderText = "subtotal_bd";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Product_id_prod";
            this.dataGridViewTextBoxColumn13.HeaderText = "Product_id_prod";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Buy_db_Buy_db_ID";
            this.dataGridViewTextBoxColumn14.HeaderText = "Buy_db_Buy_db_ID";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // frmHistorialCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 573);
            this.Controls.Add(this.buyDetailDataGridView);
            this.Controls.Add(total_buyLabel);
            this.Controls.Add(this.total_buyLabel1);
            this.Controls.Add(this.buy_dbDataGridView);
            this.Controls.Add(provider_id_provLabel);
            this.Controls.Add(this.provider_id_provLabel1);
            this.Controls.Add(description_prodLabel);
            this.Controls.Add(this.description_prodLabel1);
            this.Controls.Add(name_prodLabel);
            this.Controls.Add(this.name_prodLabel1);
            this.Controls.Add(id_prodLabel);
            this.Controls.Add(this.id_prodLabel1);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(product_id_prodLabel);
            this.Controls.Add(this.product_id_prodLabel1);
            this.Controls.Add(buy_db_IDLabel);
            this.Controls.Add(this.buy_db_IDLabel1);
            this.Name = "frmHistorialCompras";
            this.Text = "frmHistorialCompras";
            this.Load += new System.EventHandler(this.frmHistorialCompras_Load);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.buy_db_IDLabel1, 0);
            this.Controls.SetChildIndex(buy_db_IDLabel, 0);
            this.Controls.SetChildIndex(this.product_id_prodLabel1, 0);
            this.Controls.SetChildIndex(product_id_prodLabel, 0);
            this.Controls.SetChildIndex(this.btnVerificar, 0);
            this.Controls.SetChildIndex(this.productDataGridView, 0);
            this.Controls.SetChildIndex(this.id_prodLabel1, 0);
            this.Controls.SetChildIndex(id_prodLabel, 0);
            this.Controls.SetChildIndex(this.name_prodLabel1, 0);
            this.Controls.SetChildIndex(name_prodLabel, 0);
            this.Controls.SetChildIndex(this.description_prodLabel1, 0);
            this.Controls.SetChildIndex(description_prodLabel, 0);
            this.Controls.SetChildIndex(this.provider_id_provLabel1, 0);
            this.Controls.SetChildIndex(provider_id_provLabel, 0);
            this.Controls.SetChildIndex(this.buy_dbDataGridView, 0);
            this.Controls.SetChildIndex(this.total_buyLabel1, 0);
            this.Controls.SetChildIndex(total_buyLabel, 0);
            this.Controls.SetChildIndex(this.buyDetailDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_dbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_dbDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyDetailDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private purchasesDataSet purchasesDataSet;
        private purchasesDataSetTableAdapters.Buy_dbTableAdapter buy_dbTableAdapter;
        private purchasesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private purchasesDataSetTableAdapters.BuyDetailTableAdapter buyDetailTableAdapter;
        private purchasesDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource buy_dbBindingSource;
        private System.Windows.Forms.Label buy_db_IDLabel1;
        private System.Windows.Forms.BindingSource buyDetailBindingSource;
        private System.Windows.Forms.Label product_id_prodLabel1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label id_prodLabel1;
        private System.Windows.Forms.Label name_prodLabel1;
        private System.Windows.Forms.Label description_prodLabel1;
        private System.Windows.Forms.Label provider_id_provLabel1;
        private System.Windows.Forms.DataGridView buy_dbDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label total_buyLabel1;
        private System.Windows.Forms.DataGridView buyDetailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}