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

        public void Open(WindowId WindowId) 
        {
            switch (WindowId)
            {
                case WindowId.UNKNOWN:
                    break;
                case WindowId.ITEM:
                    //_uiFactory.CreateShop();
                    break;
             }
        }
    }
}
