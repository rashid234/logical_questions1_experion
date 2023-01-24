// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var arr = new string[5, 5]
{ { "1", "2", "3", "4", "5" },
{ "6", "7", "8", "9", "10" },
{ "11", "12", "13", "14", "15" },
{ "16", "17", "18", "19", "20"},
{ "21", "22", "23", "24", "25" } };
int k = 1;
while (k <= 3)
{
    Console.WriteLine("enter seat number");
    string seatnum = Console.ReadLine();
    Console.WriteLine("a.veg b.nonveg -choose a/b");
    string pref = Console.ReadLine();
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if ((arr[i, j] == seatnum) && (pref == "a"))
            {
                arr[i, j] = seatnum + " " + "veg";
            }
            else if ((arr[i, j] == seatnum) && (pref == "b"))
            {
                arr[i, j] = seatnum + " " + "nonveg";
            }
        }
    }
    k++;
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}
