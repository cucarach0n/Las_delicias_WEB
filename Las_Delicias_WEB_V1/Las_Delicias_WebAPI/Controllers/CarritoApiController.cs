using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ENTIDAD;
using NEGOCIO;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Las_Delicias_WebAPI.Models;
namespace Las_Delicias_WEBAPI.Controllers
{
    public class CarritoApiController : ApiController
    {

        /*public List<menu> GetMenus()
        {
            MenuNegocio menuN = new MenuNegocio();
            List<menu> menuE = new List<menu>();
            foreach (var item in menuN.listarMenu())
            {
                menu menu_ = new menu();
                menu_.cod_menu = item.cod_menu;
                menu_.cod_cat_plato = item.cod_cat_plato;
                menu_.cat_plato = item.cat_plato;
                menu_.cat_plato.menu = item.cat_plato.menu;
                menu_.nomplato = item.nomplato;
                menu_.precio = item.precio;
                menu_.estado_plato = item.estado_plato;
                menu_.imagen = item.imagen;
                menu_.fecha = item.fecha;
                menu_.cantidad = item.cantidad;
                menu_.descrip_men = item.descrip_men;
                menuE.Add(menu_);
            }
            
            return menuE;
        }*/
        public HttpResponseMessage Post_agregarItem(CarritoMODEL carrito)
        {
            List<CarritoMODEL> carritoL = new List<CarritoMODEL>();
            if (System.Web.HttpContext.Current.Session["carritoSession"] != null)
            {
                carritoL = (List<CarritoMODEL>)System.Web.HttpContext.Current.Session["carritoSession"];
                carritoL.Add(carrito);
                System.Web.HttpContext.Current.Session["carritoSession"] = carritoL;
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else 
            {
                carritoL.Add(carrito);
                System.Web.HttpContext.Current.Session["carritoSession"] = carritoL;
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            
        }
    }
}
