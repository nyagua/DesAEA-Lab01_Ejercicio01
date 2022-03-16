using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos numeros");
                Console.WriteLine("[2] Resta de dos numeros");
                Console.WriteLine("[3] Multiplicacion de dos numeros");
                Console.WriteLine("[4] Division de dos numeros");
                Console.WriteLine("[5] Imprimir la raiz cuadrada de los 10 primeros numeros enteros");
                Console.WriteLine("[6] Convertir de Fahrenheit a Celcius");
                Console.WriteLine("[7] Convertir de Celcius a Fahrenheit");
                Console.WriteLine("[8] Imprimir los primeros 10 numeros primos");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opcion y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer numero");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el primer numero");
                        int y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", y, x, Resta(y, x));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer numero");
                        int z = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int w = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicacion de {0} y {1} es {2}", z, w, Multiplicacion(z, w));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer numero");
                        int j = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int k = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division de {0} y {1} es {2}", j, k, Division(j, k));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Ingrese la temperatura en Fahrenheit");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La conversion de {0}F a C es {1}", f, Celcius(f));
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese la temperatura en Celcius");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La conversion de {0}C a F es {1}", c, Farenheit(c));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Calculando...");
                        Primos();
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
        }

        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int y, int x)
        {
            return y - x;
        }

        static int Multiplicacion(int z, int w)
        {
            return z * w;
        }

        static int Division(int j, int k)
        {
            return j / k;
        }

        static int Celcius(int f) 
        {
            return (5 * (f - 32)) / 9;
        }

        static int Farenheit(int c)
        {
            return ((9*c)/5)+32;
        }

        static void Primos()
        {
            int numero = 2, divisible = 0;

            while (numero <= 30)
            {
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        divisible++;
                    }
                }
                if (divisible == 2)
                {
                    Console.WriteLine("{0}", numero);
                }
                divisible = 0;
                numero++;
            }
        }

        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }
    }
}
