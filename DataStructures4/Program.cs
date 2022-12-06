class DataStructures
{
    public static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(30);
        stack.Push(56);

        string result1;
        string result;
        int poz = stack.ElementAt(1);
        int poz1 = stack.ElementAt(0);

        result = poz + poz1 == 30 ? "true" : "false";
        Console.WriteLine(result);
        result1 = poz == 30 ? "true" : "false";
        Console.WriteLine(result1);
    }
}