using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiplication assigment
            Console.WriteLine("Please enter a comma seperated list of numbers.");
            var myanswer = Console.ReadLine();

            string [] finalanswer = myanswer.Split(",");
            int finalproduct = 1;

            foreach (var answer in finalanswer)
            {
                finalproduct *= int.Parse(answer);
            }
            Console.WriteLine("If I multiply these numbers together, my final answer is:");
            Console.WriteLine(finalproduct);

            //Squares assignment
        }
    }
}
