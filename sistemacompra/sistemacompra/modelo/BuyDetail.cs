//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sistemacompra.modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class BuyDetail
    {
        public string amount_bd { get; set; }
        public string price_bd { get; set; }
        public string subtotal_bd { get; set; }
        public int Product_id_prod { get; set; }
        public decimal Buy_db_Buy_db_ID { get; set; }
    
        public virtual Buy_db Buy_db { get; set; }
        public virtual Product Product { get; set; }
    }
}
