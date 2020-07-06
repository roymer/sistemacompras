using sistemacompra.modelo;
using sistemacompra.vista.frmNuevos;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemacompra.controlador
{
    class ProductController
    {
        // Funcion para validar los datos de un producto
        public static bool verify(Product prd)
        {
            prd.nom_prod = prd.nom_prod.Trim();
            prd.desc_prod = prd.desc_prod.Trim();
            if (prd.desc_prod.Length == 0 || prd.nom_prod.Length == 0 || prd.Provider_id_prov == -1)
                return false;
            return true;
        }

        // Verifica si un id existe en la base de datos
        private bool exists(int id)
        {
            purchasesEntities conection = new purchasesEntities();
            if (conection.Product.Where(x => x.id_prod == id).Count() == 0)
                return false;
            return true;
        }

        // Obtiene el siguiente ID disponible de la tabla Product
        public static int getIdPrd()
        {
            purchasesEntities conection = new purchasesEntities();
            int id = conection.Product.Select(p => p.id_prod).DefaultIfEmpty(0).Max();
            id++;
            return id;
        }

        public static int getIdProv(string nombre)
        {
            purchasesEntities conection = new purchasesEntities();
            if (conection.Provider.Where(p => p.name_prov == nombre).Count() == 0)
                return -1;
            int id = conection.Provider.Where(p => p.name_prov == nombre).First().id_prov;
            return id;
        }
        public static string getNomProv(int id)
        {
            purchasesEntities conection = new purchasesEntities();
            string tmp = conection.Provider.Where(p => p.id_prov == id).First().name_prov;
            return tmp;
        }

        public static ComboBox loadProveedores()
        {
            ComboBox datos = new ComboBox();
            purchasesEntities ctx = new purchasesEntities();
            //MessageBox.Show(ctx.Provider.Select(x => x.name_prov).Count().ToString());
            var data = ctx.Provider.Select(x => x.name_prov);
            foreach(var x in data)
                datos.Items.Add(x);
            return datos;
        }

        public static List<Product> loadProductos(string pat)
        {
            purchasesEntities ctx = new purchasesEntities();
            return ctx.Product.Where(x => SqlFunctions.PatIndex("%"+pat+"%", x.nom_prod) > 0).ToList();
        }

        public static void saveProduct(Product data)
        {
            purchasesEntities ctx = new purchasesEntities();
            ctx.Product.Add(data);
            ctx.SaveChanges();
        }

        public static void modifyProduct(Product data)
        {
            purchasesEntities ctx = new purchasesEntities();
            Product val = ctx.Product.Find(data.id_prod);
            val.nom_prod = data.nom_prod;
            val.desc_prod = data.desc_prod;
            val.Provider_id_prov = data.Provider_id_prov;
            ctx.SaveChanges();
        }

        public static bool deleteProduct(int id)
        {
            purchasesEntities ctx = new purchasesEntities();
            int cnt = ctx.Buy_Detail.Where(x => x.Product_id_prod == id).Count();
            if(cnt == 0)
            {
                Product val = ctx.Product.Find(id);
                ctx.Product.Remove(val);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
