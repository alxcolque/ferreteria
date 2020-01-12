using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ferreteria_x_2019.Forms;
using Oracle.DataAccess.Client;
using System.Configuration;
using Oracle.DataAccess.Types;
using ferreteria_x_2019.Controlador;

namespace ferreteria_x_2019.UC_Inicio
{
    public partial class UC_Items : UserControl
    {
        OracleConnection conn = null;
        public UC_Items()
        {
            InitializeComponent();
            //abrirConexion();
            listai();
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
        public void refrescar()
        {
            listai();
        }
        private void btnAgregarItems_Click(object sender, EventArgs e)
        {
             CI_Items.Id_It = "0";
            using (frmAgregarItem uf = new frmAgregarItem())
            {
                uf.ShowDialog();
                refrescar();
            }
        }
        public void listai()
        {
            abrirConexion();
            dgvItems.Rows.Clear();
            dgvItems.AllowUserToAddRows = false;
            DataSet ds = new DataSet();
            try
            {
                
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "list_items";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("resul", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(ds);
                }
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dgvItems.Rows.Add(
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String ide = dgvItems.CurrentRow.Cells[0].Value.ToString();
            String nom = dgvItems.CurrentRow.Cells[1].Value.ToString();
            String ic = dgvItems.CurrentRow.Cells[2].Value.ToString();
            String tipo = dgvItems.CurrentRow.Cells[3].Value.ToString();
            String marca = dgvItems.CurrentRow.Cells[4].Value.ToString();
            String prec = dgvItems.CurrentRow.Cells[5].Value.ToString();

            CI_Items.Id_It = ide;
            CI_Items.Nom = nom;
            CI_Items.I_Cod = ic;
            CI_Items.Tipo = tipo;
            CI_Items.Marca = marca;
            CI_Items.Prec = prec;
            //MessageBox.Show(ide+nom+ic+tipo+marca+prec);
            using (frmAgregarItem uf = new frmAgregarItem())
            {
                uf.ShowDialog();
                //refrescar();
            }
            refrescar();

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            abrirConexion();
            String ide = dgvItems.CurrentRow.Cells[0].Value.ToString();//select nombre from items where item_id=1;
            CI_Items.Id_It = ide;
            OracleCommand cmdu = new OracleCommand("select nombre from items where item_id='" + int.Parse(ide) + "'", conn);
            string nomb = (cmdu.ExecuteScalar()).ToString();
            if (MessageBox.Show("¿Va a eliminar "+nomb+"?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string a = CI_Items.Id_It;
                    OracleCommand cmd2 = new OracleCommand("DELETE items WHERE item_id = '" + int.Parse(a) + "'", conn);
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

        private void lblMarcas_Click(object sender, EventArgs e)
        {
            using (frmMarca uf = new frmMarca())
            {
                uf.ShowDialog();
            }
        }

        private void lblTipos_Click(object sender, EventArgs e)
        {
            using (frmMarca uf = new frmMarca())
            {
                uf.ShowDialog();
            }
        }
    }
}
