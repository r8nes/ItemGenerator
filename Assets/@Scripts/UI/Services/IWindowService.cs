using ItemGenerator.Service;

namespace ItemGenerator.UI.Services
{
    public interface IWindowService : IService
    {
        public void Open(WindowId WindowId);
    }
}