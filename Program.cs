using System;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter first number");
            Double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number");
            Double num2 = Convert.ToDouble(Console.ReadLine());

            Double sum = num1 + num2;
            Console.WriteLine("Sum of two number is" + sum);

        

           


        }
    }
}