/*A partir del siguiente requerimiento, diseñe el diagrama de clases en sintaxis Mermaid (classDiagram) y luego
escriba la solución en C#:
Requerimiento del sistema:
Se requiere representar una CuentaBancaria que posee los atributos públicos numeroCuenta (string), titular
(string) y saldo (double). La clase debe incluir los métodos:
Depositar(monto: double): void — Aumenta el saldo si el monto es positivo.
Retirar(monto: double): bool — Disminuye el saldo si hay fondos suficientes y retorna true; de lo
contrario retorna false.
ConsultarSaldo(): string — Retorna la información de la cuenta formateada.
*/

using System;

namespace ejercicio4
{
    class CuentaBancaria
    {
        public string numeroCuenta;
        public string titular;
        public double saldo;

        public void Depositar(double monto)
        {
            if(monto > 0)
            {
                saldo += monto;

                System.Console.WriteLine("Espere unos segundos...");
                Thread.Sleep(2000);

                System.Console.WriteLine("Dinero depositado exitosamente");
            }
            else
            {
                System.Console.WriteLine("Espere unos segundos...");
                Thread.Sleep(2000);
                System.Console.WriteLine("Cantidad Invalida");
            }
        }

        public bool Retirar(double monto)
        {
            if(saldo > 0 && saldo >= monto)
            {
                saldo -= monto;

                System.Console.WriteLine("Espere unos segundos...");
                Thread.Sleep(2000);

                System.Console.WriteLine("Dinero retirado exitosamente");
                return true;
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente pare retiro");
                return false;
            }
        }

        public string ConsultarSaldo()
        {
            return $"Su saldo es ${saldo}";
        }
    }
    class Program
    {
        static void Main()
        {
            CuentaBancaria c1 = new CuentaBancaria();
            c1.numeroCuenta = "26037";
            c1.titular = "Juanito Pérez";
            c1.saldo = 150000;

            int opcion;
            char opcion2;

            System.Console.WriteLine("Seleccione una opcion");
            System.Console.WriteLine("1.Retirar dinero");
            System.Console.WriteLine("2.Depositar dinero");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                System.Console.WriteLine("Cuanto dinero desea retirar");
                c1.Retirar(double.Parse(Console.ReadLine()));
                break;

                case 2:
                System.Console.WriteLine("Cuanto dinero desea agregar");
                c1.Depositar(double.Parse(Console.ReadLine()));
                break;

                default:
                System.Console.WriteLine("Ingrese una opcion valida");
                break;
            }

            System.Console.WriteLine("Quiere consultar su saldo S/N");
            opcion2 = char.Parse(Console.ReadLine());

            if(opcion2 == 's' || opcion2 == 'S')
            {
                System.Console.WriteLine(c1.ConsultarSaldo());
            }
            else
            {
                System.Console.WriteLine("Ok, gracias por usar nustro banco");
            }


        }
    }
}
