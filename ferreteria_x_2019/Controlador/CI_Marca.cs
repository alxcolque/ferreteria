﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lib extra
using MySql.Data.MySqlClient;
using ferreteria_x_2019.Modelo;

namespace ferreteria_x_2019.Controlador
{
    class CI_Marca
    {
        //Gestionar Marcas
        //public static int Id { get; set; }
        //public static string Nom { get; set; }
        //public static MySqlDataAdapter getId;
        public static string Id;
        public static string Nom;
        public static MySqlDataAdapter getMarca;
        //Listar items
        public void listarM()
        {
            Marca_Model obj = new Marca_Model();
            obj.listar();
        }

        public void insertarC()
        {
            Marca_Model obj = new Marca_Model();
            obj.insertar();
        }
        public void actualizarC()
        {
            Marca_Model obj = new Marca_Model();
            obj.actualizar();
        }
        public void eliminarC()
        {
            Marca_Model obj = new Marca_Model();
            obj.eliminar();
        }
    }
}
