using System;

namespace PruebasDepuracion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

            Console.Write("Introduce un número: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Introduce otro número: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("El resultado es : " + ( a + b ));
           
        }
    }
}
