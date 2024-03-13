using System;
using System.Collections.Generic;

namespace EngineRush.Core.StateMachine
{
    public abstract class AbstractStateMachine<TBaseState>
    {
        protected Dictionary<Type, IExitableState> _states;

        private IExitableState _activeState;

        public void Enter<TState>() where TState : class, IState, TBaseState
        {
            TState state = ChangeActiveState<TState>();
            state.Enter();
        }        

        public void Enter<TState, TPayload>(TPayload payload) where TState : class, IPayloadedState<TPayload>, TBaseState
        {
            TState state = ChangeActiveState<TState>();
            state.Enter(payload);
        }

        private TState ChangeActiveState<TState>() where TState : class, IExitableState
        {
            _activeState?.Exit();
            TState state = GetState<TState>();
            _activeState = state;

            return state;
        }

        private TState GetState<TState>() where TState : class, IExitableState =>
            _states[typeof(TState)] as TState;
    }
}