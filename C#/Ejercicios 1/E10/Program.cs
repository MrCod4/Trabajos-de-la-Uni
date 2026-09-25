/*Crea una clase CuentaBancaria cuyo saldo sea privado y solo accesible mediante una Property de lectura
( get sin set público). Incorpora los métodos Depositar(decimal monto) y Retirar(decimal monto) ,
asegurando que solo se procesen montos positivos y que no se pueda retirar más dinero del disponible. Solicita las
operaciones al usuario por terminal y realiza el diagrama UML de la clase. 
*/

using System;

namespace ejercicio10
{
    class CuentaBancaria
    {
        private double saldo;
        public double Saldo
        {
            get{ return saldo; }
        }

        public void Depositar(double monto)
        {
            if(monto > 0)
            {
                saldo += monto;
                System.Console.WriteLine($"Se ha realizado el deposito de ${saldo} a su cuenta bancaria");
            }
            else
            {
                System.Console.WriteLine("El monto a depositar tiene que ser positivo");
            }
        }       

        public void Retirar( double monto)
        {
            if(monto > saldo)
            {
                System.Console.WriteLine("Fondos insuficientes");
            }
            else if(monto > 0)
            {
                saldo -= monto;
                System.Console.WriteLine($"Se ha realizado el retiro de ${monto} correctamente");
            }
            else
            {
                System.Console.WriteLine("No se pueden usar valores negativos");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            CuentaBancaria c1 = new CuentaBancaria();

            int opcion;

            do
            {
                System.Console.WriteLine("Decida una opcion");
                System.Console.WriteLine("1. Depositar");
                System.Console.WriteLine("2. Retirar");
                System.Console.WriteLine("3, Consultar saldo");
                System.Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                    System.Console.WriteLine("Ingrese el monto a depositar");
                    c1.Depositar(double.Parse(Console.ReadLine()));
                    break;

                    case 2:
                    System.Console.WriteLine("Ingrese el monto a  retirar");
                    c1.Retirar(double.Parse(Console.ReadLine()));
                    break;

                    case 3:
                    System.Console.WriteLine($"Saldo actual : {c1.Saldo}");
                    break;

                    case 4:
                    System.Console.WriteLine("Programa finalizado");
                    break;

                    default:
                    System.Console.WriteLine("Opcion invalida");
                    break;
                }
            }
            while(opcion != 4);
        }
    }
}
