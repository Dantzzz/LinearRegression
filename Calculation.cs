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

        public static void CalculateAlpha()
        {
            double alpha = 0;
            int numberOfPoints = Calculation.GetNumberOfPoints(Coordinate.points);
            double sumOfAllXY = Calculation.SumOfAllXY(Coordinate.points);
            int sumOfAllX = Calculation.SumOfAllX(Coordinate.points);
            int sumOfAllY = Calculation.SumOfAllY(Coordinate.points);
            double sumOfAllXSquared = Calculation.SumOfAllXSquared(Coordinate.points);

        }

        public static void CalcBeta()
        {
            double beta;

            //TODO: 

            //Console.WriteLine($"The value of alphas is: {}.");
            //Console.WriteLine($"The value of beta is: {}.");
            //Console.WriteLine($"The formula is: {}.");
        }
    }
}

//TODO: Calculate 