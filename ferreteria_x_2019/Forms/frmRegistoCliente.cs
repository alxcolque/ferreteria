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
using ferreteria_x_2019.Forms;

namespace ferreteria_x_2019.Forms
{
    public partial class frmRegistoCliente : Form
    {
        internal static OracleConnection conn = null;
        public frmRegistoCliente()
        {
            InitializeComponent();
            llenarForm();
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

        private void llenarForm()
        {
            string i = CI_Clientes.Id_cli;
            if (int.Parse(i) == 0)
            {
                lblTitle.Text = "NUEVO CLIENTE";
                txtNombreCli.Text = "";
                txtTel.Text = "";
            }
            else
            {
                lblTitle.Text = "MODIFICAR MODIFICAR";
                txtNombreCli.Text = CI_Clientes.NomC;
                txtTel.Text = CI_Clientes.TelC;
            }

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerraVentana();
        }
        public void cerraVentana()
        {
            this.Dispose();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            abrirConexion();
            string idc = CI_Clientes.Id_cli;
            string nom = txtNombreCli.Text;
            string tel = txtTel.Text;
            try
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = conn;
                objCmd.CommandText = "add_client";
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add("idc", OracleDbType.Int32).Value = idc;
                objCmd.Parameters.Add("nom", OracleDbType.Varchar2).Value = nom;
                objCmd.Parameters.Add("tel", OracleDbType.Varchar2).Value = tel;
                //objCmd.Parameters.Add("id_cliente", OracleDbType.Int32).Value = 1;
                //objCmd.Parameters.Add("cant", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
                //MessageBox.Show(idc+"---"+nom+"---"+tel);
                objCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al registrar  cliente");
            }
            
            conn.Close();
            this.Dispose();
        }
    }
}
