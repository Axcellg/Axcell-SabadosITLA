
Numero_Mayor();
Cifras_de_numeros();
Postulante_de_Empleo();

void Numero_Mayor() {

//Definicion de las variables//
int valor1 = 0;
int valor2 = 0;
int Suma;
int Resta;
int Multiplicacion;
int Division;
string linea = string.Empty;

//Pedir numeros //
Console.WriteLine("Ingrese el valor1: ");
linea = Console.ReadLine();
valor1 = Convert.ToInt32(linea);

Console.WriteLine("Ingrese el valor2: ");
linea = Console.ReadLine();
valor2 = Convert.ToInt32(linea);

if (valor1 >= valor2)
{
   Suma = valor1 + valor2;
    Resta = valor1 - valor2;

    Console.WriteLine($"La suma de los valores es igual = {Suma}");
    Console.WriteLine($"La Resta de los valores es igual = {Resta}");
}

else 
        {
    Multiplicacion = valor1 * valor2;
    Division = valor1 / valor2;

    Console.WriteLine($"La Multiplicacion de los valores es igual = {Multiplicacion}");
    Console.WriteLine($"La Division de los valores es igual = {Division}");
}

}

void Cifras_de_numeros ()

{
    int Numero = 0;
    string linea = string.Empty;


    Console.Write("Ingrese un número entero positivo de tres cifras: ");
    linea = Console.ReadLine();
    Numero = Convert.ToInt32(linea);


    if (Numero >= 0 && Numero <= 999 && Numero > 999)
    {
        if (Numero < 10)
        {
            Console.WriteLine("El número tiene 1 cifra.");
        }
        else if (Numero < 100)
        {
            Console.WriteLine("El número tiene 2 cifras.");
        }
        else
        {
            Console.WriteLine("El número tiene 3 cifras.");
        }
    }

    else
    {
        Console.WriteLine("Error: El número es mayor a tres cifras.");
    }
}
   
void Postulante_de_Empleo()
{
    /*Un postulante a un empleo, realiza un test de capacitación, se obtuvo la siguiente información: 
    cantidad total de preguntas que se le realizaron y la cantidad de preguntas que contestó correctamente. 
    Se pide confeccionar un programa que ingrese los dos datos por teclado e informe el nivel del mismo según el porcentaje de respuestas correctas que ha obtenido, y sabiendo que:
	Nivel máximo:	Porcentaje>=90%.
	Nivel medio:	Porcentaje>=75% y <90%.
	Nivel regular:	Porcentaje>=50% y <75%.
	Fuera de nivel:	Porcentaje<50%.*/

     int Preguntas = 0;
     int Correctas = 0;
    int Porcentaje = 0;
    string Linea= string.Empty;

    Console.WriteLine("Cual es la cantidad total de preguntas que se le realizaron: ");
    Linea = Console.ReadLine();
    Preguntas = Convert.ToInt32(Linea);

    Console.WriteLine("Cual fue la cantidad de preguntas que contestó correctamente: ");
    Linea = Console.ReadLine();
    Correctas = Convert.ToInt32(Linea);

    if (Correctas >= 0 &&)
    {

    }
}





