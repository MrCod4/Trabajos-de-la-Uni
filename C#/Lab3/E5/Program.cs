/*Crea una clase Producto con los atributos privados nombre y precio . El precio debe estar protegido
mediante una Property ( get , set y value ) para evitar valores negativos. Pide los datos al usuario por terminal
para probar la asignación y elabora el diagrama de clases UML.*/

using System;

namespace ejercicio5
{
    class Producto
    {
        private string nombre;
        private double precio;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public double Precio
        {
            get
            {
                return precio;
            }

            set
            {
                if(value >= 0)
                {
                    precio = value;
                }
                else
                {
                    System.Console.WriteLine("No se pueden ingresar valores negativos");
                }

            }
        }
    }
    class Program
    {
        static void Main()
        {
            Producto p1 = new Producto();

            System.Console.WriteLine("Ingrese el nombre del producto");
            p1.Nombre = Console.ReadLine();

            System.Console.WriteLine("Ingrese el precio del producto");
            p1.Precio = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"Nombre del producto : {p1.Nombre}");
            System.Console.WriteLine($"Precio del producto : {p1.Precio}");
        }
    }
}
