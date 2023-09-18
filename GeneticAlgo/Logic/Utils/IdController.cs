namespace GeneticAlgo.Logic.Utils
{
    internal static class IdController
    {
        private static int _id = 0;
        public static int GetId()
        {
            return _id++;
        }
    }
}
