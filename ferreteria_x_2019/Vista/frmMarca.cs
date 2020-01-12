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
using ferreteria_x_2019.Controlador;

namespace ferreteria_x_2019.Forms
{
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
            refrescar();
        }

        private void refrescar()
        {
            listarM();
            listarT();
        }

        /// <summary> CRUD
        /// Marcas by Ekis
        public void listarM()
        {
            try
            {
                //Tabla Marcas
                CI_Marca objT = new CI_Marca();
                objT.listarM();

                DataSet data = new DataSet();
                (CI_Marca.getMarca).Fill(data);
                dgvM.AllowUserToAddRows = false;
                dgvM.Rows.Clear();
                for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                {
                    dgvM.Rows.Add(
                        data.Tables[0].Rows[i][0],
                        data.Tables[0].Rows[i][1]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar Marca :(");
            }
        }
        

        private void btnNewM_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtMarca.Text))
                {
                    MessageBox.Show("No puedes insertar campo vacío.");
                }
                else
                {
                    CI_Marca.Nom = txtTipo.Text;
                    CI_Marca obj = new CI_Marca();
                    obj.insertarC();
                }
                listarM();
                txtMarca.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
       

        private void dgvMa_SelectionChanged(object sender, EventArgs e)
        {
            btnUptM.Enabled = true;
            String nom = dgvM.CurrentRow.Cells[1].Value.ToString();
            CI_Marca.Nom = nom;
            txtMarca.Text = nom;
        }

        private void btnUptM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                MessageBox.Show("No puedes Actualizar campo vacío.");
            }
            else
            {
                CI_Marca.Nom = txtMarca.Text;
                CI_Marca obj = new CI_Marca();
                obj.actualizarC();
                listarM();
                txtMarca.Text = "";
            }
        }

        private void btnElimM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                MessageBox.Show("No puedes Eliminar campo vacío.");
            }
            else
            {
                CI_Marca obj = new CI_Marca();
                obj.eliminarC();
                listarM();
                txtMarca.Text = "";
            }
        }
        /// <summary>
        /// Fin de Marcas
        /// Incio de Tipos CRUD
        /// </summary>

        public void listarT()
        {
            //dgvMa.Rows.Clear();
            try
            {

                //Tabla Tipo
                CI_Tipo objT = new CI_Tipo();
                objT.listar();

                DataSet dataT = new DataSet();
                (CI_Tipo.getTipo).Fill(dataT);
                dgvTi.AllowUserToAddRows = false;
                dgvTi.Rows.Clear();
                for (int i = 0; i < dataT.Tables[0].Rows.Count; i++)
                {
                    dgvTi.Rows.Add(
                    dataT.Tables[0].Rows[i][0],
                    dataT.Tables[0].Rows[i][1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar Tipos");
            }
        }
        private void btnNewT_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtTipo.Text))
                {
                    MessageBox.Show("No puedes insertar campo vacío.");
                }
                else
                {
                    CI_Tipo.Nom = txtTipo.Text;
                    CI_Tipo obj = new CI_Tipo();
                    obj.insertarC();
                }
                listarT();
                txtTipo.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar Tipo");
            }
        }

        private void btnUptT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("No puedes Actualizar campo vacío.");
            }
            else
            {
                CI_Tipo.Nom = txtTipo.Text;
                CI_Tipo obj = new CI_Tipo();
                obj.actualizarC();
                listarT();
                txtTipo.Text = "";
            }
        }

        private void btnElimT_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("No puedes Eliminar campo vacío.");
            }
            else
            {
                CI_Tipo obj = new CI_Tipo();
                obj.eliminarC();
                listarT();
                txtTipo.Text = "";
            }
        }

        private void dgvTi_SelectionChanged(object sender, EventArgs e)
        {
            btnUptT.Enabled = true;
            String nom = dgvTi.CurrentRow.Cells[1].Value.ToString();
            CI_Tipo.Nom = nom;
            txtTipo.Text = nom;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvMa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Marcas by Ekis


    }
}

