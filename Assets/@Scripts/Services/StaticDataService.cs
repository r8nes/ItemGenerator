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
        private const string IMAGES_PATH = "Data/Images/ImageData";

        private Dictionary<WindowId, WindowConfigData> _windowConfigs;
        private Dictionary<ItemTypeId, ImageTypeConfigData> _imageTypeConfigs;

        public void Load()
        {
            _windowConfigs = Resources.Load<WindowsStaticData>(WINDOWS_PATH).Configs
                .ToDictionary(x => x.WindowId, x => x);

            _imageTypeConfigs = Resources.Load<ImageTypeStaticData>(IMAGES_PATH).Configs
            .ToDictionary(x => x.ImageId, x => x);
        }

        public WindowConfigData ForWindow(WindowId windowId) =>
           _windowConfigs.TryGetValue(windowId, out WindowConfigData data)
         ? data
         : null;

        public ImageTypeConfigData ForItemImage(ItemTypeId imageId) =>
           _imageTypeConfigs.TryGetValue(imageId, out ImageTypeConfigData data)
         ? data
         : null;
    }
}