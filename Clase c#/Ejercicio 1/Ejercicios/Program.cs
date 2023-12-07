public class Program

{
    private static void Main(string[] args)
    {
        CalcularPerimetroCuadrado();
        CalcularSumaYProducto();
        CalcularSumaYPromedio();

        void CalcularPerimetroCuadrado()

        {

            int lado;
            int perimetro;

            Console.WriteLine("-------------------------------------Ingrese el lado del cuadrado:-------------------------------------------------");
            lado = Convert.ToInt32(Console.ReadLine());

            perimetro = lado * 4;

            Console.WriteLine($"El perímetro del cuadrado es: {perimetro}");

        }

        void CalcularSumaYProducto()

        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int suma;
            int producto;



            Console.WriteLine("--------------------------------------Ingrese cuatro números:----------------------------------------------------------");
             num1 = Convert.ToInt32(Console.ReadLine());
             num2 = Convert.ToInt32(Console.ReadLine());
             num3 = Convert.ToInt32(Console.ReadLine());
             num4 = Convert.ToInt32(Console.ReadLine());

             suma = num1 + num2;

             producto = num3 * num4;

            Console.WriteLine($"La suma de los dos primeros números es: {suma}");

            Console.WriteLine($"El producto del tercer y cuarto número es: {producto}");
        }


        void CalcularSumaYPromedio()

        {
            int valor1 = 0;
            int valor2 = 0;
            int valor3 = 0;
            int valor4 = 0;
            int Suma;
            int promedio;

            Console.WriteLine("-----------------------------------------Ingrese cuatro valores numéricos:-------------------------------------------------");
            valor1 = Convert.ToInt32(Console.ReadLine());
            valor2 = Convert.ToInt32(Console.ReadLine());
            valor3 = Convert.ToInt32(Console.ReadLine());
            valor4 = Convert.ToInt32(Console.ReadLine());

            Suma = valor1 + valor2 + valor3 + valor4;

            promedio = Suma / 4;


            Console.WriteLine($"La suma de los cuatro valores es: {Suma}");

            Console.WriteLine($"El promedio de los cuatro valores es: {promedio}");
        }


    }
}