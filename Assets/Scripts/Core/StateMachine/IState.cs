namespace EngineRush.Core.StateMachine
{
    public interface IState : IExitableState
    {
        void Enter();
    }
}
