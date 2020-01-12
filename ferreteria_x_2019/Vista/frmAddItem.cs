using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ferreteria_x_2019.Controlador;

namespace ferreteria_x_2019.Vista
{
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Mover la ventana con el raton
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void insert_item()
        {
            try
            {

                if (string.IsNullOrEmpty(txtItem.Text) || string.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Antes de insertar llene los campos vacíos.");
                }
                else
                {
                    CI_Item.Nombre_Item = txtItem.Text;
                    CI_Item.Precio = txtPrecio.Text;


                    CI_Item obj = new CI_Item();
                    obj.insertItem();
                    txtItem.Text = "";
                    txtPrecio.Text = "";
                }
                //listar_tipo();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar Tipo");
            }

        }
        public void act_item()
        {
            try
            {

                if (string.IsNullOrEmpty(txtItem.Text) || string.IsNullOrEmpty(txtPrecio.Text) )
                {
                    MessageBox.Show("Antes de actualizar llene los campos vacíos.");
                }
                else
                {

                    CI_Item.Nombre_Item = txtItem.Text;
                    CI_Item.Precio = txtPrecio.Text;

                    CI_Item obj = new CI_Item();
                    obj.updItem();
                    txtItem.Text = "";
                    txtPrecio.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar Tipo");
            }
        }
        private void btnGuardarItem_Click(object sender, EventArgs e)
        {
            if (lblTitleItem.Text == "NUEVO ARTICULO")
            {
                insert_item();
            }
            else
            {
                act_item();
            }
        }
        public void llenarform()
        {
            string i = CI_Item.Id_Item;
            if (int.Parse(i) == 0)
            {
                lblTitleItem.Text = "NUEVO ARTICULO";
            }
            else
            {
                lblTitleItem.Text = "MODIFICAR ARTICULO";
                txtItem.Text = CI_Item.Nombre_Item;
                txtPrecio.Text = CI_Item.Precio;
            }
        }
        private void cmbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxTipo.SelectedValue != null)
            {
                CI_Item.Id_Tipo = cmbxTipo.SelectedValue.ToString();
                //MessageBox.Show(CC_Item.Id_Tipo);
            }
        }
        private void cmbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxTipo.SelectedValue != null)
            {
                CI_Item.Id_Tipo = cmbxTipo.SelectedValue.ToString();
                //MessageBox.Show(CC_Item.Id_Tipo);
            }
        }

        private void pnlSuperior_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitleItem_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
