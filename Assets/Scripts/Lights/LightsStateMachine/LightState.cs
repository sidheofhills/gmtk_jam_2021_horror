using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Lights.LightsStateMachine
{
    public abstract class LightState 
    {
        protected SingleLight light;
        protected float timeToWait;
        protected float timeDuration;
        protected int timeDecrement;
        protected LightsStateMachine stateMachine;
        protected LightAudio lightAudio;
        protected LightState nextState;
        

        protected LightState(SingleLight light, LightsStateMachine stateMachine, LightAudio lightAudio)
        {
            this.light = light;
            timeDuration = light.TimeDuration;            
            this.lightAudio = lightAudio;
            this.stateMachine = stateMachine;
        }


        public virtual void Enter()
        {
            
        }                

        public virtual void Execute()
        {
            if (light.ManualSwitchOff)
            {
                stateMachine.ChangeState(light.lightTurnedOff);
                return;
            }
            if(light.SwitchOnByTrigger)
            {
                nextState = NextState(light.normalSubstate, light.flickeringSubstate);
                stateMachine.ChangeState(nextState);
                return;
            }

        }       

        public virtual void Exit()
        {
            
        }

        public virtual void AudioUpdate()
        {

        }

        protected LightState NextState(LightState firstState, LightState secondState)
        {
            return Random.Range(0, 2) == 0 ? firstState : secondState;
        }

       

    }
}
