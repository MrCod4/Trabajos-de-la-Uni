/*Crea una clase Libro con Titulo , Autor , AnioPublicacion y CantidadDisponible . Todos los
atributos deben estar protegidos mediante encapsulamiento y contar con un constructor para su inicialización.
Agrega los métodos PrestarLibro() , DevolverLibro() y MostrarInformacion() , impidiendo prestar
unidades si no hay stock disponible. Solicita los datos e interactúa con el usuario desde la terminal, y elabora el
diagrama UML integrador
*/

using System;

class Libro
{
    private string titulo;
    private string autor;
    private int anioPublicacion;
    private int cantidadDisponible;

    public string Titulo
    {
        get{return titulo;}
        set{titulo = value;}
    }

    public string Autor
    {
        get{return autor;}
        set{autor = value;}
    }

    public int AnioPublicacion
    {
        get{return anioPublicacion;}
        set{anioPublicacion = value;}
    }

    public int CantidadDisponible
    {
        get{return cantidadDisponible;}
        set
        {
            if(value >= 0)
            {
                cantidadDisponible = value;
            }
            else
            {
                System.Console.WriteLine("Valor ingresado invalido");
            }
        }
    }

    public Libro(string titulo, string autor, int cantidaddisp)
    {
        Titulo = titulo;
        Autor = autor;
        CantidadDisponible = cantidaddisp;
    }

    public void PrestarLibro()
    {
        if(cantidadDisponible > 0)
        {
            cantidadDisponible--;
            System.Console.WriteLine("Su retiro se ha hecho exitosamente");
            Thread.Sleep(1000);
        }
        else
        {
            System.Console.WriteLine("No hay libros disponibles");
            Thread.Sleep(1000);
        }
    }

    public void DevolverLibro()
    {
        cantidadDisponible++;
        System.Console.WriteLine("Libro devuelto");
        Thread.Sleep(1000);
    }

    public void MostrarInformacion()
    {
        System.Console.WriteLine("-------------------------------------");
        System.Console.WriteLine("========Informacion del libro========");
        System.Console.WriteLine($"Titulo : {titulo}");
        System.Console.WriteLine($"Autor : {autor}");
        System.Console.WriteLine($"Cantidad disponible: {cantidadDisponible}");
        System.Console.WriteLine("-------------------------------------");
        Thread.Sleep(1000);
    }
}

class Program
{
    static void Main()
    {
        string titulo;
        string autor;
        int cantidadDisponible;
        int opcion;

        System.Console.WriteLine("===Ingreso de datos de libro===");
        System.Console.WriteLine("Ingrese el titulo del libro");
        titulo = Console.ReadLine();

        System.Console.WriteLine("Ingrese el autor del libro");
        autor = Console.ReadLine();

        System.Console.WriteLine("Ingrese la Cantidad disponible");
        cantidadDisponible = int.Parse(Console.ReadLine());

        Libro l1 = new Libro(titulo, autor, cantidadDisponible);

        do
        {
            System.Console.WriteLine("-------------------------------------");
            System.Console.WriteLine("Ingrese su decicion");
            System.Console.WriteLine("1. Pedir libro");
            System.Console.WriteLine("2. Devolver libro");
            System.Console.WriteLine("3. Mostrar informacion");
            System.Console.WriteLine("4. Salir");
            System.Console.WriteLine("-------------------------------------");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                l1.PrestarLibro();
                break;

                case 2:
                l1.DevolverLibro();
                break;

                case 3:
                l1.MostrarInformacion();
                break;

                case 4:
                System.Console.WriteLine("Programa finalizado.");
                break;

                default:
                System.Console.WriteLine("Opcion invalida");
                break;
            }

        }while(opcion != 4);

    }
}
