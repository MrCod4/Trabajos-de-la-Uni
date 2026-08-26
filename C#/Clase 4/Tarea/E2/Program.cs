/*Diseña una función EvaluarClima que reciba una temperatura en grados Celsius y devuelva un texto
indicando la categoría: "Fresco", "Templado" o "Cálido"*/

using System;

namespace ejercicio2
{
    class Program
    {
        
        static void EvaluaClima(double c)
        {
            if(c <= 10)
            {
                System.Console.WriteLine("El clima es frio");
            }
            else if(c > 10 && c < 20)
            {
                System.Console.WriteLine("El clima es templado");
            }
            else
            {
                System.Console.WriteLine("El clima es calido");
            }    
        }

        static void Main(string[] args)
        {
            int c;

            System.Console.WriteLine("Que grados de temperatura hay");
            c = int.Parse(Console.ReadLine());

            EvaluaClima(c);
        }
    }
}