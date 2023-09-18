using GeneticAlgo.Logic.Objects;
using GeneticAlgo.Logic.Utils;
namespace GeneticAlgo.Logic
{
    internal class SelectionAlgo
    {
        public City[] cities;
        public Path[] currentGeneration;
        public SelectionAlgo(int iterations, int agents, int mutationChance, City[] cities)
        {
            this.cities = cities;
            currentGeneration = new Path[agents];
            for (int i = 0; i<agents;i++)
            {
                currentGeneration[i] = new Path(cities.Shuffle()); ;
            }
        }

    }
}
