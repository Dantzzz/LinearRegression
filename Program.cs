using System;

namespace LinearRegression
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.PopulateList();
            Coordinate.BuildPoints(Person.people);
            Calculation calculation = new Calculation(Coordinate.points);

            double alpha = Calculation.CalculateAlpha();
            double beta = Calculation.CalculateBeta();
            Console.WriteLine($"The value of alpha is: {alpha}.");
            Console.WriteLine($"The value of beta is: {beta}.");
            Console.WriteLine($"The formula is: y = {alpha} + {beta} * x");

            // Linear Regression
            double prediction = Regression.Predict(alpha, beta, Coordinate.points);
            Console.WriteLine(prediction);
            //Test(Calculation.CalculateAlpha());
            //Test(Calculation.CalculateBeta());
        }
        public static void Test(double val)
        {
            Console.WriteLine(val);
        }
    }
}
