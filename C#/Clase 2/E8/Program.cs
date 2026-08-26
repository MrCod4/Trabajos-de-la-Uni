using System;

Console.WriteLine("Ingrese la medida del lado a: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la medida del lado b: ");
double b = double.Parse(Console.ReadLine());

double hipotenusa = (a*a) + (b*b);

Console.WriteLine("medida del lado a: "+b);
Console.WriteLine("medida del lado b: "+a);
Console.WriteLine("La hipotenusa del triangulo es: "+hipotenusa);