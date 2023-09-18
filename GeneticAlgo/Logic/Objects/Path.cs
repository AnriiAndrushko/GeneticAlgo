using GeneticAlgo.Logic.Objects;

namespace GeneticAlgo.Logic
{
    internal class Path
    {
        public City[] CurPath { get; }
        public float TotalDistance { get
            {
                return CalculateDistance();
            }}
        public Path(City[] path) 
        {
            CurPath = path;
        }

        private float CalculateDistance()
        {
            float distance = 0;
            var prevCity = CurPath[0];
            for(int i = 1; i<CurPath.Length; i++)
            {
                distance += prevCity.Distance(CurPath[i]);
                prevCity = CurPath[i];
            }
            distance += prevCity.Distance(CurPath[0]);
            return distance;
        }
    }
}
