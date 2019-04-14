using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DATO;
namespace NEGOCIO
{
    public class ClienteNegocio
    {
        ClienteDATO clienteD;
        public ClienteNegocio()
        {
            clienteD = new ClienteDATO();
        }

        public bool registrarCliente(cliente client)
        {
            return clienteD.registrarCliente(client);
        }
        public bool actualizarCliente(cliente client)
        {
            return clienteD.actualizarCliente(client);
        }
        public cliente validarCliente(string user, string pass)
        {
            return clienteD.validarAcceso(user, pass);
        }
        public string newCod()
        {
            return clienteD.newCod();
        }
    }
}
