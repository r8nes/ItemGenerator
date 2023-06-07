using ItemGenerator.UI.Factory;

namespace ItemGenerator.UI.Services
{
    public class WindowServices : IWindowService
    {
        private readonly IUIFactory _uiFactory;

        public WindowServices(IUIFactory factory) 
        {
            _uiFactory = factory;
        }

        public void Open(WindowId windowId) 
        {
            if (windowId == WindowId.ITEM)
            {

                _uiFactory.CreateItemInfoWindow();
                return;
            }

            _uiFactory.CreateWindowById(windowId);
        }
    }
}
