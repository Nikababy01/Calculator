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

            //Squares assignment if use number use Math.Sqrt(3)
            Console.WriteLine("Enter a comma separated numbers to square");
            var squareanswer = Console.ReadLine();
            string [] squareproduct = squareanswer.Split(",");
            string squareofproduct = "";
             
            foreach (var sqproduct in squareproduct)
            {
              squareofproduct += int.Parse(sqproduct) * int.Parse(sqproduct) + ",";
            }
            squareofproduct = squareofproduct.TrimEnd(',');
            Console.WriteLine("If I square the list of numbers entered, my final answer is:");
            Console.WriteLine(squareofproduct);
        }
    }
}
