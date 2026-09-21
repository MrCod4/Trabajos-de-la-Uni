/*Crea una clase Producto con Nombre , Precio y Stock , todos encapsulados. El precio y el stock no pueden
asumir valores negativos. Diseña un constructor y el método MostrarInformacion() . Solicita los datos por
consola para instanciar el producto y confecciona el diagrama UML. 
*/

using System;

namespace ejercicio12
{
    class Producto
    {
        private string nombre;
        private double precio;
        private int stock;

        public string Nombre
        {
            get{return nombre;}
            set{nombre = value;}
        }

        public double Precio
        {
            get{return precio;}
            set
            {
                if(value >= 0)
                {
                    precio = value;
                }
                else
                {
                    System.Console.WriteLine("Valor invalido");
                }
            }
        }

        public int Stock
        {
            get{return stock;}
            set
            {
                if(value >= 0)
                {
                    stock = value;
                }
                else
                {
                    System.Console.WriteLine("Valor invalido");
                }
            }
        }

        public Producto()
        {
            stock = 0;
            precio = 0;
            System.Console.WriteLine("Producto creado exitosamente");
        }

        public void MostrarInformacion()
        {
            System.Console.WriteLine($"Nombre del producto : {nombre}");
            System.Console.WriteLine($"Precio del producto : {precio}");
            System.Console.WriteLine($"Stock del producto : {stock}");
        }


    }
    class Program
    {
        static void Main()
        {
            Producto p1 = new Producto();
            System.Console.WriteLine("Ingrese el nombre del producto");
            p1.Nombre = Console.ReadLine();

            System.Console.WriteLine("Ingrese el Precio del producto");
            p1.Precio = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Ingrese el stock del producto");
            p1.Stock = int.Parse(Console.ReadLine());

            p1.MostrarInformacion();

        }
    }
}
