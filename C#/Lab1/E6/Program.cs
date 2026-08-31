/*Crea una función booleana IntentarDividir que reciba dividendo y divisor. Retorna true y asigna el
resultado a una variable de salida si el divisor no es cero; de lo contrario retorna false .*/

using System;
namespace ejercicio6
{
    class Program
    {
        static bool IntentarDividir(ref int a, ref int b, out double res)
        {
            if(b != 0)
            {
                res = a/b;
                return true;
            }
            else
            {
                res = 0;
                return false;    
            }
        }
        static void Main()
        {
            int a;
            int b;
            double res;

            System.Console.WriteLine("Ingrese el valor de a ");
            a =  int.Parse(Console.ReadLine());

            System.Console.WriteLine("Ingrese el valor de b ");
            b =  int.Parse(Console.ReadLine());

            IntentarDividir(ref a, ref b, out res);

            if(res != 0)
            {
                System.Console.WriteLine("Resultado : "+res);
            }
            else
            {
                System.Console.WriteLine("Valor invalido");
            }
        }
    }
}
