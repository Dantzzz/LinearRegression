using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearRegression
{
    internal class Calculation
    {
        public static int GetNumberOfPoints(List<Coordinate> points)
        {
            // n
            return points.Count();
        }

        public static double SumOfAllXY(List<Coordinate> points)
        {
            // ∑xy
            double sumOfProducts = 0;
            for (int i = 0; i < points.Count; i++)
            {
                sumOfProducts += points[i].X * points[i].Y;
            }
            return sumOfProducts;
        }

        public static int SumOfAllY(List<Coordinate> points)
        {
            // ∑y
            int sum = 0;
            for (int i = 0; i < points.Count; i++)
            {
                sum += points[i].Y;
            }
            return sum;
        }

        public static int SumOfAllX(List<Coordinate> points)
        {
            // ∑x
            int sum = 0;
            for (int i = 0; i < points.Count; i++)
            {
                sum += points[i].X;
            }
            return sum;

        }
        public static double SumOfAllXSquared(List<Coordinate> points)
        {
            // ∑x^2
            double sum = 0;
            for (int i = 0; i < points.Count; i++)
            {
                sum += points[i].X * points[i].X;
            }
            return sum;
        }

        public static double CalculateAlpha()
        {
            //TODO: Make a Calculation object that contains all these variables as fields
            int numberOfPoints = GetNumberOfPoints(Coordinate.points);
            double sumOfAllXY = SumOfAllXY(Coordinate.points);
            int sumOfAllX = SumOfAllX(Coordinate.points);
            int sumOfAllY = SumOfAllY(Coordinate.points);
            double sumOfAllXSquared = SumOfAllXSquared(Coordinate.points);
            

            double numerator = (sumOfAllY * sumOfAllXSquared) - (sumOfAllX * sumOfAllXY);
            double denominator = (numberOfPoints * sumOfAllXSquared) - Math.Pow(sumOfAllX, 2);
            double alpha = numerator / denominator;
            
            return alpha;
        }

        public static double CalculateBeta()
        {
            int numberOfPoints = GetNumberOfPoints(Coordinate.points);
            double sumOfAllXY = SumOfAllXY(Coordinate.points);
            int sumOfAllX = SumOfAllX(Coordinate.points);
            int sumOfAllY = SumOfAllY(Coordinate.points);
            double sumOfAllXSquared = SumOfAllXSquared(Coordinate.points);

            double numerator = (numberOfPoints * sumOfAllXY) - (sumOfAllX * sumOfAllY);
            double denominator = (numberOfPoints * sumOfAllXSquared) - Math.Pow(sumOfAllX, 2);
            double beta = numerator / denominator;
            return beta;

            
            
            //Console.WriteLine($"The formula is: {}.");
        }
    }
}

//TODO: Calculate 