using System;

class Persona
{
    public string nombre {get; set;}
    public int edad {get; set;}
    public string rut {get; set;}
}

class Profesor : Persona
{
    public string especialidad {get; set;}

    public void MostrarInfo()
    {
        System.Console.WriteLine("----------------------------------------");
        System.Console.WriteLine($"Nombre del profesor: {nombre}");
        System.Console.WriteLine($"Edad del profesor : {edad}");
        System.Console.WriteLine($"Rut del profesor : {rut}");
        System.Console.WriteLine($"Especialidad del profesor : {especialidad}");   
    }
}

class Estudiante : Persona
{
    public string carrera {get; set;}

    public void MostrarInfo()
    {
        System.Console.WriteLine("----------------------------------------");
        System.Console.WriteLine($"Nombre del estudiante: {nombre}");
        System.Console.WriteLine($"Edad del estudiante : {edad}");
        System.Console.WriteLine($"Rut del estudiante : {rut}");
        System.Console.WriteLine($"carrera del estudiante : {carrera}");  
    }
}

class Administrativo : Persona
{
    public string area {get; set;}

    public void MostrarInfo()
    {
        System.Console.WriteLine("----------------------------------------");
        System.Console.WriteLine($"Nombre del administrativo: {nombre}");
        System.Console.WriteLine($"Edad del administrativo : {edad}");
        System.Console.WriteLine($"Rut del administrativo : {rut}");
        System.Console.WriteLine($"carrera del administrativo : {area}");  
    }
}

class Program
{
    static void Main()
    {
        Profesor p1 = new Profesor();
        p1.nombre = "Juan Perez";
        p1.edad = 42;
        p1.rut = "22.518.531-k";
        p1.especialidad = "Ing en informatica";

        p1.MostrarInfo();
        Thread.Sleep(1000);

        Estudiante e1 = new Estudiante();
        e1.nombre = "Juan Pereira";
        e1.edad = 18;
        e1.rut = "22.518.531-1";
        e1.carrera = "Ing en informatica";

        e1.MostrarInfo();
        Thread.Sleep(1000);

        Administrativo a1 = new Administrativo();
        a1.nombre = "Juan Masoquia";
        a1.edad = 45;
        a1.rut = "22.518.531-2";
        a1.area = "Vigilancia";

        a1.MostrarInfo();
        Thread.Sleep(1000);
    }
}
