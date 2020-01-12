using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferreteria_x_2019.Controlador
{
    public class CI_Stock
    {
        public int Id_Item { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }
        //public DateTime Fecha_Venta { get; set; }
        public static string Id_It;
        public static string Cant;
    }
}
