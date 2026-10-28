using System.Text.RegularExpressions;
using ConsoleApp1.DataLayer.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new();


            Console.WriteLine("Please enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your LastName");
            string LastName = Console.ReadLine();
            Console.WriteLine("Please enter your birth date");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;
            if (birthdate.Date > today.AddYears(-age))
            {
                age = --age;
            }
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("enter your ID number");
            string IDnumber = Console.ReadLine();
            string pattern = @"^\d{10}$";
            if (Regex.IsMatch(IDnumber, pattern))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine("Enter Card number");
            string firstSix;
            string cardNumber = Console.ReadLine();
            if (Regex.IsMatch(cardNumber, @"^\d{16}$"))
            {
                firstSix = cardNumber.Substring(0, 6);
                if (firstSix == "621986")
                {
                    Console.WriteLine("Blu Bank");
                }
                if (firstSix == "502229")
                {
                    Console.WriteLine("Pasargad Bank");
                }
                if (firstSix == "603799")
                {
                    Console.WriteLine("Melli Bank");
                }
            }






        }
    }
}
