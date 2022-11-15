// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int a, b, c;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());

if (a > b && a >c )
    Console.WriteLine("Maximum number is "  + a);
else if (b > a && b > c)
    Console.WriteLine("Maximum number is "  + b);
else
    Console.WriteLine("Maximum number is " + c);

if (a < b && a < c)
    Console.WriteLine("Minimum number is " + a);
else if(b < a && b < c)
    Console.WriteLine("Minimum number is " + b);
else
    Console.WriteLine("Minimum number is " + c);
