// See https://aka.ms/new-console-template for more information
using System.Globalization;
Console.WriteLine("Hello, World!");

int[] arr = new int[10];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("enter wheight");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] >= 24)
    {
        var total = (arr[i] - 24) * 15;
        Console.WriteLine($"overwheight fare total={total}");
    }
    else
    {
        Console.WriteLine("no overwheight");
    }
}
Console.WriteLine("sorted order :");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (arr[i] > arr[j])
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{arr[i]}");
}
