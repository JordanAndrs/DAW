using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosDeApoyo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ej7();
            Console.ReadLine();
        }
        static void Ej1()
        {
            /* Mostrar todos los números del 0 al 100 */

            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine("Numero: " + i.ToString());
            }
        }
        static void Ej2()
        {
            /* Mostrar todos los números del 0 al 100 y decir si son par o impar */

            for (int i = 0; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("El numero " + i.ToString() + " es par");
                }
                else
                {
                    Console.WriteLine("El número " + i.ToString() + " es impar");
                }
            }
        }
        static void Ej3()
        {
            //Función que pida una temperatura en Celsius y calcule y devuelva Fahrenheit y Kelvin

            Console.Write("Introduzca la temperatura en grados Celsius: ");
            Double Celsius = Convert.ToDouble(Console.ReadLine());

            Double Fahrenheit = Celsius * 9 / 5 + 32;
            Console.WriteLine("La temperatura en Fahrenheit es: " + Fahrenheit);

            Double Kelvin = Celsius + 273.15;
            Console.WriteLine("La temperatura en Kelvin es: " + Kelvin);
        }
        static void Ej4()
        {
            /* Función que lee un número que corresponde al radio de una circunferencia y calcule e imprima la
            longitud de la misma y el área del círculo correspondiente.*/

            Console.Write("Introduzca el radio: ");
            Double radio = Convert.ToDouble(Console.ReadLine());

            Double Longitud = ((radio * 2) * 3.1415);
            Console.WriteLine("La longitud de la circunferencia es: " + (Longitud));

            Double area = Math.Pow(radio, 2) * 3.1415;
            Console.WriteLine("El área de la circunferencia es: " + (area));
        }
        static void Ej5()
        {
            /* Función que lee dos números y calcule e imprima la suma, resta, producto y división */

            Console.Write("Introduzca un número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Introduzca otro número: ");
            int num2 = int.Parse(Console.ReadLine());

            int suma = num1 + num2;
            Console.WriteLine("La suma de los dos numeros es " + suma);

            int resta = num1 - num2;
            Console.WriteLine("La resta de los dos numeros es " + resta);

            int producto = num1 * num2;
            Console.WriteLine("El producto de los dos números es " + producto);

            int division = num1 / num2;
            Console.WriteLine("La división entre los dos números es " + division);
        }
        static void Ej6()
        {
            /* Implementar una función que convierta a euros una determinada cantidad en pesetas que se recibirán como parámetro de 
               entrada(1 euro = 166.386 pesetas)*/

            Console.Write("Introduzca el número de pesetas a convertir en euros: ");

            double dinero = Convert.ToDouble(Console.ReadLine());

            double pesetas = 166.386;

            double euros = dinero / pesetas;

            Console.WriteLine("Las pesetas introducidas son " + euros + " euros");
        }
        static void Ej7()
        {
            Console.Write("Introduzca el diámetro: ");
            double diametro = Convert.ToDouble(Console.ReadLine());

            double radio = diametro / 2;

            double Area = 3.14 * Math.Pow(radio, 2);

            Console.WriteLine("El area del circulo es: " + Area);
        }
        static void Ej8()
        {
            /* Implementar una función que calcule y devuelva el precio de un artículo tras aplicarle un 16% de IVA.
             El precio del artículo se recibirá como parámetro de entrada*/

            Console.Write("Introduzca el precio sin iva: ");
            Double precio = Convert.ToDouble(Console.ReadLine());

            Double PrecioEntero = (precio / 1) * 1.16;

            Console.WriteLine("El precio con iva es: " + PrecioEntero);
        }
        static void Ej9()
        {
            Console.WriteLine("Introduzca los números que quiera: ");
        } 
    }
}