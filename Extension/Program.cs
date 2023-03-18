

class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>();
        Console.WriteLine("Enter the names: ");
        string input = Console.ReadLine();

        try
        {
            CheckTheNames(names);
            Console.WriteLine("Valid name");
        }
        catch (BlankNameException ex)
        {
            Console.WriteLine(ex.Message);
        }

    
    }
    static void CheckTheNames(List<string> names)
    {
        for(int i = 3; i >= names.Count; i++)
        {
            if  (names == null )
            {
                throw new BlankNameException($"{names} is not valid");
            }                    
        }
        
    }



public class BlankNameException: Exception
    {
        public BlankNameException(string message): base(message)
        {

        }
    }



















//    {
//        try
//        {
//            DateTime result = checkDate();
//            Console.WriteLine(result);
//        }
//        catch (InvalidDateException ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
         
//    }
//    static DateTime checkDate()
//    {
//        Console.WriteLine("Introduce the date;");
//        DateTime date =DateTime.Parse(Console.ReadLine());
//        if (date == DateTime.MinValue)
//        {
//            throw new Exception("Error");
//        }
//        if(date == DateTime.MaxValue)
//        {
//            Console.WriteLine("date valid");
//        }
//        return date;
//    }
//}
//public class InvalidDateException: Exception
//{
//    public InvalidDateException(string message): base(message)
//    {

//    }
}