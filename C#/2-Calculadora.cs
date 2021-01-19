using System;

namespace MyCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenid@ a mi Calculadora");
            Console.WriteLine("==========================");

            // Recibir por consola un par de números y realizar la operación seleccionada
            // por ejemplo: + - * /
            // Ejercicio (Portafolio): elegir algunas conversiones entre unidades para implementar
            // p.e.: pasar de kg a libras

            Console.WriteLine("Elige la operación:");
            Console.WriteLine("a > Suma");
            Console.WriteLine("b > Resta");
            Console.WriteLine("c > Producto");
            Console.WriteLine("d > División");

            string myChar = Console.ReadLine();

            Console.WriteLine("Introduce el primer número:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // switch case para presentar el resultado obtenido en la op elegida
            switch (myChar)
            {
                case "a":
                    Console.WriteLine("Suma: " + (num1 + num2));
                    break;
                case "b":
                    Console.WriteLine("Resta: " + (num1 - num2));
                    break;
                case "c":
                    Console.WriteLine("Producto: " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine("División: " + (num1 / num2));
                    break;
            }

            // Ideas: 
            // - Añadir bucle while para que haga más operaciones y opción para salir
            // - Implementar (algunas) operaciones definidas en métodos de Math
            // - Añadir más operaciones como convertir unidades
            // - Introducir más números en las operaciones
        }
    }
}
