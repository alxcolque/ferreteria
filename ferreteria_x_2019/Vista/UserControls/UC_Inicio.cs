using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//lib
using MySql.Data.MySqlClient;
using System.Configuration;
using ferreteria_x_2019.Modelo;
using ferreteria_x_2019.Controlador;
using ferreteria_x_2019.Forms;
using Bunifu;

namespace ferreteria_x_2019.UC_Inicio
{
    public partial class UC_Inicio : UserControl
    {

        public UC_Inicio()
        {
            InitializeComponent();
            refresca();
        }
        private void refresca()
        {
            listarStock();
            listar();
            //detalles();
        }
        public void listarStock()
        {
            try
            {
                //s
                /*Inicio_C obj = new Inicio_C();
                obj.listarR();

                DataSet dataI = new DataSet();
                (Inicio_C.getLstR).Fill(dataI);
                dgvRecep.AllowUserToAddRows = false;
                dgvRecep.Rows.Clear();
                for (int i = 0; i < dataI.Tables[0].Rows.Count; i++)
                {
                    dgvRecep.Rows.Add(
                    dataI.Tables[0].Rows[i][0],
                    dataI.Tables[0].Rows[i][1],
                    dataI.Tables[0].Rows[i][2],
                    dataI.Tables[0].Rows[i][3]
                    );

                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar Clientes");
            }

        }
        public void listar()
        {
            try
            {
                //s
                /*Inicio_C obj = new Inicio_C();
                obj.listarE();

                DataSet dataI = new DataSet();
                (Inicio_C.getLst).Fill(dataI);
                dgvEnviados.AllowUserToAddRows = false;
                dgvEnviados.Rows.Clear();
                for (int i = 0; i < dataI.Tables[0].Rows.Count; i++)
                {
                    dgvEnviados.Rows.Add(
                    dataI.Tables[0].Rows[i][0],
                    dataI.Tables[0].Rows[i][1],
                    dataI.Tables[0].Rows[i][2],
                    dataI.Tables[0].Rows[i][3]
                    );

                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar Enviados");
            }

        }
        public void disabl_btn()
        {
            /*OracleCommand cmd3 = new OracleCommand("select count(*) from cesta", conn);
            string contr = (cmd3.ExecuteScalar()).ToString();
            OracleCommand cmd4 = new OracleCommand("select count(*) from stock", conn);
            string c_stk = (cmd4.ExecuteScalar()).ToString();

            //MessageBox.Show("La tabla: "+contr+" stock: "+c_stk);
            if (int.Parse(c_stk) == 0)
            {
                btnAddToCart.Enabled = false;
                bunifuImageButton2.Enabled = false;
                btnGuardarCart.Enabled = false;
            }
            if (int.Parse(contr) == 0)
            {
                bunifuImageButton2.Enabled = false;
                btnGuardarCart.Enabled = false;
            }*/
        }
        private void abrirConexion()
        {
            /*string conexionstring = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            conn = new OracleConnection(conexionstring);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion");
                throw new Exception("Error !!!");
            }*/
        }
        private void UC_Inicio_Load(object sender, EventArgs e)
        {
            dgvCart.AllowUserToAddRows = false;
            refrescar();
        }
        public void refrescar()
        {
            dgvCart.AllowUserToAddRows = false;
            cargarGrilla();
            cargarCart();
            cartTotal();
            ventaTotal();
            totalcli();
        }
        private void totalcli()
        {
            abrirConexion();

            try
            {
                /*OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "select count(*) from clientes";
                //guardamos el resultado en el TextBox txt_num_ventas
                lblClientes.Text = (comando.ExecuteScalar()).ToString();*/

            }
            catch (Exception ex)
            {
                MessageBox.Show("NO se puede Obtener los Resultados");
            }
        }
        private void ventaTotal()
        {
            abrirConexion();
            
            try
            {
                /*OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "select sum(total) from ventas";
                //guardamos el resultado en el TextBox txt_num_ventas
                lblVentasHoy.Text = (comando.ExecuteScalar()).ToString() + " Bs.";*/

            }
            catch (Exception ex)
            {
                MessageBox.Show("NO se puede Obtener los Resultados");
            }
        }
        private void cartTotal()
        {
            abrirConexion();
            //String sql = string.Format("select SUM(precio*cantidad) from cesta c, items i where c.item_id = i.item_id");
            try
            {
                /*OracleCommand comando = new OracleCommand();
                comando.Connection = conn;
                comando.CommandText = "select SUM(precio*cantidad) from cesta c, items i where c.item_id = i.item_id";
                //guardamos el resultado en el TextBox txt_num_ventas
                lblTotalCesta.Text = (comando.ExecuteScalar()).ToString() + " Bs.";
                lblOredenes.Text = (comando.ExecuteScalar()).ToString()+" Bs.";*/
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO se puede Obtener los Resultados");
            }
            
        }

        private void cargarGrilla()
        {
            dgvStock.Rows.Clear();
            dgvStock.Refresh();
            DataSet ds1 = new DataSet();
            try
            {

                /*if (conn.State == System.Data.ConnectionState.Open)
                {
                    OracleCommand cmd1 = new OracleCommand();
                    cmd1.Connection = conn;
                    cmd1.CommandText = "stock_lista";
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("resul", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    OracleDataAdapter da = new OracleDataAdapter(cmd1);
                    da.Fill(ds1);
                }
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    dgvStock.Rows.Add(
                            ds1.Tables[0].Rows[i][0],
                            ds1.Tables[0].Rows[i][1],
                            ds1.Tables[0].Rows[i][2],
                            ds1.Tables[0].Rows[i][3]
                        );
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla Stock");
                ///throw new Exception("Error !!!");
            }
        }
        public void cargarCart()
        {
            dgvCart.AllowUserToAddRows = false;
            dgvCart.Rows.Clear();
            dgvCart.Refresh();
            abrirConexion();
            DataSet ds1 = new DataSet();
            try
            {

                /*if (conn.State == System.Data.ConnectionState.Open)
                {
                    OracleCommand cmd1 = new OracleCommand();
                    cmd1.Connection = conn;
                    cmd1.CommandText = "cart_lista";
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("resul", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    cmd1.ExecuteNonQuery();
                    OracleDataAdapter da = new OracleDataAdapter(cmd1);
                    da.Fill(ds1);
                }
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    dgvCart.Rows.Add(
                            ds1.Tables[0].Rows[i][0],
                            ds1.Tables[0].Rows[i][1],
                            ds1.Tables[0].Rows[i][2],
                            ds1.Tables[0].Rows[i][3]
                        );
                }*/
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla Cesta");
                ///throw new Exception("Error !!!");
            }
            
        }
        public void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*UC_Inicio.UC_Inicio obj = new UC_Inicio.UC_Inicio();
            obj.regisventa();
            this.Dispose();*/
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            /*String ide = dgvStock.CurrentRow.Cells[0].Value.ToString();
            CI_Cesta.NomItem = dgvStock.CurrentRow.Cells[1].Value.ToString();
            int id = Convert.ToInt32(ide);
            CI_Cesta.Id = id;
            
            Modal_Add_Cart a = new Modal_Add_Cart();
            a.ShowDialog();
            refrescar();*/
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            /*String ID_C = dgvCart.CurrentRow.Cells[0].Value.ToString();
            int ide = Convert.ToInt32(ID_C);
            abrirConexion();
            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = conn;
            objCmd.CommandText = "quitaritem";
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.Parameters.Add("id_item", OracleDbType.Int32).Value = ide;
            objCmd.Parameters.Add("id_tienda", OracleDbType.Int32).Value = 1;
            //objCmd.Parameters.Add("cant", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
            try
            {
                objCmd.ExecuteNonQuery();
                //Principal m = new Principal();
                //m.ShowDialog();
                //this.Hide();
                //MessageBox.Show(ide);
                //System.Console.WriteLine("Number of employees in department 20 is {0}", objCmd.Parameters["pout_count"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al al procesar quitar datos de cart");
            }
            refrescar();*/
        }

