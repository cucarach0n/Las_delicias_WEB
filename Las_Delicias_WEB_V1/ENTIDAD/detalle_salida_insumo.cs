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
    
    public partial class detalle_salida_insumo
    {
        public int cod_det_salida { get; set; }
        public Nullable<int> cod_salida { get; set; }
        public string codisumos { get; set; }
        public Nullable<decimal> cantidad { get; set; }
    
        public virtual salida_insumo salida_insumo { get; set; }
        public virtual insumo insumo { get; set; }
    }
}
