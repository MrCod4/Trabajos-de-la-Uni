using System;
using System.ComponentModel;

namespace ejercicio1
{
    class Program
    {

        static double F(double num)
        { 
            double f = (num*9/5)+32;
            return f;
        }

        static void Main(string[] args)
        {
            double c;
            double f;

            System.Console.WriteLine("Ingrese la temperatura a convertir");
            c= double.Parse(Console.ReadLine());

            f = F(c);

            System.Console.WriteLine("La temperatura en Farenheit es: "+f);
        }
    }
}
