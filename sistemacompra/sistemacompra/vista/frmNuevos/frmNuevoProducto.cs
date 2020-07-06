using sistemacompra.controlador;
using sistemacompra.modelo;
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
    public partial class frmNuevoProducto : frmNuevo
    {
        public frmNuevoProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Product tmp = new Product();
            tmp.nom_prod = txtNombrePrd.Text.ToString();
            tmp.desc_prod = txtDescPrd.Text.ToString();
            tmp.id_prod = ProductController.getIdPrd();
            tmp.Provider_id_prov = ProductController.getIdProv(proveedores.Text);
            if (ProductController.verify(tmp) == true)
            {
                ProductController.saveProduct(tmp);
                MessageBox.Show("Producto agregado con exito.");
                this.Close();
                MessageBox.Show("Haga click en RECARGAR DATOS para ver los cambios");
            }
            else
                MessageBox.Show("Datos incorrectos.");    
        }

        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            proveedores.Items.Clear();
            purchasesEntities ctx = new purchasesEntities();
            ComboBox datos = ProductController.loadProveedores();
            foreach(var x in datos.Items)
                proveedores.Items.Add(x);
        }
    }
}
