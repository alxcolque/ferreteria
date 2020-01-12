using ferreteria_x_2019.Controlador;
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
        public Form1()
        {
            InitializeComponent();
            
        }
        public void btnAcceder_Click(object sender, EventArgs e)
        {
            login();
        }
        public void login()
        {
            CI_Login.Usuario = txtUsuario.Text;
            CI_Login.Clave = txtPassword.Text;
            CI_Login obj = new CI_Login();
            obj.resp();

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
