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
    
    public partial class distrito
    {
        public distrito()
        {
            this.cliente = new HashSet<cliente>();
            this.ped_delivery_cabe = new HashSet<ped_delivery_cabe>();
            this.personal = new HashSet<personal>();
            this.proveedor = new HashSet<proveedor>();
        }
    
        public string cod_distrito { get; set; }
        public string nomdistrito { get; set; }
    
        public virtual ICollection<cliente> cliente { get; set; }
        public virtual ICollection<ped_delivery_cabe> ped_delivery_cabe { get; set; }
        public virtual ICollection<personal> personal { get; set; }
        public virtual ICollection<proveedor> proveedor { get; set; }
    }
}
