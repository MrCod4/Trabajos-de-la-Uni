/*Crea una clase Persona con los atributos Nombre y Edad . Debe incluir un constructor que reciba ambos datos.
En el programa principal, solicita al usuario que ingrese los valores por la terminal para instanciar el objeto y
mostrar su información en pantalla. Asimismo, elabora el diagrama de clases UML correspondiente. 
*/

using System;

namespace ejercicio3
{
    class Videojuego
    {
        public string nombre;
        public string plataforma;
        public int precio;

        public Videojuego(string nombre, string plataforma, int precio)
        {
            this.nombre = nombre;
            this.plataforma = plataforma;
            this.precio = precio;

            System.Console.WriteLine("Videojuego agragado exitosamente");
            Thread.Sleep(500);
        }

        public void MostrarInfo()
        {
            System.Console.WriteLine($"Nombre del juego : {nombre}");
            System.Console.WriteLine($"Plataforma del juego : {plataforma}");
            System.Console.WriteLine($"Precio del juego : {precio}");
        }
    }
    class Program
    {
        static void Main()
        {
            string nombre;
            string plataforma;
            int precio;

            System.Console.WriteLine("Ingrese el nombre del videojuego");
            nombre = Console.ReadLine();

            System.Console.WriteLine("Ingrese la plataforma del videojuego");
            plataforma = Console.ReadLine();

            System.Console.WriteLine("Ingrese el precio del videojuego");
            precio = int.Parse(Console.ReadLine());

            Videojuego v1 = new Videojuego(nombre, plataforma, precio);

            v1.MostrarInfo();
        }
    }
}
