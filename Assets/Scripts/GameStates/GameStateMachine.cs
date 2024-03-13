using EngineRush.Core.StateMachine;

namespace EngineRush.GameStates
{
    public class GameStateMachine : AbstractStateMachine<IGameState>
    {
        public GameStateMachine(GameStatesFactory gameStatesFactory) =>
            _states = gameStatesFactory.CreateStates();
    }
}