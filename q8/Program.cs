// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] arr = new int[3];
string[] arr2 = new string[3];
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("enter flight fare");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter destination name");
    arr2[i] = Console.ReadLine();
}
Console.WriteLine("enter a number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"destination:{arr2[num]} rate:{arr[num]}");