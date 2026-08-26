/*Construya un algoritmo que permita leer una cantidad de 20 números y nos indique finalmente
cuantos fueron positivos y cuantos fueron negativos.*/

using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int cp = 0;
            int cn = 0;
            int num;

            for (int i=0; i<20; i++)
            {
                System.Console.WriteLine("Ingrese un numero positivo o negativo");
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    cp++;
                }
                else
                {
                    cn++;
                }   
            }

            System.Console.WriteLine("----------------------------------------------");
            System.Console.WriteLine("Cantidad de negativos: "+cn);
            System.Console.WriteLine("Cantidad de positivos: "+cp);
        }
    }
}
