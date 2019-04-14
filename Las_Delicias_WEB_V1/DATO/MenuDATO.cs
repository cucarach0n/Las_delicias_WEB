using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using System.Data.Entity;
namespace DATO
{
    public class MenuDATO
    {
        
        public List<menu> listarMenu()
        {
            using (BDLas_DeliciasEntities Las_Delicias = new BDLas_DeliciasEntities())
            {

                return Las_Delicias.menu.Include("cat_plato.menu").ToList();
            }
        }
    }
}
