using System;

namespace ejercicio1
{
    public class Vehiculo
    {
        public string Marca;
        public string Modelo;
        public string Patente;
        public double Velocidad;

        public void Acelerar()
        {
            Velocidad += 10;
        }

        public void Frenar()
        {
           Velocidad -= 10; 
        }

        public void Mostrar_info()
        {
            System.Console.WriteLine("-----Informaciion del vehiculo-----");
            System.Console.WriteLine("Patente: "+Patente);
            System.Console.WriteLine("Marca: "+Marca);
            System.Console.WriteLine("Modelo: "+Modelo);
            System.Console.WriteLine("Velocidad: "+Velocidad);
        }

    }
    class Program
    {
        static void Main()
        {
            string patente;
            string marca;
            string modelo;
            double velocidad;

            System.Console.WriteLine("Ingrese la patente del auto");
            patente = Console.ReadLine();

            System.Console.WriteLine("Ingrese la marca del vehiculo");
            marca = Console.ReadLine();

            System.Console.WriteLine("Ingrese la modelo del vehiculo");
            modelo = Console.ReadLine();

            System.Console.WriteLine("Ingrese la velocidad del vehiculo");
            velocidad = double.Parse(Console.ReadLine());

            //Creacion del objeto 
            Vehiculo v1 = new Vehiculo();
            v1.Patente = patente;
            v1.Marca = marca;
            v1.Modelo = modelo;
            v1.Velocidad = velocidad;

            //uso de la funcion
            v1.Acelerar();
            v1.Mostrar_info();
            
        }
    }
}
