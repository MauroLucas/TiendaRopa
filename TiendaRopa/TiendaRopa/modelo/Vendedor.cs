using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaRopa.modelo
{
    class Vendedor
    {
        private String nombre;
        private String apellido;
        private String codVendedor;
        private List<Cotizacion> lstCotizaciones;

        public Vendedor() { }
        public Vendedor(string nombre, string apellido, string codVendedor, List<Cotizacion> lstCotizaciones)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codVendedor = codVendedor;
            this.lstCotizaciones = lstCotizaciones;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string CodVendedor { get => codVendedor; set => codVendedor = value; }
        internal List<Cotizacion> LstCotizaciones { get => lstCotizaciones; set => lstCotizaciones = value; }
    }
}
