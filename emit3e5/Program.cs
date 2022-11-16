// See https://aka.ms/new-console-template for more information



int a, b, c, d, e;
Console.WriteLine("Enter the Physics mark: " );
a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the Chemistry mark: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the Biology mark: ");
c = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the Mathematics mark: ");
d = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the CS mark: ");
e = int.Parse(Console.ReadLine());

int tm = a + b + c + d + e;
int p = tm * 100 / 300;
int ma = tm / 5;



if (ma >= 90)
    Console.WriteLine(" Percentage = " + ma + " and grade is A");
else if (ma >= 80)
    Console.Write(" Percentage = " + ma + " and grade is  B");
else if (ma >= 70)
    Console.Write(" Percentage = " + ma + " and grade is  C");
else if (ma >= 60)
    Console.Write(" Percentage = " + ma +  " and grade is  D");
else if (ma >= 40)
    Console.Write(" Percentage = " + ma +  " and grade is  C");
else if  (ma < 40)
    Console.Write(" Percentage = " + ma + " and grade is F");



