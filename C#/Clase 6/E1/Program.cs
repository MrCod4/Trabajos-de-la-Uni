/*Complete la clase Personaje para implementar un sistema básico de combate. El personaje debe recibir daño y
curarse según la lógica indicada en los comentarios.
*/

using System;

namespace ejercicio1
{
    class Personaje
    {
        public string nombre;
        public double puntosVida;
        public double ataqueBase;

        public void RecibirDaño(double cantidad)
        {
            puntosVida -= cantidad;
        }

        public void Curar(double cantidad)
        {
            puntosVida += cantidad;
        }
    }
    class Program
    {
        static void Main()
        {
            Personaje p1 = new Personaje();
            p1.nombre = "Link";
            p1.puntosVida = 100;
            p1.ataqueBase = 25;

            Personaje p2 = new Personaje();
            p2.nombre = "Ganondorf";
            p2.puntosVida = 200;
            p2.ataqueBase = 50;

            int opcion;

            System.Console.WriteLine("Ganondorf te encuentra y se acerca a atacarte");

            do
            {
                System.Console.WriteLine("---------------------------------------");
                System.Console.WriteLine($"Tu vida = {p1.puntosVida}");
                System.Console.WriteLine($"La vida de ganindorf = {p2.puntosVida}");
                Thread.Sleep(1000);

                if(p1.puntosVida >= 100)
                {
                    System.Console.WriteLine($"Ganondorf empieza el turno quitandote {p2.ataqueBase} de vida!!");
                    p1.RecibirDaño(p2.ataqueBase);
                    Thread.Sleep(500);
                }
                else
                {
                    System.Console.WriteLine("Gnondorf rie, no parece hacer nada mas...");
                    Thread.Sleep(500);
                }

                System.Console.WriteLine("Es tu turno, seleccione la acción");
                System.Console.WriteLine("1.Atacar");
                System.Console.WriteLine("2.Curarse");
                System.Console.WriteLine("3.Atacar y curarse (Es posible que sea poco efectivo)");

                opcion = int.Parse(Console.ReadLine());
                Thread.Sleep(500);

                switch (opcion)
                {
                    case 1:
                    System.Console.WriteLine($"Link hace un ataque muy efectivo y le hace {p1.ataqueBase} pts de daño a ganondorf");
                    p2.RecibirDaño(p1.ataqueBase*2);
                    Thread.Sleep(500);
                    break;

                    case 2:
                    System.Console.WriteLine("Link usa una pocion y se cura 50ps, a ganondorf no le gusto eso..");
                    p1.Curar(50);
                    Thread.Sleep(500);

                    System.Console.WriteLine("Ganondorf se enoja, su ataque aumenta en un 20%!!!!");
                    p2.ataqueBase *=1.20;
                    Thread.Sleep(500);
                    break;

                    case 3:
                    System.Console.WriteLine("Link hace un ataque poco efectivo... pero algo cambia");
                    p2.RecibirDaño(p1.ataqueBase/2);
                    p1.Curar(25);
                    Thread.Sleep(500);

                    System.Console.WriteLine("Los puntos de vida base de link aumentan, su daño tambien");
                    p1.puntosVida *=1.25;
                    p1.ataqueBase *=1.50;
                    Thread.Sleep(500);

                    System.Console.WriteLine("Ganondorf se ve asustado");
                    Thread.Sleep(500);
                    System.Console.WriteLine("Su ataque baja pero su vida aumenta!!!");
                    p2.ataqueBase *=0.95;
                    p2.puntosVida *=1.50;
                    Thread.Sleep(500);
                    break;

                    default:
                    System.Console.WriteLine("Ganondorf: HAHAHAHAHAHA idiota");
                    Thread.Sleep(500);
                    System.Console.WriteLine("Por usar una opcion invalida");
                    Thread.Sleep(500);
                    System.Console.WriteLine("Como penalisacion, Ganondorf termina con tu miserable existencia");
                    Thread.Sleep(500);
                    System.Console.WriteLine("Tus ps se reducen a 0");
                    Thread.Sleep(500);
                    p1.RecibirDaño(p1.puntosVida);
                    break;
                }

                if(p1.puntosVida > 0 && p2.puntosVida <= 0)
                {
                    System.Console.WriteLine("Has ganado el combate");
                }
                else
                {
                    System.Console.WriteLine("Has perdido el conbate");
                }
            }
            while(p1.puntosVida > 0 && p2.puntosVida > 0); 
        }
    }
}
