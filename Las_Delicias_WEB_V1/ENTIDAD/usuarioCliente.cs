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
    
    public partial class usuarioCliente
    {
        public usuarioCliente()
        {
            this.cliente = new HashSet<cliente>();
        }
    
        public int cod_usu_cli { get; set; }
        public string usuario { get; set; }
        public byte[] pass { get; set; }
        public string email { get; set; }
        public bool validado { get; set; }
        public System.DateTime fechaCreacion { get; set; }
        public string token { get; set; }
        public string estado { get; set; }
    
        public virtual ICollection<cliente> cliente { get; set; }
    }
}
