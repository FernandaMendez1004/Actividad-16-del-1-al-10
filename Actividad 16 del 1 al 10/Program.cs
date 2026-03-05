Console.WriteLine("Actividad 16 ej 1 al 10");
Console.WriteLine("Elija una opción");
Console.WriteLine("1. Ejercicio 1");
int opcion = int.Parse(Console.ReadLine());


switch (opcion)
{
    case 1:
    int num1 = 1;
    do
    {
    Console.WriteLine("Ejercicio 1");
    Console.WriteLine($"{num1}");
    num1++;
    }
    while (num1 <=5 );
    break;
}