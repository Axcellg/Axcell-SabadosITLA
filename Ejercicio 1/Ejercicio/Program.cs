using System;

class Program
{
    static void Main()
    {
        CalcularPerimetroCuadrado();
        CalcularSumaYProducto();
        CalcularSumaYPromedio();
    }

    static void CalcularPerimetroCuadrado()
    {
        Console.WriteLine("Ingrese el lado del cuadrado:");
        int lado = Convert.ToInt32(Console.ReadLine());
        int perimetro = lado * 4;
        Console.WriteLine($"El perímetro del cuadrado es: {perimetro}");
    }

    static void CalcularSumaYProducto()
    {
        Console.WriteLine("Ingrese cuatro números separados por espacios:");
        string[] numeros = Console.ReadLine().Split(' ');

        if (numeros.Length != 4)
        {
            Console.WriteLine("Debe ingresar exactamente cuatro números.");
            return;
        }

        int num1 = Convert.ToInt32(numeros[0]);
        int num2 = Convert.ToInt32(numeros[1]);
        int num3 = Convert.ToInt32(numeros[2]);
        int num4 = Convert.ToInt32(numeros[3]);

        int suma = num1 + num2;
        int producto = num3 * num4;

        Console.WriteLine($"La suma de los dos primeros números es: {suma}");
        Console.WriteLine($"El producto del tercer y cuarto número es: {producto}");
    }

    static void CalcularSumaYPromedio()
    {
        Console.WriteLine("Ingrese cuatro números separados por espacios:");
        string[] numeros = Console.ReadLine().Split('');

        if (numeros.Length != 4)
        {
            Console.WriteLine("Debe ingresar exactamente cuatro números.");
            return;
        }

        int num1 = Convert.ToInt32(numeros[0]);
        int num2 = Convert.ToInt32(numeros[1]);
        int num3 = Convert.ToInt32(numeros[2]);
        int num4 = Convert.ToInt32(numeros[3]);

        int suma = num1 + num2;
        double promedio = (num1 + num2 + num3 + num4) / 4.0;

        Console.WriteLine($"La suma de los cuatro números es: {suma}");
        Console.WriteLine($"El promedio de los cuatro números es: {promedio}");
    }
}

