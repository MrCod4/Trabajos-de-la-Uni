/*Crea una clase CuentaAhorro con Titular , Saldo y NumeroCuenta . Incluye un constructor para inicializar
la cuenta. El saldo debe estar encapsulado y solo poder modificarse a través de Depositar() y Retirar() ,
evitando saldos negativos. Permite al usuario ingresar los montos a operar por la terminal e ilustra la estructura en
un diagrama UML.
*/

using System;

class CuentaAhorro
{
    private string Titular;
    private double saldo;
    private int NumeroCuenta;

    public double Saldo
    {
        get {return saldo;}
        set
        {
            if (value > 0)
            {
                saldo = value;
            }
            else
            {
                System.Console.WriteLine("El saldo ingresado es invalido");
            }
        }
    }

    public CuentaAhorro(string titular, double saldo, int numerocuenta)
    {
        Titular = titular;
        Saldo = saldo;
        NumeroCuenta = numerocuenta;

        System.Console.WriteLine("Cuenta cresada exitosamente");
    }

    public void Depositar(double cantidad)
    {
        if(cantidad > 0)
        {
            System.Console.WriteLine($"Se han ingresado ${cantidad} exitosamente");
            Saldo += cantidad;
        }
        else
        {
            System.Console.WriteLine("Valor invalido");
        }
    }

    public void Retirar(double cantidad)
    {
        if(cantidad < saldo && cantidad > 0)
        {
            System.Console.WriteLine($"Se han retirado ${cantidad} exitosamente");
            Saldo -= cantidad;
        }
        else if (cantidad > saldo)
        {
            System.Console.WriteLine("Saldo insuficiente");
        }
        else
        {
            System.Console.WriteLine("Valor invalido");
        }
    }
}

class Program
{
    static void Main()
    {
        CuentaAhorro c1 = new CuentaAhorro("Juan", 100000, 213);

        int opcion;

        System.Console.WriteLine("------------------------");
        System.Console.WriteLine("Ingrese su opcion");
        System.Console.WriteLine("1. Depositar");
        System.Console.WriteLine("2. Retirar");
        System.Console.WriteLine("------------------------");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
            System.Console.WriteLine("Ingrese el monto a depositar");
            c1.Depositar(double.Parse(Console.ReadLine()));
            break;

            case 2:
            System.Console.WriteLine("Ingrese el monto a retirar");
            c1.Retirar(double.Parse(Console.ReadLine()));
            break;

            default:
            System.Console.WriteLine("Invese un valor invalido");
            break;
        }
    }
}
