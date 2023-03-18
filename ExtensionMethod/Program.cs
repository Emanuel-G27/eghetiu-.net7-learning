

//string isPalindrome = "ana";
//if (isPalindrome.IsPalindrom())
//{
//    Console.WriteLine("Is palindrome");
//}

//public static class Extension
//{
//    public static bool IsPalindrom(this string name)
//    {
//        if (name != string.Join("",name.Reverse()))
//        {
//            return false;
//        }
//        return true;      
//    }


//}

var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
var query = list.Where(list => list % 2 == 0)
    .Select(list =>list * list )
    .Sum();

Console.WriteLine(query);

