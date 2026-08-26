using System;
Console.WriteLine("Ingrese las medidas del lado a: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese las medidas del lado b: ");
double b = double.Parse(Console.ReadLine());

double areacuadrado = a*b;

double areacirculo = (a/2)*(a/2)*3.14;

double resultado = areacuadrado - areacirculo;

Console.WriteLine("Area del cuadrado :"+areacuadrado);
Console.WriteLine("Area del circulo :"+areacirculo);
Console.WriteLine("Resultado de la resta :"+resultado);