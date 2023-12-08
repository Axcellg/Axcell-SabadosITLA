
namespace Creacion_de_clases
{
    public class Operaciones
    {

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

        public void SumadeValores()
        {
            Suma = Valor1 + Valor2;

            Console.WriteLine("Las suma de los valores es:");
            Suma = int.Parse(Console.ReadLine());


        }
         
        public void RestadeValores()
        { 
            Resta = Valor1 - Valor2;

            Console.WriteLine("Las Resta de los valores es:");
            Resta = int.Parse(Console.ReadLine());

        }

        public void MultiplicaciondeValores()
        {
            Multiplicacion = Valor1 * Valor2;

            Console.WriteLine("Las Resta de los valores es:");
            Multiplicacion = int.Parse(Console.ReadLine());

        }

        public void DiviciondeValores()
        {
            Division = Valor1 / Valor2;

            Console.WriteLine("Las Resta de los valores es:");
            Division = int.Parse(Console.ReadLine());

        }
    }
}
