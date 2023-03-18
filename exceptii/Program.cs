// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void WithFinallyOnFunctionWithoutReturn()
{
    try
    {
        Console.WriteLine("Try");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Catch");
    }
    finally
    {
        Console.WriteLine("Finally");
    }
}

