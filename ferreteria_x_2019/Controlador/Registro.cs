using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferreteria_x_2019.Controlador
{
    public class Registro
    {
        private static readonly Registro Autorizacion = new Registro();
        public string Username { get; set; }
        public string Password { get; set; }
        private Registro() { }
        public static Registro Instance
        {
            get
            {
                return Autorizacion;
            }
        }
    }
}