        private void btnAgregarItems_Click(object sender, EventArgs e)
        {
            frmModalGO aw = new frmModalGO();
            aw.ShowDialog();
            
        }
        public void regisventa()
        {
            /*string id_cli,id_user;
            string usuario = CI_Venta.Usuar;
            int tienda = 1;
            OracleCommand cmdu = new OracleCommand("select usuario_id from usuarios where usuario = '"+usuario+"'", conn);
            id_user = (cmdu.ExecuteScalar()).ToString();
            id_cli = CI_Cliente.Id_cli;

            try
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = conn;
                objCmd.CommandText = "save_sales";//id_us in number,id_cl in number,id_ti in number
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("id_us", OracleDbType.Int32).Value = int.Parse(id_user);
                objCmd.Parameters.Add("id_cl", OracleDbType.Int32).Value = int.Parse(id_cli);
                objCmd.Parameters.Add("id_ti", OracleDbType.Int32).Value = tienda;
                //MessageBox.Show(id_user+" "+id_cli+" "+1);
                objCmd.ExecuteNonQuery();
                registrodetVenta();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio error al registrar ventas");
            }
            */
        }

        public void registrodetVenta()
        {
           /* //abrirConexion();
            refrescar();
            try
            {
                OracleCommand cmd1 = new OracleCommand("select max(venta_id) from ventas", conn);
                string id_venta = (cmd1.ExecuteScalar()).ToString();
                
                for (int i = 0; i < dgvCart.Rows.Count; i++)
                {
                    OracleCommand cmd = new OracleCommand("INSERT INTO det_ventas VALUES('" + dgvCart.Rows[i].Cells[0].Value + "','" + Convert.ToInt32(id_venta) + "','" + dgvCart.Rows[i].Cells[2].Value + "')", conn);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show(dgvCart.Rows[i].Cells[0].Value+" "+ Convert.ToInt32(id_venta) + " " + dgvCart.Rows[i].Cells[2].Value);
                    
                    //conn.Close();
                }
                OracleCommand cmd2 = new OracleCommand("DELETE cesta WHERE cliente_id = 1", conn);
                cmd2.ExecuteNonQuery();
                dgvCart.Rows.Clear();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Ocurrio un error");
            }
            refrescar();
            */
        }

