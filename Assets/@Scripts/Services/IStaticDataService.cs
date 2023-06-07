using ItemGenerator.Data;
using ItemGenerator.UI.Services;

namespace ItemGenerator.Service
{
    public interface IStaticDataService : IService
    { 
        WindowConfigData ForWindow(WindowId windowId);
        ImageTypeConfigData ForItemImage(ItemTypeId windowId);

        void Load();
    }
}