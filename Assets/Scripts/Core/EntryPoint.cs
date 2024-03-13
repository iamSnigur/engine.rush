using EngineRush.GameStates;
using VContainer.Unity;

namespace EngineRush.Core
{
    public class EntryPoint : IInitializable
    {
        private readonly GameStateMachine _gameStateMachine;

        public EntryPoint(GameStateMachine gameStateMachine) =>
            _gameStateMachine = gameStateMachine;

        public void Initialize() =>
            _gameStateMachine.Enter<BootstrapState>();
    }
}