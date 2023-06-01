using System.Collections.Generic;
using System.Threading.Tasks;
using ItemGenerator.Assets;
using ItemGenerator.Data;
using ItemGenerator.Service;
using ItemGenerator.State;
using ItemGenerator.UI.Services;
using UnityEngine;

namespace ItemGenerator.UI.Factory
{
    public class UIFactory : IUIFactory
    {
        private const string UI_ROOT_PATH = "UI/MainRoot";

        private readonly IAssetsProvider _asset;
        private readonly IStaticDataService _staticData;
        private readonly IGameStateMachine _stateMachine;

        private Transform _uiRoot;
        private List<WindowBase> OpenWindows = new List<WindowBase>(5);

        public UIFactory(IAssetsProvider asset, IStaticDataService staticData, IGameStateMachine stateMachine)
        {
            _asset = asset;
            _staticData = staticData;
            _stateMachine = stateMachine;
        }

        //public void CreateShop()
        //{
        //    WindowConfig config = _staticData.ForWindow(WindowId.SHOP);
        //    WindowBase window = Object.Instantiate(config.Prefab, _uiRoot);
        //    window.Construct(_progressService);
        //}

        public void CreateUIRoot()
        {
            GameObject root = _asset.Instantiate(UI_ROOT_PATH);
            _uiRoot = root.transform;
        }

        public void CreateWindowById(WindowId windowId)
        {
            foreach (WindowBase openWindow in OpenWindows)
            {
                WindowId id = openWindow.GetId();
                if (id == windowId) return;
            }

            WindowConfigData config = _staticData.ForWindow(windowId);
            WindowBase window = UnityEngine.Object.Instantiate(config.Prefab, _uiRoot);

            window.Construct(windowId);
            window.WindowClosed += OnWindowClosed;

            OpenWindows.Add(window);
        }

        private void OnWindowClosed(WindowId id)
        {
            for (int i = 0; i < OpenWindows.Count; i++)
            {
                if (OpenWindows[i].GetId() == id)
                {
                    OpenWindows[i].WindowClosed -= OnWindowClosed;
                    OpenWindows.Remove(OpenWindows[i]);
                }
            }
        }
    }
}