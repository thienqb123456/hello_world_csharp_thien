using System;
namespace ProfileData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ur full name here : ");     
            string fullName = Console.ReadLine();
            Console.WriteLine("Enter ur phone number");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Gender:");
            bool gender = Console.ReadLine() == "male";
            Console.WriteLine("Your name is : {0}, Your phone number is : {1}, Your gender is : {2}", fullName, phoneNumber, gender);
        }
    }
}