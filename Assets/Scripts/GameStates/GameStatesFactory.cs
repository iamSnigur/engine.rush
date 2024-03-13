using EngineRush.Core.StateMachine;
using EngineRush.Core.Factories;
using System.Collections.Generic;
using System;
using VContainer;

namespace EngineRush.GameStates
{
    public class GameStatesFactory : AbstractStatesFactory
    {
        public GameStatesFactory(IObjectResolver container) : base(container) { }

        public override Dictionary<Type, IExitableState> CreateStates() =>
            new()
            {
                [typeof(BootstrapState)] = _container.Resolve<BootstrapState>(),
            };
    }
}