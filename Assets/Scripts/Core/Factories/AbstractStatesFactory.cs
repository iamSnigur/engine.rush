using EngineRush.Core.StateMachine;
using System.Collections.Generic;
using System;
using VContainer;

namespace EngineRush.Core.Factories
{
    public abstract class AbstractStatesFactory
    {
        protected readonly IObjectResolver _container;

        public AbstractStatesFactory(IObjectResolver container) =>
            _container = container;

        public abstract Dictionary<Type, IExitableState> CreateStates();
    }
}
