/*Crea una clase Termometro con un atributo privado para la temperatura, el cual solo debe aceptar valores dentro
del rango de -50 a 60. Diseña una Property con esta validación, solicita la lectura de temperatura por terminal al
usuario y elabora el diagrama UML.*/

using System;

namespace ejercicio9
{
    class Termometro
    {
        private double temperatura;

        public double Temperatura
        {
            get{ return temperatura; }
            set
            {
                if(value >= -50 && value <= 60)
                {
                    temperatura = value;
                }
            }
        }

        public Termometro(double temperatura)
        {
            Temperatura = temperatura;
            System.Console.WriteLine("Termometro agreagdo correcatmente");
        }

        public void MostrarInfo()
        {
            System.Console.WriteLine($"Temperatura del termometro : {temperatura}");
        }
    }
    class Program
    {
        static void Main()
        {
            double temperatura;

            System.Console.WriteLine("Ingrese la temperatura del termometro");
            temperatura = double.Parse(Console.ReadLine());

            Termometro t1 = new Termometro(temperatura);

            t1.MostrarInfo();
        }
    }
}
