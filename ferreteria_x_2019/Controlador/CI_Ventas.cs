using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferreteria_x_2019.Controlador
{
    public class CI_Ventas
    {
        public int Venta_Id { get; set; }
        public string Nom_Ar { get; set; }
        public string Nom_Cl { get; set; }
        public DateTime Fecha_Venta{ get; set; }
        public int Cant { get; set; }
        public int Tot { get; set; }
        

        ///Para insertar datos a la tabla ventas
        public static string Usuar;
        ///id de venta
        public static string Id_V;
    }
}
