using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Lights.LightsStateMachine.States
{
    public class LightTurnedOff : LightState
    {
        
        public LightTurnedOff(SingleLight light, LightsStateMachine stateMachine, LightAudio lightAudio) : base(light, stateMachine, lightAudio)
        {
            timeDecrement = 2;
        }

        public override void Enter()
        {
            base.Enter();
            
            timeDuration /= timeDecrement;
            timeToWait = timeDuration;
            light.SpritesAlphaSwitcher(0.0f);
            AudioUpdate();

        }

        public override void Execute()
        {
            base.Execute();
            
            timeToWait -= Time.deltaTime;
            if(timeToWait < 0)
            {
                nextState = NextState(light.normalSubstate, light.flickeringSubstate);
                stateMachine.ChangeState(nextState);
            }
        }

        public override void Exit()
        {
            base.Exit();
            timeDuration *= timeDecrement;
        }

        public override void AudioUpdate()
        {
            base.AudioUpdate();
            
            lightAudio.StopFlickering();            
            lightAudio.StopNormal();
        }
    }
}
