using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaRopa.modelo
{
    abstract class Prenda
    {
        private bool esPremium;
        private float precio;
        private int cantStock;

        public Prenda() { }
        public Prenda(bool esPremium, float precio, int cantStock)
        {
            this.esPremium = esPremium;
            this.precio = precio;
            this.cantStock = cantStock;
        }

        public abstract float precioFinal();        
       
        public float Precio { get => precio; set => precio = value; }
        public int CantStock { get => cantStock; set => cantStock = value; }
        public bool EsPremium { get => esPremium; set => esPremium = value; }
    }
}
