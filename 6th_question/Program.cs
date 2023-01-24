// See https://aka.ms/new-console-template for more information
using _6th_question;
Random rnd = new Random();
Console.WriteLine("Hello, World!");

string[] locations = new string[] {"pathiripala","palakkad","ernakulam","kannur","kgf"};
List<string> lst = new List<string>();

for (int i = 0; i < locations.Length; i++)
{
    for (int j = i + 1; j < locations.Length; j++)
    {
        lst.Add($"s{i}{j}");
    }
}

var PeopleArray = new travel[lst.Count];
int z = 0;
    for (int i = 0; i < locations.Length; i++)
    {
        for (int j = i + 1; j < locations.Length; j++)
        {
        int num = rnd.Next(800,1000);
        int short_path = rnd.Next(300, 800);
        int fair = rnd.Next(150, 300);
        int fair_short = rnd.Next(10, 150);
        PeopleArray[z]= new travel(locations[i], locations[j],num,short_path,fair,fair_short);
        z++;
        }
    }
Console.WriteLine("enter the starting");
var start = Console.ReadLine();
Console.WriteLine("enter the ending");
var end = Console.ReadLine();
int l;
do
{
    Console.WriteLine("1. shortest path finding");
    Console.WriteLine("2. longest path finding");
    Console.WriteLine("3. lowest fair finding");
    Console.WriteLine("4. highest fair finding");
    Console.WriteLine("5. short path and lowest fair finding");
    Console.WriteLine("6. short path and highest fair finding");
    Console.WriteLine("7. longest path and lowest fair finding");
    Console.WriteLine("8. longest path and highest fair finding");


    var switch_on = Console.ReadLine();
    switch (switch_on)
    {
        case "1":
            shorest_path(PeopleArray,start,end);
            break;
        case "2":
            longest_path(PeopleArray,start,end);
            break;
        case "3":
            low_fair(PeopleArray,start,end); 
            break;
        case "4":
            high_fair(PeopleArray, start, end);
            break;
        case "5":
            Short_Path_Lfair(PeopleArray, start, end);
            break;
        case "6":
            Short_path_Hfair(PeopleArray, start, end);
            break;
        case "7":
            longest_path_Hfair(PeopleArray, start, end);
            break;
        case "8":
            longest_path_Lfair(PeopleArray, start, end);
            break;
        default:
            break;
    }
    Console.WriteLine("do you want to continue press 1");
    l = int.Parse(Console.ReadLine());
} while (l == 1);
static void shorest_path(travel[] PeopleArray,string start,string end)
{
  
    for (int i = 0; i < PeopleArray.Length; i++)
    {
        if ((start == PeopleArray[i].starting && end == PeopleArray[i].ending) || (start == PeopleArray[i].ending && end == PeopleArray[i].starting))
        {
            Console.WriteLine("The shortest path is : " + PeopleArray[i].short_path);
        }
        }

    }

static void longest_path(travel[] PeopleArray,string start,string end)
{
    for (int i = 0; i < PeopleArray.Length; i++)
    {
        if ((start == PeopleArray[i].starting && end == PeopleArray[i].ending) || (start == PeopleArray[i].ending && end == PeopleArray[i].starting))
        {
            Console.WriteLine("The longest path is : " + PeopleArray[i].path);
        }
    }

}
static void low_fair(travel[] PeopleArray, string start, string end)
{
    for (int i = 0; i < PeopleArray.Length; i++)
    {
        if ((start == PeopleArray[i].starting && end == PeopleArray[i].ending) || (start == PeopleArray[i].ending && end == PeopleArray[i].starting))
        {
            Console.WriteLine("The lowest fair is : " + PeopleArray[i].fair_short);
        }
    }

}
static void high_fair(travel[] PeopleArray, string start, string end)
{
    for (int i = 0; i < PeopleArray.Length; i++)
    {
        if ((start == PeopleArray[i].starting && end == PeopleArray[i].ending) || (start == PeopleArray[i].ending && end == PeopleArray[i].starting))
        {
            Console.WriteLine("The highest fair is : " + PeopleArray[i].fair);
        }
    }

}
static void Short_Path_Lfair(travel[] PeopleArray, string start, string end)
{
    for (int i = 0; i < PeopleArray.Length; i++)
    {
        if ((start == PeopleArray[i].starting && end == PeopleArray[i].ending) || (start == PeopleArray[i].ending && end == PeopleArray[i].starting))
        {
            Console.WriteLine("The shortest path is : " + PeopleArray[i].short_path);
            Console.WriteLine("The lowest fair is : " + PeopleArray[i].fair_short);

        }
    }

}
static void Short_path_Hfair(travel[] PeopleArray, string start, string end)
{
    for (int i = 0; i < PeopleArray.Length; i++)
    {
        if ((start == PeopleArray[i].starting && end == PeopleArray[i].ending) || (start == PeopleArray[i].ending && end == PeopleArray[i].starting))
        {
            Console.WriteLine("The shortest path is : " + PeopleArray[i].short_path);
            Console.WriteLine("The higest fair : " + PeopleArray[i].fair);

        }
    }

}
static void longest_path_Hfair(travel[] PeopleArray, string start, string end)
{
    for (int i = 0; i < PeopleArray.Length; i++)
    {
        if ((start == PeopleArray[i].starting && end == PeopleArray[i].ending) || (start == PeopleArray[i].ending && end == PeopleArray[i].starting))
        {
            Console.WriteLine("The long path is : " + PeopleArray[i].path);
            Console.WriteLine("The shortest fair is : " + PeopleArray[i].fair_short);

        }
    }

}

static void longest_path_Lfair(travel[] PeopleArray, string start, string end)
{
    for (int i = 0; i < PeopleArray.Length; i++)
    {
        if ((start == PeopleArray[i].starting && end == PeopleArray[i].ending) || (start == PeopleArray[i].ending && end == PeopleArray[i].starting))
        {
            Console.WriteLine("The long path is : " + PeopleArray[i].path);
            Console.WriteLine("The low fair is : " + PeopleArray[i].fair_short);

        }
    }

}



