using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DATO;
namespace NEGOCIO
{
    public class MenuNegocio
    {
        MenuDATO menuD;
        public List<menu> listarMenu()
        {
            menuD = new MenuDATO();
            return menuD.listarMenu();
        }
    }
}
