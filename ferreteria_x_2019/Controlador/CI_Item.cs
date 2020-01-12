using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////
using System.ComponentModel;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ferreteria_x_2019.Modelo;

namespace ferreteria_x_2019.Controlador
{
    public class CI_Item
    {
        public static string Id_It;
        //Gestionar Items
        public static MySqlDataAdapter getItems;
        public static string Id_Item;
        public static string Nombre_Item;
        public static string Precio;
        public static string Codigo;
        public static string Fabricante;
        public static string Gramos;
        public static string Id_Tipo;
        public static MySqlDataAdapter getLstTipo;
        //Listar items
        public void listarItems()
        {
            Item_Model obj = new Item_Model();
            obj.listar_items();
        }
        //Insertar items
        public void selCmbox()
        {
            Item_Model obj = new Item_Model();
            obj.sel_cmbox();
        }
        public void insertItem()
        {
            Item_Model obj = new Item_Model();
            obj.insert_item();
        }
        public void updItem()
        {
            Item_Model obj = new Item_Model();
            obj.upt_item();
        }
        public void elimItem()
        {
            Item_Model obj = new Item_Model();
            obj.elim_item();
        }
    }
}
