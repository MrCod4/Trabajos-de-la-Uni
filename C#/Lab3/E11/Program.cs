/*Crea una clase Vehiculo con Patente , Marca , Modelo y Velocidad (todos privados). Incluye un
constructor que reciba la patente, marca y modelo, e inicialice la velocidad en 0. Agrega los métodos
Acelerar(int cantidad) , Frenar(int cantidad) y MostrarInformacion() , garantizando que la
velocidad nunca sea negativa. Permite al usuario interactuar mediante la terminal para modificar la velocidad y
presenta el diagrama UML de la clase. */

using System;

namespace ejercicio11
{
    class Vehiculo
    {
        private string patente;
        private string marca;
        private string modelo;
        private double velocidad;

        public Vehiculo(string patente, string marca, string modelo)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;

            velocidad = 0;
            System.Console.WriteLine("Vehiculo ingresado con exito");
        }

        public void Acelerar(double cantidad)
        {
           velocidad += cantidad; 
        }

        public void Frenar(double cantidad)
        {
            velocidad -= cantidad;
        }

        public void MostrarInformacion()
        {
            System.Console.WriteLine("-------------------------------------");
            System.Console.WriteLine($"Patente del vehiculo : {patente}");
            System.Console.WriteLine($"Marca del vehiculo : {marca}");
            System.Console.WriteLine($"Modelo del vehiculo : {modelo}");
            System.Console.WriteLine($"Velocidad del vehiculo : {velocidad}");
        }

    }
    class Program
    {
        static void Main()
        {

            int opcion;
            string patente;
            string marca;
            string modelo;

            System.Console.WriteLine("Ingrese la partente del auto");
            patente = Console.ReadLine();

            System.Console.WriteLine("Ingrese la marca del auto");
            marca = Console.ReadLine();

            System.Console.WriteLine("Ingrese el modelo del auto");
            modelo = Console.ReadLine();


            Vehiculo v1 = new Vehiculo(patente, marca, modelo);

            do
            {
                
                System.Console.WriteLine("---------------------------------");
                System.Console.WriteLine("Decida una opcion");
                System.Console.WriteLine("1. Acelerar");
                System.Console.WriteLine("2. Feranar");
                System.Console.WriteLine("3. MostrarInfo");
                System.Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                    System.Console.WriteLine("Cuanto va a acelerar");
                    v1.Acelerar(double.Parse(Console.ReadLine()));
                    break;

                    case 2:
                    System.Console.WriteLine("Cuanto va a frenar");
                    v1.Frenar(double.Parse(Console.ReadLine()));
                    break;

                    case 3:
                    v1.MostrarInformacion();
                    break;

                    case 4:
                    System.Console.WriteLine("Programa finalizado");
                    break;

                    default:
                    System.Console.WriteLine("Ingrese un valor valido");
                    break;
                }
                
            }while(opcion != 4);
        }
    }
}
