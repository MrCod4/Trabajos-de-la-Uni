/*Se desea obtener las potencias de 2 desde 0 hasta 100, es decir 2
0, 21, 22 , 23 , 24 , 25 , 26 , 27 , 28 , 29, 210
*/
using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double num = 2;

            for(int i = 0; i <= 100; i++)
            {
                System.Console.WriteLine("Potencia de 2^"+i+": "+Math.Pow(num,i));

                Thread.Sleep(500);
            }
        }
    } 
}
