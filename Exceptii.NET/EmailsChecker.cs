using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptii.NET
{
    public class EmailsChecker
    {
        public void ReadAndCheckEmails()
        {
            List<string> emails = new List<string>();
            Console.WriteLine("Enter emails, separated by space: ");

            string input = Console.ReadLine();
            string[] inputSplited = input.Split(" ");
            emails.AddRange(inputSplited);

            try
            {
                CheckAllEmails(emails);
                Console.WriteLine("Emails are ok ");
            }
            catch(InvalidEmailException invalidException)
            {
                Console.WriteLine(invalidException.Message);
            }
        }
        private void CheckAllEmails(List<string> emails)
        {
            foreach(string email in emails)
            {
                if (!IsValidEmail(email))
                {
                    throw new InvalidEmailException($"Email {email} is not valid");
                }
                
            }
        }
        private bool IsValidEmail(string email)
        {
            if (!email.Contains("@"))
            {
                return false;
            }
            return true;

            
        }

    }
    public class InvalidEmailException : Exception
    {
        public InvalidEmailException(string? message) : base(message)
        {
        }
    }
}
