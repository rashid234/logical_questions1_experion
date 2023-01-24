// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

String[] arr1;
String[] arr2;
String[] arr3 = new String[20];
arr1 = new String[] { "sifana", "dona", "Varsha", "fathima" };
arr2 = new String[] { "Dubai", "UK", "US", "Malaysia" };
var mylist = new List<string>();
mylist.AddRange(arr1);
mylist.AddRange(arr2);
arr3 = mylist.ToArray();
foreach (string s in arr3)
{
    Console.WriteLine(s);
}
