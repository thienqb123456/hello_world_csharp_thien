using System;

 namespace SumProgram
{
    internal class SumCalculator
    {
        public static void Main(string[] args)
        {   
            int input1;
            int input2;
            
            Console.WriteLine("Enter ur first number : ");
            input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ur second number : ");
            input2 = Convert.ToInt32(Console.ReadLine());
            int sum = input1 + input2;
            Console.WriteLine("Sum of {0} and {1} is: {2} ", input1, input2, sum);
        }
    }
}

