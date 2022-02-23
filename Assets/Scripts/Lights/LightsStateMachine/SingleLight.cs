using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Lights.LightsStateMachine.States;

namespace Assets.Scripts.Lights.LightsStateMachine
{
    public class SingleLight : MonoBehaviour
    {
        #region Variables
        [SerializeField] private bool leftLamp;  // for monsters to fade in and out      
        public bool LeftLamp => leftLamp;   
        public float LightValue { get; private set; }

        [SerializeField] private GameData gameData;

        [SerializeField] private bool mayBlink;
        public bool MayBlink => mayBlink;

        [SerializeField] private bool manualLampSwitchOff; // for cutscene

        [SerializeField] private float maxTimeDuration; // between blinking
        
        public float TimeDuration { get; private set; } //
        public bool IsBlinking { get; private set; }
        public LightsAudioSpectrum LightsAudioSpectrum { get; private set; }
        public LightAudio LightAudio { get; private set; }
        

        public bool ManualSwitchOff { get; private set; }
        public bool SwitchOnByTrigger { get; private set; }

        private SpriteRenderer[] spriteRenderer;
        private LightsStateMachine stateMachine;

        //states 
        public LightTurnedOff lightTurnedOff { get; private set; }
        public LightFlickering flickeringSubstate { get; private set; }
        public LightTurnedOn normalSubstate { get; private set; }
        #endregion

        private void Awake()
        {
                    
            spriteRenderer = GetComponentsInChildren<SpriteRenderer>();
            LightAudio = GetComponent<LightAudio>();
            LightsAudioSpectrum = GetComponent<LightsAudioSpectrum>();
                                                             
            IsBlinking = false;

            TimeDuration = Random.Range(0.5f, 1.01f) * maxTimeDuration;
        }

        private void Start()
        {
            stateMachine = new LightsStateMachine();
            lightTurnedOff = new LightTurnedOff(this, stateMachine, LightAudio);
            flickeringSubstate = new LightFlickering(this, stateMachine, LightAudio, LightsAudioSpectrum);
            normalSubstate = new LightTurnedOn(this, stateMachine,LightAudio);

            stateMachine.InitializeState(normalSubstate);
        }

        private void Update()
        {
            OnCutsceneManualyLightsOff();

            stateMachine.CurrentState.Execute();

            LightsOnByTrigger();

            LightValue = spriteRenderer[0].color.a;

        }

        private void LightsOnByTrigger()
        {
            if (SwitchOnByTrigger)
            {
                SwitchOnByTrigger = false;
            }
        }

        private void OnCutsceneManualyLightsOff()
        {
            if (manualLampSwitchOff && !gameData.cutSceneDone)  // for cutscene
            {
                ManualSwitchOff = true;
            }
        }

        public void SpritesAlphaSwitcher(float value)  //switches light/shadow on and off
        {
            // if i remember correctly, i couldn't get good results with only spriteRenderer[0].color.a = value
            // probably, because color is a struct?
            spriteRenderer[0].color = new Vector4(spriteRenderer[0].color.r, spriteRenderer[0].color.g, spriteRenderer[0].color.b, value);
            spriteRenderer[1].color = new Vector4(spriteRenderer[1].color.r, spriteRenderer[1].color.g, spriteRenderer[1].color.b, value);
            spriteRenderer[2].color = new Vector4(spriteRenderer[2].color.r, spriteRenderer[2].color.g, spriteRenderer[2].color.b, value);
            spriteRenderer[3].color = new Vector4(spriteRenderer[3].color.r, spriteRenderer[3].color.g, spriteRenderer[3].color.b, 1 - value);
        }


        private void StartBlinking()
        {
            IsBlinking = true;
            ManualSwitchOff = false;
            SwitchOnByTrigger = true;
        }

        private void EndExcorcistSimulation()
        {
            IsBlinking = false;
        }


        private void OnEnable()
        {
            EventManager.StartListening(gameData.MonstersSpawn, StartBlinking);
            EventManager.StartListening(gameData.OnDarkPentaDisappearing, EndExcorcistSimulation);
            
        }
        private void OnDisable()
        {
            EventManager.StopListening(gameData.MonstersSpawn, StartBlinking);
            EventManager.StopListening(gameData.OnDarkPentaDisappearing, EndExcorcistSimulation);

        }
    }
}
