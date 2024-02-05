using UnityEngine;
using UnityEngine.Audio;

public class OptionMenuScript : MonoBehaviour
{
    public AudioMixer mainMenuAudioMixer;
    //public AudioMixer sfxAudioMixer;

    public void SetBGVolume(float BGVolume)
    {
        mainMenuAudioMixer.SetFloat("VolumeMainMenu", BGVolume);
    }
    /*
        public void SetSFXVolume(float SFXVolume) {
            sfxAudioMixer.SetFloat("SFXVolume", SFXVolume);
        }
        */
}
