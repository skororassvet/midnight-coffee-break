using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Options_Menu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void setMasterVolume(float volume)
    {
        audioMixer.SetFloat("master", volume);
    }

    public void setMusicVolume(float volume)
    {
        audioMixer.SetFloat("music", volume);
    }

    public void setAmbienceVolume(float volume)
    {
        audioMixer.SetFloat("ambience", volume);
    }

    public void setSoundsVolume(float volume)
    {
        audioMixer.SetFloat("sounds", volume);
    }
}
