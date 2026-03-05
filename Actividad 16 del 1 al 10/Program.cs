Console.WriteLine("Actividad 16 ej 1 al 10");
Console.WriteLine("Elija una opción");
Console.WriteLine("1. Ejercicio 1");
int opcion = int.Parse(Console.ReadLine());


switch (opcion)
{
    case 1:
    int num1 = 1;
        Console.WriteLine("Ejercicio 1");
        do
        {   
        Console.WriteLine($"{num1}");
        num1++;
        }
        while (num1 <=5 );
        break;

    case 2:
    int num2 = 1;
        Console.WriteLine("Ejercicio 2");
        do
        {
            Console.WriteLine($"{num2}");
            num2++;
        }
        while (num2 <=10 );
        break;
    case 3:
        int num3 = 10;
        Console.WriteLine("Ejercicio 3");
        do
        {
            Console.WriteLine($"{num3}");
            num3--;
        }
        while (num3 >= 1 );
        break;
    case 4:
        int num4 = 2;
        Console.WriteLine("Ejercicio 4");
        do
        {
            if (num4 % 2 == 0)
            {
                Console.WriteLine($"{num4}");
            }
            num4++;
        }
        while (num4 <=20);
        break;
    case 5:
        int num5 = 1;
        Console.WriteLine("Ejercicio 5");
        do
        {
            if (num5 % 2 == 0)
            {
                Console.WriteLine($"{num5}");
            }
            num5++;
        }
        while (num5 <= 20);
        break;
    case 6:
        int num6 = 1;
        Console.WriteLine("Ejercicio 6");
        do
        {
            Console.WriteLine($"{num6} su cuadrado es {num6 * num6}");
            num6++;
        }
        while (num6 <= 10);
        break;
    case 7:
        int num7 = 1;
        int suma7 = 0;
        Console.WriteLine("Ejercicio 7");
        do
        { 
           suma7 = suma7 + num7;
            num7++;
        }
        while (num7 <= 10);
        Console.WriteLine($"La suma de los números del 1 al 10 es {suma7}");
        break;
    case 8:
        int num8 = 1;
        Console.WriteLine("Ejercicio 8");
        do
        {
            Console.WriteLine($"5 * {num8} = {5*num8}");
            num8++; 
        }
        while (num8 <= 10); 
        break;
    case 9:
        int num9 = 1;
        Console.WriteLine("Ejercicio 9");
        do
        {
            if (num9 % 2 != 0)
            {
                Console.WriteLine($"{num9} = Numero par");

                num9++;
            }
            else
            {
                Console.WriteLine($"{num9} = Numero impar");
                num9++;
            }
        }
        while (num9 <= 20);
        break;
    case 10:
        int num10 = 1;
        int contador10 = 0;
        Console.WriteLine("Ejercicio 10");
        do
        {
            Console.WriteLine($"{num10}");
            num10++;
            contador10++;
        }
        while (num10 <= 50);
        Console.WriteLine($"Fueron {contador10} numeros");
        break;
}