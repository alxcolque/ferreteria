using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//librerias
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using ferreteria_x_2019.Controlador;
//using ferreteria_x_2019.Vista;

namespace ferreteria_x_2019.Modelo
{
    class Login_Model
    {
        internal static MySqlConnection conn = null;
        private void abrirConexion()
        {
            string conexionstring = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            conn = new MySqlConnection(conexionstring);
            try
            {
                conn.Open();
                //MessageBox.Show("Conexion establecida");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion");
                Application.Exit();
                throw new Exception("Error !!!");
            }
        }
        //Validacion de cuenta
        private bool validate_login(string user, string pass)
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Select * from usuarios where usuario_nombre=@user and clave=@pass";
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Connection = conn;
                MySqlDataReader login = cmd.ExecuteReader();
                if (login.Read())
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Validar usuario");
                throw new Exception("Error !!!");
            }

        }
        public void login()
        {
            try
            {
                string user = CI_Login.Usuario;
                string pass = CI_Login.Clave;
                if (user == "" || pass == "")
                {
                    MessageBox.Show("Llene los campos vacios por favor..!!");
                    return;
                }
                bool r = validate_login(user, pass);
                if (r)
                {
                    Principal m = new Principal();
                    m.ShowDialog();
                }
                else
                    MessageBox.Show("Datos incorrectos, Revise e intente nuevamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de metodo Login");
                throw new Exception("Error !!!");
            }
        }
    }
}