        private void UC_Inicio_Click(object sender, EventArgs e)
        {
            refrescar();
        }

        private void txtSearchA_OnTextChange(object sender, EventArgs e)
        {
            
        }

        private void txtSearchA_Click(object sender, EventArgs e)
        {
            txtSearchA.text = "";
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchA.text.Trim()) == false)
            {
                try
                {
                    //datosBuscados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error al buscar datos");
                }
            }
        }
        private void datosBuscados()
        {
            /*
            List<CI_Stock> Lista = new List<CI_Stock>();
            using (OracleCommand command = new OracleCommand())
            {
                StringBuilder Query = new StringBuilder();

                Query.Append("select s.item_id, i.nombre,m.nombre, cantidad from stock s, items i,marcas m where i.marca_id = m.marca_id and s.item_id = i.item_id and i.nombre like('%" + txtSearchA.text.Trim() + "%')");

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = Query.ToString();

                OracleDataReader reader = null;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CI_Stock obj = new CI_Stock();
                    obj.Id_Item = Convert.ToInt32(reader["item_id"]);
                    obj.Nombre = reader["nombre"].ToString();
                    obj.Marca = reader["nombre"].ToString();
                    obj.Cantidad = Convert.ToInt32(reader["cantidad"]);
                    Lista.Add(obj);
                }
            }
            //MessageBox.Show(Lista.OrderBy(b => b.Id_Item).ToList()+"");
            dgvStock.Rows.Clear();
            dgvStock.DataSource = Lista.OrderBy(b => b.Id_Item).ToList();
            */
        }
        /*private void keypressed(Object o, KeyPressEventArgs e)
{
   // The keypressed method uses the KeyChar property to check 
   // whether the ENTER key is pressed. 

   // If the ENTER key is pressed, the Handled property is set to true, 
   // to indicate the event is handled.
   if (e.KeyChar == (char)Keys.Return)
   {
       e.Handled = true;
       MessageBox.Show("Presionaste una tecla enter");
   }
}*/

    }
}
/*
if (MessageBox.Show("¿Está seguro de realizar la venta?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string a = CI_Clientes.Id_cli;
                for(int i = 0; i < dgvCart.Rows.Count; i++)
                {
                    OracleCommand cmd = new OracleCommand("INSERT INTO det_ventas VALUES('"+dgvCart.Rows[i].Cells[0].Value+"','"+ Convert.ToInt32(a) + "','"+dgvCart.Rows[i].Cells[2].Value+"')",conn);
                    cmd.ExecuteNonQuery();
                    //conn.Close();
                    //MessageBox.Show(dgvCart.Rows[i].Cells[0].Value+" " +Convert.ToInt32(a) +" "+ dgvCart.Rows[i].Cells[2].Value);
                }
                dgvCart.Rows.Clear();
                
            }
*/
