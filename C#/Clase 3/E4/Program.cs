/*Confeccionar un algoritmo que permita resolver una ecuación de segundo
grado. Con discriminante mayor a cero (soluciones reales).
AX2+BX+C=0 X1=(-B+SQRT(B2-4AC))/(2A) X2=(-B–SQRT(B2-4AC))/(2A)
D=B2-4AC
Si D = 0 entonces X1 = X2 = -B/(2A)
Si D > 0 entonces calcular X1 y X2
Si D < 0 entonces no tiene solución en los Reales.
*/
using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double d;
            double x1;
            double x2;

            System.Console.WriteLine("Ingrese el valor de A");
            a = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Ingrese el valor de b");
            b = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Ingrese el valor de c");
            c = int.Parse(Console.ReadLine());

            d = Math.Pow(b,2) -4*a*c;

            if (d == 0)
            {
               x1 = -b/(2*a);
               System.Console.WriteLine("Ambos X1 y X2 son igual a:");
               System.Console.WriteLine(x1);
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d))/(2*a);
                x2 = (-b - Math.Sqrt(d))/(2*a);

                System.Console.WriteLine("Los valores de X1 y X2 son:");
                System.Console.WriteLine("X1 = "+x1);
                System.Console.WriteLine("X2 = "+x2);
            }
            else
            {
                System.Console.WriteLine("No tiene solucion real");
            }
        }
    }
}