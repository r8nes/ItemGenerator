using System.Collections.Generic;
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
        private const string UI_ITEM_BOX_PATH = "UI/ItemBox";

        private readonly IAssetsProvider _asset;
        private readonly IStaticDataService _staticData;
        private readonly IGameStateMachine _stateMachine;

        public Transform _uiRoot { get; set; }

        private List<WindowBase> _openWindows = new List<WindowBase>(5);

        public UIFactory(IAssetsProvider asset, IStaticDataService staticData, IGameStateMachine stateMachine)
        {
            _asset = asset;
            _staticData = staticData;
            _stateMachine = stateMachine;
        }

        public void CreateUIRoot()
        {
            GameObject root = _asset.Instantiate(UI_ROOT_PATH);
            _uiRoot = root.transform;

            root.GetComponentInChildren<GenerateButton>().Construct(this);
        }

        public GameObject CreateItemBox(ItemData data) 
        {
            GameObject itemBoxGameObject = _asset.Instantiate(UI_ITEM_BOX_PATH);
            ItemBox itemBox = itemBoxGameObject.GetComponent<ItemBox>();

            itemBox.Constuct(data);

            return itemBoxGameObject;
        }

        public void CreateItemInfoWindow()
        {
            WindowConfigData config = _staticData.ForWindow(WindowId.ITEM);
            WindowBase window = Object.Instantiate(config.Prefab, _uiRoot);
        }

        public void CreateWindowById(WindowId windowId)
        {
            foreach (WindowBase openWindow in _openWindows)
            {
                WindowId id = openWindow.GetId();
                if (id == windowId) return;
            }

            WindowConfigData config = _staticData.ForWindow(windowId);
            WindowBase window = Object.Instantiate(config.Prefab, _uiRoot);

            window.Construct(windowId);
            window.WindowClosed += OnWindowClosed;

            _openWindows.Add(window);
        }

        private void OnWindowClosed(WindowId id)
        {
            for (int i = 0; i < _openWindows.Count; i++)
            {
                if (_openWindows[i].GetId() == id)
                {
                    _openWindows[i].WindowClosed -= OnWindowClosed;
                    _openWindows.Remove(_openWindows[i]);
                }
            }
        }
    }
}