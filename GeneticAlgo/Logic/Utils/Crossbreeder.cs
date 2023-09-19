using GeneticAlgo.Logic.Objects;
using System;
using System.Collections.Generic;

namespace GeneticAlgo.Logic.Utils
{
    internal static class Crossbreeder
    {
        static Random random = new Random();
        public static (Path child1, Path child2) Cross(Path parent1, Path parent2)//TODO: refactor using DRY
        {
            if (parent1.CurPath.Length != parent2.CurPath.Length)
            {
                throw new ArgumentException("Path length must match");
            }
            int pathLength = parent1.CurPath.Length;
            City[] res1 = new City[pathLength];
            City[] res2 = new City[pathLength];

            int index1 = random.Next(pathLength);
            int index2 = random.Next(pathLength);

            HashSet<int> isPresent1 = new HashSet<int>();
            HashSet<int> isPresent2 = new HashSet<int>();

            if (index1 > index2)
            {
                for (int i = index1; i < index2; i++)
                {
                    isPresent1.Add(parent2.CurPath[i].Id);
                    isPresent2.Add(parent1.CurPath[i].Id);
                    res1[i] = parent2.CurPath[i];
                    res2[i] = parent1.CurPath[i];
                }
            }
            else
            {
                for (int i = index1; i < pathLength; i++)
                {
                    isPresent1.Add(parent2.CurPath[i].Id);
                    isPresent2.Add(parent1.CurPath[i].Id);
                    res1[i] = parent2.CurPath[i];
                    res2[i] = parent1.CurPath[i];
                }
                for (int i = 0; i < index2; i++)
                {
                    isPresent1.Add(parent2.CurPath[i].Id);
                    isPresent2.Add(parent1.CurPath[i].Id);
                    res1[i] = parent2.CurPath[i];
                    res2[i] = parent1.CurPath[i];
                }
            }

            for (int i = 0; i < index1; i++)
            {
                if (!isPresent1.Contains(parent1.CurPath[i].Id))
                {
                    isPresent1.Add(parent1.CurPath[i].Id);
                    res1[i] = parent1.CurPath[i];
                }
                if (!isPresent2.Contains(parent2.CurPath[i].Id))
                {
                    isPresent2.Add(parent2.CurPath[i].Id);
                    res2[i] = parent2.CurPath[i];
                }
            }
            for (int i = index2; i < pathLength; i++)
            {
                if (!isPresent1.Contains(parent1.CurPath[i].Id))
                {
                    isPresent1.Add(parent1.CurPath[i].Id);
                    res1[i] = parent1.CurPath[i];
                }
                if (!isPresent2.Contains(parent2.CurPath[i].Id))
                {
                    isPresent2.Add(parent2.CurPath[i].Id);
                    res2[i] = parent2.CurPath[i];
                }
            }
            Queue<int> toAdd1 = new Queue<int>();
            Queue<int> toAdd2 = new Queue<int>();

            for (int i = 0; i < pathLength; i++)
            {
                if (!isPresent1.Contains(parent1.CurPath[i].Id))
                {
                    toAdd1.Enqueue(i);
                }
                if (!isPresent2.Contains(parent2.CurPath[i].Id))
                {
                    toAdd2.Enqueue(i);
                }
            }

            for (int i = 0; i < pathLength; i++)
            {
                if (res1[i]==null)
                {
                    res1[i] = parent1.CurPath[toAdd1.Dequeue()];
                }
                if (res2[i] == null)
                {
                    res2[i] = parent2.CurPath[toAdd2.Dequeue()];
                }
            }
            return (new Path(res1), new Path(res2));
        }
        public static Path Mutate(Path path)
        {
            Path res = new Path((City[])path.CurPath.Clone());
            int index1 = random.Next(res.CurPath.Length);
            int index2 = random.Next(res.CurPath.Length);
            City tmp = res.CurPath[index1];
            res.CurPath[index1] = res.CurPath[index2];
            res.CurPath[index2] = tmp;
            return res;
        }
    }
}
