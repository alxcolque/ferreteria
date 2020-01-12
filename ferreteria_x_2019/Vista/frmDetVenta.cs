using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ferreteria_x_2019.Forms;
using Oracle.DataAccess.Client;
using System.Configuration;
using Oracle.DataAccess.Types;
using ferreteria_x_2019.Controlador;

namespace ferreteria_x_2019.Forms
{
    public partial class frmDetVenta : Form
    {
        OracleConnection conn = null;
        public frmDetVenta()
        {
            InitializeComponent();
            detalles();
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

        private void detalles()
        {
            llenart();
            abrirConexion();
            lblID_Venta.Text = CI_Venta.Id_V;
            OracleCommand cmd1 = new OracleCommand("(select c.nombre from ventas v, clientes c where v.cliente_id = c.cliente_id and venta_id ='" + CI_Venta.Id_V + "')", conn);
            lblNombreCli.Text = (cmd1.ExecuteScalar()).ToString();
            OracleCommand cmd2 = new OracleCommand("(select sum(cantidad*precio) from det_ventas d, items i where d.item_id = i.item_id and venta_id='" + CI_Venta.Id_V + "')", conn);
            lblMontoTotal.Text = (cmd2.ExecuteScalar()).ToString();//select fecha_venta from ventas where venta_id = 20;
            OracleCommand cmd3 = new OracleCommand("(select fecha_venta from ventas where venta_id = '" + CI_Venta.Id_V + "')", conn);
            lblFecha.Text = (cmd3.ExecuteScalar()).ToString();
            conn.Close();
        }
        private void llenart()
        {
            abrirConexion();
            dgvMa.Rows.Clear();
            dgvMa.AllowUserToAddRows = false;
            DataSet ds = new DataSet();
            try
            {

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "list_det_ventas";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("id", OracleDbType.Int32).Value = CI_Venta.Id_V;
                    cmd.Parameters.Add("resul", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    //MessageBox.Show(CI_Ventas.Id_V);
                    //objCmd.Parameters.Add("precio", OracleDbType.Double).Value = double.Parse(txtPrecio.Text);
                    //objCmd.Parameters.Add("cant", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
                    //MessageBox.Show(txtArt.Text + txtCod.Text + int.Parse(tipo)+"-"+int.Parse(marca)+"-" +int.Parse(txtPrecio.Text));
                    
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(ds);
                }
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dgvMa.Rows.Add(
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
