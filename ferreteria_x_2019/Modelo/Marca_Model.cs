using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//librerias
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using ferreteria_x_2019.Controlador;
using System.Data;

namespace ferreteria_x_2019.Modelo
{
    class Marca_Model
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
                throw new Exception("Error !!!");
            }
        }
        /// <summary>
        /// /Crud Tipos: by Don Colque:
        /// </summary>
        // Listar tipos
        public void listar()
        {
            abrirConexion();
            String sql = "SELECT * FROM marcas ORDER BY 1";
            MySqlDataAdapter datos = new MySqlDataAdapter(sql, conn);
            CI_Marca.getMarca = datos;
            conn.Close();

        }
        public void insertar()
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM marcas", conn);
                string id = (cmd1.ExecuteScalar()).ToString();
                if (Convert.ToInt32(id) > 0)
                {
                    MySqlCommand idmax = new MySqlCommand("SELECT MAX(marca_id) FROM marcas", conn);
                    string _id = (idmax.ExecuteScalar()).ToString();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO marcas (marca_id,nombre) VALUES ('" + (Convert.ToInt32(_id) + 1) + "', '" + CI_Marca.Nom + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd3 = new MySqlCommand("INSERT INTO marcas (marca_id,nombre) VALUES ('" + 1 + "', '" + CI_Marca.Nom + "')", conn);
                    cmd3.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar Marca");
                throw new Exception("Error !!!");
            }
        }
        public void actualizar()
        {
            try
            {
                abrirConexion();
                //MessageBox.Show(Convert.ToInt32(CC_Item.ID_Ti)+""+CC_Item.Nombre_Tipo);
                MySqlCommand cmd = new MySqlCommand("UPDATE marcas SET nombre = '" + CI_Marca.Nom + "'WHERE marca_id = '" + Convert.ToInt32(CI_Marca.Id) + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar Marca");
                throw new Exception("Error !!!");
            }
        }
        public void eliminar()
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM marcas WHERE marca_id = '" + Convert.ToInt32(CI_Marca.Id) + "'", conn);
                if (MessageBox.Show("¿Está seguro que que desea eliminar '" + CI_Marca.Nom + "'?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar Marcas");
                throw new Exception("Error !!!");
            }
        }
    }
}
