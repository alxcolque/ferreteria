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
    public partial class frmAgregarItem : Form
    {
        OracleConnection conn = null;
        public frmAgregarItem()
        {
            InitializeComponent();
            llenarCaja();
            //string a = CI_Items.Id_It;
            //MessageBox.Show(a);
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
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnGuardarArticulos_Click(object sender, EventArgs e)
        {
            string a = CI_Items.Id_Tipo;
            string b = CI_Items.Id_Marca;
            /****LLemar datos****/
            //llenarCaja();
            regisItem(a,b);
            this.Close();
            
        }

        private void llenarCaja()
        {
            string i = CI_Items.Id_It;
            if (int.Parse(i) == 0)
            {
                lblTitleItem.Text = "NUEVO ARTICULO";
                txtArt.Text = "";
                txtCod.Text = "";
                txtPrecio.Text = "";
            }
            else
            {
                lblTitleItem.Text = "MODIFICAR ARTICULO";
                txtArt.Text = CI_Items.Nom;
                txtCod.Text = CI_Items.I_Cod;
                txtPrecio.Text = CI_Items.Prec;
            }
            
        }

        public void regisItem(string tipo, string marca)
        {
            abrirConexion();
            
            try
            {
                string i =  CI_Items.Id_It;
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = conn;
                objCmd.CommandText = "add_items";//nomt in number,nomm in number, precio in number
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("idi", OracleDbType.Varchar2).Value = i;
                objCmd.Parameters.Add("nom", OracleDbType.Varchar2).Value = txtArt.Text;
                objCmd.Parameters.Add("cod", OracleDbType.Varchar2).Value = txtCod.Text;
                objCmd.Parameters.Add("nomt", OracleDbType.Int32).Value = int.Parse(tipo);
                objCmd.Parameters.Add("nomm", OracleDbType.Int32).Value = int.Parse(marca);
                objCmd.Parameters.Add("precio", OracleDbType.Double).Value = double.Parse(txtPrecio.Text);
                //objCmd.Parameters.Add("id_cliente", OracleDbType.Int32).Value = 1;
                //objCmd.Parameters.Add("cant", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
                //MessageBox.Show(txtArt.Text + txtCod.Text + int.Parse(tipo)+"-"+int.Parse(marca)+"-" +int.Parse(txtPrecio.Text));
                objCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al registrar  articulos");
            }
            txtArt.Text = "";
            txtCod.Text = "";
            txtPrecio.Text = "";
            this.Close();
            conn.Close();
        }

        private void frmAgregarItem_Load(object sender, EventArgs e)
        {
            abrirConexion();
            lst_cmbx1();
            //abrirConexion();
            lst_cmbx2();
        }

        private void lst_cmbx1()
        {
            
            DataSet ds1 = new DataSet();
            OracleCommand cmd = new OracleCommand("select * from tipos", conn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds1);
            cmbxTipo.DataSource = ds1.Tables[0];
            cmbxTipo.DisplayMember = "nombre";
            cmbxTipo.ValueMember = "tipo_id";
            //txtID_Clie.Text = cmbxTipo.SelectedValue.ToString();
            CI_Items.Id_Tipo = cmbxTipo.SelectedValue.ToString();
        }
        private void lst_cmbx2()
        {
            DataSet ds1 = new DataSet();
            OracleCommand cmd = new OracleCommand("select * from marcas", conn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds1);
            cmbxMarca.DataSource = ds1.Tables[0];
            cmbxMarca.DisplayMember = "nombre";
            cmbxMarca.ValueMember = "marca_id";
            CI_Items.Id_Marca = cmbxMarca.SelectedValue.ToString();
        }

        private void cmbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbxTipo.SelectedValue != null)
                {
                    CI_Items.Id_Tipo = cmbxTipo.SelectedValue.ToString();
                    //MessageBox.Show(txtID_Clie.Text);

                }
                //MessageBox.Show(clie);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error de obtener id del cliente");
            }
        }

        private void cmbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbxMarca.SelectedValue != null)
                {
                    CI_Items.Id_Marca = cmbxMarca.SelectedValue.ToString();
                    //MessageBox.Show(txtID_Clie.Text);

                }
                //MessageBox.Show(clie);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error de obtener id del cliente");
            }
        }
    }
}
