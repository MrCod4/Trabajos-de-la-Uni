using System;
using System.Runtime.InteropServices.Marshalling;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args0)
        {
            char ans;
            do
            {
                System.Console.WriteLine("Desea continuar S/N");
                ans = char.Parse(Console.ReadLine());
            }
            while(ans == 'N' || ans == 'n');
        }
    }
}
