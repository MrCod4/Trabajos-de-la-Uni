using System;

namespace ejercicio2
{
    class Producto
    {
        public string nombre;
        public double precio;
        public int stock;

        public Producto(string nombre)
        {
            this.nombre = nombre;
            this.precio = 0;
            this.stock = 0;
            System.Console.WriteLine("Producto agregado correctamente");
        }

        public void MostrarInfo()
        {
            System.Console.WriteLine($"Nombre del producto: {nombre}");
            System.Console.WriteLine($"Precio del producto: {precio}");
            System.Console.WriteLine($"Stock del producto: {stock}");
        }
    }

    class Program
    {
        static void Main()
        {
            Producto producto1 = new Producto("Helado");

            System.Console.WriteLine($"Ingrese el precio del {producto1.nombre}");
            producto1.precio = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"Ingrese el stock del {producto1.nombre}");
            producto1.stock = int.Parse(Console.ReadLine());

            producto1.MostrarInfo();


        }
    }


}
