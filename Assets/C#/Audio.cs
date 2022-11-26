using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip Bubble;
    public AudioClip Punch;
    
    [Min(0)]
    public float Volume;
    public float Volume2;
    public AudioSource _audio;
   

    public void BubbleAudio()
    {
       
        _audio.PlayOneShot(Bubble, Volume);
    }

    public void PunchAudio()
    {
        _audio.PlayOneShot(Punch, Volume2);
    }
}
