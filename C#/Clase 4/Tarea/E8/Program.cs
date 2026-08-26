/*Crea dos firmas sobrecargadas para la búsqueda en un sistema:
BuscarUsuario(int id) : busca al usuario únicamente utilizando su ID numérico.
BuscarUsuario(string correo, string clave) : autentica y busca al usuario mediante su correo y contraseña.
*/

using System;

namespace ejercicio8
{
    class Program
    {
        static void BuscarUsuario(int id)
        {
            if(id == 654321)
            {
                System.Console.WriteLine("Usuario: Sergio Sanchez Sepulveda");

            }else if(id == 765432)
            {
                System.Console.WriteLine("Usuario: Alfonso Rodriges Santivañez"); 
            }
            else
            {
                System.Console.WriteLine("Error, Usuario no encontrado");
            }
        }

        static void BuscarUsuario(string correo, string clave)
        {
            if(correo == "ssanchez@gmail.com" && clave == "hola123")
            {
                System.Console.WriteLine("Usuario: Sergio Sanchez Sepulveda");

            }else if(correo == "arodriges@gmail.com" && clave == "adios456")
            {
                System.Console.WriteLine("Usuario: Alfonso Rodriges Santivañez"); 
            }
            else
            {
                System.Console.WriteLine("Error, Usuario no encontrado");
            }
        }
        static void Main()
        {
            int opcion;
            int id;
            string correo;
            string clave;

            System.Console.WriteLine("Como desea buscar al usuario");
            System.Console.WriteLine("1. Por id de usuario");
            System.Console.WriteLine("2. Por correo y clave");
            opcion =  int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                System.Console.WriteLine("Ingrese la id del usuario");
                id = int.Parse(Console.ReadLine());
                BuscarUsuario(id);
                break;

                case 2:
                System.Console.WriteLine("Ingrese el correo del usuario");
                correo = Console.ReadLine();

                System.Console.WriteLine("Ingrese la clave del usuario");
                clave = Console.ReadLine();

                BuscarUsuario(correo, clave);
                break;

                default:
                System.Console.WriteLine("Ingrese una opcion valido");
                break;
            }
        }
    }
}
