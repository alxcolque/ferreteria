using ferreteria_x_2019.Config;
using ferreteria_x_2019.Controlador;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.InteropServices;

namespace ferreteria_x_2019
{
    public partial class Form1 : Form
    {
        internal static OracleConnection conexion = null;
        string conexionstring = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        //string conexionstring = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            
        }
        public void btnAcceder_Click(object sender, EventArgs e)
        {
            //this.Hide();
            OracleConnection conexion = new OracleConnection(conexionstring);
            conexion.Open();
            String sql = "SELECT * FROM usuarios WHERE usuario='" + txtUsuario.Text + "' AND clave='" + txtPassword.Text + "'";
            
            OracleDataAdapter datos = new OracleDataAdapter(sql, conexion);
            
            string username = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("El usuario y el password son datos requeridos");
            }
            else
            {
                DataSet data = new DataSet();
                datos.Fill(data);
                string ci = "";
                int usu = data.Tables[0].Rows.Count;
                if (usu == 1)
                {
                    CI_Ventas.Usuar = username;
                    for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                    {
                        ci = data.Tables[0].Rows[i][0].ToString();
                    }
                    Principal m = new Principal();
                    m.ci = ci;
                    m.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acceso denegad@. Puede que usuario sea XXX","Hola Sujeto No identificado");
                }
                conexion.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
