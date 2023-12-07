using System.Drawing;
using System.Security.Cryptography;

namespace Creacion_de_clases
{
    public class MensajeMayordeEdad
    {
        
        public string? Nombre { get; set; }
        public int Edad {  get; set; }

        public void CargarDatos()

        {
            Console.Write("Ingrese el nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese la edad: ");
            Edad = int.Parse(Console.ReadLine());
        }
        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");

            if (Edad >= 18)
            {
                Console.WriteLine("Es mayor de edad.");
            }
            else
            {
                Console.WriteLine("No es mayor de edad.");
            }
        }
    }

}
