using System;
using System.Collections.Generic;

namespace LinearRegression
{
    public class Regression
    {
        internal static double Predict(double alpha, double beta, List<Coordinate> points)
        {
            int collectionX;
            double predictedY;

            foreach (var point in points)
            {
                collectionX = point.X;
                predictedY = alpha + (beta * collectionX);
                Console.WriteLine(predictedY);
            }

            Console.WriteLine("Enter a number for the independent variable: ");
            int entryX = Int32.Parse(Console.ReadLine());

            predictedY = alpha + (beta * entryX);
            return predictedY;
        }
    }
}


// Y = α + β(X)
// dependent variable = y-intercept + slope coefficient(independent variable)