using System;

namespace LinearRegression
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.PopulateList();
            Coordinate.BuildPoints(Person.people);

            double alpha = Calculation.CalculateAlpha();
            double beta = Calculation.CalculateBeta();
            Console.WriteLine($"The value of alpha is: {alpha}.");
            Console.WriteLine($"The value of beta is: {beta}.");
            Console.WriteLine($"The formula is: y = {alpha} + {beta} * x");


        }
        public static void Test(int val)
        {
            Console.WriteLine(val);

            //foreach (var person in Person.people)
            //{
            //    Console.WriteLine(person.Name);
            //    Console.WriteLine(person.Height);
            //    Console.WriteLine(person.Weight);
            //}
            //foreach (var plots in Coordinate.points)
            //{
            //    Console.WriteLine(plots.X);
            //    Console.WriteLine(plots.Y);
            //}
        }
    }
}
