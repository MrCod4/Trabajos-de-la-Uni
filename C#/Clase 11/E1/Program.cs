using System;

class Enemigo
{
    private string nombre;
    private int ptsSalud;
    protected double velocidad;

    public string Nombre
    {
        get{return nombre;}
        set{nombre = value;}
    }

    public int PtsSalud
    {
        get{return ptsSalud;}
        set
        {
            if(value < 0)
            {
                ptsSalud = 0;
            }
            else if(value > 100)
            {
                ptsSalud = 100;
            }
            else
            {
                ptsSalud = value;
            }
        }
    }

    public double Velocidad
    {
        get{return velocidad;}
        set{velocidad = value;}
    }

    public virtual void EjecutarComportamiento()
    {
        System.Console.WriteLine("El enemigo realiza un comportamiento, no se cual, pero es un comportamiento");
    }

    public Enemigo(string nombre, int ptsSalud, double velocidad)
    {
        Nombre = nombre;
        PtsSalud = ptsSalud;
        Velocidad = velocidad;
    }

    public Enemigo()
    {
        
    }
}

class Espectro : Enemigo
{
    public Espectro(string nombre, int ptsSalud, double velocidad)
    {
        Nombre = nombre;
        PtsSalud = ptsSalud;
        Velocidad = velocidad;
    }

    public override void EjecutarComportamiento()
    {
        System.Console.WriteLine("El espectro sale de las paredes y ataca al jugador");
    }
}

class Caminante : Enemigo
{
    public Caminante(string nombre, int ptsSalud, double velocidad)
    {
        Nombre = nombre;
        PtsSalud = ptsSalud;
        Velocidad = velocidad;
    }

    public override void EjecutarComportamiento()
    {
        System.Console.WriteLine("El caminante camina hacia el jugador");
    }
}

class Sombra : Enemigo
{
    public Sombra(string nombre, int ptsSalud, double velocidad)
    {
        Nombre = nombre;
        PtsSalud = ptsSalud;
        Velocidad = velocidad;
    }

    public override void EjecutarComportamiento()
    {
        System.Console.WriteLine("La sombra aparece detras de el jugador y lo ataca");
    }
}

class Program
{
    static void Main()
    {
        string nombre;
        int vida;
        double velocidad;
        int opcion;

        List<Enemigo> enemigos = new List<Enemigo>();

        do
        {
            System.Console.WriteLine("--------------------------------------");
            System.Console.WriteLine("Ingrese su opcion");
            System.Console.WriteLine("1. Ingresar un Espectro");
            System.Console.WriteLine("2. Ingresar un Caminante");
            System.Console.WriteLine("3. Ingresar una Sombra");
            System.Console.WriteLine("4. Realizar acciones");
            System.Console.WriteLine("5. Salir");
            System.Console.WriteLine("--------------------------------------");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    System.Console.WriteLine("--------------------------------------");
                    System.Console.WriteLine("Ingrese el nombre de la entidad");
                    nombre = Console.ReadLine();

                    System.Console.WriteLine("Ingrese la vida de la entidad");
                    vida = int.Parse(Console.ReadLine());

                    System.Console.WriteLine("Ingrese la velocidadde la entidad");
                    velocidad = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("--------------------------------------");

                    enemigos.Add(new Espectro(nombre, vida, velocidad));
                break;

                case 2:
                    System.Console.WriteLine("--------------------------------------");
                    System.Console.WriteLine("Ingrese el nombre de la entidad");
                    nombre = Console.ReadLine();

                    System.Console.WriteLine("Ingrese la vida de la entidad");
                    vida = int.Parse(Console.ReadLine());

                    System.Console.WriteLine("Ingrese la velocidadde la entidad");
                    velocidad = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("--------------------------------------");

                    enemigos.Add(new Espectro(nombre, vida, velocidad));
                break;

                case 3:
                    System.Console.WriteLine("--------------------------------------");
                    System.Console.WriteLine("Ingrese el nombre de la entidad");
                    nombre = Console.ReadLine();

                    System.Console.WriteLine("Ingrese la vida de la entidad");
                    vida = int.Parse(Console.ReadLine());

                    System.Console.WriteLine("Ingrese la velocidadde la entidad");
                    velocidad = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("--------------------------------------");

                    enemigos.Add(new Espectro(nombre, vida, velocidad));
                break;

                case 4:
                    foreach(Enemigo enemigo in enemigos)
                    {
                        enemigo.EjecutarComportamiento();
                    }
                break;

                case 5:
                    System.Console.WriteLine("Programa finalizado.");
                break;

                default:
                    System.Console.WriteLine("Seleccione una opcion invalida.");
                break;
            }

        }while(opcion != 5);
    }
}