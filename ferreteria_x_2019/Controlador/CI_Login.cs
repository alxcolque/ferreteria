using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ferreteria_x_2019.Modelo;

namespace ferreteria_x_2019.Controlador
{
    class CI_Login
    {
        public static string Usuario;
        public static string Clave;

        public void resp()
        {
            Login_Model obj = new Login_Model();
            obj.login();
        }
    }
}
