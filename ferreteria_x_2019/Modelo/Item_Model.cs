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
    
    class Item_Model
    {
        internal static MySqlConnection conn = null;
        /// <summary>
        ///Conectar con la base de datos
        /// </summary>
        private void abrirConexion()
        {
            string conexionstring = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            conn = new MySqlConnection(conexionstring);
            try
            {
                conn.Open();
                MessageBox.Show("Conexion establecida");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion");
                throw new Exception("Error !!!");
            }
        }
        // Listar tipos
       
        ///Gestionar Items
        //Listar Items
        public void listar_items()
        {
            abrirConexion();
            String sql = "SELECT item_id, nombre,marca_id,tipo_id, precio FROM items";
            MySqlDataAdapter datos = new MySqlDataAdapter(sql, conn);
            CI_Item.getItems = datos;
            conn.Close();
        }
        //insertar Items
        public void sel_cmbox()
        {
            abrirConexion();
            MySqlCommand cmd = new MySqlCommand("select * from tipo", conn);
            try
            {
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                CI_Item.getLstTipo = da;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir tipos");
                throw new Exception("Error !!!");
            }
            conn.Close();

        }
        public void insert_item()
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd1 = new MySqlCommand("select count(*) from items", conn);
                string id_item = (cmd1.ExecuteScalar()).ToString();
                if (Convert.ToInt32(id_item) > 0)
                {
                    MySqlCommand idmax = new MySqlCommand("select max(item_id) from items", conn);
                    string id_ite = (idmax.ExecuteScalar()).ToString();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO items (item_id,nombre,precio,marca_id,tipo_id) VALUES ('" + (Convert.ToInt32(id_ite) + 1) + "', '" + CI_Item.Nombre_Item + "', '" + double.Parse(CI_Item.Precio) + "', '" +1+ "', '" + Convert.ToInt32(CI_Item.Id_Tipo) + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd3 = new MySqlCommand("INSERT INTO items ((item_id,nombre,precio,marca_id,tipo_id) VALUES ('" + 1 + "', '" + CI_Item.Nombre_Item + "', '" + double.Parse(CI_Item.Precio) + "', '" + 1 + "', '" + Convert.ToInt32(CI_Item.Id_Tipo) + "')", conn);
                    cmd3.ExecuteNonQuery();
                    //MessageBox.Show(CC_Item.Nombre_Item + "', '" + Convert.ToDouble(CC_Item.Precio) + "', '" + CC_Item.Codigo + "', '" + CC_Item.Fabricante + "', '" + CC_Item.Gramos + "', '" + Convert.ToInt32(CC_Item.Id_Tipo));
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar item");
                throw new Exception("Error !!!");
            }
        }
        /// <summary>
        /// Actualizar
        /// </summary>
        public void upt_item()
        {
            try
            {
                abrirConexion();

                MySqlCommand cmd = new MySqlCommand("UPDATE items SET  nombre='" + CI_Item.Nombre_Item + "',precio='" + double.Parse(CI_Item.Precio) + 1 + "',tipoitem_id='" + int.Parse(CI_Item.Id_Tipo) + "'WHERE item_id = '" + (Convert.ToInt32(CI_Item.Id_Item)) + "'", conn);
                cmd.ExecuteNonQuery();


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar item");
                throw new Exception("Error !!!");
            }
        }
        //Eliminar item
        public void elim_item()
        {
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM items WHERE item_id = '" + Convert.ToInt32(CI_Item.Id_Item) + "'", conn);
                if (MessageBox.Show("¿Está seguro que que desea eliminar este registro?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar Item");
                throw new Exception("Error !!!");
            }
        }
    }
}
