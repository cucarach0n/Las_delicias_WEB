using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ENTIDAD;
namespace Las_Delicias_WebAPI.Models
{
    public class usuarioClienteModel : usuarioCliente
    {
        public string password {get;set;}
    }
}