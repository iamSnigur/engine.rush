using EngineRush.GameStates;
using VContainer.Unity;
using VContainer;

namespace EngineRush.Core
{
    public class ProjectScopeInstaller : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            DontDestroyOnLoad(this);
            builder.RegisterEntryPoint<EntryPoint>();
            RegisterGameStates(builder);
        }

        private void RegisterGameStates(IContainerBuilder builder)
        {
            builder.Register<BootstrapState>(Lifetime.Singleton);
            builder.Register<GameStatesFactory>(Lifetime.Singleton);
            builder.Register<GameStateMachine>(Lifetime.Singleton);
        }
    }
}