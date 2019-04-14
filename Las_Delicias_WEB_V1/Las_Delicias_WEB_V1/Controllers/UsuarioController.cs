using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ENTIDAD;
using NEGOCIO;
namespace Las_Delicias_WEB_V1.Controllers
{
    public class UsuarioController : Controller
    {
        cliente cliente;
        // GET: Usuario
        /*public ActionResult Index()
        {
            return View();
        }*/
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult registrar()
        {
            return View();
        }

    }
}