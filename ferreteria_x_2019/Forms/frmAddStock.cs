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
using ferreteria_x_2019.Modelo;
using Oracle.DataAccess.Types;
using ferreteria_x_2019.Controlador;
namespace ferreteria_x_2019.Forms
{
    public partial class frmAddStock : Form
    {
        OracleConnection conn = null;
        public frmAddStock()
        {
            InitializeComponent();
            
            comprobar();
            //lst_cmbx1();
        }

        private void comprobar()
        {
            txtCant.Text = CI_Stock.Cant;
            /*abrirConexion();
            //refrescar();select count(item_id) from stock where item_id = idi;
            try
            {
                string a = CI_Stock.Id_It;
                OracleCommand cmd1 = new OracleCommand("select count(item_id) from stock where item_id = '" + a + "'", conn);
                string up = (cmd1.ExecuteScalar()).ToString();
                if (int.Parse(up) == 1)
                {
                    txtCant.Text = CI_Stock.Cant;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error");
            }*/
            //refrescar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                conn.Close();
                MessageBox.Show("Error de conexion");
                throw new Exception("Error !!!");
            }
        }
        
        private void frmAddStock_Load(object sender, EventArgs e)
        {
            //abrirConexion();
            //lst_cmbx1();
        }

        private void lst_cmbx1()
        {
            abrirConexion();
            DataSet ds1 = new DataSet();
            OracleCommand cmd = new OracleCommand("select * from items", conn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds1);
            cmbxArt.DataSource = ds1.Tables[0];
            cmbxArt.DisplayMember = "nombre";
            cmbxArt.ValueMember = "item_id";
            CI_Stock.Id_It = cmbxArt.SelectedValue.ToString();
            //MessageBox.Show(CI_Stock.Id_It);

        }

        private void cmbxArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //CI_Stock.Id_It = cmbxArt.SelectedValue.ToString();
            try
            {
                if (cmbxArt.SelectedValue != null)
                {
                    CI_Stock.Id_It = cmbxArt.SelectedValue.ToString();
                    
                    //string a = CI_Stock.Id_It;MessageBox.Show(a);



                }
                //MessageBox.Show(clie);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error de obtener id del cliente");
            }
        }

        private void guardar()
        {
            abrirConexion();

            try
            {
                string i = CI_Stock.Id_It;
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = conn;
                objCmd.CommandText = "crud_stock";//nomt in number,nomm in number, precio in number
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("idi", OracleDbType.Int32).Value = i;
                objCmd.Parameters.Add("idt", OracleDbType.Int32).Value = 1;//tienda
                objCmd.Parameters.Add("cant", OracleDbType.Int32).Value = txtCant.Text;
                //MessageBox.Show(i);
                //objCmd.Parameters.Add("precio", OracleDbType.Double).Value = double.Parse(txtPrecio.Text);
                //objCmd.Parameters.Add("cant", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
                //MessageBox.Show(txtArt.Text + txtCod.Text + int.Parse(tipo)+"-"+int.Parse(marca)+"-" +int.Parse(txtPrecio.Text));
                objCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al registrar  stock");
            }
            this.Close();
            conn.Close();
        }

        private void btnGuardarStock_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void cmbxArt_Click(object sender, EventArgs e)
        {
            lst_cmbx1();
        }
    }
}
