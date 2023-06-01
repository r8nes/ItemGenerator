using UnityEngine;

namespace ItemGenerator.Service
{
    public class RandomService : IRandomService
    {
        public int Next(int min, int max) =>
          Random.Range(min, max);
    }
}