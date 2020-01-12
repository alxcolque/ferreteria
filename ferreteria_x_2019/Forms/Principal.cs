using ferreteria_x_2019.UC_Inicio;
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
using ferreteria_x_2019.Forms;



namespace ferreteria_x_2019
{
    public partial class Principal : Form
    {
        int panelWidth;
        bool isCollapsed;
        internal string ci;
        string usuario = CI_Ventas.Usuar;
        public Principal()
        {
            InitializeComponent();
            lblAdmin.Text = usuario;
            tiempoReal.Start();
            panelWidth = pnlLeft.Width;
            isCollapsed = false;
            UC_Inicio.UC_Inicio uch = new UC_Inicio.UC_Inicio();
            AddControlsToPanel(uch);
        }
        
        /// <summary>
        /// Mover la ventana
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
            
        

        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //MessageBox("hola", "Aceptar");
            this.Dispose();
            //Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnlSidebar.Visible = false;
                pnlLeft.Width = pnlLeft.Width + 20;
                if (pnlLeft.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                    animacion1.Show(pnlSidebar);
                }
            }
            else
            {
                pnlSidebar.Visible = false;
                pnlLeft.Width = pnlLeft.Width - 20;
                if (pnlLeft.Width <= 80)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                    animacion1.Show(pnlSidebar);
                }
            }
        }

        private void pnlCuerpo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            //btn.BackColor = Color.Red;
            panelAct.Top = btn.Top;
            panelAct.Height = btn.Height;
        }
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlCuerpo.Controls.Clear();
            pnlCuerpo.Controls.Add(c);
        }
        /// Menu lateral izquierdo
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPrincipal);
            UC_Inicio.UC_Inicio uch = new UC_Inicio.UC_Inicio();
            AddControlsToPanel(uch);
        }

        private void btnListprod_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnListprod);
            UC_Items uch = new UC_Items();
            AddControlsToPanel(uch);
        }

        private void btnPerfProducto_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPerfProducto);
            UC_Perf_Prod uch = new UC_Perf_Prod();
            AddControlsToPanel(uch);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnStock);
            UC_Inventario uch = new UC_Inventario();
            AddControlsToPanel(uch);
        }

        private void btnDiarias_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnDiarias);
            UC_Ventas uch = new UC_Ventas();
            AddControlsToPanel(uch);
        }
        ///Graficos
        
        private void btnGraficos_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnGraficos);
            UC_Graficos uch = new UC_Graficos();
            AddControlsToPanel(uch);
        }
        ///Fin  graficos
        private void tiempoReal_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTimer.Text = dt.ToString("HH:MM:ss");
        }

        private void panelAct_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
