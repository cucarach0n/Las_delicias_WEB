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
    
    public partial class tipo_descuento
    {
        public tipo_descuento()
        {
            this.promocion = new HashSet<promocion>();
        }
    
        public int cod_tipo_descuento { get; set; }
        public string nombre_tipo { get; set; }
        public string descripcion_tipo { get; set; }
    
        public virtual ICollection<promocion> promocion { get; set; }
    }
}