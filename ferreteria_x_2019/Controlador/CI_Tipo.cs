using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lib extra
using MySql.Data.MySqlClient;
using ferreteria_x_2019.Modelo;

namespace ferreteria_x_2019.Controlador
{
    class CI_Tipo
    {
        //Gestionar Items
        public static int Id { get; set; }
        public static string Nom { get; set; }
        //public static MySqlDataAdapter getId;
        //public static string Id;
        //public static string Nom;
        public static MySqlDataAdapter getTipo;
        //Listar items
        public void listar()
        {
            Tipo_Model obj = new Tipo_Model();
            obj.listar();
        }

        public void insertarC()
        {
            Tipo_Model obj = new Tipo_Model();
            obj.insertar();
        }
        public void actualizarC()
        {
            Tipo_Model obj = new Tipo_Model();
            obj.actualizar();
        }
        public void eliminarC()
        {
            Tipo_Model obj = new Tipo_Model();
            obj.eliminar();
        }
    }
}
