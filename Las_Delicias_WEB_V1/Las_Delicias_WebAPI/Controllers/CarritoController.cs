using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ENTIDAD;
using Las_Delicias_WebAPI.Models;
using NEGOCIO;

namespace Las_Delicias_WebAPI.Controllers
{
    public class CarritoController : Controller
    {
        // GET: Carrito
        public ActionResult carritoStatus()
        {
            List<CarritoMODEL> carritoLista = new List<CarritoMODEL>();
            if (Session["carritoSession"] != null)
            {
                
                carritoLista = (List<CarritoMODEL>)Session["carritoSession"];
                return View(carritoLista);
            }
            else if (Session["carritoSession"] == null)
            {

                Session["carritoSession"] = carritoLista;
                return PartialView(carritoLista);
            }
            return View(carritoLista);
            
        }
    }
}