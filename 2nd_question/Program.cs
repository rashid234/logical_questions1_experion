// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello+ World!");
int g = Convert.ToInt32(Console.ReadLine());
double h = Convert.ToDouble(Console.ReadLine());

if (6 < g && g < 9)
{
    h = h * 1.10;
    Console.WriteLine("new rate"+ h);
}
else if (9 < g && g < 17)
{
    h = h * 1.20;
    Console.WriteLine("new rate"+ h);
}
else if (5 < g && g < 23)
{
    h = h * 1.07;
    Console.WriteLine("new rate"+ h);
}
else if (g == 23 || g == 0 || (g >= 1 && g <= 6))
{
    h = h * 1.05;
    Console.WriteLine("new rate"+ h);
}
else
{
    Console.WriteLine("invalid entry");
}