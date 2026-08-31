/*A partir de las especificaciones técnicas descritas, elabore el diagrama UML completo utilizando sintaxis
Mermaid (classDiagram) y posteriormente implemente su lógica en C#:
Requerimiento del sistema:
Un sistema de gestión de flotas requiere monitorear una clase VehiculoElectrico con los atributos públicos
modelo (string), porcentajeBateria (double) y consumoPorKm (double). Debe contar con los métodos:
Viajar(distanciaKm: double): bool — Verifica si la batería disponible es suficiente para el viaje
(distanciaKm * consumoPorKm). De ser así, realiza el descuento y retorna true. Si no alcanza, informa el error
y retorna false.
CargarBateria(porcentaje: double): void — Incrementa el nivel de carga sin sobrepasar el 100%.
CalcularAutonomiaRestante(): double — Retorna los km estimados que puede recorrer
(porcentajeBateria / consumoPorKm).
*/

using System;

namespace ejercicio5
{
    class VehiculoElectrico
    {
        public string modelo;
        public double porcentajeBateria;
        public double consumoPorKm;

        public bool Viajar(double distanciaKm)
        {
            if(porcentajeBateria > (distanciaKm * consumoPorKm))
            {
                porcentajeBateria -=(distanciaKm*consumoPorKm);
                return true;
            }
            else
            {
                System.Console.WriteLine("Bateria insuficiente para el viaje");
                return false;
            }
        }

        public void CargarBateria(double porcentaje)
        {
            if(porcentajeBateria < 100)
            {
                porcentajeBateria += porcentaje;
            }
            else
            {
                System.Console.WriteLine("La carga ya esta completa");
            }

            if(porcentajeBateria > 100)
            {
                porcentajeBateria = 100;
            }
        }

        public double CalcularAutonomiaRestante()
        {
            return porcentajeBateria/consumoPorKm;
        }
    }
    class Program
    {
        static void Main()
        {
            VehiculoElectrico v1 = new VehiculoElectrico();
            v1.modelo = "Tesla Model 3";
            v1.porcentajeBateria = 80;
            v1.consumoPorKm = 0.25;

            int opcion;
            char opcion2;

            System.Console.WriteLine("Que desea realizar");
            System.Console.WriteLine("1.Viajar");
            System.Console.WriteLine("2.Cargar auto");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                System.Console.WriteLine("Cuantos Km desea viajar");
                v1.Viajar(double.Parse(Console.ReadLine()));
                break;

                case 2:
                System.Console.WriteLine("Cuanto desea cargar su bateria");
                v1.CargarBateria(double.Parse(Console.ReadLine()));
                break;

                default:
                System.Console.WriteLine("Ingrese una opcion valida");
                break;
            }

            System.Console.WriteLine("Desea consultar la autonomia restante S/N");
            opcion2 = char.Parse(Console.ReadLine());

            if (opcion2 == 's' || opcion2 == 'S') 
            {
                System.Console.WriteLine("Le quedan "+v1.CalcularAutonomiaRestante()+" Kilometros restantes");
            }
        }
    }
}

