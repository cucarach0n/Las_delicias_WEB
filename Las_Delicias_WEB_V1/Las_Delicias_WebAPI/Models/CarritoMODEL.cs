using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Las_Delicias_WebAPI.Models
{
    public class CarritoMODEL
    {
        private string idMenu;
        private int cantidad;

        public string IdMenu { get => idMenu; set => idMenu = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}