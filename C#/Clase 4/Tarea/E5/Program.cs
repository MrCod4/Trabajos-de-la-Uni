/*Escribe el método ConvertirSegundos que reciba una cantidad total de segundos y devuelva mediante
tres parámetros out el equivalente en horas, minutos y segundos sobrantes.*/

using System;

namespace ejercicio5
{
    class Program
    {

        static void ConvertirSegundos(ref int segundos, out int minutos, out int horas, out int segrestantes)
        {
            horas = segundos/3600;
            int segrestanteshora = segundos % 3600;
            minutos = segrestanteshora/60;
            segrestantes = segrestanteshora % 60;
        }
        static void Main(string[] args)
        {
            int segundos;
            int minutos;
            int horas;
            int segrestantes;

            System.Console.WriteLine("Ingrese sus segundos a convertir");
            segundos = int.Parse(Console.ReadLine());

            ConvertirSegundos(ref segundos, out minutos, out horas, out segrestantes);

            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("Minutos: "+minutos);
            System.Console.WriteLine("Horas: "+horas);
            System.Console.WriteLine("Segundos restantes: "+segrestantes);
        }
    }
}