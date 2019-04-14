using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using ENTIDAD;
using NEGOCIO;
namespace Las_Delicias_WEB_V1.Controllers
{
    public class CarritoApiController : ApiController
    {
        public IEnumerable<menu> GetMst_Menu()
        {
            MenuNegocio menuN = new MenuNegocio();
            return menuN.listarMenu();
        }
    }
}