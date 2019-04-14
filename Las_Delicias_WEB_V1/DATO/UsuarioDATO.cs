using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using System.Data.Entity;
namespace DATO
{
    public class UsuarioDATO
    {
        BDLas_DeliciasEntities las_DeliciasModel;
        public UsuarioDATO()
        {
            las_DeliciasModel = new BDLas_DeliciasEntities();
        }
        public bool registrarUsuario(usuarioCliente usuario)
        {
            
            las_DeliciasModel.usuarioCliente.Add(usuario);

            return Convert.ToBoolean(las_DeliciasModel.SaveChanges()) ;
        }
        public int registrarUsuarioScope(usuarioClienteModel usuarioC)
        {
            
            System.Data.Objects.ObjectParameter id =  new System.Data.Objects.ObjectParameter("id", typeof(Int32));
            las_DeliciasModel.registrarUsuarioClienteNuevo(usuarioC.usuario, usuarioC.password, usuarioC.email, usuarioC.token,id);
            return Convert.ToInt32(id.Value);
        }
        public bool verificarTokenUSuario(string token,int id)
        {
            usuarioCliente result = las_DeliciasModel.usuarioCliente.Where(x => x.token ==token && x.cod_usu_cli == id).FirstOrDefault();
            if (result != null)
            {
                result.estado = "A";
                result.validado = true;
                las_DeliciasModel.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
