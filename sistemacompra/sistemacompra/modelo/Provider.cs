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
    
    public partial class Provider
    {
        private Provider()
        {
          
        }
        private static Provider instancia = null;
        public static Provider obtenerInstancia()
        {
            if(instancia == null){ instancia = new Provider();}
            return instancia;
        }

        //public Provider()
        //{
          //  this.Product = new HashSet<Product>();
        //}
    
        public int id_prov { get; set; }
        public string name_prov { get; set; }
        public string country_prov { get; set; }
        public string swift_prov { get; set; }
    
        public virtual ICollection<Product> Product { get; set; }
    }
}
