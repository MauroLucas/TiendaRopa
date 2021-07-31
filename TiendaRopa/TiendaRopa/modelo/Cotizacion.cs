using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaRopa.modelo
{
    class Cotizacion
    {
        private int id;
        private DateTime fechaHora;
        private String codVendedor;
        private String prenda;
        private int cantUnidades;
        private float precioFinal;

        public Cotizacion() { }
        public Cotizacion(int id, DateTime fechaHora, string codVendedor, string prenda, int cantUnidades)
        {
            this.id = id;
            this.fechaHora = fechaHora;
            this.codVendedor = codVendedor;
            this.prenda = prenda;
            this.cantUnidades = cantUnidades;            
        }

        public int Id { get => id; set => id = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public string CodVendedor { get => codVendedor; set => codVendedor = value; }
        public string Prenda { get => prenda; set => prenda = value; }
        public int CantUnidades { get => cantUnidades; set => cantUnidades = value; }
        public float PrecioFinal { get => precioFinal;}
    }
}
