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
    
    public partial class insumo
    {
        public insumo()
        {
            this.detalle_entrada_insumo = new HashSet<detalle_entrada_insumo>();
            this.detalle_salida_insumo = new HashSet<detalle_salida_insumo>();
            this.pedido_deta = new HashSet<pedido_deta>();
        }
    
        public string codisumos { get; set; }
        public string nombre_insumo { get; set; }
        public int cod_unidad_medida { get; set; }
        public Nullable<decimal> unidades_existentes { get; set; }
        public int cod_cat_insumos { get; set; }
    
        public virtual cat_insumo cat_insumo { get; set; }
        public virtual ICollection<detalle_entrada_insumo> detalle_entrada_insumo { get; set; }
        public virtual ICollection<detalle_salida_insumo> detalle_salida_insumo { get; set; }
        public virtual unidad_medida unidad_medida { get; set; }
        public virtual ICollection<pedido_deta> pedido_deta { get; set; }
    }
}