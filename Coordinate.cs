using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearRegression
{
    internal class Coordinate
    {
        public static List<Coordinate> points = new List<Coordinate>();
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Coordinate(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }
        static int GetX(Person person)
        {
            int x = person.Height;
            return x;
        }
        static int GetY(Person person)
        {
            int y = person.Weight;
            return y;
        }
        public static void BuildPoints(List<Person> people)
        {
            for (int i = 0; i < people.Count; i++)
            {
                int x = GetX(people[i]);
                int y = GetY(people[i]);
                string name = people[i].Name;
                
                Coordinate plot = new Coordinate(name, x, y);
                points.Add(plot);
            }
        }
    }
}
