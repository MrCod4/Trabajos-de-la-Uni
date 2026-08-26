using System;

Console.WriteLine("Ingrese el lado a: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el lado b: ");
double b = double.Parse(Console.ReadLine());

double area = a*b;
double perimetro = (a*2) + (b*2);

Console.WriteLine("Perimetro : "+perimetro);
Console.WriteLine("Perimetro : "+area);
