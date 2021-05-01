using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearRegression
{
    class Person
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public Person(string name, int weight, int height)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }
        internal static void Populate()
        {
            Person andre = new Person("Andre", 165, 66);
            Person aaron = new Person("Aaron", 185, 71);
            Person james = new Person("James", 190, 70);
            Person charles = new Person("Charles", 210, 72);
            Person jacon = new Person("Jacon", 180, 72);
            Person kindra = new Person("Kindra", 150, 67);
            Person malachi = new Person("Malachi", 180, 68);

            people.Add(andre);
            people.Add(aaron);
            people.Add(james);
            people.Add(charles);
            people.Add(jacon);
            people.Add(kindra);
            people.Add(malachi);
        }
    }
}
