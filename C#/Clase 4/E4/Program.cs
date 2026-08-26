using System;

namespace ejercicio4
{
    class Program
    {
        static int minmax(ref int a, ref int b)
        {
            int max=0;

            if(a < b)
            {
                max = b;
                return max;
            }
            else if(a > b)
            {
                max = a;
                return max;
            }
            else
            {
                return max;
            }
        }

        static void Main(string[] args)
        {
            int a;
            int b;
            int min;
            int max;

            System.Console.WriteLine("Ingrese el valor de A");
            a = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Ingrese el valor de B");
            b = int.Parse(Console.ReadLine());

            if(minmax(ref a, ref b) == a)
            {
                min = b;
                max = minmax(ref a, ref b);
                System.Console.WriteLine("El numero mayor es "+max+"y el numero menor es "+min);

            }else if(minmax(ref a, ref b) == b)
            {
                min = a;
                max = minmax(ref a, ref b);
                System.Console.WriteLine("El numero mayor es "+max+"y el numero menor es "+min);
            }
            else
            {
                System.Console.WriteLine("Ambos son iguales");
            }
        }
    }
}
