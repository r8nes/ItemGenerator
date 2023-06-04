using ItemGenerator.Assets;
using ItemGenerator.Service;
using ItemGenerator.UI.Factory;

namespace ItemGenerator.State
{
    public class BootstrapState : IState
    {
        private readonly AllServices _services;
        private readonly GameStateMachine _stateMachine;

        public BootstrapState(GameStateMachine gameStateMachine, AllServices services)
        {
            _services = services;
            _stateMachine = gameStateMachine;

            GloabalRegisterService();
        }

        public void Enter() => EnterLoadLevel();

        public void Exit() { }

        private void EnterLoadLevel() => _stateMachine.Enter<LoadProgressState>();

        private void GloabalRegisterService()
        {
            RegisterStateMachine();
            RegisterAssetProvider();
            RegisterStaticData();
            RegisterUiFactory();
        }

        #region Register

        private void RegisterStateMachine() 
            => _services.RegisterSingle<IGameStateMachine>(_stateMachine);

        private void RegisterAssetProvider() 
            => _services.RegisterSingle<IAssetsProvider>(new AssetsProvider());

        private void RegisterStaticData()
        {
            IStaticDataService staticData = new StaticDataService();
            staticData.Load();
            _services.RegisterSingle(staticData);
        }

        private void RegisterUiFactory()
        {
            _services.RegisterSingle<IUIFactory>(
           new UIFactory(
           _services.Single<IAssetsProvider>(),
           _services.Single<IStaticDataService>(),
           _services.Single<IGameStateMachine>()
           ));
        }

        #endregion
    }
}