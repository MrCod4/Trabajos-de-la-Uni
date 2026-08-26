using System;

namespace ejercicio2
{
    class Program
    {
        static double Csn(double sb, double pd)
        {
            double R;

            R = sb - (sb*(pd/100));

            return R;
        }

        static void Main(string[] agrs)
        {
            double Salario;
            double descuento;
            double salarioneto;

            System.Console.WriteLine("Ingrese su salario");
            Salario = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Ingrese su porcentaje de descuento");
            descuento = double.Parse(Console.ReadLine());

            salarioneto = Csn(Salario, descuento);

            System.Console.WriteLine("su salario neto es : "+salarioneto);
        }
    }
}
