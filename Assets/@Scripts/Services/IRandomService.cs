namespace ItemGenerator.Service
{
    public interface IRandomService : IService
    {
        int Next(int minValue, int maxValue);
    }
}