using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Las_Delicias_WebAPI.Models
{
    public class ClienteModel
    {
        public string cod_cli { get; set; }
        [DisplayName("Nombres")]
        public string nomcliente { get; set; }
        [DisplayName("Apellidos")]
        public string apecliente { get; set; }
        public string imagen { get; set; }
        [DisplayName("Suba su imagen de Perfil")]
        public HttpPostedFileBase imagenFile { get; set; }
        [DisplayName("Algun telefono")]
        public string telefono { get; set; }
        [DisplayName("Direccion")]
        public string direccion { get; set; }
        [DisplayName("Distrito")]
        public string cod_distrito { get; set; }
        [DisplayName("Ingrese su DNI")]
        public string DNI_RUC { get; set; }
        public string observacion { get; set; }
        public string tipo_cliente { get; set; }
        public int cod_usu_cli { get; set; }
    }
}