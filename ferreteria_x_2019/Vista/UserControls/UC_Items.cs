using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ferreteria_x_2019.Forms;
using System.Configuration;
using ferreteria_x_2019.Controlador;
using ferreteria_x_2019.Vista;

namespace ferreteria_x_2019.UC_Inicio
{
    public partial class UC_Items : UserControl
    {
        
        public UC_Items()
        {
            InitializeComponent();
            refrescar();
        }

        public void refrescar()
        {
            listar_item();
        }
        private void btnAgregarItems_Click(object sender, EventArgs e)
        {
            CI_Item.Id_Item = "0";
            frmAddItem m = new frmAddItem();
            m.ShowDialog();
        }
        public void listar_item()
        {
            try
            {

                //Tabla Tipo
                CI_Item obj = new CI_Item();
                obj.listarItems();

                DataSet dataI = new DataSet();
                (CI_Item.getItems).Fill(dataI);
                dgvItems.AllowUserToAddRows = false;
                dgvItems.Rows.Clear();
                for (int i = 0; i < dataI.Tables[0].Rows.Count; i++)
                {
                    dgvItems.Rows.Add(
                    dataI.Tables[0].Rows[i][0],
                    dataI.Tables[0].Rows[i][1],
                    dataI.Tables[0].Rows[i][2],
                    dataI.Tables[0].Rows[i][3],
                    dataI.Tables[0].Rows[i][4]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar Items");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CI_Item.Id_Item = dgvItems.CurrentRow.Cells[0].Value.ToString();
            CI_Item.Nombre_Item = dgvItems.CurrentRow.Cells[1].Value.ToString();
            CI_Item.Precio = dgvItems.CurrentRow.Cells[2].Value.ToString();


            using (frmAddItem uf = new frmAddItem())
            {
                uf.ShowDialog();
                //refrescar();
            }
            listar_item();

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            CI_Item.Id_Item = dgvItems.CurrentRow.Cells[0].Value.ToString();
            CI_Item obj = new CI_Item();
            obj.elimItem();
            listar_item();
        }

        private void lblMarcas_Click(object sender, EventArgs e)
        {
            using (frmMarca uf = new frmMarca())
            {
                uf.ShowDialog();
            }
        }

        private void lblTipos_Click(object sender, EventArgs e)
        {
            using (frmMarca uf = new frmMarca())
            {
                uf.ShowDialog();
            }
        }

        /*private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }*/
    }
}
