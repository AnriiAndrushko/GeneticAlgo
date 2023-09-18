using System;
using System.Drawing;

namespace GeneticAlgo.Logic.Objects
{
    internal class City
    {
        public Point Loaction { get; }
        public string Name { get; }

        public City(Point point, string name)
        {
            Loaction = point;
            Name = name;
        }
        public float Distance(City city2)
        {
            return Distance(this, city2);
        }
        public static float Distance(City city1, City city2)
        {
            return (float)Math.Sqrt(Math.Pow(city1.Loaction.X - city2.Loaction.X, 2) + Math.Pow(city1.Loaction.Y - city2.Loaction.Y, 2));
        }
    }
}
