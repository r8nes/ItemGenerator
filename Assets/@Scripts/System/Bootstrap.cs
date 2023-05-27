using ItemGenerator.State;
using UnityEngine;

namespace ItemGenerator.System
{
    public class Bootstrap : MonoBehaviour, ICoroutineRunner
    {
        
        private Game _game;

        private void Awake()
        {
            _game = new Game(this);
            _game.StateMachine.Enter<BootstrapState>();

            DontDestroyOnLoad(this);
        }
    }
}
