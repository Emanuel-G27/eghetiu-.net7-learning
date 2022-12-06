class DataStructure
{
    public static void Main(string[] args)
    {
        //  Using a queue which has 5 elements
        // (read from the user and added to the
        // queue one by one) check if the top of 
        //the queue is a positive number and a multiple
        // of 3 or a multiple of 7.If not remove the top
        // of the queue and print the new top of the queue.

        // nu am inteles asa bine cerinta, nu stiam daca trebuie indeplinite toate cele 3 cerinte de pozitiv,multiplu de 3 si 7


        Queue<int> nr = new Queue<int>();
        nr.Enqueue(-17);
        nr.Enqueue(3);
        nr.Enqueue(45);
        nr.Enqueue(12);
        nr.Enqueue(5);

        int x = nr.Dequeue();

        if (x < 0)
        {
            Console.WriteLine("The top of the queue({0}) is negative", x);
            Console.WriteLine("The new top element of my queue is: {0}", nr.Peek());
        }
    }
}