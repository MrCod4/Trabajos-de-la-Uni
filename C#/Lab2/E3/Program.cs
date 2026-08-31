/*Escriba en C# la clase completa representada en el diagrama UML junto con el programa de prueba en Main():*/
namespace ejercicio3
{
    class SensorTemp
    {
        public string ubicacion;
        public double lecturaActual;
        public double umbralAlerta;

        public void RegistrarLectura(double nuevaTemp)
        {
            lecturaActual = nuevaTemp;
        }

        public string EvaluarEstado()
        {
            if(lecturaActual > umbralAlerta)
            {
                return "Alerta: Temperatura Critica";
            }
            else
            {
                return "Estado Normal";
            } 
        }
    }
    class Program
    {
        static void Main()
        {
            SensorTemp s1 = new SensorTemp();
            s1.ubicacion = "Laboratorio 1";
            s1.umbralAlerta = 35.0;

            double nuevatemp;

            System.Console.WriteLine("Ingrese la temp registrada");
            nuevatemp = double.Parse(Console.ReadLine());
            s1.RegistrarLectura(nuevatemp);
            
            System.Console.WriteLine(s1.EvaluarEstado());
        }
    }
}