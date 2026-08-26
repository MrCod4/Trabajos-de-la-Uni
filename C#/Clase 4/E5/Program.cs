using System;

namespace ejercicio5
{
    class Program
    {
        static void Separar(ref double a, out double b)
        {
            b = (int)a;
            a = a - b;
            a = Math.Round(a,2);
        }
        static void Main(string[] args)
        {
            double a;
            double b;

            System.Console.WriteLine("Ingrese el valor de un numero");
            a = double.Parse(Console.ReadLine());

            Separar(ref a,out b);

            System.Console.WriteLine("Al separarlos el valor entero es "+b+" y el valor decimal es "+a);


        }
    }
}
