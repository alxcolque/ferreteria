using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Configuration;
using ferreteria_x_2019.Modelo;
using Oracle.DataAccess.Types;
using ferreteria_x_2019.Controlador;
using ferreteria_x_2019.Forms;
using Bunifu;

namespace ferreteria_x_2019.UC_Inicio
{
    public partial class UC_Ventas : UserControl
    {
        OracleConnection conn = null;
        public UC_Ventas()
        {
            InitializeComponent();
            reporteVentas();
        }

        private void reporteVentas()
        {
            abrirConexion();
            dgvVentas.Rows.Clear();
            dgvVentas.AllowUserToAddRows = false;
            DataSet ds = new DataSet();
            try
            {

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "list_ventas";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("resul", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(ds);
                }
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dgvVentas.Rows.Add(
                            ds.Tables[0].Rows[i][0],
                            ds.Tables[0].Rows[i][1],
                            ds.Tables[0].Rows[i][2],
                            ds.Tables[0].Rows[i][3]
                        );
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void abrirConexion()
        {
            string conexionstring = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            conn = new OracleConnection(conexionstring);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion");
                throw new Exception("Error !!!");
            }
        }

        private void btnDV_Click(object sender, EventArgs e)
        {
            String ide = dgvVentas.CurrentRow.Cells[0].Value.ToString();
            CI_Venta.Id_V = ide;
            using (frmDetVenta uf = new frmDetVenta())
            {
                uf.ShowDialog();
            }
        }

        private void btnVaciarVenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro quiere vaciar las ventas?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    abrirConexion();
                    OracleCommand cmd = new OracleCommand("DELETE det_ventas", conn);
                    cmd.ExecuteNonQuery();
                    OracleCommand cmd1 = new OracleCommand("DELETE ventas", conn);
                    cmd1.ExecuteNonQuery();
                    //MessageBox.Show("Yes "+a);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Se puede eliminar Porque es parte de un registro");
                }

                reporteVentas();

            }
        }
    }
}
/*
List<CI_Ventas> Lista = new List<CI_Ventas>();
            using (OracleCommand command = new OracleCommand())
            {
                StringBuilder Query = new StringBuilder();

                Query.Append("select d.venta_id,i.nombre, c.nombre, fecha_venta, cantidad, total from ventas v, clientes c, det_ventas d, items i where c.cliente_id = v.cliente_id and v.venta_id = d.venta_id and d.item_id = i.item_id order by 4;");

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = Query.ToString();

                OracleDataReader reader = null;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CI_Ventas obj = new CI_Ventas();
                    obj.Venta_Id = Convert.ToInt32(reader["venta_id"]);
                    obj.Nom_Ar = reader["nombre"].ToString();
                    obj.Nom_Cl = reader["nombre"].ToString();
                    obj.Fecha_Venta = Convert.ToDateTime(reader["fecha_venta"]);
                    obj.Cant = Convert.ToInt32(reader["cantidad"]);
                    obj.Tot = Convert.ToInt32(reader["total"]);
                    
                    Lista.Add(obj);
                }
            }
            dgvVentas.DataSource = Lista.OrderBy(b => b.Venta_Id).ToList();
    */
