using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============");
            Console.WriteLine("Variables en C#");
            Console.WriteLine("===============");

            int numero = 10;
            Console.WriteLine("int: " + numero);
            double pi  = 3.1415;
            Console.WriteLine("double: " + pi);
            char myChar = 'A';
            Console.WriteLine("char: " + myChar);
            bool myBool = true; // false
            Console.WriteLine("bool: " + myBool);
            string myString = "Esto es un string.";
            Console.WriteLine(myString);

            Console.WriteLine("===============");
            Console.WriteLine("Operaciones Básicas");
            Console.WriteLine("===============");

            double num1 = 10;
            double num2 = 11;
            Console.WriteLine("Suma: " + (num1 + num2));      // 10 + 11 = 21
            Console.WriteLine("Resta: " + (num1 - num2));   // 10 - 11 = -1
            Console.WriteLine("Producto: " + (num1 * num2));  // 10 * 11 = 110
            Console.WriteLine("División: " + (num2 / num1));  // 11 / 10 = 1,1

            Console.WriteLine("===============");
            Console.WriteLine("Incremento y Decremento");
            Console.WriteLine("===============");
            // num1 = 10
            Console.WriteLine("Valor inicial: " + num1);
            num1++; // 10 -> 11
            Console.WriteLine("Incremento: " + num1);     
            num1 = 10;
            num1--; // 10 -> 9
            Console.WriteLine("Decremento: " + num1);     

            Console.WriteLine("===============");
            Console.WriteLine("Input (Entrada) desde Consola");
            Console.WriteLine("===============");

            Console.WriteLine("¿Cómo te llamas?");
            string name = Console.ReadLine();
            Console.WriteLine("¿Cuál es tu edad?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hola, " + name + ". Tienes " + age + " años");
        }
    }
}
