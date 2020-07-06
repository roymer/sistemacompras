using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemacompra.GestionarCompra;

namespace sistemacompra.presentacion
{
    public partial class Gestionar : Form
    {
        comprar objGestionar = new comprar();
        public Gestionar()
        {
            InitializeComponent();
        }
        comprar objproducto = new comprar();
        string Operacion = "Insertar";
        string idgestionar;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Gestionar_Load(object sender, EventArgs e)
        {
            DetalleCompra();
            DetallePagar();
            ListarProductos();
        }
        private void DetalleCompra()
        {
            comprar objProd = new comprar();
            cmbBuy.DataSource = objProd.DetalleCompra();
            cmbBuy.DisplayMember = "amount_bd";
            cmbBuy.ValueMember = "id_bd";
        }
        private void DetallePagar()
        {
            comprar objProd = new comprar();
            cmdPay.DataSource = objProd.DetallePagar();
            cmdPay.DisplayMember = "date_pd";
            cmdPay.ValueMember = "id_pd";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {
                objGestionar.InsertarGestionar(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,
                    Convert.ToInt32(cmbBuy.SelectedValue),
                    Convert.ToInt32(cmdPay.SelectedValue));
                MessageBox.Show("Insertado Correctamente");
            }
            else if (Operacion == "Editar")
            { 
                objproducto.EditarProductos(Convert.ToInt32(id_buy),textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,
                    Convert.ToInt32(cmbBuy.SelectedValue),
                    Convert.ToInt32(cmdPay.SelectedValue));
                Operacion="Insertar";
                MessageBox.Show("se edito correctamente");
            }

            ListarProductos();
        }
        private void ListarProductos()
        {
            comprar objProd = new comprar();
            dataGridView1.DataSource = objProd.ListarProductos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Operacion = "Editar";

                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cmbBuy.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                cmdPay.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                idgestionar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else
                MessageBox.Show("debe seleccionar una fila ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objproducto.EliminarProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                MessageBox.Show("Se elimino satisfactoriamente");
                ListarProductos();
            }
            else
                MessageBox.Show("Seleccione una fila");

        }
    }
}
