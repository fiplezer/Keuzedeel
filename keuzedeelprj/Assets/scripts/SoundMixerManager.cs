using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundMixerManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void SetSoundFXVolume(float level)
    {
        audioMixer.SetFloat("SoundFXVolume", level);
    }
}
