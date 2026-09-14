/*Crea una clase CuentaBancaria con Titular y un atributo privado saldo que no permita valores negativos.
Utiliza una Property para consultar y asignar el saldo. Solicita por consola los datos iniciales y luego pide ingresar
un valor válido y uno negativo para comprobar la validación. Genera el diagrama UML de la clase. */

using System;

namespace ejercicio7
{
    class CuentaBancaria
    {
        private string titular;
        private double saldo;

        public string Titular
        {
            get
            {
                return titular;
            }

            set
            {
                titular = value;
            }
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                if(value >= 0)
                {
                    System.Console.WriteLine("Transaccion exitosa");
                    saldo += value;
                }
                else
                {
                    System.Console.WriteLine("No se pueden ingresar datos negativos");
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            CuentaBancaria c1 = new CuentaBancaria();

            System.Console.WriteLine("Ingrese el nombre del titular");
            c1.Titular = Console.ReadLine();

            System.Console.WriteLine("Cuanto dinero quiere ingresar");
            c1.Saldo = double.Parse(Console.ReadLine());

            System.Console.WriteLine("=== Datos del titular ===");
            System.Console.WriteLine($"Titular : {c1.Titular}");
            System.Console.WriteLine($"Saldo : ${c1.Saldo}");
        }
    }
}
