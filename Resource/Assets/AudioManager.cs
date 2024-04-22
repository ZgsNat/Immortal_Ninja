using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class AudioManager : MonoBehaviour
{
    public AudioSource audioSrc;

    private float musicVolume = 1f;

    void Start()
    {
        
    }
    void Update()
    {
        audioSrc.volume = musicVolume;
    }
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
    public void ToggleMusic()
    {
        audioSrc.mute = !audioSrc.mute;
    }
}
