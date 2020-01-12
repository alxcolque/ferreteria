using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Configuration;

namespace ferreteria_x_2019.Config
{
    public class Conexion_DB
    {
        internal static OracleConnection conexion = null;
        string conexionstring = ConfigurationManager.ConnectionStrings ["conexion"].ConnectionString;
        public void conectar()
        {
            OracleConnection conexion = new OracleConnection(conexionstring);
            conexion.Open();
            System.Windows.Forms.MessageBox.Show("Conexion exitosa");
        }
    }
}
