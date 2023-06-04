using System.Collections.Generic;
using UnityEngine;

namespace ItemGenerator.Data
{
    [CreateAssetMenu(fileName = "WindowData", menuName = "StaticData/Window")]
    public class WindowsStaticData : BaseStaticData
    {
        public List<WindowConfigData> Configs;
    }
}