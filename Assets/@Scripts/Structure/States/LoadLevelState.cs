using ItemGenerator.Factory;
using UnityEngine;

namespace ItemGenerator.State
{
    public class LoadLevelState : IPayLoadState<string>
    {
        private readonly IGameFactory _gameFactory;
        private readonly GameStateMachine _gameStateMachine;

        public LoadLevelState(GameStateMachine gameStateMachine, IGameFactory gameFactory)
        {
            _gameFactory = gameFactory;
            _gameStateMachine = gameStateMachine;
        }

        public void Enter(string sceneName)
        {
            OnLoaded();
        }

        public void Exit()
        {
        }

        private void OnLoaded()
        {
            _gameStateMachine.Enter<GameLoopState>();
        }
    }
}