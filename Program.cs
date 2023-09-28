﻿using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int opcion=0;
        do
        {
            Console.WriteLine("Menú de operaciones:");
            Console.WriteLine("1. Pares e Impares");
            Console.WriteLine("2. Tabla de multiplicar");
            Console.WriteLine("3. Factorial de un número");
            Console.WriteLine("4. Números Primos");
            Console.WriteLine("5. Sucesión de Fibonacci");
            Console.WriteLine("6. Salir");
            Console.Write("Ingrese su elección (1-6): ");

            string? input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        //ParesImpares();
                        break;
                    case 2:
                        //TablaDeMultiplicar();
                        break;
                    case 3:
                        //Factorial();
                        break;
                    case 4:
                        //NumerosPrimos();
                        break;
                    case 5:
                        //Fibonacci();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número del 1 al 6.");
            }

        } while (opcion != 6);
    }
} 