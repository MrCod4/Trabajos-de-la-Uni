using System;
class Habilidad
{
    public virtual void Usar()
    {
        System.Console.WriteLine("Usando habilidad basica sin objetivo");
    }

    public void Usar(string objetivo)
    {
        System.Console.WriteLine($"Usando habilidad basica contra {objetivo}");
    }
}

class Golpear : Habilidad
{
    public override void Usar()
    {
        System.Console.WriteLine("Usando habilidad de golpe");
    }
}

class Program
{
    static void Main()
    {
        Habilidad h1 = new Habilidad();
        h1.Usar();
        h1.Usar("nada");

        Habilidad h2 = new Golpear();
        h2.Usar();
        h2.Usar("alguien");
    }
}
