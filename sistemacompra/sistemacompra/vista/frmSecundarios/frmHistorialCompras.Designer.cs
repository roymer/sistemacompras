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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            buy_db_IDLabel = new System.Windows.Forms.Label();
            product_id_prodLabel = new System.Windows.Forms.Label();
            id_prodLabel = new System.Windows.Forms.Label();
            name_prodLabel = new System.Windows.Forms.Label();
            description_prodLabel = new System.Windows.Forms.Label();
            provider_id_provLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_dbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_dbDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(29, 98);
            this.btnBuscar.text = "";
            this.btnBuscar.OnTextChange += new System.EventHandler(this.btnBuscar_OnTextChange);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNuevo.Enabled = false;
            this.btnNuevo.Visible = false;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(430, 36);
            this.label1.Text = "HISTORIAL DE COMPRAS";
            // 
            // buy_db_IDLabel
            // 
            buy_db_IDLabel.AutoSize = true;
            buy_db_IDLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            buy_db_IDLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            buy_db_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buy_db_IDLabel.Location = new System.Drawing.Point(682, 149);
            buy_db_IDLabel.Name = "buy_db_IDLabel";
            buy_db_IDLabel.Size = new System.Drawing.Size(93, 20);
            buy_db_IDLabel.TabIndex = 25;
            buy_db_IDLabel.Text = "Buy db ID:";
            // 
            // product_id_prodLabel
            // 
            product_id_prodLabel.AutoSize = true;
            product_id_prodLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            product_id_prodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_id_prodLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            product_id_prodLabel.Location = new System.Drawing.Point(685, 242);
            product_id_prodLabel.Name = "product_id_prodLabel";
            product_id_prodLabel.Size = new System.Drawing.Size(136, 20);
            product_id_prodLabel.TabIndex = 26;
            product_id_prodLabel.Text = "Product id prod:";
            // 
            // id_prodLabel
            // 
            id_prodLabel.AutoSize = true;
            id_prodLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            id_prodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_prodLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            id_prodLabel.Location = new System.Drawing.Point(686, 337);
            id_prodLabel.Name = "id_prodLabel";
            id_prodLabel.Size = new System.Drawing.Size(69, 20);
            id_prodLabel.TabIndex = 28;
            id_prodLabel.Text = "id prod:";
            // 
            // name_prodLabel
            // 
            name_prodLabel.AutoSize = true;
            name_prodLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            name_prodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            name_prodLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            name_prodLabel.Location = new System.Drawing.Point(686, 369);
            name_prodLabel.Name = "name_prodLabel";
            name_prodLabel.Size = new System.Drawing.Size(99, 20);
            name_prodLabel.TabIndex = 29;
            name_prodLabel.Text = "name prod:";
            // 
            // description_prodLabel
            // 
            description_prodLabel.AutoSize = true;
            description_prodLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            description_prodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            description_prodLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            description_prodLabel.Location = new System.Drawing.Point(686, 405);
            description_prodLabel.Name = "description_prodLabel";
            description_prodLabel.Size = new System.Drawing.Size(143, 20);
            description_prodLabel.TabIndex = 30;
            description_prodLabel.Text = "description prod:";
            // 
            // provider_id_provLabel
            // 
            provider_id_provLabel.AutoSize = true;
            provider_id_provLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            provider_id_provLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            provider_id_provLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            provider_id_provLabel.Location = new System.Drawing.Point(685, 441);
            provider_id_provLabel.Name = "provider_id_provLabel";
            provider_id_provLabel.Size = new System.Drawing.Size(137, 20);
            provider_id_provLabel.TabIndex = 31;
            provider_id_provLabel.Text = "Provider id prov:";
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
            this.buy_db_IDLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buy_db_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buy_dbBindingSource, "Buy_db_ID", true));
            this.buy_db_IDLabel1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buy_db_IDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy_db_IDLabel1.Location = new System.Drawing.Point(781, 146);
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
            this.product_id_prodLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.product_id_prodLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyDetailBindingSource, "Product_id_prod", true));
            this.product_id_prodLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_id_prodLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.product_id_prodLabel1.Location = new System.Drawing.Point(827, 242);
            this.product_id_prodLabel1.Name = "product_id_prodLabel1";
            this.product_id_prodLabel1.Size = new System.Drawing.Size(100, 23);
            this.product_id_prodLabel1.TabIndex = 27;
            this.product_id_prodLabel1.Text = "label2";
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerificar.Location = new System.Drawing.Point(756, 186);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(86, 32);
            this.btnVerificar.TabIndex = 28;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
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
            this.productDataGridView.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.productDataGridView.DataSource = this.productBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.productDataGridView.Location = new System.Drawing.Point(101, 296);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(443, 165);
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
            this.id_prodLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.id_prodLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "id_prod", true));
            this.id_prodLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_prodLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.id_prodLabel1.Location = new System.Drawing.Point(829, 334);
            this.id_prodLabel1.Name = "id_prodLabel1";
            this.id_prodLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_prodLabel1.TabIndex = 29;
            this.id_prodLabel1.Text = "label2";
            // 
            // name_prodLabel1
            // 
            this.name_prodLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.name_prodLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "name_prod", true));
            this.name_prodLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_prodLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.name_prodLabel1.Location = new System.Drawing.Point(829, 366);
            this.name_prodLabel1.Name = "name_prodLabel1";
            this.name_prodLabel1.Size = new System.Drawing.Size(100, 23);
            this.name_prodLabel1.TabIndex = 30;
            this.name_prodLabel1.Text = "label2";
            // 
            // description_prodLabel1
            // 
            this.description_prodLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.description_prodLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "description_prod", true));
            this.description_prodLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_prodLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.description_prodLabel1.Location = new System.Drawing.Point(829, 402);
            this.description_prodLabel1.Name = "description_prodLabel1";
            this.description_prodLabel1.Size = new System.Drawing.Size(100, 23);
            this.description_prodLabel1.TabIndex = 31;
            this.description_prodLabel1.Text = "label2";
            // 
            // provider_id_provLabel1
            // 
            this.provider_id_provLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.provider_id_provLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Provider_id_prov", true));
            this.provider_id_provLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provider_id_provLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.provider_id_provLabel1.Location = new System.Drawing.Point(829, 438);
            this.provider_id_provLabel1.Name = "provider_id_provLabel1";
            this.provider_id_provLabel1.Size = new System.Drawing.Size(100, 23);
            this.provider_id_provLabel1.TabIndex = 32;
            this.provider_id_provLabel1.Text = "label2";
            // 
            // buy_dbDataGridView
            // 
            this.buy_dbDataGridView.AutoGenerateColumns = false;
            this.buy_dbDataGridView.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buy_dbDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.buy_dbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buy_dbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.buy_dbDataGridView.DataSource = this.buy_dbBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.buy_dbDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.buy_dbDataGridView.Location = new System.Drawing.Point(39, 139);
            this.buy_dbDataGridView.Name = "buy_dbDataGridView";
            this.buy_dbDataGridView.Size = new System.Drawing.Size(542, 142);
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
            // frmHistorialCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(973, 573);
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
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_dbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_dbDataGridView)).EndInit();
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
    }
}