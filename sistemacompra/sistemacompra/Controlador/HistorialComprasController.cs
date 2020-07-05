using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using sistemacompra.modelo;

namespace sistemacompra.Controlador
{
    class HistorialComprasController
    {

        purchasesEntities1 _db = new purchasesEntities1();
        //public List<Buy_db> ListarHistorial()
        public List<Buy_db> ListarHistorial(string pBuscar)
        {

            
            return _db.Buy_db.Where(x => x.obseration_buy.Contains(pBuscar)).OrderByDescending(x => x.date_buy).ToList();
            //return _db.Buy_db.OrderByDescending(x => x.date_buy)ToList();



        }
        internal List<Product> ListarProducto(int pProdId)
        {
            return _db.Product.Where(x => x.id_prod == pProdId).ToList();
        }

        internal List<BuyDetail> ListarDetalles(int pBuy_db)
        {
            return _db.BuyDetail.Where(x => x.Product_id_prod == pBuy_db).ToList();
        }
    }
}
