using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaRopa.modelo
{
    class Prenda
    {
        private String calidad;
        private float precio;
        private int cantStock;

        public Prenda() { }
        public Prenda(string calidad, float precio, int cantStock)
        {
            this.calidad = calidad;
            this.precio = precio;
            this.cantStock = cantStock;
        }

        public string Calidad { get => calidad; set => calidad = value; }
        public float Precio { get => precio; set => precio = value; }
        public int CantStock { get => cantStock; set => cantStock = value; }
    }
}
