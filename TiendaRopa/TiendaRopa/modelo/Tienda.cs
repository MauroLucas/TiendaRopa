using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaRopa.modelo
{
    class Tienda
    {
        private String nombre;
        private String direccion;
        private List<Prenda> lstPrendas;

        public Tienda() { }
        public Tienda(string nombre, string direccion, List<Prenda> lstPrendas)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.lstPrendas = lstPrendas;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal List<Prenda> LstPrendas { get => lstPrendas; set => lstPrendas = value; }
    }
}
