using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
namespace DATO
{
    public class ClienteDATO
    {
        BDLas_DeliciasEntities las_DeliciasContext = null;
        public ClienteDATO()
        {
            las_DeliciasContext = new BDLas_DeliciasEntities();
        }
        public bool registrarCliente(cliente client)
        {
            try
            {
                las_DeliciasContext.cliente.Add(client);

            return Convert.ToBoolean(las_DeliciasContext.SaveChanges());
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
        public bool actualizarCliente(cliente client)
        {
            cliente _cliente = (from c in las_DeliciasContext.cliente where c.cod_cli == client.cod_cli select c).First();
            if (_cliente != null)
            {
               
_cliente.nomcliente = client.nomcliente;
                _cliente.apecliente = client.apecliente;
                _cliente.telefono = client.telefono;
                _cliente.direccion = client.direccion;
                _cliente.cod_distrito = client.cod_distrito;
                _cliente.DNI_RUC = client.DNI_RUC;
                _cliente.tipo_cliente = client.tipo_cliente;
                las_DeliciasContext.cliente.Add(_cliente);
                return Convert.ToBoolean(las_DeliciasContext.SaveChanges());
                
                
            }
            else
            {
                return false;
            }
        }
        public cliente validarAcceso(string user , string pass)
        {
            cliente _cliente = (from c in las_DeliciasContext.cliente where c.DNI_RUC == user && c.observacion == pass select c).First();
            
            return _cliente;
        }

        public string newCod()
        {
            cliente cliente_ = (from c in las_DeliciasContext.cliente orderby c.cod_cli descending select c).First();
            string cod = cliente_.cod_cli;
            string nuevoCodigo = String.Empty;
            Int64 number = Convert.ToInt64(cod.Substring(1, 4));
            number += 1;
            if (number > 9999)
            {
                nuevoCodigo = "C" + number.ToString();
            }
            else if (number <= 9999)
            {
                nuevoCodigo = "C" + number.ToString("0000");
            }
            return nuevoCodigo;
        }

    }
}
