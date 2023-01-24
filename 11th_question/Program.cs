// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.Arm;

Console.WriteLine("enter a flight dalphabet : ");
var a = Console.ReadLine().ToCharArray();
int od = 99;
int ev = 99;
int pn = 99;
int fn = 99;
int an = 99;

int? res = null;

if (a[0] == 'f' || a[0] == 'F')
{
    for (int i = 0; i < 10; i++)
    {
        res = OddNumber();
        Console.WriteLine(a[0] + res?.ToString());
    }
}
else if(a[0] == 'w' || a[0] == 'W')
{
    for (int i = 0; i < 10; i++)
    {
        res = EvenNumber();
        Console.WriteLine(a[0] + res?.ToString());
    }
}
else if (a[0] == 'q' || a[0] == 'Q')
{
    for (int i = 0; i < 10; i++)
    {
        res = PrimeNumber();
        Console.WriteLine(a[0] + res?.ToString());
    }
}
else if (a[0] == 'n' || a[0] == 'N')
{
    for (int i = 0; i < 10; i++)
    {
        res = FibnocciNumber();
        Console.WriteLine(a[0] + res?.ToString());
    }
}
else if (a[0] == 'a' || a[0] == 'A')
{
    res = ArmstrongNumber();
    Console.WriteLine(a[0] + res?.ToString());

}

int OddNumber()
{
    while (true)
    {
        od++;
        if (od % 2 == 1)
        {
            return od;
        }
    }
}

int EvenNumber()
{
    while (true)
    {
        ev++;
        if (ev % 2 == 0)
        {
            return ev;
        }
    }
}
int PrimeNumber()
{
    while (true)
    {
        pn++;
        if (IsPrime(pn))
        {
            return pn;
        }

    }
}

int FibnocciNumber()
{
    while (true)
    {
        fn++;
        if (isFibonacci(fn))
        {
            return fn;
        }

    }
}

int ArmstrongNumber()
{
    while (true)
    {
        an++;
        if (isArmstrong(an))
        {
            return an;
        }
    }
}

bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
            return false;

    return true;
}


bool isPerfectSquare(int x)
{
    int s = (int)Math.Sqrt(x);
    return (s * s == x);
}

// Returns true if n is a
// Fibonacci Number, else false
bool isFibonacci(int n)
{
    // n is Fibonacci if one of
    // 5*n*n + 4 or 5*n*n - 4 or
    // both are a perfect square
    return isPerfectSquare(5 * n * n + 4) ||
           isPerfectSquare(5 * n * n - 4);
}

bool isArmstrong(int x)
{
    int temp = x;
    int rem;
    int sum = 0;
    for (int i = x; i > 0; i = i / 10)
    {
        rem = i % 10;
        sum = sum + rem * rem * rem;
    }

    if (sum == temp)
        return true;
    else
        return false;
}
