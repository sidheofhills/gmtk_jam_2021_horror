using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (AudioSource))]
public class LightsAudioSpectrum : MonoBehaviour  // this one is to flick with audio
{
    private float spectrumValue;
    private float[] spectrumData = new float[128];
    private AudioSource localAudioSource;

    private float prevSpectrumVal;
    private float curSpectrumVal;

    public float FlickeringValue { get; private set; }

    [SerializeField] private float bias;
    [SerializeField] private float fitVal;

    private void Awake()
    {
        localAudioSource = GetComponent<AudioSource>(); 
    }

    private void Update()
    {
        localAudioSource.GetSpectrumData(spectrumData, 0, FFTWindow.Hanning); // Hanning is good with white noise sounds 

        if (spectrumData != null && spectrumData.Length > 0)
        {
            spectrumValue = spectrumData[0] * fitVal;
            
            
            prevSpectrumVal = curSpectrumVal;
            curSpectrumVal = spectrumValue;
            if(prevSpectrumVal > bias && curSpectrumVal <= bias)
            {
                FlickeringValue = Mathf.Clamp01(Mathf.Pow(curSpectrumVal,2f));
            }

        }

        
    }

}