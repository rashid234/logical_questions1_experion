// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] arr = new int[10];
for (int i = 1; i != 0; i++)
{
    Console.WriteLine("enter passenger id");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Do you want to continue?y/n");
    var s = Console.ReadLine();
    if (s == "n")
    {
        break;
    }
}
