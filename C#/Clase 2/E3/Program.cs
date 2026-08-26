using System;
Console.WriteLine("Ingrese la nota 1: ");
double n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la nota 2: ");
double n2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la nota 3: ");
double n3 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la nota 4: ");
double n4 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la nota 5: ");
double n5 = double.Parse(Console.ReadLine());

double promedio = (n1 + n2 + n3 + n4 + n5)/5;

Console.Write("Su promedio es : "+(promedio)+"");