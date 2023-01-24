// See https://aka.ms/new-console-template for more information
using System.Collections.Immutable;

Console.WriteLine("Hello, World!");

bool z = true;
int switch_on;
string[] passengers = new string[10]; //{"rashid","sifana ks","kavita bs","aravind","sugu s","rashid","aravind"};
for (int i = 0; i < passengers.Length; i++)
{
    passengers[i] = Console.ReadLine();
}
while (z)
{
    Console.WriteLine("0 : alphabetic order");
    Console.WriteLine("1 : reverse  order");
    Console.WriteLine("2 : search");
    Console.WriteLine("3 : length");
    Console.WriteLine("4 : split");
    Console.WriteLine("5 : duplicate");

    Console.WriteLine("enter your choice ");
    switch_on = Convert.ToInt32(Console.ReadLine());
    switch (switch_on)
    {
        case 0:
            alpha(passengers); break;
        case 1:
            reve(passengers); break;
        case 2:
            search(passengers); break;
        case 3:
            leng(passengers); break;
        case 4:
            spli(passengers); break;
        case 5:
            dup(passengers); break;
        default:
            z = false; break;
    }
}


// array alphabetic order
static void alpha(string[] passengers) {
    Array.Sort(passengers);
    foreach (var item in passengers)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine('.');
}
// array reverse order
static void reve(string[] passengers)
{
    Array.Sort(passengers);
    Array.Reverse(passengers);
    foreach (var item in passengers)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine('.');
}

//search in an array
static void search(string[] passengers)
{
    Console.WriteLine("enter the name u want to search");
    string? name = Console.ReadLine();
    if (passengers.Contains(name))
    {
        Console.WriteLine($"The entered {name} is present");
    }
    else
    {
        Console.WriteLine("the entered name is not present");
    }
}

//length of names 
static void leng(string[] passengers)
{
    foreach (var item in passengers)
    {
        Console.WriteLine(item.Length);
    }
}

//split the names at space
static void spli(string[] passengers)
{
    foreach (var item in passengers)
    {
        if (item.Contains(' '))
        {
               string[]h = item.Split(' ');
            foreach (var items in h)
            {
                Console.WriteLine(items);
            }
        }
    }
}
static void dup(string[] passengers)
{
    for (int j = 0; j < passengers.Length; j++)
    {
        for (int i = j+1; i < passengers.Length; i++)
        {
        if (passengers[j] == passengers[i])
        {
            Console.WriteLine(passengers[j]);
        }
        }
    }
}