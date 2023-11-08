


void calcularpromedio()
{ 

int suma = 0;
int valor = 0;
int promedio = 0 ;
int cantidad = 3;
int i = 1;
string linea = string.Empty;

    Console.WriteLine("Ingrese un número: ");

    while (i <= cantidad)
{ 
    Console.WriteLine("Ingrese un Valor: ");
    linea = Console.ReadLine();


    if (int.TryParse(linea, out int myvalue))
    {
        valor = myvalue;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
        break;
    }

        suma = (suma + valor);
            
            }
    promedio = ()
}



}
