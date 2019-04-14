using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
namespace DATO
{
    public class DistritoDATO
    {
        BDLas_DeliciasEntities las_DeliciasContex;
        public DistritoDATO()
        {
            las_DeliciasContex = new BDLas_DeliciasEntities();
        }
        public List<distrito> listarDistrito()
        {
            return las_DeliciasContex.distrito.ToList();
        }
    }
}
