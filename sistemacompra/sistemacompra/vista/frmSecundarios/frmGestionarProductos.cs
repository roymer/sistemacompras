using sistemacompra.controlador;
using sistemacompra.modelo;
using sistemacompra.vista.frmNuevos;
using sistemacompra.vista.frmPadres;
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
    public partial class frmGestionarProductos : frmGestionar
    {
        public frmGestionarProductos()
        {
            InitializeComponent();
            load("");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoProducto fm = new frmNuevoProducto();
            fm.ShowDialog();
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            load(txtBuscar.Text);
        }

        private void btnBuscar_OnTextChange(object sender, EventArgs e)
        {

        }

        // Funcion para cargar los datos dentro de el datagridview
        public void load(String pat)
        {
            tablaProductos.Rows.Clear();
            tablaProductos.ColumnCount = 4;
            tablaProductos.Columns[0].HeaderText = "ID PRODUCTO";
            tablaProductos.Columns[1].HeaderText = "NOMBRE";
            tablaProductos.Columns[2].HeaderText = "DESCRIPCION";
            tablaProductos.Columns[3].HeaderText = "PROVEEDOR";
            List<Product> datos = ProductController.loadProductos(pat);
            for (int i = 0; i < datos.Count(); i++)
            {
                tablaProductos.Rows.Add();
                tablaProductos.Rows[i].Cells[0].Value = datos[i].id_prod;
                tablaProductos.Rows[i].Cells[1].Value = datos[i].nom_prod;
                tablaProductos.Rows[i].Cells[2].Value = datos[i].desc_prod;
                tablaProductos.Rows[i].Cells[3].Value = ProductController.getNomProv(datos[i].Provider_id_prov);
            }
        }

        private void tablaProductos_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(tablaProductos.SelectedRows.Count.ToString());
            if (tablaProductos.SelectedRows.Count == 1)
            {
                Product tmp = new Product();
                if (tablaProductos.SelectedRows[0].Cells[0].Value == null)
                    return;

                tmp.id_prod = Convert.ToInt32(tablaProductos.SelectedRows[0].Cells[0].Value.ToString());
                tmp.nom_prod = tablaProductos.SelectedRows[0].Cells[1].Value.ToString();
                tmp.desc_prod = tablaProductos.SelectedRows[0].Cells[2].Value.ToString();
                tmp.Provider_id_prov = ProductController.getIdProv(tablaProductos.SelectedRows[0].Cells[3].Value.ToString());
                frmModificarProducto f1 = new frmModificarProducto(tmp);
                f1.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaProductos.SelectedRows.Count == 1)
            {
                if (tablaProductos.SelectedRows[0].Cells[0].Value == null)
                    return;
                int id = Convert.ToInt32(tablaProductos.SelectedRows[0].Cells[0].Value.ToString());
                if (MessageBox.Show("Está seguro que desea eliminar el producto con ID = " + id.ToString() + "?",  "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ProductController.deleteProduct(id))
                    {
                        MessageBox.Show("Producto eliminado con exito");
                        MessageBox.Show("Haga click en RECARGAR DATOS para ver los cambios");
                    }
                    else
                        MessageBox.Show("No es posible eliminar el producto ya que tiene registros asociados");

                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load("");
        }
    }
}
