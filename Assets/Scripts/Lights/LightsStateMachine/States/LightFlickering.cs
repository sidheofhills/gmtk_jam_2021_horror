using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Lights.LightsStateMachine.States
{
    public class LightFlickering : LightState
    {
        private LightsAudioSpectrum audioSpectrum;


        public LightFlickering(SingleLight light, LightsStateMachine stateMachine, LightAudio lightAudio, LightsAudioSpectrum lightsAudioSpectrum) : base(light, stateMachine, lightAudio)
        {
            audioSpectrum = lightsAudioSpectrum;
            timeDecrement = 5; 
        }


        public override void Enter()
        {
            base.Enter();

            timeDuration /= timeDecrement;
            timeToWait = timeDuration;
            AudioUpdate();

        }

        public override void Execute()
        {
            base.Execute();
            
            timeToWait -= Time.deltaTime;
            
            light.SpritesAlphaSwitcher(audioSpectrum.FlickeringValue);
            if (timeToWait < 0)
            {
                if (light.IsBlinking && light.MayBlink)
                {
                    nextState = NextState(light.lightTurnedOff, light.normalSubstate);
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
            timeDuration *= timeDecrement;
        }

        public override void AudioUpdate()
        {
            base.AudioUpdate();
            if (stateMachine.PrevoiusState == stateMachine.CurrentState)
            {
                lightAudio.StopFlickering();
                lightAudio.PlayFlickering(); // the sound might be different
                return;
            }
            lightAudio.StopNormal();
            lightAudio.PlayFlickering();
        }

    }
}
