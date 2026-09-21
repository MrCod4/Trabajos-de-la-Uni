using System;

namespace ejercicio2
{
    class Vehiculo
    {
        public string patente {get; set;}
        public int velocidad {get; set;}

        public void Acelerar()
        {
            velocidad += 10;
            System.Console.WriteLine($"El auto ahora va a {velocidad} km/h");

            Thread.Sleep(500);
        }

        public void Frenar()
        {
            velocidad -= 10;
            System.Console.WriteLine($"El auto ahora va a {velocidad} km/h");

            Thread.Sleep(500);
        }
    }

    class Automovil : Vehiculo
    {
        public string color {get; set;}

        public void Cambiocolor(string nuevocolor)
        {
            color = nuevocolor;
            System.Console.WriteLine($"El color del auto cambio a {color}");
        }
    }

    class Motocicleta : Vehiculo
    {
        public double LitrosDeCombustible {get; set;}

        public void llenartanque()
        {
            LitrosDeCombustible += 10;
        }
    }


    class Program
    {
        static void Main()
        {
            Automovil auto = new Automovil();

            auto.patente = "sc-br-99";
            auto.velocidad = 100;
            auto.color = "verde";

            string color;

            System.Console.WriteLine("Ingrese el color nuevo");
            color = Console.ReadLine();

            auto.Cambiocolor(color);
            auto.Acelerar();
            auto.Frenar();
        }
    }
}
