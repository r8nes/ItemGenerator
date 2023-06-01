using System.Collections.Generic;
using ItemGenerator.Data;
using UnityEngine;

namespace ItemGenerator.Service
{
    [CreateAssetMenu(fileName = "WindowData", menuName = "StaticData/Window")]
    public class WindowsStaticData : BaseStaticData
    {
        public List<WindowConfigData> Configs;
    }
}