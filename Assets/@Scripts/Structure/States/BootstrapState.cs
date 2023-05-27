using ItemGenerator.Assets;
using ItemGenerator.Factory;
using ItemGenerator.Service;

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
            RegisterGameFactory();
        }

        #region Register

        private void RegisterStateMachine() 
            => _services.RegisterSingle<IGameStateMachine>(_stateMachine);

        private void RegisterAssetProvider() 
            => _services.RegisterSingle<IAssetsProvider>(new AssetsProvider());

        private void RegisterGameFactory()
            => _services.RegisterSingle<IGameFactory>(new GameFactory(_services.Single<IAssetsProvider>()));

        #endregion
    }
}