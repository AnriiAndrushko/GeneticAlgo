using GeneticAlgo.Logic.Objects;

namespace GeneticAlgo.Logic
{
    internal class Path
    {
        private City[] CurPath { get; }//TODO: make it immutable (who cares)
        public Path(City[] path) 
        {
            CurPath = path;
        }
    }
}
