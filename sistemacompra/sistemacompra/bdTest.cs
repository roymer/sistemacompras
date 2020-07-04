using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemacompra
{
    public partial class bdTest : Form
    {
        public bdTest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Conection_Click(object sender, EventArgs e)
        {
            string server = txtServerIP.Text;
            string port = txtPort.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;
            string data = "";
            //cadena de conexion
            string ChainCon = "server =" + server + "; port= " +port+ "; user =" + user + ";password= " + password + ";database=mysql;";
            //necesita conectores que se especifican en el readme
            //en caso de errores ir a explorador de archivos/ segundo boton del raton en referencias/ añadir referencia y buscar y tickear MySql.Data 
            MySqlConnection conectorDB = new MySqlConnection(ChainCon);
            try
             {
                //abrir conexion
                conectorDB.Open();
                MySqlDataReader reader = null;

                //ejecutando consultas
                string query="SHOW DATABASES";
                MySqlCommand cmd = new MySqlCommand(query,conectorDB);
                //almacenamos los resultados en un reader del tipo mysqldatareader
                reader = cmd.ExecuteReader();
                //leemos los datos que contiene reader
                while (reader.Read())
                {
                    data = data+reader.GetString(0)+"\n";
                }

                
             }
            catch(MySqlException ex)
             {
                MessageBox.Show(ex.ToString());
             }
            MessageBox.Show(data);
        }
    }
}
