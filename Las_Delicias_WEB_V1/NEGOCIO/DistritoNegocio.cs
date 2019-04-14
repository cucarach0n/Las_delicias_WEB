using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DATO;
namespace NEGOCIO
{
    public class DistritoNegocio
    {
        DistritoDATO distritoD;
        public DistritoNegocio()
        {
            distritoD = new DistritoDATO();
        }
        public List<distrito> listarDistrito()
        {
            return distritoD.listarDistrito();
        }
    }
}
