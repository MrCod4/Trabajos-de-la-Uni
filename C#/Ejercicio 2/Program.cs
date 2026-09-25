using System;
using System.ComponentModel;
class Empleado
{
    protected string nombre;
    protected string cedula;
    protected double salariobase;

    public string Nombre
    {
        get{return nombre;}
        set{nombre = value;}
    }

    public string Cedula
    {
        get {return cedula;}
        set {cedula = value;}
    }

    public double SalarioBase
    {
        get{ return salariobase;}
        set
        {
            if (value >= 0)
            {
                salariobase = value;
            }
            else
            {
                System.Console.WriteLine("Su valor es invalido");
                salariobase = 0;
            }
        }
    }

    public Empleado(string nombre, string cedula, double salariobase)
    {
        Nombre = nombre;
        Cedula = cedula;
        SalarioBase = salariobase;

        System.Console.WriteLine("Empleado Ingresado exitosamente");
    }

    public Empleado(string nombre, string cedula)
    {
        Nombre = nombre;
        Cedula = cedula;
        SalarioBase = 0;

        System.Console.WriteLine("Empleado Ingresado exitosamente");
    }

    public Empleado()
    {
        
    }

    public virtual double CalcularSalarioFinal()
    {
        return salariobase;
    }


}

class EmpleadoPorComision : Empleado
{
    private double ventasrealizadas;
    private double porcentajecomision;

    public double VentasRealizadas
    {
        get{return ventasrealizadas;}
        set
        {
            if(value >= 0)
            {
                ventasrealizadas = value;
            }
            else
            {
                System.Console.WriteLine("Valor invalido");
                ventasrealizadas = 0;
            }
        }
    }

    public double PorcentajeComision
    {
        get{return porcentajecomision;}
        set
        {
            if(value >= 0)
            {
                porcentajecomision = value/100;
            }
            else
            {
                System.Console.WriteLine("valor invalido");
                porcentajecomision = 0;
            }
        }
    }

    public EmpleadoPorComision(string nombre, string cedula, double salariobase, double ventasrealizadas, double porcentajecomision)
    {
        Nombre = nombre;
        Cedula = cedula;
        SalarioBase = salariobase;
        VentasRealizadas = ventasrealizadas;
        PorcentajeComision = porcentajecomision;

        System.Console.WriteLine("Empleado Ingresado exitosamente");
        System.Console.WriteLine("Tipo de empleado : Por Comision");  
    }

    public EmpleadoPorComision(string nombre, string cedula, double ventasrealizadas, double porcentajecomision)
    {
        Nombre = nombre;
        Cedula = cedula;
        SalarioBase = 0;
        VentasRealizadas = ventasrealizadas;
        PorcentajeComision = porcentajecomision;

        System.Console.WriteLine("Empleado Ingresado exitosamente");
        System.Console.WriteLine("Tipo de empleado : Por Comision");  
    }

    public EmpleadoPorComision()
    {
        
    }


    public override double CalcularSalarioFinal()
    {
        return salariobase + (ventasrealizadas*porcentajecomision);
    }

}

class EmpleadoAsalariado : Empleado
{
    private double bonofijo;

    public double BonoFijo
    {
        get{return bonofijo;}
        set
        {
            if(value >= 0)
            {
                bonofijo = value;
            }
            else
            {
                System.Console.WriteLine("Valor invalido");
                bonofijo = 0;
            }
        }
    }

    public EmpleadoAsalariado(string nombre, string cedula, double salariobase, double bonofijo)
    {
        Nombre = nombre;
        Cedula = cedula;
        SalarioBase = salariobase;
        BonoFijo = bonofijo;

        System.Console.WriteLine("Empleado Ingresado exitosamente");
        System.Console.WriteLine("Tipo de empleado : Asalariado");
    }

    public EmpleadoAsalariado(string nombre, string cedula, double bonofijo)
    {
        Nombre = nombre;
        Cedula = cedula;
        SalarioBase = 0;
        BonoFijo = bonofijo;

        System.Console.WriteLine("Empleado Ingresado exitosamente");
        System.Console.WriteLine("Tipo de empleado : Asalariado");
    }

    public EmpleadoAsalariado()
    {

    }
    public override double CalcularSalarioFinal()
    {
        return salariobase + bonofijo;
    }

}

class Program
{
    static void Main()
    {
        string nombre;
        string cedula;
        double sueldobase;
        double ventasrealizadas;
        double porcentajecomision;
        double bonofijo;
        int opcion;

        List<Empleado> empleados = new List<Empleado>();

        do
        {
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("Ingrese su opcion");
            System.Console.WriteLine("1. Ingresar empleado normal");
            System.Console.WriteLine("2. Ingresar un empleado por comision");
            System.Console.WriteLine("3. Ingresar un empleado asalariado");
            System.Console.WriteLine("4. Mostrar informacion");
            System.Console.WriteLine("5. Salir");
            System.Console.WriteLine("---------------------------------------");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                System.Console.WriteLine("------------------------------------");
                System.Console.WriteLine("Ingrese el nombre del empleado");
                nombre = Console.ReadLine();

                System.Console.WriteLine("Ingrese la cedula del empleado");
                cedula = Console.ReadLine();

                System.Console.WriteLine("Ingrese el sueldo base del empleado");
                sueldobase = double.Parse(Console.ReadLine());
                
                empleados.Add(new Empleado(nombre,cedula,sueldobase));
                break;

                case 2:
                System.Console.WriteLine("------------------------------------");
                System.Console.WriteLine("Ingrese el nombre del empleado");
                nombre = Console.ReadLine();

                System.Console.WriteLine("Ingrese la cedula del empleado");
                cedula = Console.ReadLine();

                System.Console.WriteLine("Ingrese el sueldo base del empleado");
                sueldobase = double.Parse(Console.ReadLine());

                System.Console.WriteLine("Ingrese las ventas realizadas del empleado");
                ventasrealizadas = double.Parse(Console.ReadLine());

                System.Console.WriteLine("Ingrese el porcentaje por comision");
                porcentajecomision = double.Parse(Console.ReadLine());

                empleados.Add(new EmpleadoPorComision(nombre,cedula,sueldobase, ventasrealizadas, porcentajecomision));
                break;

                case 3:
                System.Console.WriteLine("------------------------------------");
                System.Console.WriteLine("Ingrese el nombre del empleado");
                nombre = Console.ReadLine();

                System.Console.WriteLine("Ingrese la cedula del empleado");
                cedula = Console.ReadLine();

                System.Console.WriteLine("Ingrese el sueldo base del empleado");
                sueldobase = double.Parse(Console.ReadLine());

                System.Console.WriteLine("Ingrese el bono fijo del empleado");
                bonofijo = double.Parse(Console.ReadLine());

                empleados.Add(new EmpleadoAsalariado(nombre,cedula,sueldobase, bonofijo));
                break;

                case 4:
                
                foreach (Empleado e in empleados)
                {
                    System.Console.WriteLine($"Sueldo del empleado : {e.CalcularSalarioFinal()}");
                }

                break;

                case 5:
                System.Console.WriteLine("Programa finalizado");
                break;
            }
            
        }while(opcion != 5);        
    }
}
