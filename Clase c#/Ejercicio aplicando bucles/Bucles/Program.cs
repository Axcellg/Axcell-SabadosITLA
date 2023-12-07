
using System;

public class Program
{
    private static void Main(string[] args)
    {

        MedidasdeunTriangulo();
        SumadeNumeros();


        void MedidasdeunTriangulo()

        {
            Console.WriteLine("------------------------------------------------------PRIMER PROGRAMA---------------------------------------------------");

            int Altura = 0;
            int Base = 0;
            int Superficie = 0;
            int Triangulo = 1;
            int cantidad = 0;
            string linea = string.Empty;

            Console.WriteLine("Ingrese la cantidad de triangulos : ");
            linea = Console.ReadLine();
            

            if (int.TryParse(linea, out int mycantidad))
            {
                cantidad = mycantidad;
            }

            else
            {
                Console.WriteLine("El triangulo no es valido");
                return;
            }

            Console.WriteLine("---------------------------INGRESAR LAS MEDIDAS DEL TRIANGULO------------------------------");

            while (Triangulo <= cantidad)
            {
               

                Console.WriteLine($"     LAS MEDIDAS DEL TRIANGULO {Triangulo}:         " );

                Console.WriteLine($"Ingrese la altura del triangulo {Triangulo}: ");
                linea = Console.ReadLine();
                Altura = Convert.ToInt32(linea);

                Console.WriteLine($"Ingrese la base del triangulo {Triangulo}: ");
                linea = Console.ReadLine();
                Base = Convert.ToInt32(linea);

                Console.WriteLine($"Ingrese la superficie del triangulo {Triangulo}: ");
                linea = Console.ReadLine();
                Superficie = Convert.ToInt32(linea);


                if (Superficie > 12)
                {
                    Console.WriteLine($"¡Superficie del triangulo {Triangulo} es mayor a 12!");
                }

                else 
                {
                    Console.WriteLine($"La superficie del triangulo {Triangulo} no es mayor a 12 ");
                    
                }

                Triangulo += 1;

                Console.WriteLine("-----------------------------------------------------SEGUNDO PROGRAMA---------------------------------------------------");

            }

        }

     

        void SumadeNumeros()
        {
            int TNumeros = 10;
            int[] numeros = new int[TNumeros];

            for (int i = 0; i < TNumeros; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            int sumaUltimos5 = 0;
            for (int i = TNumeros - 5; i < TNumeros; i++)
            {
                sumaUltimos5 += numeros[i];
            }

            Console.WriteLine($"La suma de los últimos 5 valores ingresados es: {sumaUltimos5}");

            
        }


    }
}
    