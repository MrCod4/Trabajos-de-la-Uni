using System;
Console.WriteLine("Ingrese las millas a recorrer: ");
double millas = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese las yardas a recorrer: ");
double yardas = double.Parse(Console.ReadLine());

double millasT = millas + (yardas/1760);
double kilometros = (millasT)*1.6;

Console.WriteLine("Kilometros a recorrer: "+kilometros);