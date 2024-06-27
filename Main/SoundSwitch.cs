using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSwitch : MonoBehaviour
{

    public AudioSource MusicBg;
    private bool NonActive = false;

    public void PlayStopMusic()
    {
        if (!NonActive)
        {
            MusicBg.Play();
            NonActive = true;
        }
        else
        {
            MusicBg.Stop();
            NonActive = false;
        }
    }
}
