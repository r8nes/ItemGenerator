using ItemGenerator.Assets;
using UnityEngine;

namespace ItemGenerator.Factory
{
    public class GameFactory : IGameFactory
    {
        private readonly IAssetsProvider _assets;

        private GameObject PlayerGameObject { get; set; }

        public GameFactory(IAssetsProvider assets)
        {
            _assets = assets;
        }

        #region Instantiate Methods

        private GameObject AddGameObject(string prefabPath, Vector2 at)
        {
            GameObject gameObject = _assets.Instantiate(prefabPath, at);

            return gameObject;
        }

        private GameObject AddGameObject(string prefabPath)
        {
            GameObject gameObject = _assets.Instantiate(path: prefabPath);

            return gameObject;
        }

        #endregion
    }
}