using GeneticAlgo.Logic.Objects;
using System;
using System.Text;

namespace GeneticAlgo.Logic.Utils
{
    internal static class CityGenerator
    {
        static Random random = new Random();
        public static City[] GetCities(int amount, int padding, int width, int height)
        {
            var res = new City[amount];
            for (int i = 0; i<amount; i++)
            {
                res[i] = GetCity(padding, width, height);
            }
            return res;
        }
        public static City GetCity(int padding, int width, int height)
        {
            return new City(new System.Drawing.Point(random.Next(padding, width - padding), random.Next(padding, height - padding)), GetRandomName());
        }
        private static string GetRandomName()//this function was written by chatgpt
        {
            int cityNameLength = random.Next(5, 12);
            StringBuilder cityNameBuilder = new StringBuilder();

            for (int i = 0; i < cityNameLength; i++)
            {
                char randomChar = (char)random.Next(97, 123);
                if (random.Next(0, 4) == 0)
                {
                    int randomNumber = random.Next(0, 10);
                    cityNameBuilder.Append(randomNumber);
                }
                cityNameBuilder.Append(randomChar);
            }

            return cityNameBuilder.ToString();
        }
    }
}
