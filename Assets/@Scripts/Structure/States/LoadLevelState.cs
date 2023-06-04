using ItemGenerator.System;
using ItemGenerator.UI.Factory;

namespace ItemGenerator.State
{
    public class LoadLevelState : IPayLoadState<string>
    {
        private readonly IUIFactory _uiFactory;
        private readonly SceneLoader _sceneLoader;
        private readonly GameStateMachine _gameStateMachine;
        
        public LoadLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader, IUIFactory uiFactory)
        {
            _uiFactory = uiFactory;
            _sceneLoader = sceneLoader;
            _gameStateMachine = gameStateMachine;
        }

        public void Enter(string sceneName)
        {
            _sceneLoader.Load(sceneName, OnLoaded);
        }

        public void Exit()
        {
        }

        private void InitUIRoot()
        {
            _uiFactory.CreateUIRoot();
        }

        private void OnLoaded()
        { 

            _gameStateMachine.Enter<GameLoopState>();
        }
    }
}