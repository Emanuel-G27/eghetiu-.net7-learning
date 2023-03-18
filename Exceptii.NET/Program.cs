




//using Exceptii.NET;

//Student student = new Student()
//{
//    Id = 1
//};

//while (true)
//{
//    Console.WriteLine("Insert your name: ");
//    var name = Console.ReadLine();
//    try
//    {
//        student.Name = name;
//    }
//    catch(NameException nameException)
//    {
//        Console.WriteLine(nameException.Message);
//    }

//    if (!string.IsNullOrEmpty(student.Name))
//    {
//        break;
//    }
//}

//while (true)
//{
//    Console.WriteLine("Insert your email: ");
//    var email = Console.ReadLine();
//    try
//    {
//        student.Email = email;
//    }
//    catch (EmailException emailException)
//    {
//        Console.WriteLine(emailException.Message);
//    }

//    if (!string.IsNullOrEmpty(student.Email))
//    {
//        break;
//    }
//}


using Exceptii.NET;

//Console.WriteLine("Insert your number");
//var number2 =int.Parse(Console.ReadLine());
//var isPrime = true;

//if (isPrimeNumber(number2))
//{
//    Console.WriteLine("Number is prime");
//}
//else
//{
//    Console.WriteLine("Number isn't prime");
//}

//if (number2 < 2)
//{
//    throw new InvalidNumberException("Number can't be less than 2");
//}

//bool isPrimeNumber(int number)
//{
//    if (number == 2)
//    {
//        return true;
//    }
//    if(number % 2 == 0 || number == 1)
//    {
//        return false;
//    }
//    for (int i = 3; i < number; i++)
//    {
//        if (number % i == 0)
//        {
//            return false;
//        }
//    }
//    return true;
//}

//new EmailsChecker().ReadAndCheckEmails();

new IntegersCheckers().CheckTheIntegers();