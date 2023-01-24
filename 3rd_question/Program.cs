
// See https://aka.ms/new-console-template for more information
using System.Collections.Immutable;

Console.WriteLine("Hello, World!");

bool z = true;
int switch_on;
double[] fares = new double[5]; 
for (int i = 0; i < fares.Length; i++)
{
    fares[i] = Convert.ToDouble(Console.ReadLine());
}
while (z)
{
    Console.WriteLine("0 : ascebetic order");
    Console.WriteLine("1 : reverse  order");
    Console.WriteLine("2 : search");
    Console.WriteLine("3 : min and max");
    Console.WriteLine("4 : duplicate");

    Console.WriteLine("enter your choice ");
    switch_on = Convert.ToInt32(Console.ReadLine());
    switch (switch_on)
    {
        case 0:
            asce(fares); break;
        case 1:
            reve(fares); break;
        case 2:
            search(fares); break;
        case 3:
            max_min(fares); break;
        case 4:
            dup(fares); break;
        default:
            z = false; break;
    }
}


// array ascebetic order
static void asce(double[] fares)
{
    Array.Sort(fares);
    foreach (var item in fares)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine('.');
}
// array reverse order
static void reve(double[] fares)
{
    Array.Sort(fares);
    Array.Reverse(fares);
    foreach (var item in fares)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine('.');
}

//search in an array
static int search(double[] fares)
{
    Console.WriteLine("enter the fare u want to search");
    double? name = Convert.ToDouble(Console.ReadLine());
    for (int i = 0; i < fares.Length; i++)
    {

        if (fares[i] == name)
        {
            Console.WriteLine($"The entered {name} is present");
            return 0;
        }
        
    }
    Console.WriteLine("the entered name is not present");
    return 0;
}

//length of names 
static void max_min(double[] fares)
{
    Console.WriteLine(fares.Max());
    Console.WriteLine(fares.Min());
}

static void dup(double[] fares)
{
    for (int j = 0; j < fares.Length; j++)
    {
        for (int i = j + 1; i < fares.Length; i++)
        {
            if (fares[j] == fares[i])
            {
                Console.WriteLine(fares[j]);
            }
        }
    }
}