using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DATO;
using System.Net.Mail;
using System.Net;

namespace NEGOCIO
{
    public class UsuarioClienteNegocio
    {
        UsuarioDATO usuarioD;
        public UsuarioClienteNegocio()
        {
            usuarioD = new UsuarioDATO();
        }
        public bool registrarUsuario(usuarioCliente usuarioC)
        {
            return usuarioD.registrarUsuario(usuarioC);
        }
        public int registrarUsuarioScope(usuarioClienteModel usuarioC)
        {
            return usuarioD.registrarUsuarioScope(usuarioC);
        }
        public bool verificarTokenUSuario(string token, int id)
        {
            return usuarioD.verificarTokenUSuario(token, id);
        }
        public bool enviarCorreo(string emailDestino,string token,int id)
        {
            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress(emailDestino));
            email.From = new MailAddress("luis_ls11@hotmail.com");
            email.Subject = "Asunto ( " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss") + " ) ";
            email.Body = "<h2>Gracias por registrarte, ahora podras hacer tus pedidos online</h2><p>para activar tu cuenta, por favor dirigete al"+
                "siguiente link: http://localhost:58825/Usuario/activarUsuario?token=" + token+"&&id="+id +
                "</p><h2>Gracias!!</h2>";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.live.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("luis_ls11@hotmail.com", "92MM2i2EI2enasjn");
            
            try
            {
                smtp.Send(email);
                email.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

