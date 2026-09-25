using System;
class Personaje
{
    public virtual void Atacar()
    {
        System.Console.WriteLine("Hace un ataque que no hace nada");
    }
}

class Gerrero : Personaje
{
    public override void Atacar()
    {
        System.Console.WriteLine("El gerrero hace un ataque con su espada quitando 50 de vida");
    }
}

class Mago : Personaje
{
    public override void Atacar()
    {
        System.Console.WriteLine("El Mago hace un ataque explosivo que quita 80 de daño magico");
    }
}

class Arquero : Personaje
{
    public override void Atacar()
    {
        System.Console.WriteLine("El arquero lanza tres flechas que quitan un total de 60 de daño");
    }
}
class Program
{
    static void Main()
    {
        List<Personaje> personajes = new List<Personaje>();
        personajes.Add(new Gerrero());
        personajes.Add(new Mago());
        personajes.Add(new Arquero());

        foreach (Personaje p in personajes)
        {
            p.Atacar();
        }
    }
}
