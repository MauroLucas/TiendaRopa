using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaRopa.modelo
{
    class Camisa : Prenda
    {
        private bool esMangaCorta;
        private bool esCuelloMao;
        public Camisa(bool esPremium, float precio, int cantStock, bool tipoManga, bool tipoCuello) : base(esPremium, precio, cantStock)
        {
            this.esMangaCorta = tipoManga;
            this.esCuelloMao = tipoCuello;
        }

        public bool EsMangaCorta { get => esMangaCorta; set => esMangaCorta = value; }
        public bool EsCuelloMao { get => esCuelloMao; set => esCuelloMao = value; }

        public override float precioFinal()
        {
            float precioBase = Precio * CantStock;
            float manga = 0;
            float cuello = 0;
            float calidad = 0;

            if (EsPremium)
            {
                calidad = precioBase * 30 / 100;

                if(EsMangaCorta && EsCuelloMao)
                {
                    precioBase = precioBase - (precioBase * 10 / 100);
                    precioBase = precioBase + (precioBase * 3 / 100);
                }
                else
                {
                    if (EsMangaCorta)
                    {
                        manga = -(precioBase * 10 / 100);
                    }
                    if (EsCuelloMao)
                    {
                        cuello = (precioBase * 3 / 100);
                    }

                }
                               
            }

            return precioBase + manga + cuello + calidad;
        }
    }
}
