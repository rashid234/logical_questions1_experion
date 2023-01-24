// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter name");
string name = Console.ReadLine();
Console.WriteLine("enter miles travelled");
int miles = Convert.ToInt32(Console.ReadLine());
if (miles > 10000)
{
    Console.WriteLine($"congrats {name}! you got 10 points");
}
else if (miles > 50000)
{
    Console.WriteLine($"congrats {name}! you got 30 points");
}
else if (miles > 20000)
{
    Console.WriteLine($"congrats {name}! you got 20 points");
}
else if (miles > 100000)
{
    Console.WriteLine($"congrats {name}! you got 50 points");
}
else
{
    Console.WriteLine($"sorry {name}!you got no points");
}