// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<int> people =new List<int>();
Console.WriteLine("Enter the no:of peoples");
int l = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < l; i++)
{
    people.Add(Convert.ToInt32(Console.ReadLine()));
}
var q1 = new Queue<int>();
var q2 = new Queue<int>();
var q3 = new Queue<int>();

int j = 0;

while(j < people.Count)
{
    add();
    disp();
    unqueue();
}
 void add()
{

    for (int k = 0; k < 3; k++)
    {
        //Console.WriteLine("inside the for loop");
        if (people.Count > 0)
        {
            //Console.WriteLine("pople > 0");
            if (j < people.Count && q1.Count < 3)
            {
                //Console.WriteLine("inside 1st if");
                q1.Enqueue(people[j]);
                //people.RemoveAt(j);
                j++;
                if (j < people.Count && q2.Count < 3)
                {
                    q2.Enqueue(people[j]);
                    //people.RemoveAt(j);
                    j++;
                    if (j < people.Count && q3.Count < 3)
                    {
                        q3.Enqueue(people[j]);
                        //people.RemoveAt(j);
                        j++;
                    }

                }
            }
        }
    }
}

void disp()
{

    Console.WriteLine("Queues printed");
    int r = 1;
    foreach (var item in q1)
    {
        Console.WriteLine($"q1 {r} : {item}");
        r++;
    }

    int z = 1;
    foreach (var item in q2)
    {
        Console.WriteLine($"q2 {z} : {item}");
        z++;
    }
    int y = 1;
    foreach (var item in q3)
    {
        Console.WriteLine($"q3 {y} : {item}");
        y++;
    }
}


void unqueue()
{
    q1.Dequeue();
    q2.Dequeue();
    q3.Dequeue();
}



