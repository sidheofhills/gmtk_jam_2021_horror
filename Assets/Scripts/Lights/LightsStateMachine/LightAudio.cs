using UnityEngine;

namespace Assets.Scripts.Lights.LightsStateMachine
{
    public class LightAudio : MonoBehaviour
    {

        [SerializeField] private AudioClip[] lightBulbsNormal;  //unique for each lamp        
        [SerializeField] private AudioClips audioClips;

        private AudioSource lightAudioSource;
        public LightsAudioSpectrum audioSpectrum { get; private set; }

        private void Awake()
        {
            lightAudioSource = GetComponent<AudioSource>();
            audioSpectrum = GetComponent<LightsAudioSpectrum>();

        }

        public void PlayFlickering()
        {
            AudioPlayer.audioPlayerInstance.PlayAudio(audioClips.lightBulbsFlickering, lightAudioSource);
        }

        public void StopFlickering()
        {
            if (lightAudioSource.isPlaying)
            {
                AudioPlayer.audioPlayerInstance.StopAudio(audioClips.lightBulbsFlickering, lightAudioSource);
            }
        }

        public void PlayNormal()
        {
            AudioPlayer.audioPlayerInstance.PlayAudio(lightBulbsNormal, lightAudioSource);
        }
    

        public void StopNormal()
        {
            if (lightAudioSource.isPlaying)
            {
                AudioPlayer.audioPlayerInstance.StopAudio(lightBulbsNormal, lightAudioSource);
            }
        }
        

    }
}
