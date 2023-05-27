using ItemGenerator.Service;
using UnityEngine;

namespace ItemGenerator.Factory
{
    public interface IGameFactory : IService
    {
        GameObject CreatePlayer(Vector2 initialPoint);
        GameObject CreateSpawnerDistributor();
    }
}