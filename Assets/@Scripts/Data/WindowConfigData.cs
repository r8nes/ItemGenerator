using System;
using ItemGenerator.UI;
using ItemGenerator.UI.Services;

namespace ItemGenerator.Data
{
    [Serializable]
    public class WindowConfigData
    {
        public WindowId WindowId;
        public WindowBase Prefab;
    }
}