using GeneticAlgo.Logic.Objects;
using GeneticAlgo.Logic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneticAlgo.Logic
{
    internal class SelectionAlgo
    {
        public City[] cities;
        public Path[] currentGeneration;
        private int percentAlive;
        private int percentMutation;
        private Random random = new Random();
        public SelectionAlgo(int agents, int percentMutation, int percentAlive, City[] cities)
        {
            this.percentMutation = percentMutation;
            this.percentAlive = percentAlive;
            this.cities = cities;
            currentGeneration = new Path[agents];
            for (int i = 0; i<agents;i++)
            {
                currentGeneration[i] = new Path(cities.Shuffle()); ;
            }
        }

        public void MakeIteration()
        {
            List<Path> newGeneration = SelectBest(percentAlive).ToList();
            List<Path> mutants = new List<Path>();

            Path tmp = newGeneration[0];
            int i = 1;
            int step = 1;
            while(mutants.Count<currentGeneration.Length-newGeneration.Count)
            {
                var mutant = Crossbreeder.Cross(tmp, newGeneration[i]);
                tmp = newGeneration[i];

                Path mut1 = mutant.child1;
                Path mut2 = mutant.child2;
                if (random.Next(101)<percentMutation)
                {
                    int mutationCount = random.Next(cities.Length)/2;
                    for (int j = 0; j< mutationCount; j++)
                    {
                        mut1 = Crossbreeder.Mutate(mut1);
                    }
                }
                if (random.Next(101) < percentMutation)
                {
                    int mutationCount = random.Next(cities.Length) / 2;
                    for (int j = 0; j < mutationCount; j++)
                    {
                        mut2 = Crossbreeder.Mutate(mut2);
                    }
                }

                mutants.Add(mut1);
                mutants.Add(mut2);

                i+=step;
                if (i>=newGeneration.Count)
                {
                    i = 0;
                    step++;
                }
            }
            newGeneration.AddRange(mutants);
            while (newGeneration.Count> currentGeneration.Length)
            {
                newGeneration.RemoveAt(newGeneration.Count-1);
            }

            currentGeneration = newGeneration.ToArray();
        }

        public Path GetBestPath()
        {
            return currentGeneration.OrderBy(x => x.TotalDistance).First();
        }

        IEnumerable<Path> SelectBest(int percentToSelect)
        {
            return currentGeneration.OrderBy(x=>x.TotalDistance).Take(currentGeneration.Length*percentToSelect/100);
        }

    }
}
