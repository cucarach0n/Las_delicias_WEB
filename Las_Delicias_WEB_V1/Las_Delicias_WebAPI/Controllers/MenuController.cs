
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ENTIDAD;
using NEGOCIO;
namespace Las_Delicias_WEBAPI.Controllers
{
    public class MenuController : Controller
    {
        MenuNegocio menuN;
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Lista()
        {
            menuN = new MenuNegocio();
            return View(menuN.listarMenu());
        }

    }
}
