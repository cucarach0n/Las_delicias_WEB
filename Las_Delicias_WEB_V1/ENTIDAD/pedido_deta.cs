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
    
    public partial class pedido_deta
    {
        public string cod_ped_cabe { get; set; }
        public string codisumos { get; set; }
        public string cantidad { get; set; }
    
        public virtual insumo insumo { get; set; }
        public virtual pedido_Cabe pedido_Cabe { get; set; }
    }
}
