using System.Threading.Tasks;
using ItemGenerator.Service;
using UnityEngine;

namespace ItemGenerator.UI.Factory
{
    public interface IUIFactory : IService
    {
        public Transform _uiRoot { get; set; }

        void CreateUIRoot();
    }
}
