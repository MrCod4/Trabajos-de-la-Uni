/*En el siguiente código fuente existen 4 errores de sintaxis y compilación en C#. Identifíquelos y escriba la solución
corregida:
*/

//Faltaba using System
using System;

namespace ejercicio6
{
    class CalculadoraMoneda
    {
        public double tasaDolar = 950.0;
        public double ConvertirPesosADolar(double pesos)
        {
            double resultado = pesos / tasaDolar;

            return resultado;
            // Error 1: Falta algo obligatorio en métodos con retorno double
            //faltaba el retorno del valor.
        }
        public void MostrarConversion(double pesos)
        {
            // Error 2: Intentar usar una variable definida dentro de otro método
            //hay dos casos de lo que quiere hacer, o define la variable denuevo en la segunda funcion, o imprime el valor de la funcion que tien ese valor.
            Console.WriteLine($"Total USD: {ConvertirPesosADolar(pesos)}");

            /*o tambien  
            double resultado = pesos / tasaDolar;
            Console.WriteLine($"Total USD: {resultado}");*/
        }
    }
    class Program
    {
        static void Main()
        {
            // Error 3: Sintaxis incorrecta de instanciación
            //falta indicar la nueva instancia
            CalculadoraMoneda calc = new CalculadoraMoneda();
            // Error 4: Invocación de método que retorna valor guardado en void
            //no se puede retornar un valor double a un valor vacio, ademas de que una variable no puede ser vacia.
            double monto = calc.ConvertirPesosADolar(10000);
        }
    }
}
