using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ENTIDAD;
using Las_Delicias_WebAPI.Controllers.Repositorio;
using Las_Delicias_WebAPI.Models;
using NEGOCIO;
namespace Las_Delicias_WEBAPI.Controllers
{
    public class ClienteController : Controller
    {
        ClienteNegocio clienteN;
        DistritoNegocio distritoN;
        public ClienteController()
        {
            clienteN = new ClienteNegocio();
            distritoN = new DistritoNegocio();
        }
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Registrar()
        {
            ViewBag.distrito = distritoN.listarDistrito();
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(ClienteModel clienteValues)
        {
            /*string fileName = Path.GetFileNameWithoutExtension(clienteValues.imagenFile.FileName);
            string fileExtencion = Path.GetExtension(clienteValues.imagenFile.FileName);
            string uploadFile = ConfigurationManager.AppSettings["UserImagePath"].ToString();
            clienteValues.imagen = uploadFile + fileName + fileExtencion;
            clienteValues.imagenFile.SaveAs(clienteValues.imagen);*/
            ViewBag.distrito = distritoN.listarDistrito();
            String respuesta = UploadFTP.Upload(clienteValues.imagenFile.FileName,"clientes",clienteValues.imagenFile);
            if (respuesta != "")
            {
                clienteValues.imagen = respuesta;
                Session["clientTemp"] = clienteValues;
                return RedirectToAction("RegistrarUsuario", "Usuario");
            }
            return View();
        }
        

    }
}