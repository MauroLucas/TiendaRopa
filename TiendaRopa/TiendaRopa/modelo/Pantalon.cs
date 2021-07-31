using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaRopa.modelo
{
    class Pantalon : Prenda
    {
        private bool esChupin;

        public Pantalon() { }
        public Pantalon(bool esPremium, float precio, int cantStock, bool esChupin) : base(esPremium, precio, cantStock)
        {
            this.esChupin = esChupin;
        }

        public bool EsChupin { get => esChupin; set => esChupin = value; }

        public override float precioFinal()
        {
            float precioBase = Precio * CantStock;
            float pantalon = 0;
            float calidad = 0;
            if (EsPremium)
            {
                calidad = precioBase * 30 / 100;

                if (esChupin)
                {
                    pantalon = -(precioBase * 12 / 100);
                }

            }         

            return precioBase + pantalon + calidad;
        }
    }
}
