//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENTIDAD
{
    using System;
    using System.Collections.Generic;
    
    public partial class proveedor
    {
        public proveedor()
        {
            this.Entrada_insumo = new HashSet<Entrada_insumo>();
            this.pedido_Cabe = new HashSet<pedido_Cabe>();
        }
    
        public string cod_prove { get; set; }
        public string nom_prov { get; set; }
        public string direccion { get; set; }
        public string nom_contacto { get; set; }
        public string cargo_contaco { get; set; }
        public string telf_prov { get; set; }
        public string fax_prov { get; set; }
        public string cod_distrito { get; set; }
        public string ruc { get; set; }
    
        public virtual distrito distrito { get; set; }
        public virtual ICollection<Entrada_insumo> Entrada_insumo { get; set; }
        public virtual ICollection<pedido_Cabe> pedido_Cabe { get; set; }
    }
}