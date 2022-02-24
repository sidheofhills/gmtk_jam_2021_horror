using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Lights.LightsStateMachine.States
{
    public class LightTurnedOn : LightState
    {

        public LightTurnedOn(SingleLight light, LightsStateMachine stateMachine, LightAudio lightAudio) : base(light, stateMachine, lightAudio)
        {
        }


        public override void Enter()
        {
            base.Enter();

            timeToWait = timeDuration;
            light.SpritesAlphaSwitcher(1.0f);
            AudioUpdate();

        }

        public override void Execute()
        {
            base.Execute();
           
            timeToWait -= Time.deltaTime;
            
            if (timeToWait < 0)
            {
                
                if(light.IsBlinking && light.MayBlink)
                {
                    nextState = NextState(light.lightTurnedOff, light.flickeringSubstate);
                    stateMachine.ChangeState(nextState);
                    return;
                }
                nextState = NextState(light.normalSubstate, light.flickeringSubstate);
                stateMachine.ChangeState(nextState);
            }
        }

        public override void Exit()
        {
            base.Exit();
            
        }

       
        public override void AudioUpdate()
        {
            base.AudioUpdate();
            if (stateMachine.PrevoiusState != stateMachine.CurrentState)
            {
                lightAudio.StopFlickering();
                lightAudio.PlayNormal();
            }
            
        }
    }
   
}
