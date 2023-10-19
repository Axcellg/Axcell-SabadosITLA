using System;

public class Program
{
    public static void CalcularPerimetroCuadrado()
    {
        Console.WriteLine("Ingrese el lado del cuadrado:");
        int lado = Convert.ToInt32(Console.ReadLine());
        int perimetro = lado * 4;
        Console.WriteLine($"El perímetro del cuadrado es: {perimetro}");
    }

    public static void CalcularSumaYProducto()
    {
        Console.WriteLine("Ingrese cuatro números:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());
        int num4 = Convert.ToInt32(Console.ReadLine());
        int suma = num1 + num2;
        int producto = num3 * num4;
        Console.WriteLine($"La suma de los dos primeros números es: {suma}");
        Console.WriteLine($"El producto del tercer y cuarto número es: {producto}");
    }

    public static void CalcularSumaYPromedio()
    {
        Console.WriteLine("Ingrese cuatro valores numéricos:");
        int valor1 = Convert.ToInt32(Console.ReadLine());
        int valor2 = Convert.ToInt32(Console.ReadLine());
        int valor3 = Convert.ToInt32(Console.ReadLine());
        int valor4 = Convert.ToInt32(Console.ReadLine());
        int suma = valor1 + valor2 + valor3 + valor4;
        double promedio = (double)suma / 4;
        Console.WriteLine($"La suma de los cuatro valores es: {suma}");
        Console.WriteLine($"El promedio de los cuatro valores es: {promedio}");
    }

    public static void Main()
    {
        CalcularPerimetroCuadrado();
        CalcularSumaYProducto();
        CalcularSumaYPromedio();
    }
}
