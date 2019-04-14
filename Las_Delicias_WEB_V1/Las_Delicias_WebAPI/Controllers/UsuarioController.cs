using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ENTIDAD;
using Las_Delicias_WebAPI.Controllers.Repositorio;
using Las_Delicias_WebAPI.Models;
using NEGOCIO;
namespace Las_Delicias_WEBAPI.Controllers
{
    public class UsuarioController : Controller
    {
        ClienteModel clienteM;
        cliente client;
        ClienteNegocio clienteN;
        UsuarioClienteNegocio usuarioClienteN;
        public UsuarioController()
        {
            clienteM = new ClienteModel();
        }
        // GET: Usuario
        /*public ActionResult Index()
        {
            return View();
        }*/
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Registrado()
        {
            return View();
            //return RedirectToAction("Lista","Menu");
        }
        public ActionResult RegistrarUsuario()
        {
            if (Session["clientTemp"] != null)
            {
                
                return View();
            }
            else
            {
                return RedirectToAction("Registrar","Cliente");
            }
            
        }
        [HttpPost]
        public ActionResult RegistrarUsuario(ENTIDAD.usuarioClienteModel usuarioC)
        {
            clienteN = new ClienteNegocio();
            client = new cliente();
            clienteM = (ClienteModel)Session["clientTemp"];
            usuarioClienteN = new UsuarioClienteNegocio();
            usuarioC.usuario = clienteM.DNI_RUC;
            usuarioC.validado = false;
            usuarioC.fechaCreacion = DateTime.Now;
            usuarioC.estado = "D";
            usuarioC.token = UploadFTP.generarToken();
            

            
            
            client.cod_cli = clienteN.newCod();
            client.nomcliente = clienteM.nomcliente;
            client.apecliente = clienteM.apecliente;
            client.imagen = clienteM.imagen;
            client.telefono = clienteM.telefono;
            client.direccion = clienteM.direccion;
            client.cod_distrito = clienteM.cod_distrito;
            client.DNI_RUC = clienteM.DNI_RUC;
            client.cod_usu_cli = usuarioClienteN.registrarUsuarioScope(usuarioC);
            client.observacion = "registrado desde Web";
            client.tipo_cliente = "N";

            if (clienteN.registrarCliente(client) == true)
            {
                Session["clientTemp"] = null;
                usuarioClienteN.enviarCorreo(usuarioC.email,usuarioC.token,client.cod_usu_cli);
                return RedirectToAction("Registrado");
            }
            else
            {
                return RedirectToAction("Registrar", "Cliente");
            }

            
        }
        [HttpGet]
        public ActionResult activarUsuario(string token,int id)
        {
            usuarioClienteN = new UsuarioClienteNegocio();
            usuarioClienteN.verificarTokenUSuario(token, id);
            return RedirectToAction("Lista","Menu");
        }

    }
}