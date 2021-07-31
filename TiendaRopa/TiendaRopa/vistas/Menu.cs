using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaRopa.vistas
{
    class Menu
    {
        public Menu()
        {
            menuPrincipal();
        }
        private void menuPrincipal()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Cotizador Express");
                Console.WriteLine("Nombre Tienda:");
                Console.WriteLine("Direccón de la tienda:");
                Console.WriteLine("Nombre y Apellido Vendedor");
                Console.WriteLine("Código Vendedor");
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("1- Cotizar");
                Console.WriteLine("2- Ver historial de cotizaciones");
                Console.WriteLine("3- salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        cotizar();
                        break;
                    case 2:
                        mostrarHistorialCotizaciones();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion válida");
                        break;
                }

            } while (opcion != 3);
        }

        private void cotizar()
        {
            int opcionPrenda = 0;
            int opcionCalidad = 0;
            float precio = 0;
            int cantidad = 0;
            Console.WriteLine("Seleccione tipo de prenda");
            Console.WriteLine("1- Camisa");
            Console.WriteLine("2- Pantalon");
            opcionPrenda = int.Parse(Console.ReadLine());
            switch (opcionPrenda)
            {
                case 1:
                    cotizarCamisa();
                    break;
                case 2:
                    cotizarPantalon();
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion válida");
                    break;
            }

            Console.WriteLine("Seleccione tipo de calidad");
            Console.WriteLine("1- Standar");
            Console.WriteLine("2- Premium");
            opcionCalidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Precio unitario");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Cantidad");
            cantidad = int.Parse(Console.ReadLine());

        }

        private void cotizarPantalon()
        {
            int opcionChupin = 0;
            Console.WriteLine("¿Es un pantalon chupín?");
            Console.WriteLine("1 - Si");
            Console.WriteLine("2 - No");
            opcionChupin = int.Parse(Console.ReadLine());
        }

        private void cotizarCamisa()
        {
            int opcionMangaCorta = 0;
            int opcionCuelloMao = 0;
            Console.WriteLine("¿Es Manga corta?");
            Console.WriteLine("1 - Si");
            Console.WriteLine("2 - No");
            opcionMangaCorta = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Es Cuello mao?");
            Console.WriteLine("1 - Si");
            Console.WriteLine("2 - No");
            opcionCuelloMao = int.Parse(Console.ReadLine());

        }

        private void mostrarHistorialCotizaciones()
        {

        }
    }
}
