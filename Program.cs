using System;

namespace LinearRegression
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.PopulateList();
            Coordinate.BuildCoordinates(Person.people);
            Test();
        }
        public static void Test()
        {


            foreach (var person in Person.people)
            {
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Height);
                Console.WriteLine(person.Weight);
            }
            foreach (var plots in Coordinate.coordinates)
            {
                Console.WriteLine(plots.X);
                Console.WriteLine(plots.Y);
            }
        }
    }
}
