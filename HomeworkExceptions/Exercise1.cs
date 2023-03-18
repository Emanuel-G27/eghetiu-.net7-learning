using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkExceptions
{
    public static class Exercise1
    {
        public static void CheckTheDate()
        {
            Console.WriteLine("Insert a date from the future:");

            try
            {
                var insertedDate = Console.ReadLine();
                DateTimeHelper.ParseAndCheckIfDateIsInTheFutre(insertedDate);

                Console.WriteLine("Inserted date is correct.");
            }
            catch (InvalidDateException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
       

    }
    public class DateTimeHelper
    {
        public static void ParseAndCheckIfDateIsInTheFutre(string date)
        {
            if (!DateTime.TryParse(date, out DateTime dateTime))
            {
                throw new InvalidDateException("You date is not in the correct format.");
            }

            CheckIfDateIsInTheFutre(dateTime);
        }

        public static void CheckIfDateIsInTheFutre(DateTime date)
        {
            if (date > DateTime.Now)
            {
                return;
            }

            throw new InvalidDateException("The entered date is in the past.");
        }
    }

    public class InvalidDateException : Exception
    {
        public InvalidDateException(string? message) : base(message)
        {}
    }
}
