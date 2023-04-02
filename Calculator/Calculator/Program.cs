// See https://aka.ms/new-console-template for more information



class Program
{
    static void Main()
    {

        Console.Write("Enter a number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter another number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Enter the operation: ");
        char operation = char.Parse(Console.ReadLine());
     
  
       
        switch (operation)
        {
            case '+':
                Console.WriteLine($"The sum is: { num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"The result is: {num1 - num2}");
                break;
            case '*':
                Console.WriteLine($"The multiplication is: {num1 * num2}");
                break;
            case '/':
                Console.WriteLine($"The result is: { num1 / num2}");
                break;
        }

        if (operation != '+' & operation != '-' & operation != '*' & operation != '/')
        {
            throw new Exception("Invalid operation");     
        }
    }
}
