/*Implementa el método AplicarInteres que reciba la variable saldo por referencia y un porcentaje. Si el
saldo es positivo, debe actualizar directamente el saldo acumulado.
*/

using System;

namespace ejercicio4
{
    class Program
    {
        static void AplicarInteres(ref double saldo, ref double porcentaje, out double saldoac)
        {
            if(saldo > 0)
            {
                saldoac = saldo + (saldo*(porcentaje/100));
            }
            else
            {
                System.Console.WriteLine("Saldo negativo");
                saldoac = 0;
                
            }
        }
        static void Main(string[] args)
        {
            double saldo;
            double porcentaje;
            double saldoac;

            System.Console.WriteLine("Ingrese su saldo");
            saldo = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Ingrese su porcentaje de interes");
            porcentaje = int.Parse(Console.ReadLine());

            AplicarInteres(ref saldo, ref porcentaje, out saldoac);

            if(saldoac > 0)
            {
                System.Console.WriteLine("Saldo actual: "+saldoac);
            }
        }
    }
}