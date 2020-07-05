using sistemacompra.Controlador;
using sistemacompra.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemacompra.vista.frmSecundarios
{
    public partial class frmHistorialCompras : frmPadres.frmGestionar
    {
        HistorialComprasController _db = new HistorialComprasController();
        public frmHistorialCompras()
        {
            InitializeComponent();
        }

       

        private void frmHistorialCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'purchasesDataSet.Product' Puede moverla o quitarla según sea necesario.
            this.productTableAdapter.Fill(this.purchasesDataSet.Product);
            // TODO: esta línea de código carga datos en la tabla 'purchasesDataSet.BuyDetail' Puede moverla o quitarla según sea necesario.
            //this.buyDetailTableAdapter.Fill(this.purchasesDataSet.BuyDetail);
            // TODO: esta línea de código carga datos en la tabla 'purchasesDataSet.Buy_db' Puede moverla o quitarla según sea necesario.
            //this.buy_dbTableAdapter.Fill(this.purchasesDataSet.Buy_db);
            cargarDatos(btnBuscar.text);
        }

        private void cargarDatos(string pBuscar)
        {
            //buy_dbBindingSource.DataSource = _db.Listar(pBuscar);
            buy_dbBindingSource.DataSource = _db.ListarHistorial(pBuscar);
        }

        private void btnBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                cargarDatos(btnBuscar.Text);
            }
                
        }

        private void btnBuscar_OnTextChange(object sender, EventArgs e)
        {
            cargarDatos(btnBuscar.Text);
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buy_dbBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.buy_dbBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.purchasesDataSet);

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            buyDetailBindingSource.DataSource = _db.ListarDetalles(Convert.ToInt32(buy_db_IDLabel1.Text));
            productDataGridView.Visible = true;
            try
            {
                productBindingSource.DataSource = _db.ListarProducto(Convert.ToInt32(product_id_prodLabel1.Text));
            }
            catch (Exception)
            {
                productDataGridView.Visible = false;
                //
                MessageBox.Show("Dato no existente");
            }
            
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
