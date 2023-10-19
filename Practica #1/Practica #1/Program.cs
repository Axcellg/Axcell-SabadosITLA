
Console.WriteLine("Ingrese la Fecha de tu cumple:");

int Mes = 0;
int Dia = 0;
int Año = 0 ;
string linea = string.Empty;

//Pedir numeros //
Console.WriteLine("Ingrese el valor de Mes: ");
linea = Console.ReadLine();
Mes = Convert.ToInt32(linea);

Console.WriteLine("Ingrese el valor de Dia: ");
linea = Console.ReadLine();
Dia = Convert.ToInt32(linea);

Console.WriteLine("Ingrese el valor de Año: ");
linea = Console.ReadLine();
Año = Convert.ToInt32(linea);

if(Mes == 1 || Mes == 2 || Mes == 3)

{
    Console.WriteLine("El mes corresponde al primer trimestre");
}
else
{
    Console.WriteLine("El mes no corresponde al primer trimestre");
}