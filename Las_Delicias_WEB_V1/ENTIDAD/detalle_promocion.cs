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
    
    public partial class detalle_promocion
    {
        public detalle_promocion()
        {
            this.boleta_cabe = new HashSet<boleta_cabe>();
            this.factura_cabe = new HashSet<factura_cabe>();
        }
    
        public int cod_cupon { get; set; }
        public Nullable<int> cod_promo { get; set; }
        public Nullable<bool> canjeado { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
    
        public virtual ICollection<boleta_cabe> boleta_cabe { get; set; }
        public virtual promocion promocion { get; set; }
        public virtual ICollection<factura_cabe> factura_cabe { get; set; }
    }
}