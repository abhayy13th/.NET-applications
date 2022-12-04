// See https://aka.ms/new-console-template for more information
using Calculator;
using System;
using Calculator.Arrays;
using Calculator.Week2;
using Calculator.Week3;
using Calculator.Week4;

Calc calculate = new Calc();
Arrays arr = new Arrays();
Interpolation inter = new Interpolation();
ControlStatements CS = new ControlStatements();
Swap sw = new Swap();
OddEven oe = new OddEven();
Search sr = new Search();
Prime p = new Prime();


Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("Press 1 for Addition");
Console.WriteLine("Press 2 for Subtraction");
Console.WriteLine("Press 3 for Multiplication");
Console.WriteLine("Press 4 for Division");
Console.WriteLine("Press 5 for Jagged Arrays");
Console.WriteLine("Press 6 for SingleDimensional Arrays");
Console.WriteLine("Press 7 for ImplicitlyTyped Arrays");
Console.WriteLine("Press 8 for MultiDimensional Arrays");
Console.WriteLine("Press 9 for If-Else example");
Console.WriteLine("Press 10 for Switch case example ");
Console.WriteLine("Press 11 for While loop example ");
Console.WriteLine("Press 12 for Do While loop example ");
Console.WriteLine("Press 13 for For example ");
Console.WriteLine("Press 14 for For each example ");
Console.WriteLine("Press 15 for Prime or not example ");
Console.WriteLine("Press 16 for Odd even example ");
Console.WriteLine("Press 17 for Search element in array ");
Console.WriteLine("Press 18 for Swap example ");
Console.WriteLine("Press 19 for Inheritance ");
Console.WriteLine("Press 20 for Abstraction ");
Console.WriteLine("Press 21 for Encapsulation ");
Console.WriteLine("Press 22 for Polymorphism ");


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
    case 9:
        CS.CS();
        break;
    case 10:
        CS.switchcase();
        break;
    case 11:
        CS.whileloop();
        break;
    case 12:
        CS.doLoop();
        Console.WriteLine("Welcome");
        break;
    case 13:
        CS.forExample();
        break;
    case 14:
        CS.forEachExample();
        break;
    case 15:
        p.prime();
        break;
    case 16:
        oe.odd_even();
        break;
    case 17:
        sr.stringSearch();
        break;
    case 18:
        sw.swap();
        break;
    case 19:
        Testing.Test();
        break;
    case 20:
        CallAbstraction.AbstractionCall();
        break;
    case 21:
        EncapsulationClass.CallEncapsulation();
        break;
    case 22:
        Polymorphism.PolyClass.PolynMethod();
        break;


    default:
        inter.StringInterpolation();
        break;
}


Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();