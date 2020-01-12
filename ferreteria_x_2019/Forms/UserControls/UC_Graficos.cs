using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferreteria_x_2019.UC_Inicio
{
    public partial class UC_Graficos : UserControl
    {
        public UC_Graficos()
        {
            InitializeComponent();
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            Temporizador.Stop();
            //for(ifn)
            this.Grafico.Series["ChartLinea"].Points.AddXY("Domingo", 80);
            this.Grafico.Series["ChartLinea"].Points.AddXY("Lunes",10);
            this.Grafico.Series["ChartLinea"].Points.AddXY("Martes", 13);
            this.Grafico.Series["ChartLinea"].Points.AddXY("Miercoles", 54);
            this.Grafico.Series["ChartLinea"].Points.AddXY("Jueves", 34);
            this.Grafico.Series["ChartLinea"].Points.AddXY("Viernes", 60);
            this.Grafico.Series["ChartLinea"].Points.AddXY("Sábado", 87);
        }
    }
}
