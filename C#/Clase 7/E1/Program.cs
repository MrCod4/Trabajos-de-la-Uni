using System;

namespace ejercicio1
{
    class Animal
    {
        public string nombre {get; set;}
        public int edad {get; set;}

        public void Comer()
        {
            System.Console.WriteLine($"{nombre}, esta comiento");
        }
    }

    class Perro : Animal
    {
        public string raza {get; set;}

        public void Ladrar()
        {
            System.Console.WriteLine($"{nombre}, esta ladrando");
        }
    }
    class Program
    {
        static void Main()
        {
            Perro perro = new Perro();

            perro.nombre = "Max";
            perro.edad = 3;
            perro.raza = "Labrador";

            perro.Comer();
            perro.Ladrar();
        }
    }
}
