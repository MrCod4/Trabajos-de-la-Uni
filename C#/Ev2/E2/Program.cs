/*Una reserva forestal cuenta con un sistema de monitoreo para la prevención y respuesta ante incendios forestales.
Las condiciones ambientales pueden cambiar rápidamente y la central necesita clasificar las condiciones de una zona determinando su nivel de riesgo considerando tres mediciones ambientales: temperatura del aire, humedad relativa y velocidad del viento.
La central ha establecido cuatro niveles: BAJO, MODERADO, ALTO y EXTREMO. El encargado de la estación solicita un programa en C# modular que analice las condiciones y reporte inmediatamente el nivel de riesgo.

El programa solicitará tres valores enteros:
Temperatura: Grados Celsius (°C), entre -30 y 60.
Humedad relativa: Porcentaje (%), entre 0 y 100.
Velocidad del viento: Kilómetros por hora (km/h), entre 0 y 250.
Si algún dato de entrada está fuera de rango, el programa imprimirá únicamente: Error: datos de entrada no validos.

Para garantizar un diseño modular, el cálculo debe implementarse en un método auxiliar llamado EvaluarRiesgo que reciba las mediciones e informe los resultados mediante parámetros out :

static void EvaluarRiesgo(int temp, int humedad, int viento, out string nivel, out string
alerta)
Reglas de Clasificación (Orden Jerárquico):

EXTREMO: Si la temperatura alcance al menos 35°C y, simultáneamente, la humedad sea como máximo 20%. Asigna nivel = "EXTREMO" y alerta = "ALERTA: Riesgo extremo detectado. Evacuacion activada." .
ALTO: Si la velocidad del viento alcanza al menos 40 km/h y la humedad es como máximo 30%. Asigna nivel = "ALTO" y alerta = "" .
MODERADO: Si la temperatura alcanza al menos 30°C o la humedad es como máximo 40%. Asigna nivel = "MODERADO" y alerta = "" .
BAJO: Si ninguna de las anteriores se cumple. Asigna nivel = "BAJO" y alerta = "" .
Si los datos son válidos, el programa imprimirá:
Temp: T°C | Humedad: H% | Viento: V km/h -> Riesgo: NIVEL
Si el nivel es EXTREMO, inmediatamente en la siguiente línea imprimirá el mensaje de alerta correspondiente.*/

using System;

namespace ejercicio2
{
    class Program
    {
        static void EvaluarRiesgo(double celcius, double porcentaje, double velViento, out string nivel, out string alerta)
        {
            if(celcius >= 35 && porcentaje <= 20)
            {
                nivel = "EXTREMO";
                alerta = "ALERTA: Riesgo extremo detectado. Evacuacion activada.";
            }
            else if(velViento >= 40 && porcentaje <= 30)
            {
                nivel = "ALTO";
                alerta = "";
            }
            else if (celcius >= 30 && porcentaje <= 40)
            {
                nivel = "ALTO";
                alerta = "";
            }
            else
            {
                nivel = "BAJO";
                alerta = "";
            }
        }

        static void Main()
        {
            double celcius;
            double porcentaje;
            double velViento;
            string nivel;
            string alerta;

            System.Console.WriteLine("Ingrese la temperatura en celcius (entre -30 y 60)");
            celcius = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Ingrese el porcentaje de humedad (entre 0 y 100)");
            porcentaje = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Ingrese la velocidad del viento en km (entre 0 y 250)");
            velViento = double.Parse(Console.ReadLine());

            if (celcius >= -30 && celcius <= 60 && porcentaje <= 100 && porcentaje >= 0 && velViento <= 200 && velViento >= 0)
            {
                EvaluarRiesgo(celcius, porcentaje, velViento, out nivel, out alerta);

                System.Console.WriteLine($"Temp: {celcius}°C | Humedad: {porcentaje}% | Viento: {velViento} km/h -> Riesgo: {nivel}");

                if(nivel == "EXTREMO")
                {
                    System.Console.WriteLine($"{alerta}");
                }
            }
            else
            {
                System.Console.WriteLine("Error: datos de entrada no validos.");
            }
        }
    }
}
