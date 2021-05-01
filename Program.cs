using System;

namespace LinearRegression
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.PopulateList();
            Coordinate.BuildPoints(Person.people);

            int numberOfPoints = Calculation.GetNumberOfPoints(Coordinate.points);
            double sumOfAllXY = Calculation.SumOfAllXY(Coordinate.points);
            int sumOfAllX = Calculation.SumOfAllX(Coordinate.points);
            int sumOfAllY = Calculation.SumOfAllY(Coordinate.points);
            double sumOfAllXSquared = Calculation.SumOfAllXSquared(Coordinate.points);



            Test(numberOfPoints);
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
