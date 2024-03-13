using EngineRush.Core.StateMachine;
using UnityEngine;

namespace EngineRush.GameStates
{
    public class BootstrapState : IGameState, IState
    {
        public void Enter()
        {
            Debug.Log("BootstrapState");
        }

        public void Exit()
        {
            
        }
    }
}