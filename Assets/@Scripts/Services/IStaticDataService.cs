using System.Collections.Generic;
using System.Linq;
using ItemGenerator.Data;
using ItemGenerator.UI.Services;
using UnityEngine;

namespace ItemGenerator.Service
{
    public interface IStaticDataService : IService
    { 
        WindowConfigData ForWindow(WindowId windowId);

        void Load();
    }
}