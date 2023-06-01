using System.Collections.Generic;
using System.Linq;
using ItemGenerator.Data;
using ItemGenerator.UI.Services;
using UnityEngine;

namespace ItemGenerator.Service
{
    public class StaticDataService : IStaticDataService
    {
        private const string WINDOWS_PATH = "Data/Windows/WindowData";

        private Dictionary<WindowId, WindowConfigData> _windowConfigs;

        public void Load()
        {
            _windowConfigs = Resources.Load<WindowsStaticData>(WINDOWS_PATH).Configs
                .ToDictionary(x => x.WindowId, x => x);
        }

        public WindowConfigData ForWindow(WindowId windowId) =>
           _windowConfigs.TryGetValue(windowId, out WindowConfigData data)
         ? data
         : null;
    }
}