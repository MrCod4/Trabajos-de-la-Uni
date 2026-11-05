using System;

class EntidadSotano
{
    protected string nombre;
    protected int puntosvida;
    protected int daniobase;

    public int Puntosvida
    {
        get{return puntosvida;}
        set
        {
            if(value <= 0)
            {
                puntosvida = 0;
                System.Console.WriteLine($"¡{nombre} ha sido derrotado y desvanecido en el sótano!");
            }
        }
    }

    public virtual void EjecutarAtaque()
    {
        System.Console.WriteLine($"{nombre} hace un ataque, no se cual, pero ataco");
    }

    public EntidadSotano(string nombre, int puntosvida, int daniobase)
    {
        this.nombre = nombre;
        Puntosvida = puntosvida;
        this.daniobase = daniobase;
    }

    public EntidadSotano()
    {
        
    }
}

class MoscaEnemiga : EntidadSotano
{
    public override void EjecutarAtaque()
    {
        System.Console.WriteLine($"{nombre} se hacerca volando y te golpea con su cuerpo quitandote {daniobase}");
    }

    public MoscaEnemiga(string nombre, int puntosvida, int daniobase)
    {
        this.nombre = nombre;
        Puntosvida = puntosvida;
        this.daniobase = daniobase;
    }
}

class JefeMonstro : EntidadSotano
{
    public override void EjecutarAtaque()
    {
        System.Console.WriteLine($"{nombre} se lanza hacia el cielo y te apisona quitandote {daniobase}");
    }

    public JefeMonstro(string nombre, int puntosvida, int daniobase)
    {
        this.nombre = nombre;
        Puntosvida = puntosvida;
        this.daniobase = daniobase;
    }
}

class Program
{
    static void Main()
    {
        List<EntidadSotano> entidades = new List<EntidadSotano>();

        entidades.Add(new MoscaEnemiga("Pooter",100,1));
        entidades.Add(new MoscaEnemiga("Attack Fly",100,1));
        entidades.Add(new JefeMonstro("Monstro", 0, 3));

        foreach(EntidadSotano entidad in entidades)
        {
            entidad.EjecutarAtaque();
            if(entidad.Puntosvida >= 200)
            {
                System.Console.WriteLine("--------------------------------------");
                entidad.Puntosvida = 0;
            }
        }
    }
}
