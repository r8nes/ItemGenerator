using System.Threading.Tasks;
using ItemGenerator.UI.Services;
using UnityEngine;

namespace ItemGenerator.UI.Factory
{
    public class UIFactory : IUIFactory
    {
        private const string UI_ROOT_PATH = "UI/UIRoot";

        //private readonly IAsset _asset;
        //private readonly IStaticDataService _staticData;
        //private readonly IProgressService _progressService;

        private Transform _uiRoot;

        //public UIFactory(IAsset asset, IStaticDataService staticData, IProgressService progressService)
        //{
        //    _asset = asset;
        //    _staticData = staticData;
        //    _progressService = progressService;
        //}

        //public void CreateShop()
        //{
        //    WindowConfig config = _staticData.ForWindow(WindowId.SHOP);
        //    WindowBase window = Object.Instantiate(config.Prefab, _uiRoot);
        //    window.Construct(_progressService);
        //}

        //public async Task CreateUIRoot()
        //{
        //    GameObject root = await _asset.Instantiate(UI_ROOT_PATH);
        //    _uiRoot = root.transform;
        //}
    }
}