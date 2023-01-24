// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] arr = new int[10];
for (int i = 0; i < 2; i++)
{
    Console.WriteLine("enter passengers year of birth");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"year of birth : {arr[i]} ");
    if (arr[i] > 2013 && arr[i] <= 2023)
    {
        Console.WriteLine("KID");
    }
    else if (arr[i] > 1993 && arr[i] <= 2013)
    {
        Console.WriteLine("YOUTH");
    }
    else if (arr[i] > 1963 && arr[i] <= 1993)
    {
        Console.WriteLine("ADULT");
    }
    else if (arr[i] <= 1963)
    {
        Console.WriteLine("OLD");
    }
    else
    {
        Console.WriteLine("invalid entry");
    }
}