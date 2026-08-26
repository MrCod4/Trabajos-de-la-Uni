/*Crea una función llamada CalcularPrecioFinal que reciba el precio original de un producto y el
porcentaje de descuento (por valor). La función debe validar que los datos sean positivos y retornar el
valor a pagar.*/

using System;

namespace ejercicio1
{
    class Program
    {
        static double CalcularPrecioF(double vi, double d)
        {   
            double vf;

            if(vi >= 0 && d >= 0)
            {

            vf = vi - (vi*(d/100));

            return vf;

            }
            else
            {
                System.Console.WriteLine("Valores invalidos");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            double valori;
            double descuento;
            double valorfinal;

            System.Console.WriteLine("Ingrese el precio del producto");
            valori = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Ingrese el descuento del producto");
            descuento = int.Parse(Console.ReadLine());

            valorfinal = CalcularPrecioF(valori, descuento);

            if(CalcularPrecioF(valori, descuento) > 0)
            {
                System.Console.WriteLine("El precio final a pagar es: "+valorfinal);
            }
        }
    }
}
