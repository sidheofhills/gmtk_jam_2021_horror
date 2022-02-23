using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Lights.LightsStateMachine
{
    public class LightsStateMachine
    {
        public LightState CurrentState {  get; private set; }
        public LightState PrevoiusState { get; private set; }

        public void InitializeState(LightState startingState)
        {
            PrevoiusState = null;
            CurrentState = startingState;
            CurrentState.Enter();
        }

        public void ChangeState(LightState nextState)
        {
            
            CurrentState.Exit();
            PrevoiusState = CurrentState;
            CurrentState = nextState;
            CurrentState.Enter();
        }
    }
}
