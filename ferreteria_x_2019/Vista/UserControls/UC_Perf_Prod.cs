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
    public partial class UC_Perf_Prod : UserControl
    {
        OracleConnection conn = null;
        public UC_Perf_Prod()
        {
            InitializeComponent();
            refrescar();
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
        //Lista stock
        private void refrescar()
        {
            listaStk();
        }
        public void listaStk()
        {
            abrirConexion();
            dgvStock.Rows.Clear();
            dgvStock.AllowUserToAddRows = false;
            DataSet ds = new DataSet();
            try
            {

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "list_stock";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("resul", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(ds);
                }
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dgvStock.Rows.Add(
                            ds.Tables[0].Rows[i][0],
                            ds.Tables[0].Rows[i][1],
                            ds.Tables[0].Rows[i][2],
                            ds.Tables[0].Rows[i][3],
                            ds.Tables[0].Rows[i][4],
                            ds.Tables[0].Rows[i][5]
                        );
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            abrirConexion();
            OracleCommand cmd = new OracleCommand("select count(*) from stock", conn);
            string co = (cmd.ExecuteScalar()).ToString();
            if (int.Parse(co) == 0)
            {
                CI_Stock.Id_It = "0";
                using (frmAddStock uf = new frmAddStock())
                {
                    uf.ShowDialog();
                    refrescar();
                }
            }
            else
            {
                CI_Stock.Id_It = dgvStock.CurrentRow.Cells[0].Value.ToString();
                CI_Stock.Cant = dgvStock.CurrentRow.Cells[2].Value.ToString();
                using (frmAddStock uf = new frmAddStock())
                {
                    uf.ShowDialog();
                    refrescar();
                }
            }
            conn.Close();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            abrirConexion();
            String ide = dgvStock.CurrentRow.Cells[0].Value.ToString();//select nombre from items where item_id=1;
            CI_Item.Id_It = ide;
            OracleCommand cmdu = new OracleCommand("select nombre from items where item_id='" + int.Parse(ide) + "'", conn);
            string nomb = (cmdu.ExecuteScalar()).ToString();
            if (MessageBox.Show("¿Va a eliminar " + nomb + "?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string a = CI_Item.Id_It;
                    OracleCommand cmd2 = new OracleCommand("DELETE stock WHERE item_id = '" + int.Parse(a) + "'", conn);
                    cmd2.ExecuteNonQuery();
                    //MessageBox.Show("Yes "+a);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Se puede eliminar Porque es parte de un registro");
                }

                refrescar();

            }
        }

        private void dgvStock_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
