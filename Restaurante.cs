using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_bloaters
{
    public class Restaurante
    {
        public string NombreRestaurante { get; set; }
        public string Direccion { get; set; }
        public List<string> NombresMeseros { get; set; } = new List<string>();
        public List<string> NombresCocineros { get; set; } = new List<string>();
        public List<string> Platillos { get; set; } = new List<string>();
        public List<int> Precios { get; set; } = new List<int>();
        public List<int> TiempoPreparacion { get; set; } = new List<int>();

        public Restaurante(string nombreRestaurante, string direccion)
        {
            NombreRestaurante = nombreRestaurante;
            Direccion = direccion;
        }

        public void AgregarMesero(string nombre)
        {
            NombresMeseros.Add(nombre);
        }

        public void AgregarCocinero(string nombre)
        {
            NombresCocineros.Add(nombre);
        }

        public void AgregarPlatillo(string platillo, int precio, int tiempoPreparacion)
        {
            Platillos.Add(platillo);
            Precios.Add(precio);
            TiempoPreparacion.Add(tiempoPreparacion);
        }

        public void GenerarReporteRestaurante()
        {
            Console.WriteLine($"Restaurante: {NombreRestaurante}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine("Meseros:");
            foreach (var mesero in NombresMeseros)
            {
                Console.WriteLine($"- {mesero}");
            }
            Console.WriteLine("Cocineros:");
            foreach (var cocinero in NombresCocineros)
            {
                Console.WriteLine($"- {cocinero}");
            }
            Console.WriteLine("Menú:");
            for (int i = 0; i < Platillos.Count; i++)
            {
                Console.WriteLine($"- {Platillos[i]}: ${Precios[i]} (Tiempo de preparación: {TiempoPreparacion[i]} mins)");
            }
        }
    }
}
