/*Construya un algoritmo que permita leer sólo números positivos hasta reunir 100 números pares u
ochenta números 5. Indicar luego la totalidad de números leídos.
*/

using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int cpar = 0;
            int ccinco = 0;
            int c = 0;
            int num;

            do
            { 
                System.Console.WriteLine("Ingrese un numero");
                num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    System.Console.WriteLine("Porfavor ingrese un numero valido");
                }
                else if(num % 2 == 0)
                {
                    c++;
                    cpar++;
                }
                else if (num % 5 == 0 && num % 2 != 0)
                {
                    c++;
                    ccinco++;
                }
                else
                {
                    c++;
                }
            }
            while (cpar < 100 && ccinco < 80);
        
            System.Console.WriteLine("------------------------------------------");
            System.Console.WriteLine("Numeros par totales: "+cpar);
            System.Console.WriteLine("Numeros cinco totales: "+ccinco);
            System.Console.WriteLine("Numeros totales: "+c);
        }
    }
}