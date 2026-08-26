using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i=1; i<=100;i++)
            {
                if (i%5==0)
                {
                    System.Console.WriteLine(i);
                    Thread.Sleep(500);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}