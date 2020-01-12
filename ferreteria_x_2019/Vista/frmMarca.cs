using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Configuration;
using Oracle.DataAccess.Types;
using ferreteria_x_2019.Controlador;

namespace ferreteria_x_2019.Forms
{
    public partial class frmMarca : Form
    {
        OracleConnection conn = null;
        public frmMarca()
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

        private void refrescar()
        {
            llenarM();
            llenarT();
        }
        public void llenarM()
        {
            abrirConexion();
            List<CI_Marca> listaT = new List<CI_Marca>();
            using (OracleCommand command = new OracleCommand())
            {
                StringBuilder Query = new StringBuilder();

                Query.Append("select * from marcas;");

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = Query.ToString();

                OracleDataReader reader = null;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CI_Marca obj = new CI_Marca();
                    obj.M_Id = Convert.ToInt32(reader["marca_id"]);
                    obj.Nombre = reader["nombre"].ToString();
                    listaT.Add(obj);
                }
            }
            dgvMa.DataSource = listaT.OrderBy(b => b.M_Id).ToList();
        }
        public void llenarT()
        {
            //dgvMa.Rows.Clear();
            abrirConexion();
            List<CI_Items> listaT = new List<CI_Items>();
            using (OracleCommand command = new OracleCommand())
            {
                StringBuilder Query = new StringBuilder();

                Query.Append("select * from tipos;");

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = Query.ToString();

                OracleDataReader reader = null;
                command.Connection = conn;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CI_Items obj = new CI_Items();
                    obj.T_Id = Convert.ToInt32(reader["tipo_id"]);
                    obj.Nombre = reader["nombre"].ToString();
                    listaT.Add(obj);
                }
            }
            dgvTi.DataSource = listaT.OrderBy(b => b.T_Id).ToList();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNewM_Click(object sender, EventArgs e)
        {
            CI_Items.Idm="0";
            crudMarca();
            conn.Close();
        }
        public void crudMarca()
        {
            abrirConexion();
            
            try
            {
                string i = CI_Items.Idm; //MessageBox.Show(i);
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = conn;
                objCmd.CommandText = "crud_marca";//nomt in number,nomm in number, precio in number
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("idm", OracleDbType.Varchar2).Value = i;
                objCmd.Parameters.Add("nomm", OracleDbType.Varchar2).Value = txtMarca.Text;
                //objCmd.Parameters.Add("id_cliente", OracleDbType.Int32).Value = 1;
                //objCmd.Parameters.Add("cant", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
                //MessageBox.Show(txtArt.Text + txtCod.Text + int.Parse(tipo)+"-"+int.Parse(marca)+"-" +int.Parse(txtPrecio.Text));
                objCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al registrar  Marca");
            }
            refrescar();
        }

        private void btnUptM_Click(object sender, EventArgs e)
        {
            String ide = dgvMa.CurrentRow.Cells[0].Value.ToString();
            CI_Items.Idm = ide;
            
            crudMarca();
            conn.Close();
            refrescar();
        }

        private void dgvMa_SelectionChanged(object sender, EventArgs e)
        {
            btnUptM.Enabled = true;
            String nom = dgvMa.CurrentRow.Cells[1].Value.ToString();
            CI_Items.NomM = nom;
            txtMarca.Text = nom;
        }

        private void btnElimM_Click(object sender, EventArgs e)
        {
            abrirConexion();
            String ide = dgvMa.CurrentRow.Cells[0].Value.ToString();
            OracleCommand cmdu = new OracleCommand("select nombre from marcas where marca_id='" + int.Parse(ide) + "'", conn);
            string nomb = (cmdu.ExecuteScalar()).ToString();
            if (MessageBox.Show("¿Va a eliminar " + nomb + "?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    OracleCommand cmd2 = new OracleCommand("DELETE marcas WHERE marca_id = '" + int.Parse(ide) + "'", conn);
                    cmd2.ExecuteNonQuery();
                    //MessageBox.Show("Yes "+a);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Se puede eliminar Porque es parte de un registro");
                }

                refrescar();

            }
            conn.Close();
        }

        private void btnNewT_Click(object sender, EventArgs e)
        {
            CI_Items.IdT = "0";
            crudTipo();
        }

        private void btnUptT_Click(object sender, EventArgs e)
        {
            String ide = dgvTi.CurrentRow.Cells[0].Value.ToString();
            CI_Items.IdT = ide;
            crudTipo();
            refrescar();
        }

        private void btnElimT_Click(object sender, EventArgs e)
        {
            abrirConexion();
            String ide = dgvTi.CurrentRow.Cells[0].Value.ToString();
            OracleCommand cmdu = new OracleCommand("select nombre from tipos where tipo_id='" + int.Parse(ide) + "'", conn);
            string nomb = (cmdu.ExecuteScalar()).ToString();
            if (MessageBox.Show("¿Va a eliminar " + nomb + "?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    OracleCommand cmd2 = new OracleCommand("DELETE tipos WHERE tipo_id = '" + int.Parse(ide) + "'", conn);
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

        private void dgvTi_SelectionChanged(object sender, EventArgs e)
        {
            btnUptT.Enabled = true;
            String nom = dgvTi.CurrentRow.Cells[1].Value.ToString();
            CI_Items.NomT = nom;
            txtTipo.Text = nom;
        }
        ///crud tipo
        public void crudTipo()
        {
            abrirConexion();

            try
            {
                string i = CI_Items.IdT; //MessageBox.Show(i);
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = conn;
                objCmd.CommandText = "crud_tipo";//nomt in number,nomm in number, precio in number
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("idt", OracleDbType.Varchar2).Value = i;
                objCmd.Parameters.Add("nomt", OracleDbType.Varchar2).Value = txtTipo.Text;
                //objCmd.Parameters.Add("id_cliente", OracleDbType.Int32).Value = 1;
                //objCmd.Parameters.Add("cant", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
                //MessageBox.Show(txtArt.Text + txtCod.Text + int.Parse(tipo)+"-"+int.Parse(marca)+"-" +int.Parse(txtPrecio.Text));
                objCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al registrar  Tipos");
            }
            refrescar();
        }

    }
}
/*
OracleCommand cmd2 = new OracleCommand("DELETE cesta WHERE cliente_id = 1", conn);
                cmd2.ExecuteNonQuery();
                dgvCart.Rows.Clear();
*/
