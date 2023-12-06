/*Confeccionar un programa que lea n pares de datos, cada par de datos corresponde a la medida de la base y la altura de un triángulo.
 El programa deberá informar:
a) De cada triángulo la medida de su base, su altura y su superficie.
b) La cantidad de triángulos cuya superficie es mayor a 12.
Desarrollar un programa que solicite la carga de 10 números e imprima la suma de los últimos 5 valores ingresados.*/


using System.Drawing;

public class Program2
{
    private static void Main(string[] args)
    {

        MedidasdeunTriangulo();

        void MedidasdeunTriangulo()

        {

            int Altura = 0;
            int Base = 0;
            int Superficie = 0;
            int Triangulo = 1;
            int cantidad = 0;
            string linea = string.Empty;

            Console.WriteLine("Ingrese la cantidad de triangulos : ");
            linea = Console.ReadLine();
            Triangulo = Convert.ToInt32(linea);

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
                Console.WriteLine($"     LAS MEDIDAS DEL TRIANGULO {Triangulo}: ");

                Console.WriteLine($"Ingrese la base del triangulo {Triangulo}: ");
                linea = Console.ReadLine();
                Base = Convert.ToInt32(linea);



                if (int.TryParse(linea, out int myValue))
                {
                    Base = myValue;
                }
                else
                {
                    Console.WriteLine("El valor digitado es inválido");
                    break;
                }

                Triangulo += 1;




            }
        }
    }
}
    