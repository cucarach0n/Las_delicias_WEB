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
    
    public partial class cat_insumo
    {
        public cat_insumo()
        {
            this.insumo = new HashSet<insumo>();
        }
    
        public int cod_cat_insumos { get; set; }
        public string nom_cat_insu { get; set; }
        public string descrip_cat { get; set; }
    
        public virtual ICollection<insumo> insumo { get; set; }
    }
}
