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
    public partial class frmModalGO : Form
    {
        OracleConnection conn = null;
        public frmModalGO()
        {
            
            InitializeComponent();
        }

        

        private void frmModalGO_Load(object sender, EventArgs e)
        {
            lst_cmbx();
        }
        public void lst_cmbx()
        {
            string conexionstring = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            conn = new OracleConnection(conexionstring);
            conn.Open();
            DataSet ds1 = new DataSet();
            OracleCommand cmd = new OracleCommand("select * from clientes", conn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds1);
            comboBoxCliente.DataSource = ds1.Tables[0];
            comboBoxCliente.DisplayMember = "nombre";
            comboBoxCliente.ValueMember = "cliente_id";
            txtID_Clie.Text = comboBoxCliente.SelectedValue.ToString();
            CI_Cliente.Id_cli = txtID_Clie.Text;
        }
        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            UC_Inicio.UC_Inicio obj = new UC_Inicio.UC_Inicio();

            obj.regisventa();
            
            this.Dispose();
        }

        private void btnCancelarOrden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string clie;
                if (comboBoxCliente.SelectedValue != null)
                {
                    clie = comboBoxCliente.SelectedValue.ToString();
                    txtID_Clie.Text = clie;
                    //MessageBox.Show(txtID_Clie.Text);

                }
                CI_Cliente.Id_cli = txtID_Clie.Text;
                //MessageBox.Show(clie);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error de obtener id del cliente");
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            CI_Cliente.Id_cli = "0";
            try
            {
                frmRegistoCliente ar = new frmRegistoCliente();
                ar.ShowDialog();
                lst_cmbx();
            }
            catch (Exception ex)
            {
                lst_cmbx();
            }
        }
    }
    
}
