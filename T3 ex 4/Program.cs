// See https://aka.ms/new-console-template for more information




int a, b, c;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
int maximum;
int minimum;

maximum = (a > b && a > c) ? a : (( b > a && b > c) ? b : c );
minimum = (a < b && a < c) ? a : (b < a && b < c) ? b : c;

Console.WriteLine("Maximum number is " + maximum);
Console.WriteLine("Minimum number is " + minimum);


