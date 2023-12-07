

namespace Creacion_de_clases
{
    public class losladosdeuntriángulo
    {

        public int Lado1 { get; set; }
        public int Lado2 { get; set; }
        public int Lado3 { get; set; }

        public void inicializarlosatributoso()
        {
            Console.WriteLine("Ingresa el lado1 del Triangulo");
            Lado1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el lado1 del Triangulo");
            Lado2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el lado1 del Triangulo");
            Lado3 = int.Parse(Console.ReadLine());

        }

        public void ImprimirLadoMayor()
        { 
           if (Lado1 > Lado2 && Lado1 > Lado3) 
            {
                Console.WriteLine($"El lado mayor es: {Lado1}");

            }
           if (Lado2 > Lado1 && Lado2 > Lado3)
            {
                Console.WriteLine($"El lado mayor es: {Lado2}");
                    
            }

           else
            {
                Console.WriteLine($"El lado mayor es: {Lado3}");
            }


        }

        public void LadoEquilatero()
        {
            if (Lado1 == Lado2 && Lado2 == Lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else
            {
                Console.WriteLine("El triángulo no es equilátero.");
            }
        }

    }

}

