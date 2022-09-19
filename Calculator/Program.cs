// See https://aka.ms/new-console-template for more information
using Calculator;
using System;
using Calculator.Arrays;

Calc calculate = new Calc();
Class2 substract = new Class2();
Arrays arr = new Arrays();
Interpolation inter = new Interpolation();

Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("Press 1 for Addition");
Console.WriteLine("Press 2 for Subtraction");
Console.WriteLine("Press 3 for Multiplication");
Console.WriteLine("Press 4 for Division");
Console.WriteLine("Press 5 for Jagged Arrays");
Console.WriteLine("Press 6 for SingleDimensional Arrays");
Console.WriteLine("Press 7 for ImplicitlyTyped Arrays");
Console.WriteLine("Press 8 for MultiDimensional Arrays");
Console.Write("Your option? ");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        calculate.addition();
        break;
    case 2:
        calculate.substraction();
        break;
    case 3:
        calculate.multiplication();
        break;
    case 4:
        calculate.division();
        break;
    case 5:
        arr.JaggedArray();
        break;
    case 6:
       arr.OneDArray();
        break;
    case 7:
        arr.ImplicitArray();
        break;
    case 8:
        arr.MultiDArray();
        break;
    default:
        inter.StringInterpolation();
        break;
}


Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();