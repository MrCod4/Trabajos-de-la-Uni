using System;
using System.Runtime.InteropServices.Marshalling;

class Personaje
{
    public virtual void Atacar()
    {
        System.Console.WriteLine("El personaje realiza un ataque basico");
    }
}

class Gerrero : Personaje
{
    public override void Atacar()
    {
       System.Console.WriteLine("El gerrero ataca con su espada causando 50 de daño");
    }
}

class Mago : Personaje
{
    public override void Atacar()
    {
        System.Console.WriteLine("El mago lanza una bola de fuego causando 80 de daño magico");
    }
}
class Program
{
    static void Main()
    {
        Personaje p1 = new Gerrero();
        p1.Atacar();

        Personaje p2 = new Mago();
        p2.Atacar();
    }
}
