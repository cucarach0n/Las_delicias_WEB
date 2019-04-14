using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ENTIDAD;
using NEGOCIO;
namespace Las_Delicias_WEB_V1.Controllers
{
    public class CarritoController : ApiController
    {
        public IEnumerable<menu> GetMenus()
        {
            MenuNegocio menuN = new MenuNegocio();
            return menuN.listarMenu();
        }
    }
}
