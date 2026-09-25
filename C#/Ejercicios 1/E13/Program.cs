/*Crea una clase Personaje con Nombre , Vida (rango permitido entre 0 y 100) y Nivel (mayor a 0). Agrega
los métodos RecibirDanio(int cantidad) , Curarse(int cantidad) y MostrarEstado() . Pide al
usuario los datos del personaje y las acciones a realizar a través de la terminal, y realiza el diagrama de clases
UML. 
*/

using System;

class Personaje
{
    private string nombre;
    private int vida;
    private int nivel;

    public string Nombre
    {
        get{ return nombre; }
        set{ nombre = value; }
    }

    public int Vida
    {
        get{ return vida;}
        set
        {
            if(value >= 0 && value <= 100)
            {
                vida = value;
            }
        }
    }

    public int Nivel
    {
        get{ return nivel; }
        set
        {
            if(value > 0)
            {
                nivel = value;
            }
        }
    }

    public Personaje(string nombre, int vida, int nivel)
    {
        Nombre = nombre;
        Vida = vida;
        Nivel = nivel;

        System.Console.WriteLine("Personaje creado");
    }

    public void RecibirDanio(int cantidad)
    {
        if(cantidad >= 0)
        {
            Vida -= cantidad;

            if(Vida < 0)
            {
                Vida = 0;
            }
        }
        else
        {
            System.Console.WriteLine("CValor invalido");
        }
    }

    public void Curarse(int cantidad)
    {
        
        if(cantidad >= 0)
        {
            Vida += cantidad;

            if(Vida > 100)
            {
                Vida = 100;
            }
            else
            {
                System.Console.WriteLine("Valor invalido");
        
            }
        }
    }

    public void MostrarEstado()
    {
        System.Console.WriteLine("----------------------------");
        System.Console.WriteLine($"========{nombre}=======");
        System.Console.WriteLine($"Vida : {vida}");
        System.Console.WriteLine($"Nivel : {nivel}");
        System.Console.WriteLine("----------------------------");
        Thread.Sleep(1000);
    }    
}

class Program
{
    static void Main()
    {
        string nombre;
        int vida;
        int nivel;
        int opcion;

        System.Console.WriteLine("Ingrese el nombre del personaje");
        nombre = Console.ReadLine();

        System.Console.WriteLine("Ingrese la vida del personaje");
        vida = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Ingrese el nivel de su personaje");
        nivel = int.Parse(Console.ReadLine());

        Personaje p1 = new Personaje(nombre, vida, nivel);

        do
        {
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("Ingrese su opcion");
            System.Console.WriteLine("1. Recibir daño");
            System.Console.WriteLine("2. Curarse");
            System.Console.WriteLine("3. Mostrar informacion");
            System.Console.WriteLine("4. Salir");
            System.Console.WriteLine("----------------------------");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                System.Console.WriteLine("----------------------------");
                System.Console.WriteLine("Ingrese el daño a recibir");
                p1.RecibirDanio(int.Parse(Console.ReadLine()));
                break;

                case 2:
                System.Console.WriteLine("----------------------------");
                System.Console.WriteLine("Ingrese la cantidad de curacion");
                p1.Curarse(int.Parse(Console.ReadLine()));
                break;

                case 3:
                p1.MostrarEstado();
                break;

                case 4:
                System.Console.WriteLine("----------------------------");
                System.Console.WriteLine("Programa finalizado.");
                System.Console.WriteLine("----------------------------");
                break;

                default:
                System.Console.WriteLine("----------------------------");
                System.Console.WriteLine("Ingrese un valir valido");
                break;
            }


        } while(opcion != 4);
    }
}

