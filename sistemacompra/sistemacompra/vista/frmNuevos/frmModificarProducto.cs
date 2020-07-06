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

namespace sistemacompra.vista.frmNuevos
{
    public partial class frmModificarProducto : Form
    {
        private Product update;
        public frmModificarProducto(Product tmp)
        {
            InitializeComponent();
            update = new Product();
            update.id_prod = tmp.id_prod;
            txtNombrePrd.Text = tmp.nom_prod;
            txtDescPrd.Text = tmp.desc_prod;
            proveedores.Items.Clear();
            purchasesEntities ctx = new purchasesEntities();
            ComboBox datos = ProductController.loadProveedores();
            foreach (var x in datos.Items)
                proveedores.Items.Add(x);
            proveedores.Text = ProductController.getNomProv(tmp.Provider_id_prov);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update.nom_prod = txtNombrePrd.Text.ToString();
            update.desc_prod = txtDescPrd.Text.ToString();
            update.Provider_id_prov = ProductController.getIdProv(proveedores.Text);
            if (ProductController.verify(update) == true)
            {
                ProductController.modifyProduct(update);
                MessageBox.Show("Producto modificado con exito.");
                this.Close();
                MessageBox.Show("Haga click en RECARGAR DATOS para ver los cambios");
            }
            else
                MessageBox.Show("Datos incorrectos.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
