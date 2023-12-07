
namespace Creacion_de_clases
{
    public class Operaciones
    {
        /*1.Confeccionar una clase que permita carga el nombre y la edad de una persona
         * .Mostrar los datos cargados.Imprimir un mensaje si es mayor de edad (edad>=18).
        2.Desarrollar un programa que cargue los lados de un triángulo e 
       implemente los siguientes métodos: inicializar los atributos,
       imprimir el valor del lado mayor y otro método que muestre si es equilátero o no.
       3.Implementar la clase operaciones.Se deben cargar dos valores enteros, 
        calcular su suma, resta, multiplicación y división, cada una en un método, 
        imprimir dichos resultados.*/

       public int Valor1 { get; set; }
       public int Valor2 { get; set;}
       public int Suma { get; set;}
       public int Resta { get; set;}
       public int Multiplicacion { get; set;}
       public int Division { get; set;}

        public void CargadeValores()
        {
            Console.WriteLine("Ingresa el valor 1:");
            Valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el Valor 2:");
            Valor2 = int.Parse(Console.ReadLine());
        }

        public void Suma()
        {

        }


    }
}
