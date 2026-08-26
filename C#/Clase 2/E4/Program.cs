using System;
Console.WriteLine("Ingrese el dimetro de la figura: ");
double diametro = double.Parse(Console.ReadLine());

double radio = (diametro/2);
double resultado = radio*radio*3.14;

Console.WriteLine("El area de la figura es: "+resultado);
