using System;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Configuration;
using ferreteria_x_2019.Controlador;
namespace ferreteria_x_2019.Forms
{
    public partial class Modal_Add_Cart : Form
    {
        OracleConnection conn = null;
        public Modal_Add_Cart()
        {
            InitializeComponent();
        }
        private void Modal_Add_Cart_Load(object sender, EventArgs e)
        {
            lblItemsSel.Text = CI_Cesta.NomItem;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender,EventArgs e)
        {
            string conexionstring = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            conn = new OracleConnection(conexionstring);
            conn.Open();//select cantidad from stock where item_id = id_item;
            
            OracleCommand cmd1 = new OracleCommand("select cantidad from stock where item_id ='" + CI_Cesta.Id + "'", conn);
            string cant = (cmd1.ExecuteScalar()).ToString();
            if (int.Parse(cant)<int.Parse(txtCantidad.Text))
            {
                MessageBox.Show("Añada sotock o cambie la cantidad a ordenar ","¡Stock es insuficiente!");
                //MessageBox.Show("¿Va a eliminar " + nomb + "?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes
            }
            else
            {
                //MessageBox.Show("Correcto se puede ejecutar");
                ejecutar();
            }

            conn.Close();
        }

        private void ejecutar()
        {
            int ide = CI_Cesta.Id;
            int can = Int32.Parse(txtCantidad.Text);

            string conexionstring = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            conn = new OracleConnection(conexionstring);
            conn.Open();

            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = conn;
            objCmd.CommandText = "addtocart";
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.Parameters.Add("id_item", OracleDbType.Int32).Value = ide;
            objCmd.Parameters.Add("cant", OracleDbType.Int32).Value = can;
            objCmd.Parameters.Add("id_cliente", OracleDbType.Int32).Value = 1;
            //objCmd.Parameters.Add("cant", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
            try
            {
                objCmd.ExecuteNonQuery();
                //this.Refresh();
                //MessageBox.Show(ide);
                //System.Console.WriteLine("Number of employees in department 20 is {0}", objCmd.Parameters["pout_count"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Procesar");
            }
            conn.Close();
            this.Dispose();
        }

        private void btnCancelarOrden_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
