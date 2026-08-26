/*Confeccione un algoritmo que genere la siguiente serie:
1010, 1020, 1030, 1040, 1050, ..........., 10.000.
*/
using System;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] agrs)
        {
            int num = 0;
            for (int i = 0; i<100;i++)
            {
                num +=10;

                System.Console.WriteLine(num);

                Thread.Sleep(500);
            }        
        }
    }
}
