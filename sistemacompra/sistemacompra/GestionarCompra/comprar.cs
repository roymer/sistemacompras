using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Configuration;
using System.Drawing.Printing;

namespace sistemacompra.GestionarCompra
{
    class comprar
    {
        private conexionbd Conexion = new conexionbd();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable DetalleCompra()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.abrir();
            Comando.CommandText = "DetalleCompra";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.cerrar();
            return Tabla;
        }
        public DataTable DetallePagar()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.abrir();
            Comando.CommandText = "DetallePagar";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.cerrar();
            return Tabla;
        }
        public void InsertarGestionar(int date_buy, string total_buy, string observation_buy, string state_buy, int id_bd, int id_pd)
        {
            Comando.Connection = Conexion.abrir();
            Comando.CommandText = "AgregarProducto";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@date_buy", date_buy);
            Comando.Parameters.AddWithValue("@total_buy", total_buy);
            Comando.Parameters.AddWithValue("@observation_buy", observation_buy);
            Comando.Parameters.AddWithValue("@state_buy", state_buy);
            Comando.Parameters.AddWithValue("@id_bd", id_bd);
            Comando.Parameters.AddWithValue("@id_pd", id_pd);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Conexion.cerrar();
        }
        public DataTable ListarProductos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.abrir();
            Comando.CommandText = "ListarProductos";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.cerrar();
            return Tabla;
        }
        public void EditarProductos(int id_buy, int date_buy, string total_buy, string observation_buy, string state_buy, int id_bd, int id_pd)
        {
            Comando.Connection = Conexion.abrir();
            Comando.CommandText = "update Gestionar set date_buy=" + date_buy + ",total_buy=" + total_buy + ",observation_buy='" + observation_buy + "',state_buy=" + state_buy + ",id_bd=" + id_bd + ",id_pd=" + id_pd + " WHERE IDPROD=" + id_buy;
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.cerrar();
        }
        public void EliminarProducto(int id_buy)
        {
            Comando.Connection = Conexion.abrir();
            Comando.CommandText = "delete Gestionar where id_buy=" + id_buy;
            Comando.CommandType = CommandType.Text;
            Comando.ExecuteNonQuery();
            Conexion.cerrar();
        }
    }
}
