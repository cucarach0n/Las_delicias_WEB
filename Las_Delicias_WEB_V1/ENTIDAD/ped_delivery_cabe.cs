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
    
    public partial class ped_delivery_cabe
    {
        public ped_delivery_cabe()
        {
            this.ped_delivery_deta = new HashSet<ped_delivery_deta>();
        }
    
        public int cod_delivery_cabe { get; set; }
        public string cod_cli { get; set; }
        public Nullable<System.DateTime> fecha_pedido { get; set; }
        public string cod_personal { get; set; }
        public string estado_delivery { get; set; }
        public string cod_distrito { get; set; }
        public string direccion { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual distrito distrito { get; set; }
        public virtual personal personal { get; set; }
        public virtual ICollection<ped_delivery_deta> ped_delivery_deta { get; set; }
    }
}
