using System.Threading.Tasks;
using ItemGenerator.Data;
using ItemGenerator.Service;
using ItemGenerator.UI.Services;
using UnityEngine;

namespace ItemGenerator.UI.Factory
{
    public interface IUIFactory : IService
    {
        public Transform _uiRoot { get; set; }

        void CreateUIRoot();
        void CreateItemInfoWindow();

        GameObject CreateItemBox(ItemData data);
        void CreateWindowById(WindowId windowId);
    }
}
