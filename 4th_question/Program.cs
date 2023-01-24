// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
var today = DateTime.Today;
Console.WriteLine("enter the date of birth");
var bday = Console.ReadLine();
var dob = Convert.ToDateTime(bday);
var days = today - dob;
var hours = days * 24;
var week = days / 7;
var month = days / 30;
var year = today.Year - dob.Year;

Console.WriteLine($"The age in days {days}");
Console.WriteLine($"The age in hours {hours}");
Console.WriteLine($"The age in weeks {week}");
Console.WriteLine($"The age in months {month}");
Console.WriteLine($"The age in years {year}");

if ((0 == dob.Year % 4) && (0 != dob.Year % 100) || (0 == dob.Year % 400))
{
    Console.WriteLine(dob.Year + " is a leap year");
}
else
{
    Console.WriteLine(dob.Year + " is not a leap year");
}