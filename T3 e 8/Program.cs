// See https://aka.ms/new-console-template for more information


int temp;
temp = Convert.ToInt32(Console.ReadLine());
if (temp < 0)
    Console.Write("Freezing weather");
else if (temp < 10)
    Console.Write("Very cold weather");
else if (temp < 20)
    Console.Write("Cold weather");
else if (temp < 30)
    Console.Write("Normal in temp");
else if (temp < 40)
    Console.Write("Its Hot");
else
    Console.Write("Its very hot");

