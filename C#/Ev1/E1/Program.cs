using System;

namespace Evaluacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            char opcion2 = 'c';
            char mayor;

            int a = 0;
            int c = 0;
            int m = 0;

            int contadorA = 0;
            int contadorC = 0;
            int contadorM = 0;
            int contadorG = 0;
            int invalido = 0;


            do
            {
                System.Console.WriteLine("Que objero desea ingresar");
                System.Console.WriteLine("A. Analisadores de cable");
                System.Console.WriteLine("C. Equipos de conectividad");
                System.Console.WriteLine("M. Herramientas Manuales");
                opcion = char.Parse(Console.ReadLine());

                if(opcion == 'a' || opcion == 'A')
                {
                    System.Console.WriteLine("Cual es la cantidad del elemento ingresado");
                    a = int.Parse(Console.ReadLine());

                    contadorA = contadorA + a;

                }else if(opcion == 'c' || opcion == 'C')
                {
                    System.Console.WriteLine("Cual es la cantidad del elemento ingresado");
                    c = int.Parse(Console.ReadLine());

                    contadorC = contadorC + c;

                }else if(opcion == 'm' || opcion == 'M')
                {

                   System.Console.WriteLine("Cual es la cantidad del elemento ingresado");
                   m = int.Parse(Console.ReadLine());

                    contadorM = contadorM + m;

                }
                else
                {
                    System.Console.WriteLine("Error, objeto invalido");
                    invalido = 1;
                }

                if (a < 0 || c < 0 || m < 0)
                {
                    System.Console.WriteLine("Error, cantidad invalida");
                    invalido = 1;
                }

                if(invalido == 0)
                {
                    System.Console.WriteLine("Desea agregar otro elemento S/N");
                    opcion2 = char.Parse(Console.ReadLine());
                }

            }while(opcion2 == 'S' || opcion2 == 's' && invalido == 0);

            contadorG = contadorA + contadorC + contadorM;

            if(contadorA < contadorC && contadorC > contadorM)
            {
                mayor = 'C';

            }else if (contadorA > contadorC && contadorA > contadorM)
            {
                mayor = 'A';
            }
            else
            {
                mayor = 'M'; 
            }

            System.Console.WriteLine("----------------Objetos ingresados----------------");
            System.Console.WriteLine("Cantidad de Analisadores de cable: "+contadorA);
            System.Console.WriteLine("Equipos de conectividad: "+contadorC);
            System.Console.WriteLine("Herramientas Manuales: "+contadorM);
            System.Console.WriteLine("Total de articulos agregados: "+contadorG);
            System.Console.WriteLine("Articulo con mayor cantidad agregada: "+mayor);

        }
    }
}