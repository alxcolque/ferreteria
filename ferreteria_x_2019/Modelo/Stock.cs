using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferreteria_x_2019.Modelo
{
    public class Stock
    {
        private string _cod;
        private string _nombre;
        private string _marca;
        private int _cantidad;
        public string Cod
        {
            get
            {
                return _cod;
            }
            set
            {
                _cod = value;
            }
        }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        
        public string Marca
        {
            get
            {
                return _marca;
            }
            set
            {
                _marca = value;
            }
        }
        public int Cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                _cantidad = value;
            }
        }
        public Stock()
        {

        }
    }
}
