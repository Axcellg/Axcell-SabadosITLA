using System;

public class Class1
{
	public Class1()
	{
		/*Confeccionar un programa que lea n pares de datos, cada par de datos corresponde a la medida de la base y la altura de un triángulo.
 El programa deberá informar:
a) De cada triángulo la medida de su base, su altura y su superficie.
b) La cantidad de triángulos cuya superficie es mayor a 12.
Desarrollar un programa que solicite la carga de 10 números e imprima la suma de los últimos 5 valores ingresados.*/


internal class test

    {
        private static void Main(string[] args)
        {
            CalcularPromedio();


            void CalcularPromedio()
            {
                int suma = 0;
                int valor = 0;
                decimal promedio = 0;
                int cantidad = 0;
                string linea = string.Empty;
                int x = 1;


                Console.WriteLine("Ingrese la cantidad: ");
                linea = Console.ReadLine();

                if (int.TryParse(linea, out int myCantidad))
                {
                    cantidad = myCantidad;
                }
                else
                {
                    Console.WriteLine("La cantidad ingresada no es válida");
                    return;
                }

                Console.WriteLine("---------------------------INGRESAR LOS VALORES------------------------------");

                while (x <= cantidad)
                {
                    Console.WriteLine($"Ingrese el valor {x} ");
                    linea = Console.ReadLine();


                    if (int.TryParse(linea, out int myValue))
                    {
                        valor = myValue;
                    }
                    else
                    {
                        Console.WriteLine("El valor digitado es inválido");
                        break;
                    }


                    suma = suma + valor;
                    x += 1;
                }

                promedio = suma / cantidad;

                Console.WriteLine("--------------------------------------RESULTADOS----------------------------------------------------");


                Console.WriteLine($"La suma es: {suma} ");

                Console.WriteLine($"El promedio es: {promedio}");


            }
        }
    }
}
}
