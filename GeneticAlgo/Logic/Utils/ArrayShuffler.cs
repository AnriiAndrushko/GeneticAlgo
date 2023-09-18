using System;

namespace GeneticAlgo.Logic.Utils
{
    internal static class ArrayShuffler
    {
        private static Random random = new Random();

        public static T[] Shuffle<T>(this T[] array)
        {
            T[] res = (T[])array.Clone();
            int n = res.Length;
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                T temp = res[i];
                res[i] = res[j];
                res[j] = temp;
            }
            return res;
        }
    }
}
