/*Complete el método CalcularTotalConIva() y la lógica para verificar si hay stock disponible antes de realizar
una venta*/

using System;
using System.Security.Cryptography.X509Certificates;

namespace ejercicio2
{
    class ProductoTienda
    {
        public string codigo;
        public string nombre;
        public double precioNeto;
        public int stock;

        public double CalcularPrecioFinal(int cantidad)
        {
            return precioNeto*cantidad*1.19;
        }

        public bool Vender(int cantidad)
        {
            if (stock >= cantidad)
            {
                stock = stock - cantidad;
                return true;
            }
            else
            {
                return false;
            }
        }


    }
    class Program
    {
        static void Main()
        {
            ProductoTienda p1 = new ProductoTienda();
            p1.codigo = "1225";
            p1.nombre = "Nintendo Switch";
            p1.precioNeto = 290000;
            p1.stock = 5;

            int cantidad;

            do
            {
                System.Console.WriteLine("Cual va a ser la cantidad de productos que desea comprar");
                cantidad = int.Parse(Console.ReadLine());

                if(p1.Vender(cantidad) == true)
                {
                    System.Console.WriteLine($"El total a pagar seran {p1.CalcularPrecioFinal(cantidad)}");
                }
                else
                {
                    System.Console.WriteLine("Stock insuficiente");
                }
            }
            while(p1.stock != 0);

        }
    }
}
