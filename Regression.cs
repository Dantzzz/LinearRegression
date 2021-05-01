using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LinearRegression
{
    public class Regression
    {
        public static List<Person> people = new List<Person>();
        public static void Run()
        {
            Person.Populate();
            Coordinates.BuildCoordinates(people);
        }

    }
}



// Y = α + β(X)
// dependent variable = y-intercept + slope coefficient(independent variable)