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
using Oracle.DataAccess.Types;
using ferreteria_x_2019.Controlador;
using ferreteria_x_2019.Forms;

namespace ferreteria_x_2019.UC_Inicio
{
    public partial class UC_Inventario : UserControl
    {
        OracleConnection conn = null;
        public UC_Inventario()
        {
            InitializeComponent();
            listac();
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
        public void listac()
        {
            abrirConexion();
            dgvClientes.Rows.Clear();
            dgvClientes.AllowUserToAddRows = false;
            DataSet ds = new DataSet();
            try
            {

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "list_clientes";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("resul", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(ds);
                }
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dgvClientes.Rows.Add(
                            ds.Tables[0].Rows[i][0],
                            ds.Tables[0].Rows[i][1],
                            ds.Tables[0].Rows[i][2]
                        );
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                CI_Cliente.Id_cli = "0";
                using (frmRegistoCliente t = new frmRegistoCliente())
                {
                    t.ShowDialog();
                    listac();
                }
            }
            catch (Exception ex)
            {
                listac();
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                CI_Cliente.Id_cli = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                CI_Cliente.NomC = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                CI_Cliente.TelC = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                //MessageBox.Show(ide+nom+ic+tipo+marca+prec);
                using (frmRegistoCliente r = new frmRegistoCliente())
                {
                    r.ShowDialog();
                }
                listac();
            }
            catch (Exception ex) {
                listac();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            abrirConexion();
            string ide = dgvClientes.CurrentRow.Cells[0].Value.ToString();//select nombre from items where item_id=1;
            OracleCommand cmdu = new OracleCommand("select nombre from clientes where cliente_id='" + int.Parse(ide) + "'", conn);
            string nomb = (cmdu.ExecuteScalar()).ToString();
            if (MessageBox.Show("¿Desea eliminar al cliente " + nomb + "?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    OracleCommand cmd2 = new OracleCommand("DELETE clientes WHERE cliente_id = '" + int.Parse(ide) + "'", conn);
                    cmd2.ExecuteNonQuery();
                    //MessageBox.Show("Yes "+a);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Se puede eliminar Porque es parte de un registro");
                }

                listac();

            }
        }
    }
}
