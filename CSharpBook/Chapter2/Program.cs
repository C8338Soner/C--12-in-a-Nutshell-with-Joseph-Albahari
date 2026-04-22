using System;
// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

System.Console.WriteLine("Hello, World!");

int x = 12*30;
System.Console.WriteLine($"The value of x is {x}");



int y = 12;
int z = 30;
int t = y * z;
Console.WriteLine($"The value of {t}");



Console.WriteLine(FeetToInches(30));
Console.WriteLine(FeetToInches(1200));

int FeetToInches(int feet)
{
    int inches=feet*12;
    return inches;
}



SayHello();
void SayHello()
{
    Console.WriteLine("Hello Soner");
}