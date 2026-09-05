/*Sonic necesita probar el sistema de energía de sus escudos. Para ello, el laboratorio de Tails cuenta con una función moduladora de energía que analiza un valor numérico X en cada segundo y determina cuánta carga recibe el escudo y qué tipo de escudo debe desplegarse.
Debes construir una solución modular en C# que implemente una función auxiliar utilizando paso de parámetros por referencia o salida ( out / ref ).


Requerimientos de la Función:
Crea un método llamado EvaluarEnergia que reciba el número de segundo actual X y retorne dos valores a través de parámetros out :

Función carga :
Si X es múltiplo de 3 y de 5 al mismo tiempo (múltiplo de 15), la carga obtenida es 100.
Si X es múltiplo de 3 o de 5 (pero no de ambos a la vez), la carga obtenida es 50.
Si X no es múltiplo ni de 3 ni de 5, la carga obtenida es 0.
Función mensaje :
Si la carga es 100: "[X]s (Carga 100%): ¡Súper Escudo Activado!"
Si la carga es 50: "[X]s (Carga 50%): Escudo Normal Activado"
Si la carga es 0: "[X]s (Carga 0%): Carga en proceso..."
Programa Principal ( Main ):
El programa debe solicitar/recibir un número entero N (1 ≤ N ≤ 100).
Utilizando un bucle, debe llamar la función EvaluarEnergia para cada segundo desde 1 hasta N.
Imprimir en pantalla el mensaje obtenido por el parámetro.

En caso de ingresar un valor fuera del rango imprimir "Error, valor invalido" y finalizar el programa.

Al momento de la ejecución no debe de existir el mensaje de nulabilidad.*/

using System;
namespace ejercicio1
{
    class Program
    {
        static void EvaluarEnergia(int segundo, out int carga)
        {
            if(segundo % 3 == 0 && segundo % 5 == 0)
            {
                carga = 100;
            }
            else if(segundo % 3 == 0 || segundo % 5 == 0)
            {
                carga = 50;
            }
            else
            {
                carga = 0;
            }
        }
        static void EvaluarEnergia(ref int carga, int segundos)
        {
            if(carga == 100)
            {
                System.Console.WriteLine($"[{segundos}]s (Carga 100%): ¡Súper Escudo Activado!");
            }
            else if(carga == 50)
            {
                System.Console.WriteLine($"[{segundos}]s (Carga 50%): Escudo Normal Activado");
            }
            else
            {
                System.Console.WriteLine($"[{segundos}]s (Carga 0%): Carga en proceso...");
            }
        }
        static void Main()
        {
            int segActual;
            int carga;

            System.Console.WriteLine("Ingrese un numero entre 1 y 100");
            segActual = int.Parse(Console.ReadLine());

            if(segActual < 100 && segActual > 1)
            {
                for(int i=1; i<=segActual; i++)
                {
                    EvaluarEnergia(i, out carga);
                    EvaluarEnergia(ref carga, i);
                    
                    Thread.Sleep(1000);
                    //sirve para hacer que haya un tiempo de espera entre siclos, a menos para este caso
                }
            }
            else
            {
                System.Console.WriteLine("Error, valor invalido");
            }
        }
    }
}
