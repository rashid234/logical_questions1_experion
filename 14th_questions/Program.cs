// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

Random rnd = new Random();
Console.WriteLine("Hello, World!");
int[,] arr = new int[5, 5];
List<int> list = new List<int>();
int chooser = 1;
do
{
    Console.WriteLine("1.for add");
    Console.WriteLine("2.for display");
    var switch_on = Console.ReadLine();
    switch (switch_on)
    {
        case "1":
            addElements();
            break;
        case "2":
            displayElements(); break;
        default:
            chooser= 0;
            break;
    }

} while (chooser == 1);

int countSpace()
{
    int counter = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == 0)
            {
                counter++;
            }
        }
    }
    return counter;
}

void addElements()
{
    list.Clear();
    int space = countSpace();
    Console.WriteLine($"The available number of seats {countSpace()}");
    Console.WriteLine("Enter the persons boarding pass number [persons count should be with in the limit of available seats");
    while (true)
    {
        var pass_no = Console.ReadLine();
        if(pass_no == "q")
        {
            break;
        }
        list.Add(Convert.ToInt32(pass_no));
    }
    var n = list.Count;
    if (n <= space)
    {
        if( n == 5)
        {
            Console.WriteLine("5 peoples");
            for (int xx = 0; xx < arr.GetLength(0); xx++)
            {
                if (arr[xx,0] == 0 && arr[xx, 1] == 0 && arr[xx, 2] == 0 && arr[xx, 3] == 0 && arr[xx, 4] == 0)
                {
                    arr[xx, 0] = list[0];
                    arr[xx, 1] = list[1];
                    arr[xx, 2] = list[2];
                    arr[xx, 3] = list[3];
                    arr[xx, 4] = list[4];
                    break;
                }
            }

        }
        else
        {
            int zz = 0;
            int zk = rnd.Next(0,5);

            for (int i = 0; i < list.Count;)
            {
                Console.WriteLine($"[{zz},{zk}]");
                if (arr[zz, zk] == 0)
                {
                    if (zk <= 5)
                    {
                        arr[zz, zk] = list[i];
                        i++;
                    }
                    else if(zk > 5)
                    {
                        if (zz < 4) zz++;
                        else zz = 0;
                    }
                }
                else
                {
                    if (zz < 4) zz++;
                    else zz = 0;
                }
                zk = rnd.Next(0,5);
            }
        }

    }
    else Console.WriteLine("The seats are already filled or you cannot accomadate this much of peoples");
}

void displayElements()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}