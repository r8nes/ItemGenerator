using ItemGenerator.Factory;
using ItemGenerator.UI.Factory;

namespace ItemGenerator.State
{
    public class LoadLevelState : IPayLoadState<string>
    {
        private readonly IUIFactory _uiFactory;
        private readonly IGameFactory _gameFactory;

        private readonly GameStateMachine _gameStateMachine;

        public LoadLevelState(GameStateMachine gameStateMachine, IGameFactory gameFactory, IUIFactory uiFactory)
        {
            _gameFactory = gameFactory;
            _gameStateMachine = gameStateMachine;
            _uiFactory = uiFactory;
        }

        public void Enter(string sceneName)
        {
            OnLoaded();
        }

        public void Exit()
        {
        }

        private void InitUIRoot() => _uiFactory.CreateUIRoot();

        private void OnLoaded()
        {
            InitUIRoot();
            _gameStateMachine.Enter<GameLoopState>();
        }
    }
}