using System;
class Animal
{
    public virtual void HacerSonido()
    {
        System.Console.WriteLine("Sonido");
    }
}

class Perro : Animal
{
    public override void HacerSonido()
    {
        System.Console.WriteLine("Guau");
    }
}

class Gato : Animal
{
    public override void HacerSonido()
    {
        System.Console.WriteLine("Miau");
    }
}

class Vaca : Animal
{
    public override void HacerSonido()
    {
        System.Console.WriteLine("Muuu");
    }
}

class Pollito : Animal
{
    public override void HacerSonido()
    {
        System.Console.WriteLine("Pio");
    }
}
class Program
{
    static void Main()
    {
        List<Animal> animales = new List<Animal>();
        animales.Add(new Gato());
        animales.Add(new Vaca());
        animales.Add(new Perro());
        animales.Add(new Pollito());

        foreach (Animal a in animales)
        {
            a.HacerSonido();
        }
    }
}
